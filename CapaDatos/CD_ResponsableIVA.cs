using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_ResponsableIVA
    {
        public List<CE_ResponsableIVA> Listar()
        {
            List<CE_ResponsableIVA> lista = new List<CE_ResponsableIVA>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    string query = "SELECT * FROM cResponsableIVA;";
                    SqlCommand cmd = new SqlCommand(query, oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_ResponsableIVA()
                            {
                                Id = Convert.ToInt32(reader["ID_RespIVA"]),
                                Nombre = reader["ResponsableIVA"].ToString(),
                            });
                        }
                        reader.Close();
                    }
                }
                catch (SqlException ex)
                {
                    lista = new List<CE_ResponsableIVA>();
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