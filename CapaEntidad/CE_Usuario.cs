namespace CapaEntidad
{
    public class CE_Usuario
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreCompleto
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Apellido) && string.IsNullOrWhiteSpace(Nombre))
                    return string.Empty;

                if (string.IsNullOrWhiteSpace(Apellido))
                    return Nombre;

                if (string.IsNullOrWhiteSpace(Nombre))
                    return Apellido;

                return $"{Apellido}, {Nombre}";
            }
        }
        public string Clave { get; set; }
        public string FechaCreacion { get; set; }
        public CE_Estado oEstado { get; set; }
        public CE_Rol oRol { get; set; }
    }
}