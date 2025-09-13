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
        private int _idClienteSeleccionado = 0;
        private int _idProductoSeleccionado = 0;
        private int _productoCantidad = 1;
        private int _productoStockMaximo = 0;
        private const string _formatoPrecio = "0.00";
        private static readonly CultureInfo _culturaArgentina = new CultureInfo("es-AR");
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
            InitializeComponent();
            _usuario = oUsuario;
            BackColor = Color.FromArgb(63, 81, 181); // Indigo 500
            UtilidadesDGV.Configurar(dgvProductos);
            dtpVentaFecha.Value = DateTime.Now;
            txtClienteNombreCompleto.ReadOnly = true;
            txtProductoDescripcion.ReadOnly = true;
            txtProductoPrecio.ReadOnly = true;
            txtProductoPrecio.TextAlign = HorizontalAlignment.Right;
            txtProductoStock.ReadOnly = true;
            txtProductoStock.TextAlign = HorizontalAlignment.Right;
            txtTotal.ReadOnly = true;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            txtVuelto.TextAlign = HorizontalAlignment.Right;
            txtPago.TextAlign = HorizontalAlignment.Right;
            txtProductoCantidad.TextAlign = HorizontalAlignment.Center;
            //txtProductoCantidad.Minimum = 1;
            //txtProductoCantidad.Maximum = 999; // Este podria setearse en base al stock del producto
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
        private void txtProductoCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            CE_Producto oProducto = new CN_Producto().Listar()
                .Find(p => p.Codigo == txtProductoCodigo.Text.Trim() && p.oEstado.Id == true && p.Stock >= 1);
            
            if (oProducto == null)
            {
                //txtProductoCodigo.BackColor = Color.LightCoral;
                txtProductoCodigo.SetErrorState(true);
                //txtProductoCodigo.ShowAssistiveText = true;
                _idProductoSeleccionado = 0;
                txtProductoDescripcion.Clear();
                txtProductoPrecio.Text = "0,00";
                txtProductoCantidad.Text = "1";
                txtProductoStock.Text = "0";
                _productoStockMaximo = 0;
                return;
            }

            //txtProductoCodigo.BackColor = Color.LightGreen;
            txtProductoCodigo.SetErrorState(false);
            //txtProductoCodigo.ShowAssistiveText = false;
            _idProductoSeleccionado = oProducto.Id;
            txtProductoDescripcion.Text = oProducto.Descripcion;
            txtProductoPrecio.Text = oProducto.PrecioVenta.ToString();
            txtProductoCantidad.Text = "1";
            txtProductoStock.Text = oProducto.Stock.ToString();
            _productoStockMaximo = oProducto.Stock;
        }
        private void txtProductoCodigo_TrailingIconClick(object sender, EventArgs e)
        {
            LimpiarProducto();

            UtilidadesModal.BuscarProducto(
                txtCodigo: txtProductoCodigo,
                txtDescripcion: txtProductoDescripcion,
                idProductoSeleccionado: ref _idProductoSeleccionado,
                txtPrecio: txtProductoPrecio,
                txtStock: txtProductoStock
            );

            if (int.TryParse(txtProductoStock.Text, out int stock))
            {
                _productoStockMaximo = stock;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal productoPrecio;

            if (_idProductoSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un producto.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- Validación de stock ---
            CE_Producto oProducto = new CN_Producto().Listar()
                .Find(p => p.Id == _idProductoSeleccionado && p.oEstado.Id == true);

            if (!EsCantidadValida(txtProductoCantidad.Text, out int productoCantidad))
            {
                MessageBox.Show($"La cantidad ingresada ({txtProductoCantidad.Text}) supera el stock disponible ({oProducto.Stock}).",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!UtilidadesTextBox.EsPrecioValido(txtProductoPrecio.Text))
            {
                MessageBox.Show("El formato del precio no es válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductoPrecio.Select();
                return;
            }
            productoPrecio = decimal.Parse(txtProductoPrecio.Text, _culturaArgentina);

            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value) == _idProductoSeleccionado)
                {
                    MessageBox.Show("El producto que se intenta agregar ya fue agregado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            decimal subtotal = productoCantidad * productoPrecio;

            dgvProductos.Rows.Add(new object[]
            {
                _idProductoSeleccionado,
                txtProductoDescripcion.Text,
                productoPrecio.ToString(_formatoPrecio, _culturaArgentina),
                productoCantidad,
                subtotal.ToString(_formatoPrecio, _culturaArgentina),
                "" // btnEliminar
            });

            CalcularTotal();
            LimpiarProducto(); 
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
                    Id = _idClienteSeleccionado
                },
                //FechaVenta = dtpFechaVenta.Value,
                Total = Convert.ToDecimal(txtTotal.Text, _culturaArgentina),
            };

            int respuesta = new CN_Venta().Crear(oVenta, ventaDetalle, out string mensaje);

            if (respuesta == 0)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Venta registrada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtClienteNombreCompleto.Clear();
            dgvProductos.Rows.Clear();
            CalcularTotal();
        }
        private void txtClienteDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesTextBox.PermitirSoloDigitos(sender, e);
        }
        private void txtClienteDocumento_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarCliente(
                txtClienteDocumento,
                txtClienteNombreCompleto,
                ref _idClienteSeleccionado
            );
        }
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesTextBox.PermitirSoloPrecio(sender, e);
        }

        private void LimpiarProducto()
        {
            _idProductoSeleccionado = 0;
            UtilidadesForm.ReiniciarControles(gbProducto);
            txtProductoCantidad.Text = "1";
            _productoCantidad = 1;
            txtProductoCodigo.SetErrorState(false);
            txtProductoCodigo.Select();
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
                if (decimal.TryParse(textoCelda, NumberStyles.Any, _culturaArgentina, out decimal subtotal))
                {
                    total += subtotal;
                }
            }

            txtTotal.Text = total.ToString(_formatoPrecio, _culturaArgentina);
        }
        private bool EsCantidadValida(string texto, out int cantidad)
        {
            cantidad = 0;

            if (!int.TryParse(texto, out cantidad))
                return false;

            if (cantidad < 1 || cantidad > _productoStockMaximo)
                return false;

            return true;
        }

        private void txtVentaFecha_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesTextBox.DesplegarCalendario(dtpVentaFecha);
        }
        private void dtpVentaFecha_ValueChanged(object sender, EventArgs e)
        {
            txtVentaFecha.Text = dtpVentaFecha.Value.ToString("dd/MM/yyyy", _culturaArgentina);
        }
        private void txtProductoCantidad_LeadingIconClick(object sender, EventArgs e)
        {
            if (_productoCantidad <= 1)
                return;

            _productoCantidad--;
            txtProductoCantidad.Text = _productoCantidad.ToString();
        }
        private void txtProductoCantidad_TrailingIconClick(object sender, EventArgs e)
        {
            if (_productoCantidad >= _productoStockMaximo)
                return;

            _productoCantidad++;
            txtProductoCantidad.Text = _productoCantidad.ToString();
        }
    }
}
