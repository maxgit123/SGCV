using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadenaSQL = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}