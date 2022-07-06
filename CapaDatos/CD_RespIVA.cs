using System;
using System.Collections.Generic;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_RespIVA
    {
        public List<CE_RespIVA> Listar()
        {
            List<CE_RespIVA> lista = new List<CE_RespIVA>();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    string query = "SELECT * FROM RESP_IVA";
                    SQLiteCommand cmd = new SQLiteCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_RespIVA()
                            {
                                IdRespIVA = Convert.ToInt32(reader["ID_RespIVA"]),
                                ResponsableIVA = reader["ResponsableIVA"].ToString(),
                            });
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    lista = new List<CE_RespIVA>();
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