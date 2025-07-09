using System;
using System.Collections.Generic;

namespace CapaEntidad
{
    public class CE_Compra
    {
        public int IdCompra { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<CE_CompraDetalle> oDetalleCompra { get; set; }
        public CE_Usuario oUsuario { get; set; }
        public CE_Estado oEstado { get; set; }
        public CE_Proveedor oProveedor { get; set; }
    }
}