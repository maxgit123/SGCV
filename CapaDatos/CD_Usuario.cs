using System;
using System.Collections.Generic;
using System.Text;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<CE_Usuario> Listar()
        {
            List<CE_Usuario> lista = new List<CE_Usuario>();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.ID_Usuario,u.Documento,u.Nombre,u.Apellido,u.Clave,u.FechaRegistro,r.ID_Rol,r.NomRol FROM USUARIO u");
                    query.AppendLine("INNER JOIN ROL r on r.ID_Rol = u.ID_Rol;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Usuario()
                            {
                                IdUsuario = Convert.ToInt32(reader["ID_Usuario"]),
                                Documento = reader["Documento"].ToString(),
                                Nombre = reader["Nombre"].ToString(),
                                Apellido = reader["Apellido"].ToString(),
                                Clave = reader["Clave"].ToString(),
                                FechaCreacion = reader["FechaRegistro"].ToString(),
                                oRol = new CE_Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["ID_Rol"]),
                                    NomRol = reader["NomRol"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    lista = new List<CE_Usuario>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
        public int Crear(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO USUARIO (Documento,Nombre,Apellido,Clave,FechaRegistro,ID_Rol)" +
                        "VALUES (@Documento,@Nombre,@Apellido,@Clave,@FechaRegistro,@ID_Rol);");
                    query.AppendLine("SELECT last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@Documento", oUsuario.Documento));
                    cmd.Parameters.Add(new SQLiteParameter("@Nombre", oUsuario.Nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@Apellido", oUsuario.Apellido));
                    cmd.Parameters.Add(new SQLiteParameter("@Clave", oUsuario.Clave));
                    cmd.Parameters.Add(new SQLiteParameter("@FechaRegistro", DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Rol", oUsuario.oRol.IdRol));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID del usuario.
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
        public bool Actualizar(CE_Usuario oUsuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE USUARIO SET "
                                     + "Documento = @Documento, "
                                     + "Nombre = @Nombre, "
                                     + "Apellido = @Apellido, "
                                     + "Clave = @Clave, "
                                     + "ID_Rol = @ID_Rol "
                                     + "WHERE ID_Usuario = @ID_Usuario");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@Documento", oUsuario.Documento));
                    cmd.Parameters.Add(new SQLiteParameter("@Nombre", oUsuario.Nombre));
                    cmd.Parameters.Add(new SQLiteParameter("@Apellido", oUsuario.Apellido));
                    cmd.Parameters.Add(new SQLiteParameter("@Clave", oUsuario.Clave));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Rol", oUsuario.oRol.IdRol));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Usuario", oUsuario.IdUsuario));

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
        public bool Eliminar(CE_Usuario oUsuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM USUARIO WHERE ID_Usuario = @ID_Usuario;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Usuario", oUsuario.IdUsuario));
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