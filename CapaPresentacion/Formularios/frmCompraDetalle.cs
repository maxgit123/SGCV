using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios
{
    public partial class frmCompraDetalle : Form
    {
        public frmCompraDetalle()
        {
            InitializeComponent();
        }

        private void CargarDatosCompra(CE_Compra oCompra)
        {
            if (oCompra.Id == 0)
            {
                txtNroCompra.SetErrorState(true);
                return;
            }

            txtNroCompra.Text = oCompra.Id.ToString();
            txtNroCompra.SetErrorState(false);

            txtFechaPedido.Text = oCompra.FechaPedido.ToString("dd/MM/yyyy");
            txtFechaEntrega.Text = oCompra.FechaEntrega.ToString("dd/MM/yyyy");
            txtUsuario.Text = oCompra.oUsuario.NombreCompleto;
            txtDocumento.Text = oCompra.oUsuario.Documento;
            txtFechaCreacion.Text = oCompra.FechaCreacion.ToString("dd/MM/yyyy HH:mm:ss");
            txtRazonSocial.Text = oCompra.oProveedor.RazonSocial;
            txtTelefono.Text = oCompra.oProveedor.Telefono;
            txtCorreo.Text = oCompra.oProveedor.Correo;
            txtTotal.Text = oCompra.Total.ToString("N2");

            dgvProductos.Rows.Clear();
            foreach (CE_CompraDetalle cd in oCompra.oCompraDetalle)
            {
                dgvProductos.Rows.Add(new object[]
                {
                    cd.oProducto.Codigo,
                    cd.oProducto.Descripcion,
                    cd.PrecioCompraUnitario,
                    cd.Cantidad,
                    cd.Subtotal
                });
            }
        }

        private void txtNroCompra_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarCompra(this, CargarDatosCompra);
        }
        private void txtNroCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (string.IsNullOrWhiteSpace(txtNroCompra.Text))
                return;

            CE_Compra oCompra = new CN_Compra().ObtenerCompra(Convert.ToInt32(txtNroCompra.Text));
            CargarDatosCompra(oCompra);
        }
        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            UtilidadesForm.ReiniciarControles(pnlInfoCompra);
            txtNroCompra.SetErrorState(false);
            dgvProductos.Rows.Clear();
        }
    }
}
