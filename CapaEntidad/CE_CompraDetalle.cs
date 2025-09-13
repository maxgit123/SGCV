namespace CapaEntidad
{
    public class CE_CompraDetalle
    {
        public int Id { get; set; }
        public CE_Compra oCompra { get; set; }
        public CE_Producto oProducto { get; set; }
        public decimal PrecioCompraUnitario { get; set; }
        public decimal PrecioVentaUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
