using System.Collections.Generic;

namespace CapaEntidad
{
    public class CE_Compra
    {
        public int IdCompra { get; set; }
        public decimal Total { get; set; }
        public string FechaPedido { get; set; }
        public string FechaEntrega { get; set; }
        public string FechaCreacion { get; set; }
        public List<CE_DetalleCompra> oDetalleCompra { get; set; }
        public CE_Usuario oUsuario { get; set; }
        public CE_Estado oEstado { get; set; }
        public CE_Proveedor oProveedor { get; set; }
    }
}