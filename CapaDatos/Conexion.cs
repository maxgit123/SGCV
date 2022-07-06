using System.Configuration;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadenaDB = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
    }
}