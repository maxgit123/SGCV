using System;
using System.Collections.Generic;
using System.Linq;
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
        private static class NombreColumna
        {
            public const string ID_USUARIO = "id_usuario";
            public const string DOCUMENTO = "documento";
            public const string NOMBRE = "nombre";
            public const string APELLIDO = "apellido";
            public const string ROL_ID = "id_rol";
            public const string ESTADO_ID = "id_estado";
            public const string BTN_EDITAR = "btnEditar";
            public const string BTN_ELIMINAR = "btnEliminar";
        }
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            UtilidadesDGV.Configurar(dgvUsuarios);

            UtilidadesCB.Cargar(cbRol, new CN_Rol().Listar(), r => r.Id, r => r.Nombre);

            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvUsuarios, NombreColumna.APELLIDO);

            UtilidadesForm.AlternarPanelHabilitado(pnlListaUsuarios, pnlFormUsuario, txtBuscar);

            ListarUsuariosEnDGV();
        }
        private void dgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e, NombreColumna.BTN_EDITAR, NombreColumna.BTN_ELIMINAR);
        }
        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            string nombreColumna = dgvUsuarios.Columns[e.ColumnIndex].Name;
            
            if (nombreColumna != NombreColumna.BTN_EDITAR && nombreColumna != NombreColumna.BTN_ELIMINAR)
                return;

            // Usar este if si se usan columnas con orden dinamico o no se lo conoce
            //if (e.ColumnIndex == dgvUsuarios.Columns[NombreColumna.BTN_EDITAR].Index)
            if (nombreColumna == NombreColumna.BTN_EDITAR)
            {
                CargarDatosParaEdicion(e.RowIndex);
                ConfigurarFormularioParaEdicion(false);
            }
            else if (nombreColumna == NombreColumna.BTN_ELIMINAR)
            {
                EliminarUsuario(e.RowIndex);
            }
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
            ConfigurarFormularioParaEdicion(true);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            CE_Usuario oUsuario = new CE_Usuario()
            {
                Id = idUsuarioSeleccionado,
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Clave = txtClave.Text.Trim(),
                oRol = new CE_Rol()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbRol.SelectedItem).Valor)
                }
            };

            string mensaje;
            bool operacionExitosa;

            if (idUsuarioSeleccionado == 0)
                operacionExitosa = new CN_Usuario().Crear(oUsuario, out mensaje) != 0;
            else
                operacionExitosa = new CN_Usuario().Actualizar(oUsuario, out mensaje);

            if (!operacionExitosa)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListarUsuariosEnDGV();
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaUsuarios, pnlFormUsuario, txtBuscar);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaUsuarios, pnlFormUsuario, txtBuscar);
        }
        private void ListarUsuariosEnDGV()
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
                    item.oRol.Id,
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
        private bool ValidarCampos()
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
                errores.AppendLine("Ingrese el nº de documento.");
            else if (txtDocumento.Text.Length != 8 || !txtDocumento.Text.All(char.IsDigit))
                errores.AppendLine("El documento debe tener ocho (8) caracteres numéricos.");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                errores.AppendLine("Ingrese el nombre del usuario.");

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
                errores.AppendLine("Ingrese el apellido del usuario.");

            if (idUsuarioSeleccionado == 0 && string.IsNullOrWhiteSpace(txtClave.Text))
                errores.AppendLine("Ingrese la clave del usuario.");

            if (cbRol.SelectedItem == null || !(cbRol.SelectedItem is OpcionCombo))
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
        private void ConfigurarFormularioParaEdicion(bool esNuevoUsuario)
        {
            txtClave.Enabled = esNuevoUsuario;
            if (esNuevoUsuario)
            {
                idUsuarioSeleccionado = 0;
                LimpiarForm();
            }
            UtilidadesForm.AlternarPanelHabilitado(pnlFormUsuario, pnlListaUsuarios, txtDocumento);
        }
        private void CargarDatosParaEdicion(int indiceFilaSeleccionada)
        {
            DataGridViewRow filaSeleccionada = dgvUsuarios.Rows[indiceFilaSeleccionada];

            idUsuarioSeleccionado = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ID_USUARIO].Value);
            txtDocumento.Text = filaSeleccionada.Cells[NombreColumna.DOCUMENTO].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells[NombreColumna.NOMBRE].Value.ToString();
            txtApellido.Text = filaSeleccionada.Cells[NombreColumna.APELLIDO].Value.ToString();
            
            int idRolSeleccionado = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ROL_ID].Value);
            cbRol.SelectedItem = cbRol.Items
                .Cast<OpcionCombo>()
                .FirstOrDefault(oc => Convert.ToInt32(oc.Valor) == idRolSeleccionado);

            //foreach (OpcionCombo oc in cbRol.Items)
            //{
            //    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvUsuarios.Rows[indiceFila].Cells[NombreColumna.ROL_ID].Value))
            //    {
            //        cbRol.SelectedIndex = cbRol.Items.IndexOf(oc);
            //        break;
            //    }
            //}
        }
        private bool EliminarUsuario(int indiceFilaSeleccionada)
        {
            var filaSeleccionada = dgvUsuarios.Rows[indiceFilaSeleccionada];
            var nombreUsuario = filaSeleccionada.Cells[NombreColumna.NOMBRE].Value.ToString();
            var apellidoUsuario = filaSeleccionada.Cells[NombreColumna.APELLIDO].Value.ToString();
            
            if (!UtilidadesForm.ConfirmarAccion($"¿Desea eliminar al usuario {apellidoUsuario}, {nombreUsuario}?"))
                return false;

            var oUsuario = new CE_Usuario()
            {
                Id = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ID_USUARIO].Value)
            };

            if (!new CN_Usuario().Eliminar(oUsuario, out string mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            dgvUsuarios.Rows.RemoveAt(indiceFilaSeleccionada);
            return true;
        }
        private void pnlListaUsuarios_Resize(object sender, EventArgs e)
        {
            UtilidadesForm.CentrarHorizontalmente(lblListaUsuarios);
        }
    }
}
