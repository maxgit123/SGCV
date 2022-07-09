using System;
using System.Collections.Generic;
using System.Text;
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Modulo
    {
        public List<CE_Modulo> Listar(int idUsuario)
        {
            List<CE_Modulo> lista = new List<CE_Modulo>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT m.nombre, m.rol_id, r.id FROM cModulo m");
                    query.AppendLine("INNER JOIN cRol r ON r.id = m.rol_id");
                    query.AppendLine("INNER JOIN Usuario u ON u.rol_id = r.id");
                    query.AppendLine("WHERE u.id = @IdUsuario;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Modulo()
                            {
                                Nombre = reader["nombre"].ToString(),
                                oRol = new CE_Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["id"])
                                }
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    lista = new List<CE_Modulo>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
    }
}
