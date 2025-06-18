using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Proveedores
{
    public partial class frmProveedores : Form
    {
        private int idProveedorSeleccionado = 0;
        private static class NombreColumna
        {
            public const string ID_PROVEEDOR = "ID_Proveedor";
            public const string RAZON_SOCIAL = "RazonSocial";
            public const string OBSERVACION = "Observacion";
            public const string FECHA_CREACION = "FechaCreacion";
            public const string TELEFONO = "Telefono";
            public const string CORREO = "Correo";
            public const string ESTADO_ID = "ID_Estado";
            public const string ESTADO_NOMBRE = "NombreEstado";
            public const string BTN_EDITAR = "btnEditar";
            public const string BTN_ELIMINAR = "btnEliminar";
        }
        public frmProveedores()
        {
            InitializeComponent();
        }
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            UtilidadesDGV.Configurar(dgvProveedores);

            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvProveedores, NombreColumna.RAZON_SOCIAL);

            UtilidadesForm.AlternarPanelHabilitado(pnlListaProveedores, pnlFormProveedor, txtBuscar);

            ListarProveedoresEnDGV();
        }
        private void dgvProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e, NombreColumna.BTN_EDITAR, NombreColumna.BTN_ELIMINAR);
        }
        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            string nombreColumna = dgvProveedores.Columns[e.ColumnIndex].Name;
            if (nombreColumna != NombreColumna.BTN_EDITAR && nombreColumna != NombreColumna.BTN_ELIMINAR)
                return;

            if (nombreColumna == NombreColumna.BTN_EDITAR)
            {
                CargarDatosParaEdicion(e.RowIndex);
                ConfigurarFormularioParaEdicion(false);
            }
            else if (nombreColumna == NombreColumna.BTN_ELIMINAR)
            {
                EliminarProveedor(e.RowIndex);
            }
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvProveedores, cbBuscar, txtBuscar.Text);
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvProveedores, txtBuscar);
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            ConfigurarFormularioParaEdicion(true);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            CE_Proveedor oProveedor = new CE_Proveedor()
            {
                Id = idProveedorSeleccionado,
                Observacion = txtObservacion.Text.Trim(),
                RazonSocial = txtRazonSocial.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim()
            };

            string mensaje;
            bool operacionExitosa;

            if (idProveedorSeleccionado == 0)
            {
                operacionExitosa = new CN_Proveedor().Crear(oProveedor, out mensaje) != 0;
            }
            else
            {
                operacionExitosa = new CN_Proveedor().Actualizar(oProveedor, out mensaje);

            }

            if (!operacionExitosa)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListarProveedoresEnDGV();
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaProveedores, pnlFormProveedor, txtBuscar);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaProveedores, pnlFormProveedor, txtBuscar);
        }
        private void ListarProveedoresEnDGV()
        {
            dgvProveedores.Rows.Clear();
            List<CE_Proveedor> listaProveedor = new CN_Proveedor().Listar(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al listar proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (CE_Proveedor item in listaProveedor)
            {
                dgvProveedores.Rows.Add(new object[] {
                    item.Id,
                    item.RazonSocial,
                    item.Observacion,
                    item.FechaCreacion,
                    item.Telefono,
                    item.Correo,
                    item.oEstado.Id,
                    item.oEstado.Nombre,
                    "",""
                });
            }
        }
        private void LimpiarForm()
        {
            idProveedorSeleccionado = 0;
            UtilidadesForm.ReiniciarControles(pnlFormProveedor);
        }
        private bool ValidarCampos()
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                errores.AppendLine("Ingrese la razón social del proveedor.");

            // Si se ingreso un telfono o un correo, se agrega validaciones adicionales.

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
        private void ConfigurarFormularioParaEdicion(bool esNuevo)
        {
            if (esNuevo)
            {
                idProveedorSeleccionado = 0;
                LimpiarForm();
            }
            UtilidadesForm.AlternarPanelHabilitado(pnlFormProveedor, pnlListaProveedores, txtRazonSocial);
        }
        private void CargarDatosParaEdicion(int indiceFila)
        {
            idProveedorSeleccionado = Convert.ToInt32(dgvProveedores.Rows[indiceFila].Cells[NombreColumna.ID_PROVEEDOR].Value);
            txtRazonSocial.Text = dgvProveedores.Rows[indiceFila].Cells[NombreColumna.RAZON_SOCIAL].Value.ToString();
            txtObservacion.Text = dgvProveedores.Rows[indiceFila].Cells[NombreColumna.OBSERVACION].Value.ToString();
            txtTelefono.Text = dgvProveedores.Rows[indiceFila].Cells[NombreColumna.TELEFONO].Value.ToString();
            txtCorreo.Text = dgvProveedores.Rows[indiceFila].Cells[NombreColumna.CORREO].Value.ToString();
        }
        private bool ConfirmarAccion(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        private bool EliminarProveedor(int indiceFila)
        {
            var nombreProveedor = dgvProveedores.Rows[indiceFila].Cells[NombreColumna.RAZON_SOCIAL].Value.ToString();
            if (!ConfirmarAccion($"¿Desea eliminar al proveedor {nombreProveedor}?"))
                return false;

            var oProveedor = new CE_Proveedor
            {
                Id = Convert.ToInt32(dgvProveedores.Rows[indiceFila].Cells[NombreColumna.ID_PROVEEDOR].Value)
            };

            if (!new CN_Proveedor().Eliminar(oProveedor, out string mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            dgvProveedores.Rows.RemoveAt(indiceFila);
            return true;
        }
        private void pnlListaProveedores_Resize(object sender, EventArgs e)
        {
            lblListaProveedores.CentrarH();
        }
    }
}
