using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Clientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            List<CE_ResponsableIVA> listaRespIVA = new CN_ResponsableIVA().Listar();

            foreach (CE_ResponsableIVA item in listaRespIVA)
            {
                cbRespIVA.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.Nombre });
                cbRespIVA.DisplayMember = "Texto";
                cbRespIVA.ValueMember = "Valor";
                cbRespIVA.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgvClientes.Columns)
            { //Se agrega al combobox de busqueda los encabezados visibles. 
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;


            //Muestra los Clientes de la base de datos en el dgv
            List<CE_Cliente> listaCliente = new CN_Cliente().Listar();

            foreach (CE_Cliente item in listaCliente)
            {
                dgvClientes.Rows.Add(new object[] { // Se debe poner los TODOS los items EN ORDEN
                    item.IdCliente,
                    item.Documento,
                    item.Nombre,
                    item.Apellido,
                    item.oRespIVA.Id,
                    item.oRespIVA.Nombre,
                    "",""
                });
            }
        }
        private void dgvClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 6) //Pinta el icono de editar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.edit16.Width;
                var h = Properties.Resources.edit16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.edit16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 7) //Pinta el icono de eliminar
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
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;

            if (indice >= 0)
            {
                if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    //Labels de ayuda para ver el indice del DGV y el ID del Cliente.
                    lblIndice.Text = indice.ToString();
                    lblID_Cliente.Text = dgvClientes.Rows[indice].Cells["ID_Cliente"].Value.ToString();

                    txtDocumento.Text = dgvClientes.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombre.Text = dgvClientes.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtApellido.Text = dgvClientes.Rows[indice].Cells["Apellido"].Value.ToString();
                    foreach (OpcionCombo oc in cbRespIVA.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvClientes.Rows[indice].Cells["ID_RespIVA"].Value))
                        {
                            int indice_combo = cbRespIVA.Items.IndexOf(oc);
                            cbRespIVA.SelectedIndex = indice_combo; //Se selecciona el que encontro.
                            break; //Cuando la relacion sea correcta se corta el foreach.
                        }
                    }
                }
                else if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEliminar")
                {
                    if (MessageBox.Show("¿Desea eliminar al cliente " + dgvClientes.Rows[indice].Cells["Nombre"].Value.ToString() +
                        "?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string mensaje = string.Empty;

                        CE_Cliente oCliente = new CE_Cliente() //Se crea un nueva instancia
                        { //de la que solo se necesita el ID del Cliente.
                            IdCliente = int.Parse(dgvClientes.Rows[indice].Cells["ID_Cliente"].Value.ToString())
                        };

                        bool respuesta = new CN_Cliente().Eliminar(oCliente, out mensaje);

                        if (respuesta) //Si se elimino correctamente (Eliminar retorna respuesta bool):
                            dgvClientes.Rows.RemoveAt(Convert.ToInt32(indice)); //se elimina la fila del DGV.
                        else
                            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Cliente oCliente = new CE_Cliente() //Se crea un obj de la clase Cliente
            { //y se le asignan los valores del formulario.
                IdCliente = Convert.ToInt32(lblID_Cliente.Text),
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                oRespIVA = new CE_ResponsableIVA() { Id = Convert.ToInt32(((OpcionCombo)cbRespIVA.SelectedItem).Valor) },
            };

            if (oCliente.IdCliente == 0) //Si es un Cliente nuevo:
            {
                //Se ejecuta el metodo Crear que retorna el ID del Cliente creado que se genera desde la BD.
                int idClienteCreado = new CN_Cliente().Crear(oCliente, out mensaje);

                if (idClienteCreado != 0) //Si se agrego correctamente
                { //Se agregan los datos al DGV.
                    dgvClientes.Rows.Add(new object[] { //Nota: el orden es importante.
                        idClienteCreado,
                        txtDocumento.Text.Trim(),
                        txtNombre.Text.Trim(),
                        txtApellido.Text.Trim(),
                        ((OpcionCombo)cbRespIVA.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbRespIVA.SelectedItem).Texto.ToString(),
                        "","" //Lo dos botones (Editar y Eliminar):
                    });

                    LimpiarForm(); //Limpia los campos del formulario.
                }
                else //MessageBox que muestra un error sqlite.
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Si su ID no es 0, se ejecuta el metodo Actualizar.
            {
                bool resultado = new CN_Cliente().Actualizar(oCliente, out mensaje);

                if (resultado) //Si se agrego correctamente, se agregan los datos a la lista.
                {
                    DataGridViewRow row = dgvClientes.Rows[Convert.ToInt32(lblIndice.Text)];
                    row.Cells["ID_Cliente"].Value = lblID_Cliente.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text.Trim();
                    row.Cells["Nombre"].Value = txtNombre.Text.Trim();
                    row.Cells["Apellido"].Value = txtApellido.Text.Trim();
                    row.Cells["ID_RespIVA"].Value = ((OpcionCombo)cbRespIVA.SelectedItem).Valor.ToString();
                    row.Cells["ResponsableIVA"].Value = ((OpcionCombo)cbRespIVA.SelectedItem).Texto.ToString();

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
        private void LimpiarForm()
        {
            lblIndice.Text = "-1"; //Se setea en -1 xq el indice empieza en 0.
            lblID_Cliente.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            //Se limpian los campos:
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbRespIVA.SelectedIndex = 0;
            //Y se vuelve a dejar seleccionado el primer textbox.
            txtDocumento.Select();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            if (dgvClientes.Rows.Count > 0) //Si no hay elementos en la tabla no tiene sentido hacer la busqueda.
            {
                foreach (DataGridViewRow row in dgvClientes.Rows) //Recorre cada fila que encuentre en dgvClientes.
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
            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
