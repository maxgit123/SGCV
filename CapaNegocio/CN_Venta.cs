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
    public class CN_Venta
    {
        private readonly CD_Venta oCD_Venta = new CD_Venta();

        public int Crear(CE_Venta oVenta, DataTable ventaDetalle, out string mensaje)
        {
            //if (oVenta.oCliente.Id < 1)
            //{
            //    mensaje = "Debe seleccionar un cliente para la venta.";
            //    return false;
            //}
            //if (ventaDetalle == null || ventaDetalle.Rows.Count == 0)
            //{
            //    mensaje = "Debe agregar al menos un producto a la venta.";
            //    return false;
            //}

            return oCD_Venta.Crear(oVenta, ventaDetalle, out mensaje);
        }
    }
}
