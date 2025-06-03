using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Modulo
    {
        public List<CE_Modulo> Listar(int idUsuario)
        {
            var lista = new List<CE_Modulo>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT m.nombre 
                    FROM cModulo m
                    INNER JOIN Usuario u ON u.rol_id = m.rol_id
                    WHERE u.id_usuario = @id_usuario;", oConexion))
            {
                cmd.Parameters.AddWithValue("@id_usuario", idUsuario);

                try
                {
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Modulo()
                            {
                                Nombre = reader["nombre"].ToString(),
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    //mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    lista = new List<CE_Modulo>();
                }
            }
            return lista;
        }
    }
}
