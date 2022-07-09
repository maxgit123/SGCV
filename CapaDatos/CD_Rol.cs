using System;
using System.Collections.Generic;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Rol
    {
        public List<CE_Rol> Listar()
        {
            List<CE_Rol> lista = new List<CE_Rol>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    string query = "SELECT id, nombre FROM cRol";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Rol()
                            {
                                IdRol = Convert.ToInt32(reader["id"]),
                                NomRol = reader["nombre"].ToString(),
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    lista = new List<CE_Rol>();
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
