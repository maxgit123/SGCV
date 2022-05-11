namespace CapaEntidad
{
    public class CE_Producto
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int QuiebreStock { get; set; }
        public CE_Categoria oCategoria { get; set; }
        //En vez de hacer referencia a ID_Categoria se hace a la clase.
    }
}
