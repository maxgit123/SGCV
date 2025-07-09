namespace CapaEntidad
{
    public class CE_VentaDetalle
    {
        public int IdDetalleVenta { get; set; }
        public CE_Venta oVenta { get; set; }
        public CE_Producto oProducto { get; set; }
        public decimal PrecioCompraUnitario { get; set; }
        public decimal PrecioVentaUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
