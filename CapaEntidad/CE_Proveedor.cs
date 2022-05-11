namespace CapaEntidad
{
    public class CE_Proveedor
    {
        public int IdProveedor { get; set; }
        public string RazonSocial { get; set; }
        public CE_Contacto oContacto { get; set; }
    }
}
