namespace CapaEntidad
{
    public class CE_Cliente
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string FechaCreacion { get; set; }
        public CE_ResponsableIVA oRespIVA { get; set; }
        public CE_Estado oEstado { get; set; }
    }
}
