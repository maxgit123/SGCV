namespace CapaEntidad
{
    public class CE_Categoria
    {
        public int IdCategoria { get; set; }
        public string NomCategoria { get; set; }
        public CE_Estado oEstado { get; set; }
        public CE_AlicuotaIVA oAlicuotaIVA { get; set; }
    }
}
