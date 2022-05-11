using System;
using System.Collections.Generic;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_Provincia
    {
        public List<CE_Provincia> Listar()
        {
            List<CE_Provincia> lista = new List<CE_Provincia>();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaSQL))
            {
                try
                {
                    string query = "SELECT * FROM PROVINCIA";
                    SQLiteCommand cmd = new SQLiteCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
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
                catch (SQLiteException ex)
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
