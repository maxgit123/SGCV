using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private readonly CD_Compra oCD_Compra = new CD_Compra();

        public bool Crear(CE_Compra oCompra, DataTable compraDetalle, out string mensaje)
        {
            //var errores = new StringBuilder();
            //if (oCompra.oProveedor.Id < 1)
            //    errores.AppendLine("Seleccione un proveedor para la compra.");
            //if (lst == null || lst.Count == 0)
            //    errores.AppendLine("Debe agregar al menos un producto a la compra.");
            //if (errores.Length > 0)
            //{
            //    mensaje = $"Se encontraron los siguientes errores:\n\n {errores}";
            //    return 0;
            //}

            return oCD_Compra.Crear(oCompra, compraDetalle, out mensaje);
        }
    }
}
