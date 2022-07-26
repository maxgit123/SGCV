using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<CE_Categoria> Listar()
        {
            List<CE_Categoria> lista = new List<CE_Categoria>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.id,c.nombre,c.alicuotaIVA_id,a.porcentaje,c.estado_id,e.nombre AS [estado] FROM Categoria c");
                    query.AppendLine("INNER JOIN cAlicuotaIVA a ON a.id = c.alicuotaIVA_id");
                    query.AppendLine("INNER JOIN cEstado e ON e.id = c.estado_id");
                    query.AppendLine("WHERE c.estado_id = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Categoria()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["nombre"].ToString(),
                                oAlicuotaIVA = new CE_AlicuotaIVA()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Porcentaje = Convert.ToDecimal(reader["porcentaje"])
                                },
                                oEstado = new CE_Estado()
                                {
                                    Id = Convert.ToBoolean(reader["id"]),
                                    Nombre = reader["nombre"].ToString(),
                                }
                            });
                        }
                    }
                }
                catch (SqlException ex)
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
            int idCreado = 0;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_crearcategoria", oConexion)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@nombre", oCategoria.Nombre);
                    cmd.Parameters.AddWithValue("@alicuotaIVA_id", oCategoria.oAlicuotaIVA.Id);
                    cmd.Parameters.Add("@idCreado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    idCreado = Convert.ToInt32(cmd.Parameters["@idCreado"].Value);
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
        public bool Actualizar(CE_Categoria oCategoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_actualizarcategoria", oConexion)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@id", oCategoria.Id);
                    cmd.Parameters.AddWithValue("@nombre", oCategoria.Nombre);
                    cmd.Parameters.AddWithValue("@alicuotaIVA_id", oCategoria.oAlicuotaIVA.Id);
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
        public bool Eliminar(CE_Categoria oCategoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("usp_eliminarusuario", oConexion)
                    { CommandType = CommandType.StoredProcedure };

                    cmd.Parameters.AddWithValue("@id", oCategoria.Id);
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
    }
}
