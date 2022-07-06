namespace CapaEntidad
{
    public class CE_DetallePerdida
    {
        public int IdDetallePerdida { get; set; }
        public CE_Perdida oPerdida { get; set; }
        public CE_Producto oProducto { get; set; }
        public decimal CostoUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
    }
}
