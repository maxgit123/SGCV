using CapaDatos;

namespace CapaNegocio
{
    public class CN_Conexion
    {
        public static bool VerificarConexion(out string mensaje)
        {
            return Conexion.TestConnection(out mensaje);
        }
    }
}