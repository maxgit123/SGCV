using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Provincia
    {
        public List<CE_Provincia> Listar()
        {
            List<CE_Provincia> lista = new List<CE_Provincia>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    string query = "SELECT * FROM cProvincia;";
                    SqlCommand cmd = new SqlCommand(query, oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Provincia()
                            {
                                Id = Convert.ToInt32(reader["id_provincia"]),
                                Nombre = reader["nombre"].ToString(),
                            });
                        }
                        reader.Close();
                    }
                }
                catch (SqlException)
                {
                    lista = new List<CE_Provincia>();
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
