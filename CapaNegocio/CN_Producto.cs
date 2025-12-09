using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private readonly CD_Producto oCD_Producto = new CD_Producto();

        public List<CE_Producto> Listar(bool? soloActivos = null, bool? soloConStock = null)
        {
            return oCD_Producto.Listar(soloActivos, soloConStock);
        }
        public int Crear(CE_Producto oProducto, out string mensaje)
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(oProducto.Codigo))
                errores.AppendLine("Ingrese un código para el producto.");

            if (string.IsNullOrWhiteSpace(oProducto.Descripcion))
                errores.AppendLine("Ingrese la descripción del producto.");

            if (oProducto.PrecioVenta < 0)
                errores.AppendLine("Ingrese un precio de venta válido.");

            if (oProducto.QuiebreStock < 0)
                errores.AppendLine("Ingrese un quiebre de stock dentro del rango valido.");

            if (oProducto.oCategoria.Id < 1)
                errores.AppendLine("Seleccione una categoría para el producto.");

            if (errores.Length > 0)
            {
                mensaje = $"Se encontraron los siguientes errores:\n\n {errores}";
                return 0;
            }
            
            return oCD_Producto.Crear(oProducto, out mensaje);
        }
        public bool Actualizar(CE_Producto oProducto, out string mensaje)
        {
            var errores = new StringBuilder();

            //if (string.IsNullOrWhiteSpace(oProducto.Codigo))
            //    errores.AppendLine("Ingrese un código para el producto.");

            if (string.IsNullOrWhiteSpace(oProducto.Descripcion))
                errores.AppendLine("Ingrese la descripción del producto.");

            if (oProducto.PrecioVenta < 0)
                errores.AppendLine("Ingrese un precio de venta válido.");

            if (oProducto.QuiebreStock < 0)
                errores.AppendLine("Ingrese un quiebre de stock dentro del rango valido.");

            if (oProducto.oCategoria.Id < 1)
                errores.AppendLine("Seleccione una categoría para el producto.");

            if (errores.Length > 0)
            {
                mensaje = $"Se encontraron los siguientes errores:\n\n {errores}";
                return false;
            }

            return oCD_Producto.Actualizar(oProducto, out mensaje);
        }
        public bool Eliminar(CE_Producto oProducto, out string mensaje)
        {
            return oCD_Producto.Eliminar(oProducto, out mensaje);
        }
    }
}
