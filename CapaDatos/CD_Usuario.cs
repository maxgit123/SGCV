using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

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
                    query.AppendLine("SELECT u.id_usuario,u.documento,u.nombre,u.apellido,u.clave,u.fechaCreacion,");
                    query.AppendLine("r.id_rol,r.nombre AS rol_nombre,e.id_estado,e.nombre AS estado_nombre FROM Usuario u");
                    query.AppendLine("INNER JOIN cRol r ON r.id_rol = u.rol_id");
                    query.AppendLine("INNER JOIN cEstado e ON e.id_estado = u.estado_id");
                    query.AppendLine("WHERE u.estado_id = 1;");
                    
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Usuario()
                            {
                                Id = Convert.ToInt32(reader["id_usuario"]),
                                Documento = reader["documento"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Clave = reader["clave"].ToString(),
                                FechaCreacion = reader["fechaCreacion"].ToString(),
                                oRol = new CE_Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["id_rol"]),
                                    Nombre = reader["rol_nombre"].ToString()
                                },
                                oEstado = new CE_Estado()
                                {
                                    Id = Convert.ToBoolean(reader["id_estado"]),
                                    Nombre = reader["estado_nombre"].ToString()
                                }
                            });
                        }
                        reader.Close();
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
        public CE_Usuario Login(string documento, string clave)
        {
            CE_Usuario oUsuario = null;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_loginUsuario", oConexion)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@documento", documento);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Si el usuario existe se devuelve el objeto completo. Sino, null.
                        if (reader.Read())
                        {
                            oUsuario = new CE_Usuario()
                            {
                                Id = Convert.ToInt32(reader["id_usuario"]),
                                Documento = reader["documento"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Clave = reader["clave"].ToString(),
                                FechaCreacion = reader["fechaCreacion"].ToString(),
                                oRol = new CE_Rol()
                                {
                                    IdRol = Convert.ToInt32(reader["id_rol"]),
                                    Nombre = reader["rol_nombre"].ToString()
                                },
                                oEstado = new CE_Estado()
                                {
                                    Id = Convert.ToBoolean(reader["id_estado"]),
                                    Nombre = reader["estado_nombre"].ToString()
                                }
                            };
                        }
                    }
                }
                catch (SqlException)
                {
                    oUsuario = null;
                }
                finally
                {
                    if (oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }

            return oUsuario;
        }
        public int Crear(CE_Usuario oUsuario, out string mensaje)
        {
            int idCreado = 0;
            mensaje = string.Empty;
            
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_crearUsuario", oConexion)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@documento", oUsuario.Documento);
                    cmd.Parameters.AddWithValue("@nombre", oUsuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", oUsuario.Apellido);
                    cmd.Parameters.AddWithValue("@clave", oUsuario.Clave);
                    cmd.Parameters.AddWithValue("@rol_id", oUsuario.oRol.IdRol);
                    cmd.Parameters.Add("@idUsuarioCreado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    idCreado = Convert.ToInt32(cmd.Parameters["@idUsuarioCreado"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    cmd.Parameters.Clear();
                }
                catch (SqlException ex)
                {
                    idCreado = 0;
                    mensaje = "Codigo de error: " + ex.ErrorCode + "\n" + ex.Message;
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return idCreado;
        }
        public bool Actualizar(CE_Usuario oUsuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_actualizarUsuario", oConexion)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@id_usuario", oUsuario.Id);
                    cmd.Parameters.AddWithValue("@documento", oUsuario.Documento);
                    cmd.Parameters.AddWithValue("@nombre", oUsuario.Nombre);
                    cmd.Parameters.AddWithValue("@apellido", oUsuario.Apellido);
                    cmd.Parameters.AddWithValue("@rol_id", oUsuario.oRol.IdRol);
                    cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
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
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();

                    using (SqlCommand cmd = new SqlCommand("usp_eliminarUsuario", oConexion))
                    { 
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", oUsuario.Id);
                        cmd.Parameters.Add("@respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        
                        cmd.ExecuteNonQuery();

                        respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                        mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    }
                }
                catch (SqlException ex)
                {
                    respuesta = false;
                    mensaje = "Codigo de error: " + ex.ErrorCode + "\n" + ex.Message;
                }
            }
            return respuesta;
        }
        public bool CambiarEstado(CE_Usuario oUsuario, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_estadoUsuario", oConexion)
                    { CommandType = CommandType.StoredProcedure };
                    
                    cmd.Parameters.AddWithValue("@id", oUsuario.Id);
                    cmd.Parameters.AddWithValue("@estado_id", oUsuario.oEstado.Id);
                    cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;

                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
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
        public bool CambiarClave(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;

            try
            {
                using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
                using (SqlCommand cmd = new SqlCommand("usp_cambiarClaveUsuario", oConexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_usuario", oUsuario.Id);
                    cmd.Parameters.AddWithValue("@nueva_clave", oUsuario.Clave);

                    cmd.Parameters.Add("@respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    bool resultado = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();

                    return resultado;
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Código de error: " + ex.ErrorCode + "\n" + ex.Message;
                return false;
            }
        }
    }
}