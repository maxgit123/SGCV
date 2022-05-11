using System;
using System.Collections.Generic;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_AlicuotaIVA
    {
        public List<CE_AlicuotaIVA> Listar()
        {
            List<CE_AlicuotaIVA> lista = new List<CE_AlicuotaIVA>();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaSQL))
            {
                try
                {
                    string query = "SELECT * FROM ALICUOTA_IVA";
                    SQLiteCommand cmd = new SQLiteCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
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
                catch (SQLiteException ex)
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
