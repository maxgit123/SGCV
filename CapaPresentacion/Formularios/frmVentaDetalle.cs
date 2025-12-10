using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios
{
    public partial class frmVentaDetalle : Form
    {
        private bool _datosCargados = false;

        public frmVentaDetalle()
        {
            InitializeComponent();
            UtilidadesDGV.Configurar(dgvProductos);
        }

        private void txtNroVenta_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarVenta(this, CargarDatosVenta);
        }
        private void txtNroVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (string.IsNullOrWhiteSpace(txtNroVenta.Text))
                return;

            CE_Venta oVenta = new CN_Venta().ObtenerVenta(Convert.ToInt32(txtNroVenta.Text));
            CargarDatosVenta(oVenta);
        }
        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            UtilidadesForm.ReiniciarControles(pnlInfoVenta);
            txtNroVenta.SetErrorState(false);
            dgvProductos.Rows.Clear();

            _datosCargados = false;
            txtNroVenta_AlternarTrailingIcon();
        }
        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosVenta(CE_Venta oVenta)
        {
            if (oVenta.Id == 0)
            {
                txtNroVenta.SetErrorState(true);
                return;
            }

            txtNroVenta.SetErrorState(false);
            txtNroVenta.Text = oVenta.Id.ToString();
            txtFechaVenta.Text = oVenta.FechaVenta.ToString("dd/MM/yyyy");
            txtTipoFactura.Text = oVenta.TipoFactura;
            txtUsuario.Text = oVenta.oUsuario.NombreCompleto;
            txtUsuarioDocumento.Text = oVenta.oUsuario.Documento;
            txtFechaCreacion.Text = oVenta.FechaCreacion.ToString("dd/MM/yyyy HH:mm:ss");
            txtClienteDocumento.Text = oVenta.oCliente.Documento;
            txtClienteNombre.Text = oVenta.oCliente.NombreCompleto;
            txtTelefono.Text = oVenta.oCliente.Telefono;
            txtCorreo.Text = oVenta.oCliente.Correo;
            txtTotal.Text = oVenta.Total.ToString("N2");

            dgvProductos.Rows.Clear();
            foreach (CE_VentaDetalle vd in oVenta.oVentaDetalle)
            {
                dgvProductos.Rows.Add(new object[]
                {
                    vd.oProducto.Codigo,
                    vd.oProducto.Descripcion,
                    vd.Cantidad,
                    vd.PrecioVentaUnitario,
                    vd.Subtotal
                });
            }

            _datosCargados = true;
            //txtNroVenta_AlternarTrailingIcon();
        }
        private void ActualizarTrailingIcon()
        {
            txtNroVenta.ReadOnly = _datosCargados;
            txtNroVenta.TrailingIcon = _datosCargados
                ? Properties.Resources.cancel_32
                : Properties.Resources.search_32;
        }
        private void txtNroVenta_AlternarTrailingIcon()
        {
            ActualizarTrailingIcon();

            if (_datosCargados)
            {
                txtNroVenta.ReadOnly = true;
                txtNroVenta.TrailingIconClick -= txtNroVenta_TrailingIconClick;
                txtNroVenta.TrailingIconClick += btnBorrarCampos_Click;
            }
            else
            {
                txtNroVenta.ReadOnly = false;
                txtNroVenta.TrailingIconClick -= btnBorrarCampos_Click;
                txtNroVenta.TrailingIconClick += txtNroVenta_TrailingIconClick;
            }
        }
    }
}