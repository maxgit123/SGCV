using System;
using System.Collections.Generic;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

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
                    string query = "SELECT * FROM PROVINCIA";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Provincia()
                            {
                                IdProvincia = Convert.ToInt32(reader["ID_Provincia"]),
                                NomProvincia = reader["NomProvincia"].ToString(),
                            });
                        }
                    }
                }
                catch (SqlException ex)
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
