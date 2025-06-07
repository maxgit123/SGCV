namespace CapaEntidad
{
    public class CE_Producto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int QuiebreStock { get; set; }
        public string FechaCreacion { get; set; }
        public CE_Categoria oCategoria { get; set; }
        public CE_Estado oEstado { get; set; }
    }
}
