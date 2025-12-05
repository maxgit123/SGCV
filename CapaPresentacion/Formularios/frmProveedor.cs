using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios
{
    public partial class frmProveedor : Form
    {
        private int _idProveedorSeleccionado = 0;
        private static class NombreColumna
        {
            public const string ID_PROVEEDOR = "id_proveedor";
            public const string RAZON_SOCIAL = "razonSocial";
            public const string OBSERVACION = "observacion";
            public const string TELEFONO = "telefono";
            public const string CORREO = "correo";
            public const string BTN_EDITAR = "btnEditar";
            public const string BTN_ELIMINAR = "btnEliminar";
        }

        public frmProveedor()
        {
            InitializeComponent();

            BackColor = System.Drawing.Color.FromArgb(63, 81, 181); // Indigo 500
            UtilidadesDGV.Configurar(dgvProveedores);

            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvProveedores, NombreColumna.RAZON_SOCIAL);
            UtilidadesForm.AlternarPanelHabilitado(pnlListaProveedores, mpnlFormProveedor, txtBuscar);
            ListarProveedoresEnDGV();
        }

        private void dgvProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e,
                nombreColEditar: NombreColumna.BTN_EDITAR,
                nombreColEliminar: NombreColumna.BTN_ELIMINAR
            );
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
        private void txtBuscar_TrailingIconClick(object sender, EventArgs e)
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
                Id = _idProveedorSeleccionado,
                Observacion = txtObservacion.Text.Trim(),
                RazonSocial = txtRazonSocial.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim()
            };

            string mensaje;
            bool operacionExitosa;

            if (_idProveedorSeleccionado == 0)
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
            UtilidadesForm.AlternarPanelHabilitado(pnlListaProveedores, mpnlFormProveedor, txtBuscar);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaProveedores, mpnlFormProveedor, txtBuscar);
        }
        private void pnlListaProveedores_Resize(object sender, EventArgs e)
        {
            UtilidadesForm.CentrarHorizontalmente(lblListaProveedores);
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
            _idProveedorSeleccionado = 0;
            UtilidadesForm.ReiniciarControles(mpnlFormProveedor);
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
                _idProveedorSeleccionado = 0;
                LimpiarForm();
            }
            UtilidadesForm.AlternarPanelHabilitado(mpnlFormProveedor, pnlListaProveedores, txtRazonSocial);
        }
        private void CargarDatosParaEdicion(int indiceFila)
        {
            var fila = dgvProveedores.Rows[indiceFila];

            _idProveedorSeleccionado = Convert.ToInt32(fila.Cells[NombreColumna.ID_PROVEEDOR].Value);
            txtRazonSocial.Text = fila.Cells[NombreColumna.RAZON_SOCIAL].Value.ToString();
            txtObservacion.Text = fila.Cells[NombreColumna.OBSERVACION].Value.ToString();
            txtTelefono.Text = fila.Cells[NombreColumna.TELEFONO].Value.ToString();
            txtCorreo.Text = fila.Cells[NombreColumna.CORREO].Value.ToString();
        }
        private bool EliminarProveedor(int indiceFila)
        {
            var nombreProveedor = dgvProveedores.Rows[indiceFila].Cells[NombreColumna.RAZON_SOCIAL].Value.ToString();
            if (!UtilidadesForm.ConfirmarAccion($"¿Desea eliminar al proveedor {nombreProveedor}?"))
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
    }
}
