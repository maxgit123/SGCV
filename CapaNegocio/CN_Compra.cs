using System.Collections.Generic;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Compra
    {
        private readonly CD_Compra oCD_Compra = new CD_Compra();

        public List<CE_Compra> Listar(out string mensaje)
        {
            return oCD_Compra.Listar(out mensaje);
        }
        public CE_Compra ObtenerCompra(int idCompra) // Obtiene la compra junto al detalle
        {
            var oCompra = oCD_Compra.ObtenerCompraPorId(idCompra);

            if (oCompra.Id != 0)
            {
                List<CE_CompraDetalle> oCompraDetalle = oCD_Compra.ObtenerCompraDetallePorId(idCompra);

                oCompra.oCompraDetalle = oCompraDetalle;
            }

            return oCompra;
        }
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
