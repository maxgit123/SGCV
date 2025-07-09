using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Modal;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios
{
    public partial class frmCompra : Form
    {
        private readonly CE_Usuario usuario;
        private int idProveedorSeleccionado = 0;
        private int idProductoSeleccionado = 0;
        private const string FormatoPrecio = "0.00";
        private static readonly CultureInfo CulturaArgentina = new CultureInfo("es-AR");

        private static class NombreColumna
        {
            public const string ID_PRODUCTO = "id_producto";
            public const string DESCRIPCION = "descripcion";
            public const string PRECIO_COMPRA = "precioCompra";
            public const string CANTIDAD = "cantidad";
            public const string SUBTOTAL = "subTotal";
            public const string BTN_ELIMINAR = "btnEliminar";
        }
        public frmCompra(CE_Usuario oUsuario = null)
        {
            usuario = oUsuario;
            InitializeComponent();
        }
        private void frmCompras_Load(object sender, EventArgs e)
        {
            UtilidadesDGV.Configurar(dgvProductos);
            dtpPedido.Value = DateTime.Now;
            dtpEntrega.Value = DateTime.Now;
            txtRazonSocial.ReadOnly = true;
            txtDescProducto.ReadOnly = true;
            nudCantidad.Minimum = 1;
            nudCantidad.Maximum = 999;
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
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            string nombreColumna = dgvProductos.Columns[e.ColumnIndex].Name;

            if (nombreColumna != NombreColumna.BTN_ELIMINAR) return;

            if (nombreColumna == NombreColumna.BTN_ELIMINAR)
            {
                dgvProductos.Rows.RemoveAt(Convert.ToInt32(e.RowIndex));
                CalcularTotal();
            }
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    idProductoSeleccionado = modal.Producto.Id;
                    txtCodProducto.Text = modal.Producto.Codigo;
                    txtCodProducto.BackColor = Color.LightGreen;
                    txtDescProducto.Text = modal.Producto.Descripcion;
                }
            }
        } // Check
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    idProveedorSeleccionado = modal.Proveedor.Id;
                    txtRazonSocial.Text = modal.Proveedor.RazonSocial;
                }
            }
        } // Check
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            //decimal precioVenta = 0;
            bool productoExiste = false;

            // Se comprueba que se haya seleccionado un producto
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se valida el campo de precio de compra y se guarda como decimal
            if (!UtilidadesForm.EsPrecioValido(txtPrecioCompra.Text))
            {
                MessageBox.Show("El formato del precio no es válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioCompra.Select();
                return;
            }
            precioCompra = decimal.Parse(txtPrecioCompra.Text);

            // Se comprueba que no se agregue un producto ya agregado
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value) == idProductoSeleccionado)
                {
                    productoExiste = true;
                    MessageBox.Show("El producto que se intenta agregar ya fue agregado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            if (!productoExiste)
            {
                decimal subTotal = nudCantidad.Value * precioCompra;

                dgvProductos.Rows.Add(new object[]
                {
                    idProductoSeleccionado,
                    txtDescProducto.Text,
                    precioCompra.ToString(FormatoPrecio),
                    //precioVenta.ToString(FormatoPrecio),
                    nudCantidad.Value.ToString(),
                    (subTotal).ToString(FormatoPrecio),
                    "" // btnEliminar
                });

                CalcularTotal();
                LimpiarProducto();
                txtCodProducto.Select();
            }
        }
        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvProductos.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar al menos un producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarFechas())
                return;

            DataTable compraDetalle = new DataTable();

            compraDetalle.Columns.Add("id_producto", typeof(int));
            compraDetalle.Columns.Add("precioCompraUnitario", typeof(decimal));
            compraDetalle.Columns.Add("cantidad", typeof(int));
            compraDetalle.Columns.Add("subTotal", typeof(decimal));

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                compraDetalle.Rows.Add(
                    new object[]
                    {
                        Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value),
                        Convert.ToDecimal(fila.Cells[NombreColumna.PRECIO_COMPRA].Value),
                        Convert.ToInt32(fila.Cells[NombreColumna.CANTIDAD].Value),
                        Convert.ToDecimal(fila.Cells[NombreColumna.SUBTOTAL].Value)
                    }
                );
            }

            CE_Compra oCompra = new CE_Compra()
            {
                oUsuario = new CE_Usuario()
                {
                    Id = usuario.Id
                },
                oProveedor = new CE_Proveedor()
                {
                    Id = idProveedorSeleccionado
                },
                FechaPedido = dtpPedido.Value,
                FechaEntrega = dtpEntrega.Value,
                Total = Convert.ToDecimal(txtTotal.Text)
            };

            bool respuesta = new CN_Compra().Crear(oCompra, compraDetalle, out string mensaje);

            if (!respuesta)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Compra registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtRazonSocial.Clear();
            dgvProductos.Rows.Clear();
            CalcularTotal();
        }
        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            // Se usa keyDown para detectar la tecla Enter (los lectores de código de barras envían Enter al finalizar la lectura)
            if (e.KeyCode == Keys.Enter)
            {
                CE_Producto oProducto = new CN_Producto().Listar().Find(p => p.Codigo == txtCodProducto.Text.Trim() && p.oEstado.Id == true);

                if (oProducto == null)
                {
                    txtCodProducto.BackColor = Color.LightCoral;
                    idProductoSeleccionado = 0;
                    txtDescProducto.Clear();
                    return;
                }

                txtCodProducto.BackColor = Color.LightGreen;
                idProductoSeleccionado = oProducto.Id;
                txtDescProducto.Text = oProducto.Descripcion;
                txtPrecioCompra.Select();
            }
        }
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesForm.EsEntradaPrecioValida(sender, e);
        }
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesForm.EsEntradaPrecioValida(sender, e);
        }

        private void LimpiarProducto()
        {
            idProductoSeleccionado = 0;
            UtilidadesForm.ReiniciarControles(gbInfoProducto);
        }
        private void CalcularTotal()
        {
            decimal total = 0;

            if (dgvProductos.Rows.Count < 1) return;

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                var valorCelda = fila.Cells[NombreColumna.SUBTOTAL].Value;
                
                if (valorCelda == null) continue; // En el flujo normal no debería ser null (btnAgregar_Click valida esto)

                string textoCelda = valorCelda.ToString();
                if (decimal.TryParse(textoCelda, NumberStyles.Any, CulturaArgentina, out decimal subTotal))
                {
                    total += subTotal;
                }
            }

            txtTotal.Text = total.ToString(FormatoPrecio, CulturaArgentina);
        }
        private bool ValidarFechas()
        {
            if (dtpEntrega.Value < dtpPedido.Value)
            {
                MessageBox.Show("La fecha de entrega no puede ser anterior a la fecha de pedido", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
