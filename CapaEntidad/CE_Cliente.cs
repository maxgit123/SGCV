namespace CapaEntidad
{
    public class CE_Cliente
    {
        public int IdCliente { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaCreacion { get; set; }
        public CE_Estado oEstado { get; set; }
        public CE_Contacto oContacto { get; set; }
        public CE_ResponsableIVA oRespIVA { get; set; }
    }
}
