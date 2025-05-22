using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class CD_AlicuotaIVA
    {
        public List<CE_AlicuotaIVA> Listar()
        {
            List<CE_AlicuotaIVA> lista = new List<CE_AlicuotaIVA>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    string query = "SELECT * FROM cAlicuotaIVA";

                    SqlCommand cmd = new SqlCommand(query, oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_AlicuotaIVA()
                            {
                                Id = Convert.ToInt32(reader["id_alicuotaIVA"]),
                                Porcentaje = Convert.ToDecimal(reader["porcentaje"]),
                            });
                        }
                        reader.Close();
                    }
                }
                catch (SqlException ex)
                {
                    lista = new List<CE_AlicuotaIVA>();
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
