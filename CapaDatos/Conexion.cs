using System.Configuration;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadenaDB = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();
        public static bool TestConnection(out string errorMessage)
        {
            errorMessage = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(cadenaDB))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (SqlException ex)
            {
                errorMessage = $"Error de conexión: {ex.Message}\nCódigo de error: {ex.ErrorCode}";
                return false;
            }
            catch (ConfigurationErrorsException ex)
            {
                errorMessage = $"Error en la configuración: {ex.Message}";
                return false;
            }
        }
    }
}