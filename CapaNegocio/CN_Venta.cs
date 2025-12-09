using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private readonly CD_Venta oCD_Venta = new CD_Venta();

        public int Crear(CE_Venta oVenta, DataTable ventaDetalle, out string mensaje)
        {
            return oCD_Venta.Crear(oVenta, ventaDetalle, out mensaje);
        }
    }
}
