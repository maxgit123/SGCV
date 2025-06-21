using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Clientes
{
    public partial class frmClientes : Form
    {
        private int idClienteSeleccionado = 0;
        private static class NombreColumna
        {
            public const string ID_CLIENTE = "id_cliente";
            public const string DOCUMENTO = "documento";
            public const string NOMBRE = "nombre";
            public const string APELLIDO = "apellido";
            public const string TELEFONO = "telefono";
            public const string CORREO = "correo";
            public const string BTN_EDITAR = "btnEditar";
            public const string BTN_ELIMINAR = "btnEliminar";
        }
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            UtilidadesDGV.Configurar(dgvClientes);

            UtilidadesCB.Cargar(cbRespIVA, new CN_ResponsableIVA().Listar(), r => r.Id, r => r.Nombre);

            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvClientes, NombreColumna.APELLIDO);

            ListarClientesEnDGV();
        }
        private void dgvClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e, NombreColumna.BTN_EDITAR, NombreColumna.BTN_ELIMINAR);
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            string nombreColumna = dgvClientes.Columns[e.ColumnIndex].Name;
            if (nombreColumna != NombreColumna.BTN_EDITAR && nombreColumna != NombreColumna.BTN_ELIMINAR)
                return;

            if (nombreColumna == NombreColumna.BTN_EDITAR)
            {
                CargarDatosParaEdicion(e.RowIndex);
                ConfigurarFormularioParaEdicion(false);
            }
            else if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                EliminarCliente(e.RowIndex);
            }
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvClientes, cbBuscar, txtBuscar.Text);
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvClientes, txtBuscar);
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            ConfigurarFormularioParaEdicion(true);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            CE_Cliente oCliente = new CE_Cliente()
            {
                Id = idClienteSeleccionado,
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                oRespIVA = new CE_ResponsableIVA()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbRespIVA.SelectedItem).Valor)
                }
            };

            string mensaje;
            bool operacionExitosa;

            if (idClienteSeleccionado == 0)
            {
                operacionExitosa = new CN_Cliente().Crear(oCliente, out mensaje) != 0;
            }
            else
            {
                operacionExitosa = new CN_Cliente().Actualizar(oCliente, out mensaje);
            }

            if (!operacionExitosa)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListarClientesEnDGV();
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaClientes, pnlFormCliente, txtBuscar);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaClientes, pnlFormCliente, txtBuscar);
        }
        private void ListarClientesEnDGV()
        {
            dgvClientes.Rows.Clear();
            List<CE_Cliente> listaCliente = new CN_Cliente().Listar(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al listar clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (CE_Cliente item in listaCliente)
            {
                dgvClientes.Rows.Add(new object[] {
                    item.Id,
                    item.Documento,
                    item.Nombre,
                    item.Apellido,
                    item.Telefono,
                    item.Correo,
                    item.FechaCreacion,
                    item.oRespIVA.Id,
                    item.oRespIVA.Nombre,
                    item.oEstado.Id,
                    item.oEstado.Nombre,
                    "",""
                });
            }
        }
        private void LimpiarForm()
        {
            idClienteSeleccionado = 0;
            UtilidadesForm.ReiniciarControles(pnlFormCliente);
        }
        private bool ValidarCampos()
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtDocumento.Text))
                errores.AppendLine("Ingrese un nº de documento.");
            else if (txtDocumento.Text.Length != 8 || !txtDocumento.Text.All(char.IsDigit))
                errores.AppendLine("El documento debe tener ocho (8) caracteres numéricos.");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                errores.AppendLine("Ingrese el nombre del cliente.");

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
                errores.AppendLine("Ingrese el apellido del cliente.");

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                errores.AppendLine("Ingrese el número de teléfono del cliente.");

            if (string.IsNullOrWhiteSpace(txtCorreo.Text))
                errores.AppendLine("Ingrese el correo electrónico del cliente.");

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
        private void ConfigurarFormularioParaEdicion(bool esNuevoCliente)
        {
            if (esNuevoCliente)
            {
                idClienteSeleccionado = 0;
                LimpiarForm();
            }
            UtilidadesForm.AlternarPanelHabilitado(pnlFormCliente, pnlListaClientes, txtDocumento);
        }
        private void CargarDatosParaEdicion(int indiceFilaSeleccionada)
        {
            DataGridViewRow filaSeleccionada = dgvClientes.Rows[indiceFilaSeleccionada];

            idClienteSeleccionado = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ID_CLIENTE].Value);
            txtDocumento.Text = filaSeleccionada.Cells[NombreColumna.DOCUMENTO].Value.ToString();
            txtNombre.Text = filaSeleccionada.Cells[NombreColumna.NOMBRE].Value.ToString();
            txtApellido.Text = filaSeleccionada.Cells[NombreColumna.APELLIDO].Value.ToString();
            txtTelefono.Text = filaSeleccionada.Cells[NombreColumna.TELEFONO].Value.ToString();
            txtCorreo.Text = filaSeleccionada.Cells[NombreColumna.CORREO].Value.ToString();
            int idRespIVASeleccionado = Convert.ToInt32(filaSeleccionada.Cells["ID_RespIVA"].Value);

            cbRespIVA.SelectedItem = cbRespIVA.Items.Cast<OpcionCombo>()
                .FirstOrDefault(oc => Convert.ToInt32(oc.Valor) == idRespIVASeleccionado);
        }
        private bool EliminarCliente(int indiceFilaSeleccionada)
        {
            DataGridViewRow filaSeleccionada = dgvClientes.Rows[indiceFilaSeleccionada];

            var nombreCliente = filaSeleccionada.Cells[NombreColumna.NOMBRE].Value.ToString();
            var apellidoCliente = filaSeleccionada.Cells[NombreColumna.APELLIDO].Value.ToString();
            
            if (!UtilidadesForm.ConfirmarAccion($"¿Desea eliminar al cliente {apellidoCliente}, {nombreCliente}?"))
                return false;

            var oCliente = new CE_Cliente()
            {
                Id = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ID_CLIENTE].Value)
            };

            if (!new CN_Cliente().Eliminar(oCliente, out string mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            dgvClientes.Rows.RemoveAt(indiceFilaSeleccionada);
            return true;
        }
        private void pnlListaClientes_Resize(object sender, EventArgs e)
        {
            UtilidadesForm.CentrarHorizontalmente(lblListaClientes);
        }
    }
}
