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
    public partial class frmCompra : Form
    {
        private readonly CE_Usuario _usuario;
        private int idProveedorSeleccionado = 0;
        private int idProductoSeleccionado = 0;
        private const string FormatoPrecio = "0.00";
        private static readonly CultureInfo culturaArgentina = new CultureInfo("es-AR");
        private static class NombreColumna
        {
            public const string ID_PRODUCTO = "id_producto";
            //public const string DESCRIPCION = "descripcion";
            public const string PRECIO_COMPRA = "precioCompra";
            public const string CANTIDAD = "cantidad";
            public const string SUBTOTAL = "subTotal";
            public const string BTN_ELIMINAR = "btnEliminar";
        }

        public frmCompra(CE_Usuario oUsuario = null)
        {
            InitializeComponent();
            _usuario = oUsuario;
            BackColor = Color.FromArgb(63, 81, 181); // Indigo 500
            UtilidadesDGV.Configurar(dgvProductos);
            dtpFechaPedido.Value = DateTime.Now;
            dtpFechaEntrega.Value = DateTime.Now;
            txtProveedor.ReadOnly = true;
            txtProductoDescripcion.ReadOnly = true;
            txtTotal.ReadOnly = true;
        }

        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e, nombreColEliminar: NombreColumna.BTN_ELIMINAR);
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0)
                return;

            string nombreColumna = dgvProductos.Columns[e.ColumnIndex].Name;

            if (nombreColumna != NombreColumna.BTN_ELIMINAR)
                return;

            dgvProductos.Rows.RemoveAt(Convert.ToInt32(e.RowIndex));
            CalcularTotal();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            bool productoYaExiste = false;

            // Se comprueba que se haya seleccionado un producto
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se valida el campo de precio de compra y se guarda como decimal
            if (!UtilidadesTextBox.EsPrecioValido(txtProductoPrecio.Text))
            {
                MessageBox.Show("El formato del precio no es válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProductoPrecio.Select();
                return;
            }
            precioCompra = decimal.Parse(txtProductoPrecio.Text);

            // Se comprueba que no se agregue un producto ya agregado
            foreach (DataGridViewRow fila in dgvProductos.Rows)
            {
                if (Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value) == idProductoSeleccionado)
                {
                    productoYaExiste = true;
                    MessageBox.Show("El producto que se intenta agregar ya fue agregado.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            if (!productoYaExiste)
            {
                //decimal subtotal = txtProductoCantidad.Value * precioCompra;
                Int32.TryParse(txtProductoCantidad.Text, out int cantidad);
                decimal subtotal = cantidad * precioCompra;

                dgvProductos.Rows.Add(new object[]
                {
                    idProductoSeleccionado,
                    txtProductoDescripcion.Text,
                    precioCompra.ToString(FormatoPrecio, culturaArgentina),
                    txtProductoCantidad.Text,
                    (subtotal).ToString(FormatoPrecio, culturaArgentina),
                    "" // btnEliminar
                });

                CalcularTotal();
                LimpiarProducto();
                txtProductoCantidad.Text = "1";
                txtProductoCodigo.Select();
            }
        }
        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvProductos.Rows.Count < 1)
            {
                MessageBox.Show("Debe agregar al menos un producto", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                compraDetalle.Rows.Add(new object[]
                {
                    Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value),
                    Convert.ToDecimal(fila.Cells[NombreColumna.PRECIO_COMPRA].Value),
                    Convert.ToInt32(fila.Cells[NombreColumna.CANTIDAD].Value),
                    Convert.ToDecimal(fila.Cells[NombreColumna.SUBTOTAL].Value)
                });
            }

            CE_Compra oCompra = new CE_Compra()
            {
                oUsuario = new CE_Usuario()
                {
                    Id = _usuario.Id
                },
                oProveedor = new CE_Proveedor()
                {
                    Id = idProveedorSeleccionado
                },
                FechaPedido = dtpFechaPedido.Value,
                FechaEntrega = dtpFechaEntrega.Value,
                Total = Convert.ToDecimal(txtTotal.Text, culturaArgentina)
            };

            bool respuesta = new CN_Compra().Crear(oCompra, compraDetalle, out string mensaje);

            if (!respuesta)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Compra registrada correctamente.", "Éxito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtProveedor.Clear();
            dgvProductos.Rows.Clear();
            CalcularTotal();
        }
        private void txtProductoCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            // Se usa keyDown para detectar la tecla Enter (los lectores de código de barras envían Enter al finalizar la lectura)
            if (e.KeyCode != Keys.Enter)
                return;

            CE_Producto oProducto = new CN_Producto().Listar()
                .Find(p => p.Codigo == txtProductoCodigo.Text.Trim() && p.oEstado.Id == true);

            if (oProducto == null)
            {
                txtProductoCodigo.BackColor = Color.LightCoral;
                idProductoSeleccionado = 0;
                txtProductoDescripcion.Clear();
                return;
            }

            txtProductoCodigo.BackColor = Color.LightGreen;
            idProductoSeleccionado = oProducto.Id;
            txtProductoDescripcion.Text = oProducto.Descripcion;
            txtProductoPrecio.Select();
        }
        private void txtProductoCodigo_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarProducto(
                txtCodigo: txtProductoCodigo,
                txtDescripcion: txtProductoDescripcion,
                idProductoSeleccionado: ref idProductoSeleccionado
            );
        }
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesTextBox.PermitirSoloPrecio(sender, e);
        }
        private void txtProveedor_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarProveedor(
                txtProveedor,
                ref idProveedorSeleccionado
            );
        }
        private void txtProductoCantidad_LeadingIconClick(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductoCantidad.Text, out int cantidad))
                return;

            if (cantidad > 1)
                txtProductoCantidad.Text = (cantidad - 1).ToString();
        }
        private void txtProductoCantidad_TrailingIconClick(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductoCantidad.Text, out int cantidad))
                return;

            txtProductoCantidad.Text = (cantidad + 1).ToString();
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

                // En el flujo normal no debería ser null (btnAgregar_Click valida esto)
                if (valorCelda == null)
                    continue;

                string textoCelda = valorCelda.ToString();
                if (decimal.TryParse(textoCelda, NumberStyles.Any, culturaArgentina, out decimal subTotal))
                {
                    total += subTotal;
                }
            }

            txtTotal.Text = total.ToString(FormatoPrecio, culturaArgentina);
        }
        private bool ValidarFechas()
        {
            if (dtpFechaEntrega.Value < dtpFechaPedido.Value)
            {
                MessageBox.Show("La fecha de entrega no puede ser anterior a la fecha de pedido", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void txtFechaPedido_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesTextBox.DesplegarCalendario(dtpFechaPedido);
        }
        private void dtpFechaPedido_ValueChanged(object sender, EventArgs e)
        {
            txtFechaPedido.Text = dtpFechaPedido.Value.ToString("dd/MM/yyyy", culturaArgentina);
        }
        private void txtFechaEntrega_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesTextBox.DesplegarCalendario(dtpFechaEntrega);
        }
        private void dtpFechaEntrega_ValueChanged(object sender, EventArgs e)
        {
            txtFechaEntrega.Text = dtpFechaEntrega.Value.ToString("dd/MM/yyyy", culturaArgentina);
        }

    }
}
