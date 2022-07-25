using System;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;

namespace CapaPresentacion.Formularios.Compras
{
    public partial class frmCompras : Form
    {
        private readonly CE_Usuario usuario;
        public frmCompras(CE_Usuario oUsuario = null)
        {
            usuario = oUsuario;
            InitializeComponent();
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            dtpPedido.Value = DateTime.Now;
        }
        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvProductos.ColumnCount - 1) //Pinta el icono de eliminar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete16.Width;
                var h = Properties.Resources.delete16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || dgvProductos.Columns[e.ColumnIndex].Name != "btnEliminar")
                return;

            if (e.ColumnIndex == dgvProductos.Columns["btnEliminar"].Index)
            {
                dgvProductos.Rows.RemoveAt(Convert.ToInt32(e.RowIndex));
                CalcularTotal();
            }
        }
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProveedor.Text = modal.Proveedor.Id.ToString();
                    txtRazonSocial.Text = modal.Proveedor.RazonSocial;
                }
            }
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProducto.Text = modal.Producto.Id.ToString();
                    txtDescProducto.Text = modal.Producto.Descripcion;
                    txtCosto.Select();
                }
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal costo = 0;
            decimal precio = 0;
            bool productoExiste = false;

            if (int.Parse(txtIdProducto.Text) == 0)
            {
                MessageBox.Show("Seleccione un prodcuto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!decimal.TryParse(txtCosto.Text, out costo))
            {
                MessageBox.Show("Costo: formato incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCosto.Select();
                return;
            }
            /*
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Precio: formato incorrecto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecio.Select();
                return;
            }
            */
            
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (fila.Cells["ID_Producto"].Value.ToString() == txtIdProducto.Text)
                {
                    productoExiste = true;
                    break;
                }
            }
            if (!productoExiste)
            {
                dgvProductos.Rows.Add(new object[]
                {
                    txtIdProducto.Text,
                    txtDescProducto.Text,
                    costo.ToString("0.00"),
                    //precio.ToString("0.00"),
                    nudCantidad.Value.ToString(),
                    (nudCantidad.Value * costo).ToString("0.00"),
                    ""
                });
                CalcularTotal();
                LimpiarProducto();
                //txtCodProducto.Select();
            }
        }
        private void LimpiarProducto()
        {
            txtIdProducto.Text = "0";
            //txtCodProducto.Text = "";
            //txtCodProducto.BackColor = Color.White;
            txtDescProducto.Text = "";
            txtCosto.Text = "";
            //txtPrecio.Text = "";
            nudCantidad.Value = 1;
        }
        private void CalcularTotal()
        {
            decimal total = 0;
            if (dgvProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvProductos.Rows)
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value.ToString());
            }
            txtTotal.Text = total.ToString("0.00");
        }
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
            {
                if (txtCosto.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                    e.Handled = true;
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
            {
                if (txtPrecio.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                    e.Handled = true;
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                        e.Handled = false;
                    else
                        e.Handled = true;
                }
            }
            */
        }
        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No se ha registrado una venta aún.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //MessageBox.Show("Ingrese el nombre.\nIngrese el Apellido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //MessageBox.Show("No se puede eliminar un cliente asosiado a una venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
