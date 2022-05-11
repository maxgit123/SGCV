using System;
using System.Collections.Generic;
using System.Text;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public List<CE_Cliente> Listar()
        {
            List<CE_Cliente> lista = new List<CE_Cliente>();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaSQL))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.ID_Cliente,c.Documento,c.Nombre,c.Apellido,r.ID_RespIVA,r.ResponsableIVA FROM CLIENTE c");
                    query.AppendLine("INNER JOIN RESP_IVA r on r.ID_RespIVA = c.ID_RespIVA");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Cliente()
                            {
                                IdCliente = Convert.ToInt32(reader["ID_Cliente"]),
                                Documento = reader["Documento"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                oRespIVA = new CE_RespIVA()
                                {
                                    IdRespIVA = Convert.ToInt32(reader["ID_RespIVA"]),
                                    ResponsableIVA = reader["ResponsableIVA"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    lista = new List<CE_Cliente>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
        public int Crear(CE_Cliente oCliente, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaSQL))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO CLIENTE (Documento,Nombre,Apellido,ID_RespIVA)" +
                        "VALUES (@Documento,@Nombre,@Apellido,@ID_RespIVA);");
                    query.AppendLine("SELECT last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@Documento", oCliente.Documento));
                    cmd.Parameters.Add(new SQLiteParameter("@Nombre", oCliente.Nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@Apellido", oCliente.Apellido));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_RespIVA", oCliente.oRespIVA.IdRespIVA));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID del Cliente.
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
        public bool Actualizar(CE_Cliente oCliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaSQL))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Cliente SET "
                                     + "Documento = @Documento, "
                                     + "Nombre = @Nombre, "
                                     + "Apellido = @Apellido, "
                                     + "ID_RespIVA = @ID_RespIVA "
                                     + "WHERE ID_Cliente = @ID_Cliente");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@Documento", oCliente.Documento));
                    cmd.Parameters.Add(new SQLiteParameter("@Nombre", oCliente.Nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@Apellido", oCliente.Apellido));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_RespIVA", oCliente.oRespIVA.IdRespIVA));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Cliente", oCliente.IdCliente));

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
        public bool Eliminar(CE_Cliente oCliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaSQL))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM CLIENTE WHERE ID_Cliente = @ID_Cliente;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Cliente", oCliente.IdCliente));
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
