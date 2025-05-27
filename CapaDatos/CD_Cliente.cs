using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public List<CE_Cliente> Listar()
        {
            List<CE_Cliente> lista = new List<CE_Cliente>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.id_cliente, c.documento, c.nombre, c.apellido, c.telefono, c.correo, c.fechaCreacion,");
                    query.AppendLine("r.id_responsableIVA, r.nombre AS responsableIVA,");
                    query.AppendLine("e.nombre AS estado");
                    query.AppendLine("FROM Cliente c");
                    query.AppendLine("INNER JOIN cResponsableIVA r ON r.id_responsableIVA = c.responsableIVA_id");
                    query.AppendLine("INNER JOIN cEstado e ON e.id_estado = c.estado_id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Cliente()
                            {
                                IdCliente = Convert.ToInt32(reader["id_cliente"]),
                                Documento = reader["documento"].ToString(),
                                Nombre = reader["nombre"].ToString(),
                                Apellido = reader["apellido"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                Correo = reader["correo"].ToString(),
                                FechaCreacion = reader["fechaCreacion"].ToString(),
                                oRespIVA = new CE_ResponsableIVA()
                                {
                                    Id = Convert.ToInt32(reader["id_responsableIVA"]),
                                    Nombre = reader["responsableIVA"].ToString()
                                },
                                oEstado = new CE_Estado()
                                {
                                    Nombre = reader["estado"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (SqlException ex)
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

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO CLIENTE (Documento,Nombre,Apellido,ID_RespIVA)" +
                        "VALUES (@Documento,@Nombre,@Apellido,@ID_RespIVA);");
                    query.AppendLine("SELECT last_insert_rowid();");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@Documento", oCliente.Documento));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", oCliente.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Apellido", oCliente.Apellido));
                    cmd.Parameters.Add(new SqlParameter("@ID_RespIVA", oCliente.oRespIVA.Id));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID del Cliente.
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
        public bool Actualizar(CE_Cliente oCliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
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
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@Documento", oCliente.Documento));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", oCliente.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@Apellido", oCliente.Apellido));
                    cmd.Parameters.Add(new SqlParameter("@ID_RespIVA", oCliente.oRespIVA.Id));
                    cmd.Parameters.Add(new SqlParameter("@ID_Cliente", oCliente.IdCliente));

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
        public bool Eliminar(CE_Cliente oCliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM CLIENTE WHERE ID_Cliente = @ID_Cliente;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.Add(new SqlParameter("@ID_Cliente", oCliente.IdCliente));
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
