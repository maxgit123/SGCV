namespace CapaEntidad
{
    public class CE_Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public CE_Estado oEstado { get; set; }
        public CE_AlicuotaIVA oAlicuotaIVA { get; set; }
    }
}
