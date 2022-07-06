namespace CapaEntidad
{
    public class CE_Modulo
    {
        public int IdModulo { get; set; }
        public string Nombre { get; set; }
        public string FechaCreacion { get; set; }
        public CE_Rol oRol { get; set; }
    }
}
