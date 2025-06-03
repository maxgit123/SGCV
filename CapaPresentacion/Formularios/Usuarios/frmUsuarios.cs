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
            // Se configura el DataGridView para que ajuste las columnas al contenido y los botones tengan un tamaño fijo.
            foreach (DataGridViewColumn col in dgvUsuarios.Columns)
            {
                if (col.Name != "btnEditar" && col.Name != "btnEliminar")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    col.Width = 30;
                    col.Resizable = DataGridViewTriState.False;
                }
            }

            List<CE_Rol> listaRol = new CN_Rol().Listar();

            foreach (CE_Rol item in listaRol)
            {
                cbRol.Items.Add(new OpcionCombo() { Valor = item.IdRol, Texto = item.Nombre });
            }

            cbRol.DisplayMember = "Texto";
            cbRol.ValueMember = "Valor";

            // Solo selecciona el primer item del combobox si hay items.
            if (cbRol.Items.Count > 0)
                cbRol.SelectedIndex = 0;

            // Se agregan al combobox de busqueda los encabezados visibles del dgv. 
            foreach (DataGridViewColumn columna in dgvUsuarios.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";

            if (cbBuscar.Items.Count > 0)
                cbBuscar.SelectedIndex = 0;

            MostrarListaUsuarios();
            DeshabilitarForm();
        }
        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PintarDGV.PintarbtnEditarEliminar(sender, e, "btnEditar", "btnEliminar");
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || (dgvUsuarios.Columns[e.ColumnIndex].Name != "btnEditar" && dgvUsuarios.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            int indice = e.RowIndex;

            if (e.ColumnIndex == dgvUsuarios.Columns["btnEditar"].Index)
            {
                lblIndice.Text = indice.ToString();
                lblID_Usuario.Text = dgvUsuarios.Rows[indice].Cells["ID_Usuario"].Value.ToString();

                txtDocumento.Text = dgvUsuarios.Rows[indice].Cells["Documento"].Value.ToString();
                txtNombre.Text = dgvUsuarios.Rows[indice].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvUsuarios.Rows[indice].Cells["Apellido"].Value.ToString();
                foreach (OpcionCombo oc in cbRol.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsuarios.Rows[indice].Cells["ID_Rol"].Value))
                    {
                        int indice_combo = cbRol.Items.IndexOf(oc);
                        // Se selecciona el que encontro.
                        cbRol.SelectedIndex = indice_combo;
                        // Cuando la relacion sea correcta se corta el foreach.
                        break;
                    }
                }

                HabilitarForm();
                txtClave.Enabled = false;
            }
            else if (e.ColumnIndex == dgvUsuarios.Columns["btnEliminar"].Index)
            {
                if (MessageBox.Show("¿Desea eliminar al usuario " + dgvUsuarios.Rows[indice].Cells["Nombre"].Value.ToString() +
                    "?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                // Se crea un nueva instancia de la que solo se necesita el ID del Cliente.
                CE_Usuario oUsuario = new CE_Usuario()
                {
                    Id = Convert.ToInt32(dgvUsuarios.Rows[indice].Cells["ID_Usuario"].Value)
                };

                bool respuesta = new CN_Usuario().Eliminar(oUsuario, out string mensaje);

                if (respuesta)
                    // Si se elimino correctamente (Eliminar retorna respuesta bool)
                    // se elimina la fila del DGV.
                    dgvUsuarios.Rows.RemoveAt(indice);
                else
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
                int idUsuarioCreado = new CN_Usuario().Crear(oUsuario, out string mensaje);

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
                bool resultado = new CN_Usuario().Actualizar(oUsuario, out string mensaje);

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
            LimpiarForm();
            DeshabilitarForm();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvUsuarios.Rows.Count == 0)
                return;

            string textoFiltro = txtBuscar.Text.Trim().ToUpper();
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();

            foreach (DataGridViewRow row in dgvUsuarios.Rows)
            {
                if (row.Cells[columnaFiltro].Value != null &&
                    row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textoFiltro))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            // Se elimina el filtro.
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
                    item.oRol.Nombre,
                    item.oEstado.Id,
                    item.oEstado.Nombre,
                    // Botones de editar y eliminar.
                    "",""
                });
            }
        }
        private void LimpiarForm()
        {
            // Se setea en -1 porque el indice empieza en 0.
            lblIndice.Text = "-1";
            // Se setea en 0 para que el boton guardar sepa si debe Crear o Actualizar.
            lblID_Usuario.Text = "0";

            // Se recorre el panel de formulario y se limpian los TextBox.
            foreach (Control control in pnlFormUsuario.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Clear();
                }
            }

            cbRol.SelectedIndex = 0;
            txtDocumento.Select();
        }
        private void HabilitarForm()
        {
            foreach (Control ctrl in pnlFormUsuario.Controls)
            {
                if (ctrl.EsInteractivo())
                    ctrl.Enabled = true;
            }

            pnlFormUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            pnlListaUsuarios.BackColor = System.Drawing.Color.Lavender;

            foreach (Control c in pnlListaUsuarios.Controls)
            {
                if (c.EsInteractivo())
                    c.Enabled = false;
            }

            txtDocumento.Select();

            //pnlFormUsuario.Enabled = true;

            //txtDocumento.Enabled = true;
            //txtNombre.Enabled = true;
            //txtApellido.Enabled = true;
            //txtClave.Enabled = true;
            //cbRol.Enabled = true;
            //btnGuardar.Enabled = true;
            //btnCancelar.Enabled = true;
        }
        private void DeshabilitarForm()
        {
            foreach (Control c in pnlFormUsuario.Controls)
            {
                if (c.EsInteractivo())
                    c.Enabled = false;
            }

            pnlFormUsuario.BackColor = System.Drawing.Color.Lavender;
            pnlListaUsuarios.BackColor = System.Drawing.SystemColors.ActiveCaption;

            foreach (Control c in pnlListaUsuarios.Controls)
            {
                if (c.EsInteractivo())
                    c.Enabled = true;
            }


            txtBuscar.Select();

            //pnlFormUsuario.Enabled = false;

            //txtDocumento.Enabled = false;
            //txtNombre.Enabled = false;
            //txtApellido.Enabled = false;
            //txtClave.Enabled = false;
            //cbRol.Enabled = false;
            //btnGuardar.Enabled = false;
            //btnCancelar.Enabled = false;
        }
        private void pnlListaUsuarios_Resize(object sender, EventArgs e)
        {
            lblListaUsuarios.CentrarH();
        }
    }
}
