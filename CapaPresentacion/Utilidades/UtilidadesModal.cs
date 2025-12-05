using System;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Modal;
using MaterialSkin.Controls;

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
        /// <param name="requerirStock">Si es true, solo lista productos con stock.</param>
        /// <returns>true si se seleccionó un producto, false si se canceló la selección.</returns>
        public static bool BuscarProducto(
            TextBox txtCodigo, TextBox txtDescripcion,
            ref int idProductoSeleccionado,
            TextBox txtPrecio = null, TextBox txtStock = null, bool requerirStock = true
        )
        {
            using (var modal = new mdProducto(requerirStock))
            {
                var result = modal.ShowDialog();

                if (result != DialogResult.OK)
                    return false;

                idProductoSeleccionado = modal._producto.Id;
                txtCodigo.Text = modal._producto.Codigo;
                txtCodigo.BackColor = Color.LightGreen;
                txtDescripcion.Text = modal._producto.Descripcion;

                if (txtPrecio != null)
                {
                    txtPrecio.Text = modal._producto.PrecioVenta.ToString(_FORMATO_PRECIO);
                }

                if (txtStock != null)
                {
                    txtStock.Text = modal._producto.Stock.ToString();
                }

                return true;
            }
        }
        public static bool BuscarProducto(
            MaterialTextBox2 txtCodigo, MaterialTextBox2 txtDescripcion,
            ref int idProductoSeleccionado,
            MaterialTextBox2 txtPrecio = null, MaterialTextBox2 txtStock = null, bool requerirStock = true
        )
        {
            using (var modal = new mdProducto(requerirStock))
            {
                var result = modal.ShowDialog();

                if (result != DialogResult.OK)
                    return false;

                idProductoSeleccionado = modal._producto.Id;
                txtCodigo.Text = modal._producto.Codigo;
                txtDescripcion.Text = modal._producto.Descripcion;

                if (txtPrecio != null)
                {
                    txtPrecio.Text = modal._producto.PrecioVenta.ToString(_FORMATO_PRECIO);
                }

                if (txtStock != null)
                {
                    txtStock.Text = modal._producto.Stock.ToString();
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
        public static bool BuscarProveedor(MaterialTextBox2 txtRazonSocial, ref int idProveedorSeleccionado)
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
        /// <param name="txtDocumento"
        /// <param name="txtNombreCompleto">TextBox para mostrar el nombre completo del cliente.</param>
        /// <param name="idClienteSeleccionado">Variable de referencia para almacenar el ID del cliente.</param>
        /// <returns>true si se seleccionó un cliente, false si se canceló la selección.</returns>
        public static bool BuscarCliente(TextBox txtDocumento, TextBox txtNombreCompleto, ref int idClienteSeleccionado)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    idClienteSeleccionado = modal._cliente.Id;
                    txtDocumento.Text = modal._cliente.Documento;
                    txtNombreCompleto.Text = $"{modal._cliente.Apellido}, {modal._cliente.Nombre}";
                    return true;
                }
                return false;
            }
        }
        public static bool BuscarCliente(MaterialTextBox2 txtDocumento, MaterialTextBox2 txtNombreCompleto, ref int idClienteSeleccionado)
        {
            using (var modal = new mdCliente())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    idClienteSeleccionado = modal._cliente.Id;
                    txtDocumento.Text = modal._cliente.Documento;
                    txtNombreCompleto.Text = $"{modal._cliente.Apellido}, {modal._cliente.Nombre}";
                    return true;
                }
                return false;
            }
        }
        
        public static bool BuscarCompra(Form formularioPadre, Action<CE_Compra> callbackActualizacion)
        {
            using (var modal = new mdCompra())
            {
                modal.StartPosition = FormStartPosition.CenterParent;
                if (modal.ShowDialog(formularioPadre) == DialogResult.OK)
                {
                    var compra = new CN_Compra().ObtenerCompra(modal._IdCompraSeleccionada);

                    if (compra.Id != 0)
                    {
                        callbackActualizacion(compra);
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
