using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
//Lo que agregue:
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Proveedores
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvProveedores.Columns)
            { //Se agrega al combobox de busqueda los encabezados visibles. 
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;

            //Muestra los usuarios de la base de datos en el dgv
            List<CE_Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (CE_Proveedor item in listaProveedor)
            {
                dgvProveedores.Rows.Add(new object[] { //Acordate de poner los TODOS los items EN ORDEN
                    item.IdProveedor,
                    item.RazonSocial,
                    item.oContacto.Telefono,
                    item.oContacto.Correo,
                    "",""
                });
            }
        }
        private void dgvProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 4) //Pinta el icono de editar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.edit16.Width;
                var h = Properties.Resources.edit16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.edit16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 5) //Pinta el icono de eliminar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete16.Width;
                var h = Properties.Resources.delete16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                if (dgvProveedores.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //Labels de ayuda para ver el indice del DGV y el ID del usuario.
                    lblIndice.Text = indice.ToString();
                    lblID_Proveedor.Text = dgvProveedores.Rows[indice].Cells["ID_Proveedor"].Value.ToString();

                    txtRazonSocial.Text = dgvProveedores.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    txtTelefono.Text = dgvProveedores.Rows[indice].Cells["Telefono"].Value.ToString();
                    txtCorreo.Text = dgvProveedores.Rows[indice].Cells["Correo"].Value.ToString();
                }
                else if (dgvProveedores.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    if (MessageBox.Show("¿Desea eliminar al proveedor " + dgvProveedores.Rows[indice].Cells["RazonSocial"].Value.ToString() + "?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        CE_Proveedor oProveedor = new CE_Proveedor() //Se crea un nueva instancia
                        { //de la que solo se necesita el ID del usuario.
                            IdProveedor = int.Parse(dgvProveedores.Rows[indice].Cells["ID_Proveedor"].Value.ToString())
                        };

                        bool respuesta = new CN_Proveedor().Eliminar(oProveedor, out mensaje);

                        if (respuesta) //Si se elimino correctamente (Eliminar retorna respuesta bool):
                            dgvProveedores.Rows.RemoveAt(Convert.ToInt32(indice)); //se elimina la fila del DGV.
                        else
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Proveedor oProveedor = new CE_Proveedor() //Se crea un obj de la clase Proveedor
            { //y se le asignan los valores del formulario.
                IdProveedor = Convert.ToInt32(lblID_Proveedor.Text),
                RazonSocial = txtRazonSocial.Text.Trim(),
                oContacto = new CE_Contacto() { Telefono = txtTelefono.Text.Trim(), Correo = txtCorreo.Text.Trim() },
            };

            if (oProveedor.IdProveedor == 0) //Si es un usuario nuevo:
            {
                //Se ejecuta el metodo Crear que retorna el ID del usuario creado que se genera desde la BD.
                int idProveedorCreado = new CN_Proveedor().Crear(oProveedor, out mensaje);

                if (idProveedorCreado != 0) //Si se agrego correctamente
                { //Se agregan los datos al DGV.
                    dgvProveedores.Rows.Add(new object[] { //Nota: el orden es importante.
                        idProveedorCreado,
                        txtRazonSocial.Text.Trim(),
                        txtTelefono.Text.Trim(),
                        txtCorreo.Text.Trim(),
                        "","" //Lo dos botones (Editar y Eliminar)
                    });

                    LimpiarForm(); //Limpia los campos del formulario.
                }
                else //MessageBox que muestra un error sqlite.
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Si su ID no es 0, se ejecuta el metodo Actualizar.
            {
                bool resultado = new CN_Proveedor().Actualizar(oProveedor, out mensaje);

                if (resultado) //Si se agrego correctamente, se agregan los datos a la lista.
                {
                    DataGridViewRow row = dgvProveedores.Rows[Convert.ToInt32(lblIndice.Text)];
                    row.Cells["ID_Proveedor"].Value = lblID_Proveedor.Text;
                    row.Cells["RazonSocial"].Value = txtRazonSocial.Text.Trim();
                    row.Cells["Telefono"].Value = txtTelefono.Text.Trim();
                    row.Cells["Correo"].Value = txtCorreo.Text.Trim();

                    LimpiarForm();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }
        private void LimpiarForm() //Limpia los textbox y combobox.
        {
            lblIndice.Text = "-1"; //Se setea en -1 xq el indice empieza en 0.
            lblID_Proveedor.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            //Se limpian los campos:
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            //Y se vuelve a dejar seleccionado el primer textbox.
            txtRazonSocial.Select();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            if (dgvProveedores.Rows.Count > 0) //Si no hay elementos en la tabla no tiene sentido hacer la busqueda.
            {
                foreach (DataGridViewRow row in dgvProveedores.Rows) //Recorre cada fila que encuentre en dgvProveedores.
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        //Se hace el filtro por la columnaFiltro si contiene lo que se encuentra en txtBuscar.
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        { //Limpia el textbox de busqueda y se elimina el filtro.
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
