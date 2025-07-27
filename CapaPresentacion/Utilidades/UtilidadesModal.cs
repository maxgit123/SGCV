using System.Drawing;
using System.Windows.Forms;
using CapaPresentacion.Formularios.Modal;

namespace CapaPresentacion.Utilidades
{
    public static class UtilidadesModal
    {
        private const string _FORMATO_PRECIO = "0.00";

        /// <summary>
        /// Abre un form modal de búsqueda de producto y actualiza los controles relacionados
        /// con la información del producto seleccionado.
        /// </summary>
        /// <param name="txtCodigo">TextBox para mostrar el código del producto.</param>
        /// <param name="txtDescripcion">TextBox para mostrar la descripción del producto.</param>
        /// <param name="idProductoSeleccionado">Variable de referencia para almacenar el ID del producto.</param>
        /// <returns>true si se seleccionó un producto, false si se canceló la selección.</returns>
        public static bool BuscarProducto(
            TextBox txtCodigo, TextBox txtDescripcion,
            ref int idProductoSeleccionado,
            TextBox txtPrecioVenta = null, TextBox txtStockProducto = null
        )
        {
            using (var modal = new mdProducto())
            {
                var result = modal.ShowDialog();

                if (result != DialogResult.OK)
                    return false;

                idProductoSeleccionado = modal._producto.Id;
                txtCodigo.Text = modal._producto.Codigo;
                txtCodigo.BackColor = Color.LightGreen;
                txtDescripcion.Text = modal._producto.Descripcion;

                if (txtPrecioVenta != null)
                {
                    txtPrecioVenta.Text = modal._producto.PrecioVenta.ToString(_FORMATO_PRECIO);
                }

                if (txtStockProducto != null)
                {
                    txtStockProducto.Text = modal._producto.Stock.ToString();
                }

                return true;
            }
        }

        /// <summary>
        /// Abre un form modal de búsqueda de proveedor y actualiza los controles relacionados
        /// con la información del proveedor seleccionado.
        /// </summary>
        /// <param name="txtRazonSocial">TextBox para mostrar la razón social del proveedor.</param>
        /// <param name="idProveedorSeleccionado">Variable de referencia para almacenar el ID del proveedor.</param>
        /// <returns>true si se seleccionó un proveedor, false si se canceló la selección.</returns>
        public static bool BuscarProveedor(TextBox txtRazonSocial, ref int idProveedorSeleccionado)
        {
            using (var modal = new mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    idProveedorSeleccionado = modal._proveedor.Id;
                    txtRazonSocial.Text = modal._proveedor.RazonSocial;
                    return true;
                }

                return false;
            }
        }

        /// <summary>
        /// Abre un form modal de búsqueda de cliente y actualiza los controles relacionados
        /// con la información del cliente seleccionado.
        /// </summary>
        /// <param name="txtDniCliente"
        /// <param name="txtNombreCompletoCliente">TextBox para mostrar el nombre completo del cliente.</param>
        /// <param name="idClienteSeleccionado">Variable de referencia para almacenar el ID del cliente.</param>
        /// <returns>true si se seleccionó un cliente, false si se canceló la selección.</returns>
        public static bool BuscarCliente(TextBox txtDniCliente, TextBox txtNombreCompletoCliente, ref int idClienteSeleccionado)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    idClienteSeleccionado = modal._cliente.Id;
                    txtDniCliente.Text = modal._cliente.Documento;
                    txtNombreCompletoCliente.Text = $"{modal._cliente.Apellido}, {modal._cliente.Nombre}";
                    return true;
                }
                return false;
            }
        }
    }
}
