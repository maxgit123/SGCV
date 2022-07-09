using System;
using System.Collections.Generic;
using System.Text;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Usuario
    {
        public List<CE_Usuario> Listar()
        {
            List<CE_Usuario> lista = new List<CE_Usuario>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT u.id,u.documento,u.nombre,u.apellido,u.clave,u.fechaCreacion,r.nombre AS [rol],e.nombre AS [estado] FROM Usuario u");
                    query.AppendLine("INNER JOIN cRol r ON r.id = u.rol_id");
                    query.AppendLine("INNER JOIN cEstado e ON e.id = u.estado_id;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Usuario()
                            {
                                IdUsuario = Convert.ToInt32(reader["id"]),
                                Documento = reader["documento"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Clave = reader["clave"].ToString(),
                                FechaCreacion = reader["fechaCreacion"].ToString(),
                                oRol = new CE_Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["id"]),
                                    NomRol = reader["rol"].ToString()
                                },
                                oEstado = new CE_Estado()
                                {
                                    IdEstado = Convert.ToBoolean(reader["id"]),
                                    Nombre = reader["estado"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (SqlException ex)
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

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO USUARIO (Documento,Nombre,Apellido,Clave,FechaRegistro,ID_Rol)" +
                        "VALUES (@Documento,@Nombre,@Apellido,@Clave,@FechaRegistro,@ID_Rol);");
                    query.AppendLine("SELECT last_insert_rowid();");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@Documento", oUsuario.Documento));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", oUsuario.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Apellido", oUsuario.Apellido));
                    cmd.Parameters.Add(new SqlParameter("@Clave", oUsuario.Clave));
                    cmd.Parameters.Add(new SqlParameter("@FechaRegistro", DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")));
                    cmd.Parameters.Add(new SqlParameter("@ID_Rol", oUsuario.oRol.IdRol));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID del usuario.
                    cmd.Parameters.Clear();
                }
                catch (SqlException ex)
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

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
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
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@Documento", oUsuario.Documento));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", oUsuario.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Apellido", oUsuario.Apellido));
                    cmd.Parameters.Add(new SqlParameter("@Clave", oUsuario.Clave));
                    cmd.Parameters.Add(new SqlParameter("@ID_Rol", oUsuario.oRol.IdRol));
                    cmd.Parameters.Add(new SqlParameter("@ID_Usuario", oUsuario.IdUsuario));

                    cmd.CommandType = CommandType.Text;
                    respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    cmd.Parameters.Clear();
                }
                catch (SqlException ex)
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

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM USUARIO WHERE ID_Usuario = @ID_Usuario;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.Add(new SqlParameter("@ID_Usuario", oUsuario.IdUsuario));
                    cmd.CommandType = CommandType.Text;
                    respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    cmd.Parameters.Clear();
                }
                catch (SqlException ex)
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