using System;
using System.Collections.Generic;
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

            MostrarListaUsuarios();
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
                foreach (OpcionCombo oc in cbRol.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["ID_Rol"].Value))
                    {
                        int indice_combo = cbRol.Items.IndexOf(oc);
                        cbRol.SelectedIndex = indice_combo; //Se selecciona el que encontro.
                        break;
                    }
                }
                HabilitarForm();
                txtClave.Enabled = false;
            }
            else if (e.ColumnIndex == dgvUsuarios.Columns["btnEliminar"].Index)
            {
                if (MessageBox.Show("¿Desea eliminar al usuario " + dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString() + "?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                string mensaje = string.Empty;

                CE_Usuario oUsuario = new CE_Usuario()
                {
                    Id = int.Parse(dgvUsuarios.Rows[e.RowIndex].Cells["ID_Usuario"].Value.ToString())
                };

                bool respuesta = new CN_Usuario().Eliminar(oUsuario, out mensaje);

                if (respuesta)
                    dgvUsuarios.Rows.RemoveAt(Convert.ToInt32(e.RowIndex));
                else
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Usuario oUsuario = new CE_Usuario()
            {
                Id = Convert.ToInt32(lblID_Usuario.Text),
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Clave = txtClave.Text.Trim(),
                oRol = new CE_Rol()
                {
                    IdRol = Convert.ToInt32(((OpcionCombo)cbRol.SelectedItem).Valor)
                }
            };
            
            if (oUsuario.Id == 0)
            {
                int idUsuarioCreado = new CN_Usuario().Crear(oUsuario, out mensaje);

                if (idUsuarioCreado == 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                MostrarListaUsuarios();
                LimpiarForm();
                DeshabilitarForm();
            }
            else
            {
                bool resultado = new CN_Usuario().Actualizar(oUsuario, out mensaje);

                if (!resultado)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MostrarListaUsuarios();
                LimpiarForm();
                DeshabilitarForm();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarForm();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || dgvUsuarios.Rows.Count < 0)
                return;

            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            foreach (DataGridViewRow row in dgvUsuarios.Rows) //Recorre cada fila que encuentre en dgvUsuarios.
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                    //Se hace el filtro por la columnaFiltro si contiene lo que se encuentra en txtBuscar.
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        { //Se elimina el filtro.
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                row.Visible = true;
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            HabilitarForm();
        }
        private void MostrarListaUsuarios()
        {
            dgvUsuarios.Rows.Clear();
            List<CE_Usuario> listaUsuario = new CN_Usuario().Listar();

            foreach (CE_Usuario item in listaUsuario)
            {
                dgvUsuarios.Rows.Add(new object[] {
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
        private void HabilitarForm()
        {
            txtDocumento.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtClave.Enabled = true;
            cbRol.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void DeshabilitarForm()
        {
            txtDocumento.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtClave.Enabled = false;
            cbRol.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
