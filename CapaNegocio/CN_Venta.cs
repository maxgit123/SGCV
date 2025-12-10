using System.Collections.Generic;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private readonly CD_Venta oCD_Venta = new CD_Venta();

        public List<CE_Venta> Listar(out string mensaje)
        {
            return oCD_Venta.Listar(out mensaje);
        }
        public CE_Venta ObtenerVenta(int idVenta) // Obtiene la venta junto al detalle
        {
            var oVenta = oCD_Venta.ObtenerVentaPorId(idVenta);

            if (oVenta.Id != 0)
            {
                List<CE_VentaDetalle> oVentaDetalle = oCD_Venta.ObtenerVentaDetallePorId(idVenta);
                oVenta.oVentaDetalle = oVentaDetalle;
            }

            return oVenta;
        }
        public int Crear(CE_Venta oVenta, DataTable ventaDetalle, out string mensaje)
        {
            return oCD_Venta.Crear(oVenta, ventaDetalle, out mensaje);
        }
    }
}
