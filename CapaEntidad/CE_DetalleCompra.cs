namespace CapaEntidad
{
    public class CE_DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public CE_Compra oCompra { get; set; }
        public CE_Producto oProducto { get; set; }
        public decimal CostoUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public string FechaCreacion { get; set; }
    }
}
