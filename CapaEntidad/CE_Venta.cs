using System;
using System.Collections.Generic;

namespace CapaEntidad
{
    public class CE_Venta
    {
        public int IdVenta { get; set; }
        public string TipoFactura { get; set; }
        public decimal Total { get; set; }
        public decimal Pago { get; set; }
        public decimal Vuelto { get; set; }
        public DateTime FechaVenta { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<CE_VentaDetalle> oVentaDetalle { get; set; }
        public CE_Estado oEstado { get; set; }
        public CE_Usuario oUsuario { get; set; }
        public CE_Comercio oComercio { get; set; }
        public CE_Cliente oCliente { get; set; }
    }
}