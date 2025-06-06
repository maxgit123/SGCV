namespace CapaEntidad
{
    public class CE_ResponsableIVA
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public CE_Estado oEstado { get; set; }
    }
}
