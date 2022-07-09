using System;
using System.Collections.Generic;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

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
                    string query = "SELECT * FROM ALICUOTA_IVA";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_AlicuotaIVA()
                            {
                                IdAlicuotaIVA = Convert.ToInt32(reader["ID_AlicuotaIVA"]),
                                PorcentajeIVA = Convert.ToDecimal(reader["PorcentajeIVA"]),
                            });
                        }
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
