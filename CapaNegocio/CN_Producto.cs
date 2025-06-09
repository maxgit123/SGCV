using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Producto
    {
        private readonly CD_Producto oCD_Producto = new CD_Producto();
        public List<CE_Producto> Listar()
        {
            return oCD_Producto.Listar();
        }
        public int Crear(CE_Producto oProducto, out string mensaje)
        {
            var errores = new StringBuilder();

            //if (string.IsNullOrWhiteSpace(oProducto.Codigo))
            //    errores.AppendLine("Ingrese el codigo del producto.");

            if (string.IsNullOrWhiteSpace(oProducto.Descripcion))
                errores.AppendLine("Ingrese la descripcion del producto.");

            if (oProducto.QuiebreStock < 0)
                errores.AppendLine("El quiebre de stock no puede ser negativo.");

            if (oProducto.oCategoria.Id < 1)
                errores.AppendLine("Seleccione una categoria.");

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
            //    errores.AppendLine("Ingrese el codigo del producto.");

            if (string.IsNullOrWhiteSpace(oProducto.Descripcion))
                errores.AppendLine("Ingrese la descripcion del producto.");

            if (oProducto.QuiebreStock < 0)
                errores.AppendLine("El quiebre de stock no puede ser negativo.");

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
