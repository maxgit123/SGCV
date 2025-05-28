using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Cliente
    {
        public List<CE_Cliente> Listar(out string mensaje)
        {
            mensaje = string.Empty;

            List<CE_Cliente> lista = new List<CE_Cliente>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.id_cliente, c.documento, c.nombre, c.apellido, c.telefono, c.correo, c.fechaCreacion,");
                    query.AppendLine("r.id_responsableIVA, r.nombre AS responsableIVA,");
                    query.AppendLine("e.id_estado, e.nombre AS estado");
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
                                Id = Convert.ToInt32(reader["id_cliente"]),
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
                    mensaje = "Codigo de error: " + ex.ErrorCode + "\n" + ex.Message;
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

                    query.AppendLine("INSERT INTO Cliente (documento, nombre, apellido, telefono, correo, responsableIVA_id, estado_id)");
                    query.AppendLine("VALUES (@documento, @nombre, @apellido, @telefono, @correo, @responsableIVA_id, @estado_id);");
                    query.AppendLine("SELECT SCOPE_IDENTITY();");

                    using (SqlCommand cmd = new SqlCommand(query.ToString(), oConexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("@documento", oCliente.Documento));
                        cmd.Parameters.Add(new SqlParameter("@nombre", oCliente.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellido", oCliente.Apellido));
                        cmd.Parameters.Add(new SqlParameter("@telefono", oCliente.Telefono));
                        cmd.Parameters.Add(new SqlParameter("@correo", oCliente.Correo));
                        cmd.Parameters.Add(new SqlParameter("@responsableIVA_id", oCliente.oRespIVA.Id));
                        cmd.Parameters.Add(new SqlParameter("@estado_id", 1));
                        //cmd.CommandType = CommandType.Text;

                        respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    }
                }
                catch (SqlException ex)
                {
                    respuesta = 0;
                    mensaje = "Codigo de error: " + ex.ErrorCode + "\n" + ex.Message;
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
                    query.AppendLine("UPDATE Cliente SET");
                    query.AppendLine("documento = @documento, nombre = @nombre, apellido = @apellido,");
                    query.AppendLine("telefono = @telefono, correo = @correo, responsableIVA_id = @responsableIVA_id");
                    query.AppendLine("WHERE id_cliente = @id_cliente;");

                    using (SqlCommand cmd = new SqlCommand(query.ToString(), oConexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("@documento", oCliente.Documento));
                        cmd.Parameters.Add(new SqlParameter("@nombre", oCliente.Nombre));
                        cmd.Parameters.Add(new SqlParameter("@apellido", oCliente.Apellido));
                        cmd.Parameters.Add(new SqlParameter("@telefono", oCliente.Telefono));
                        cmd.Parameters.Add(new SqlParameter("@correo", oCliente.Correo));
                        cmd.Parameters.Add(new SqlParameter("@responsableIVA_id", oCliente.oRespIVA.Id));
                        cmd.Parameters.Add(new SqlParameter("@id_cliente", oCliente.Id));

                        respuesta = cmd.ExecuteNonQuery() > 0;
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
        public bool Eliminar(CE_Cliente oCliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();

                    string query = "DELETE FROM Cliente WHERE id_cliente = @id_cliente;";

                    using (SqlCommand cmd = new SqlCommand(query, oConexion))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", oCliente.Id);
                        respuesta = cmd.ExecuteNonQuery() > 0;
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
    }
}
