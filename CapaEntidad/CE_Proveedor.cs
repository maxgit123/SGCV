namespace CapaEntidad
{
    public class CE_Proveedor
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Observacion { get; set; }
        public string FechaCreacion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public CE_Estado oEstado { get; set; }
    }
}
