namespace CapaEntidad
{
    public class CE_Proveedor
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public string Observacion { get; set; }
        public string FechaCreacion { get; set; }
        public CE_Contacto oContacto { get; set; }
        public CE_Estado oE_Estado { get; set; }
    }
}
