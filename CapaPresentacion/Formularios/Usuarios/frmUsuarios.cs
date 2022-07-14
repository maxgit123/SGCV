using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Usuarios
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            List<CE_Rol> listaRol = new CN_Rol().Listar();

            foreach (CE_Rol item in listaRol)
            {
                cbRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.NomRol });
                cbRol.DisplayMember = "Texto";
                cbRol.ValueMember = "Valor";
                cbRol.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgvUsuarios.Columns)
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
            List<CE_Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (CE_Usuario item in listaUsuario)
            {
                dgvUsuarios.Rows.Add(new object[] { //Poner los TODOS los items EN ORDEN.
                    item.Id,
                    item.Documento,
                    item.Nombre,
                    item.Apellido,
                    item.Clave,
                    item.FechaCreacion,
                    item.oRol.IdRol,
                    item.oRol.NomRol,
                    item.oEstado.Id,
                    item.oEstado.Nombre,
                    "","" //Botones Editar y Elimiar.
                });
            }
        }
        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PintarDGV.PintarbtnEditarEliminar(sender, e, dgvUsuarios.ColumnCount);
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e) //Boton Editar y Eliminar.
        {
            if (e.ColumnIndex < 0 || (dgvUsuarios.Columns[e.ColumnIndex].Name != "btnEditar" && dgvUsuarios.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            if (e.ColumnIndex == dgvUsuarios.Columns["btnEditar"].Index){
                //Labels de ayuda para ver el indice del DGV y el ID del usuario.
                lblIndice.Text = e.RowIndex.ToString();
                lblID_Usuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells["ID_Usuario"].Value.ToString();

                txtDocumento.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Documento"].Value.ToString();
                txtNombre.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
                txtClave.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Clave"].Value.ToString();
                foreach (OpcionCombo oc in cbRol.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["ID_Rol"].Value))
                    {
                        int indice_combo = cbRol.Items.IndexOf(oc);
                        cbRol.SelectedIndex = indice_combo; //Se selecciona el que encontro.
                        break;
                    }
                }
            }
            else if (e.ColumnIndex == dgvUsuarios.Columns["btnEliminar"].Index)
            {
                if (MessageBox.Show("¿Desea eliminar al usuario " + dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString() + "?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                string mensaje = string.Empty;

                CE_Usuario oUsuario = new CE_Usuario() //Se crea un nueva instancia
                { //de la que solo se necesita el ID del usuario.
                    Id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells["ID_Usuario"].Value.ToString())
                };

                bool respuesta = new CN_Usuario().Eliminar(oUsuario, out mensaje);

                if (respuesta) //Si se elimino correctamente (Eliminar retorna respuesta bool):
                    dgvUsuarios.Rows.RemoveAt(Convert.ToInt32(e.RowIndex)); //se elimina la fila del DGV.
                else
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Usuario oUsuario = new CE_Usuario() //Se crea un obj de la clase Usuario
            { //y se le asignan los valores del formulario.
                Id = Convert.ToInt32(lblID_Usuario.Text),
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Clave = txtClave.Text.Trim(),
                oRol = new CE_Rol() {IdRol = Convert.ToInt32(((OpcionCombo)cbRol.SelectedItem).Valor)},
            };
            
            if (oUsuario.Id == 0) //Si es un usuario nuevo:
            {
                //Se ejecuta el metodo Crear que retorna el ID del usuario creado que se genera desde la BD.
                int idUsuarioCreado = new CN_Usuario().Crear(oUsuario, out mensaje);

                if (idUsuarioCreado != 0) //Si se agrego correctamente
                { //Se agregan los datos al DGV.
                    dgvUsuarios.Rows.Add(new object[] { //Nota: el orden es importante.
                        idUsuarioCreado,
                        txtDocumento.Text.Trim(),
                        txtNombre.Text.Trim(),
                        txtApellido.Text.Trim(),
                        txtClave.Text.Trim(),
                        DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"),
                        ((OpcionCombo)cbRol.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbRol.SelectedItem).Texto.ToString(),
                        "","" //Lo dos botones (Editar y Eliminar):
                    });

                    LimpiarForm(); //Limpia los campos del formulario.
                }
                else //MessageBox que muestra un error sqlite.
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else //Si su ID no es 0, se ejecuta el metodo Actualizar.
            {
                bool resultado = new CN_Usuario().Actualizar(oUsuario, out mensaje);

                if (resultado) //Si se actualizo correctamente, se agregan los datos a la lista.
                {
                    DataGridViewRow row = dgvUsuarios.Rows[Convert.ToInt32(lblIndice.Text)];
                    row.Cells["ID_Usuario"].Value = lblID_Usuario.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text.Trim();
                    row.Cells["Nombre"].Value = txtNombre.Text.Trim();
                    row.Cells["Apellido"].Value = txtApellido.Text.Trim();
                    row.Cells["Clave"].Value = txtClave.Text.Trim();
                    row.Cells["ID_Rol"].Value = ((OpcionCombo)cbRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cbRol.SelectedItem).Texto.ToString();

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
            lblID_Usuario.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtClave.Text = "";
            cbRol.SelectedIndex = 0;
            txtDocumento.Select();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            if (dgvUsuarios.Rows.Count > 0) //Si no hay elementos en la tabla no tiene sentido hacer la busqueda.
            {
                foreach (DataGridViewRow row in dgvUsuarios.Rows) //Recorre cada fila que encuentre en dgvUsuarios.
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
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                row.Visible = true;
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form form = new frmCrearUsuario();
            form.Show();
        }
    }
}
