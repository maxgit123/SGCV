using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios
{
    public partial class frmVenta : Form
    {
        private readonly CE_Usuario _usuario;
        private int idClienteSeleccionado = 0;
        private int idProductoSeleccionado = 0;
        private int stockProducto = 0;
        private const string formatoPrecio = "0.00";
        private static readonly CultureInfo culturaArgentina = new CultureInfo("es-AR");
        private static class NombreColumna
        {
            public const string ID_PRODUCTO = "id_producto";
            //public const string DESCRIPCION = "descripcion";
            public const string PRECIO = "precio";
            public const string CANTIDAD = "cantidad";
            public const string SUBTOTAL = "subtotal";
            public const string ELIMINAR = "btnEliminar";
        }

        public frmVenta(CE_Usuario oUsuario = null)
        {
            _usuario = oUsuario;
            InitializeComponent();
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            UtilidadesDGV.Configurar(dgvProductos);
            dtpFechaVenta.Value = DateTime.Now;
            txtNombreCompletoCliente.ReadOnly = true;
            txtDescripcionProducto.ReadOnly = true;
            txtPrecioVenta.ReadOnly = true;
            txtPrecioVenta.TextAlign = HorizontalAlignment.Right;
            txtStockProducto.ReadOnly = true;
            txtStockProducto.TextAlign = HorizontalAlignment.Right;
            txtTotal.ReadOnly = true;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtVuelto.TextAlign = HorizontalAlignment.Right;
            txtPago.TextAlign = HorizontalAlignment.Right;
            nudCantidadProducto.TextAlign = HorizontalAlignment.Right;
            nudCantidadProducto.Minimum = 1;
            nudCantidadProducto.Maximum = 999; // Este podria setearse en base al stock del producto
        }
        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e, nombreColEliminar: NombreColumna.ELIMINAR);
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            string nombreColumna = dgvProductos.Columns[e.ColumnIndex].Name;

            if (nombreColumna != NombreColumna.ELIMINAR)
                return;

            dgvProductos.Rows.RemoveAt(e.RowIndex);
            CalcularTotal();
        }
        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarProducto(
                txtCodigo: txtCodigoProducto,
                txtDescripcion: txtDescripcionProducto,
                idProductoSeleccionado: ref idProductoSeleccionado,
                txtPrecioVenta: txtPrecioVenta,
                txtStockProducto: txtStockProducto
            );

            if (int.TryParse(txtStockProducto.Text, out int stock))
            {
                nudCantidadProducto.Maximum = stock;
            }
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarCliente(
                txtDniCliente,
                txtNombreCompletoCliente,
                ref idClienteSeleccionado
            );
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioVenta;

            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Validación de stock ---
            CE_Producto oProducto = new CN_Producto().Listar()
                .Find(p => p.Id == idProductoSeleccionado && p.oEstado.Id == true);

            if (nudCantidadProducto.Value > oProducto.Stock)
            {
                MessageBox.Show($"La cantidad solicitada ({nudCantidadProducto.Value}) supera el stock disponible ({oProducto.Stock}).",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!UtilidadesForm.EsPrecioValido(txtPrecioVenta.Text))
            {
                MessageBox.Show("El formato del precio no es válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioVenta.Select();
                return;
            }
            precioVenta = decimal.Parse(txtPrecioVenta.Text, culturaArgentina);

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value) == idProductoSeleccionado)
                {
                    MessageBox.Show("El producto que se intenta agregar ya fue agregado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            decimal subtotal = nudCantidadProducto.Value * precioVenta;

            dgvProductos.Rows.Add(new object[]
            {
                idProductoSeleccionado,
                txtDescripcionProducto.Text,
                precioVenta.ToString(formatoPrecio, culturaArgentina),
                nudCantidadProducto.Value,
                subtotal.ToString(formatoPrecio, culturaArgentina),
                "" // btnEliminar
            });

            CalcularTotal();
            LimpiarProducto();
            txtCodigoProducto.Select();
        }
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            //if (idClienteSeleccionado == 0)
            //{
            //    MessageBox.Show("Debe seleccionar un cliente.", "Advertencia",
            //        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            if (dgvProductos.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar al menos un producto a la venta.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable ventaDetalle = new DataTable();

            ventaDetalle.Columns.Add("id_producto", typeof(int));
            ventaDetalle.Columns.Add("precioVentaUnitario", typeof(decimal));
            ventaDetalle.Columns.Add("cantidad", typeof(int));
            ventaDetalle.Columns.Add("subtotal", typeof(decimal));

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                ventaDetalle.Rows.Add(new object[]
                {
                    Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value),
                    Convert.ToDecimal(fila.Cells[NombreColumna.PRECIO].Value),
                    Convert.ToInt32(fila.Cells[NombreColumna.CANTIDAD].Value),
                    Convert.ToDecimal(fila.Cells[NombreColumna.SUBTOTAL].Value)
                });
            }

            CE_Venta oVenta = new CE_Venta()
            {
                oUsuario = new CE_Usuario()
                {
                    Id = _usuario.Id,
                },
                oCliente = new CE_Cliente()
                {
                    Id = idClienteSeleccionado
                },
                //FechaVenta = dtpFechaVenta.Value,
                Total = Convert.ToDecimal(txtTotal.Text, culturaArgentina),
            };

            int respuesta = new CN_Venta().Crear(oVenta, ventaDetalle, out string mensaje);

            if (respuesta == 0)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Venta registrada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombreCompletoCliente.Clear();
            dgvProductos.Rows.Clear();
            CalcularTotal();
        }
        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            CE_Producto oProducto = new CN_Producto().Listar()
                .Find(p => p.Codigo == txtCodigoProducto.Text.Trim() && p.oEstado.Id == true);
            
            if (oProducto == null)
            {
                txtCodigoProducto.BackColor = Color.LightCoral;
                idProductoSeleccionado = 0;
                txtDescripcionProducto.Clear();
                return;
            }

            txtCodigoProducto.BackColor = Color.LightGreen;
            idProductoSeleccionado = oProducto.Id;
            txtDescripcionProducto.Text = oProducto.Descripcion;
            txtPrecioVenta.Select();
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

            if (dgvProductos.Rows.Count < 1)
            {
                txtTotal.Text = "0.00";
                return;
            }

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                var valorCelda = fila.Cells[NombreColumna.SUBTOTAL].Value;

                if (valorCelda == null)
                    continue;

                string textoCelda = valorCelda.ToString();
                if (decimal.TryParse(textoCelda, NumberStyles.Any, culturaArgentina, out decimal subtotal))
                {
                    total += subtotal;
                }
            }

            txtTotal.Text = total.ToString(formatoPrecio, culturaArgentina);
        }
    }
}
