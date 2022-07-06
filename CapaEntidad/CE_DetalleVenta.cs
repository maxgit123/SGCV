namespace CapaEntidad
{
    public class CE_DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public CE_Venta oVenta { get; set; }
        public CE_Producto oProducto { get; set; }
        public decimal CostoUnitario { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}
