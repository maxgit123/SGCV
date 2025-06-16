using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Usuarios
{
    public partial class frmUsuarios : Form
    {
        private int idUsuarioSeleccionado = 0;
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            UtilidadesDGV.Configurar(dgvUsuarios);

            UtilidadesCB.Cargar(cbRol, new CN_Rol().Listar(), r => r.IdRol, r => r.Nombre);

            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvUsuarios, "apellido");

            UtilidadesForm.AlternarPanelHabilitado(pnlListaUsuarios, pnlFormUsuario, txtBuscar);

            MostrarListaUsuarios();
        }
        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e, "btnEditar", "btnEliminar");
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || (dgvUsuarios.Columns[e.ColumnIndex].Name != "btnEditar" && dgvUsuarios.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            int indiceFila = e.RowIndex;

            // Usar este if si se usan columnas con orden dinamico o no se lo conoce
            //if (e.ColumnIndex == dgvUsuarios.Columns["btnEditar"].Index)
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                idUsuarioSeleccionado = Convert.ToInt32(dgvUsuarios.Rows[indiceFila].Cells["id_usuario"].Value);
                txtDocumento.Text = dgvUsuarios.Rows[indiceFila].Cells["documento"].Value.ToString();
                txtNombre.Text = dgvUsuarios.Rows[indiceFila].Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvUsuarios.Rows[indiceFila].Cells["apellido"].Value.ToString();

                foreach (OpcionCombo oc in cbRol.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsuarios.Rows[indiceFila].Cells["id_rol"].Value))
                    {
                        int indiceCombo = cbRol.Items.IndexOf(oc);
                        // Se selecciona el que encontro.
                        cbRol.SelectedIndex = indiceCombo;
                        // Cuando la relacion sea correcta se corta el foreach.
                        break;
                    }
                }

                UtilidadesForm.AlternarPanelHabilitado(pnlFormUsuario, pnlListaUsuarios, txtDocumento);
                txtClave.Enabled = false;
            }
            else if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                // Si se presiona el boton de eliminar, se pregunta si se desea eliminar el usuario.
                DialogResult respuestaEliminar = MessageBox.Show(
                    $"¿Desea eliminar al usuario {dgvUsuarios.Rows[indiceFila].Cells["nombre"].Value}?",
                    "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                if (respuestaEliminar == DialogResult.No)
                    return;

                // Se crea un nueva instancia de la que solo se necesita el ID del Cliente.
                CE_Usuario oUsuario = new CE_Usuario()
                {
                    Id = Convert.ToInt32(dgvUsuarios.Rows[indiceFila].Cells["id_usuario"].Value)
                };

                bool respuesta = new CN_Usuario().Eliminar(oUsuario, out string mensaje);

                // Si se elimino correctamente (Eliminar retorna respuesta bool) se elimina la fila del DGV.
                if (respuesta)
                    dgvUsuarios.Rows.RemoveAt(indiceFila);
                else
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarEntradas())
                return;

            CE_Usuario oUsuario = new CE_Usuario()
            {
                Id = idUsuarioSeleccionado,
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Clave = txtClave.Text.Trim(),
                oRol = new CE_Rol()
                {
                    IdRol = Convert.ToInt32(((OpcionCombo)cbRol.SelectedItem).Valor)
                }
            };

            //string mensaje;
            //bool operacionExitosa;

            if (idUsuarioSeleccionado == 0)
            {
                int idUsuarioCreado = new CN_Usuario().Crear(oUsuario, out string mensaje);

                if (idUsuarioCreado == 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                bool resultado = new CN_Usuario().Actualizar(oUsuario, out string mensaje);

                if (!resultado)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            MostrarListaUsuarios();
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaUsuarios, pnlFormUsuario, txtBuscar);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaUsuarios, pnlFormUsuario, txtBuscar);
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvUsuarios, cbBuscar, txtBuscar.Text);
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvUsuarios, txtBuscar);
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            idUsuarioSeleccionado = 0;
            UtilidadesForm.AlternarPanelHabilitado(pnlFormUsuario, pnlListaUsuarios, txtDocumento);
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
            // Se setea en 0 para que el boton guardar sepa si debe Crear o Actualizar.
            idUsuarioSeleccionado = 0;
            UtilidadesForm.ReiniciarControles(pnlFormUsuario);
        }
        private void pnlListaUsuarios_Resize(object sender, EventArgs e)
        {
            lblListaUsuarios.CentrarH();
        }
        private bool ValidarEntradas()
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
                errores.AppendLine("Ingrese un nº de documento.");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                errores.AppendLine("Ingrese el nombre del usuario.");

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
                errores.AppendLine("Ingrese el apellido del usuario.");

            if (idUsuarioSeleccionado == 0 && string.IsNullOrWhiteSpace(txtClave.Text))
                errores.AppendLine("Ingrese la clave del usuario.");

            if (!(cbRol.SelectedItem is OpcionCombo))
                errores.AppendLine("Seleccione el rol del usuario.");

            if (errores.Length > 0)
            {
                MessageBox.Show(
                    $"Se encontraron los siguientes errores:\n\n {errores}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }
        private bool ConfirmarAccion(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
