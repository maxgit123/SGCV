using System;
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
            var lista = new List<CE_Usuario>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT u.id_usuario, u.documento, u.nombre, u.apellido, u.clave, u.fechaCreacion,
                r.id_rol, r.nombre AS rol_nombre,
                e.id_estado, e.nombre AS estado_nombre
                FROM Usuario u
                INNER JOIN cRol r ON r.id_rol = u.rol_id
                INNER JOIN cEstado e ON e.id_estado = u.estado_id
                WHERE u.estado_id = 1;", oConexion))
            {
                try
                {
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
                    }
                }
                catch (SqlException)
                {
                    //mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    lista = new List<CE_Usuario>();
                }
            }
            return lista;
        }
        public CE_Usuario Login(string documento, string clave, out string mensaje)
        {
            mensaje = string.Empty;
            CE_Usuario oUsuario = null;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_loginUsuario", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@documento", documento);
                cmd.Parameters.AddWithValue("@clave", clave);

                try
                {
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            mensaje = "No se encontró ningún usuario con esas credenciales";
                            return null;
                        }

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
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    return null;
                }
            }

            if (oUsuario == null)
                mensaje = "Error al leer los datos del usuario";

            return oUsuario;
        }
        public int Crear(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            int idUsuarioCreado = 0;
            
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_crearUsuario", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@documento", oUsuario.Documento);
                cmd.Parameters.AddWithValue("@nombre", oUsuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oUsuario.Apellido);
                cmd.Parameters.AddWithValue("@clave", oUsuario.Clave);
                cmd.Parameters.AddWithValue("@rol_id", oUsuario.oRol.IdRol);
                cmd.Parameters.Add("@idUsuarioCreado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    idUsuarioCreado = Convert.ToInt32(cmd.Parameters["@idUsuarioCreado"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    idUsuarioCreado = 0;
                }
            }
            return idUsuarioCreado;
        }
        public bool Actualizar(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_actualizarUsuario", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                
                cmd.Parameters.AddWithValue("@id_usuario", oUsuario.Id);
                cmd.Parameters.AddWithValue("@documento", oUsuario.Documento);
                cmd.Parameters.AddWithValue("@nombre", oUsuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oUsuario.Apellido);
                cmd.Parameters.AddWithValue("@rol_id", oUsuario.oRol.IdRol);
                cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                
                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    respuesta = false; // se puede eliminar esta linea, ya que respuesta ya es false por defecto
                }
            }
            return respuesta;
        }
        public bool Eliminar(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_eliminarUsuario", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oUsuario.Id);
                cmd.Parameters.Add("@respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    respuesta = false;
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
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool CambiarClave(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

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

                    respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();

                    return respuesta;
                }
            }
            catch (SqlException ex)
            {
                mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                return false;
            }
        }
    }
}