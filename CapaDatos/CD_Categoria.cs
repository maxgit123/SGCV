using System;
using System.Collections.Generic;
using System.Text;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<CE_Categoria> Listar()
        {
            List<CE_Categoria> lista = new List<CE_Categoria>();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.ID_Categoria,u.NomCategoria,r.ID_AlicuotaIVA,r.PorcentajeIVA FROM CATEGORIA u");
                    query.AppendLine("INNER JOIN ALICUOTA_IVA r on r.ID_AlicuotaIVA = u.ID_AlicuotaIVA");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Categoria()
                            {
                                IdCategoria = Convert.ToInt32(reader["ID_Categoria"]),
                                NomCategoria = reader["NomCategoria"].ToString(),
                                oAlicuotaIVA = new CE_AlicuotaIVA()
                                {
                                    IdAlicuotaIVA = Convert.ToInt32(reader["ID_AlicuotaIVA"]),
                                    PorcentajeIVA = Convert.ToDecimal(reader["PorcentajeIVA"])
                                }
                            });
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    lista = new List<CE_Categoria>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
        public int Crear(CE_Categoria oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO CATEGORIA (NomCategoria,ID_AlicuotaIVA)" +
                        "VALUES (@NomCategoria,@ID_AlicuotaIVA);");
                    query.AppendLine("SELECT last_insert_rowid();");
                    //last_insert_rowid retorna el ultimo row id que se inserto.
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@NomCategoria", oCategoria.NomCategoria));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_AlicuotaIVA", oCategoria.oAlicuotaIVA.IdAlicuotaIVA));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID.
                    cmd.Parameters.Clear();
                }
                catch (SQLiteException ex)
                {
                    respuesta = 0;
                    mensaje = "Codigo de error: " + ex.ErrorCode + "\n" + ex.Message;
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return respuesta;
        }
        public bool Actualizar(CE_Categoria oCategoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE CATEGORIA SET "
                                     + "NomCategoria = @NomCategoria, "
                                     + "ID_AlicuotaIVA = @ID_AlicuotaIVA "
                                     + "WHERE ID_Categoria = @ID_Categoria");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@NomCategoria", oCategoria.NomCategoria));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_AlicuotaIVA", oCategoria.oAlicuotaIVA.IdAlicuotaIVA));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Categoria", oCategoria.IdCategoria));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    cmd.Parameters.Clear();
                }
                catch (SQLiteException ex)
                {
                    respuesta = false;
                    mensaje = "Codigo de error: " + ex.ErrorCode + "\n" + ex.Message;
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return respuesta;
        }
        public bool Eliminar(CE_Categoria oCategoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM CATEGORIA WHERE ID_Categoria = @ID_Categoria;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Categoria", oCategoria.IdCategoria));
                    cmd.CommandType = CommandType.Text;
                    respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    cmd.Parameters.Clear();
                }
                catch (SQLiteException ex)
                {
                    respuesta = false;
                    mensaje = "Codigo de error: " + ex.ErrorCode + "\n" + ex.Message;
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return respuesta;
        }
    }
}
