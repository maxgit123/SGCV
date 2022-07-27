using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public List<CE_Proveedor> Listar()
        {
            List<CE_Proveedor> lista = new List<CE_Proveedor>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id,p.razonSocial,p.observacion,p.fechaCreacion,p.telefono,p.correo,e.nombre AS [estado] FROM Proveedor p");
                    query.AppendLine("INNER JOIN cEstado e ON e.id = p.estado_id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Proveedor()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                RazonSocial = reader["razonSocial"].ToString(),
                                Observacion = reader["observacion"].ToString(),
                                FechaCreacion = reader["fechaCreacion"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                Correo = reader["correo"].ToString(),
                                oEstado = new CE_Estado()
                                {
                                    Id = Convert.ToBoolean(reader["id"]),
                                    Nombre = reader["estado"].ToString()
                                }
                            });
                        }
                        reader.Close();
                    }
                }
                catch (SqlException ex)
                {
                    lista = new List<CE_Proveedor>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
        public int Crear(CE_Proveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO Proveedor (razonSocial,observacion,telefono,correo,estado_id");
                    query.AppendLine("VALUES (@razonSocial,@observacion,@telefono,@correo,@estado_id;");
                    query.AppendLine("SELECT last_insert_rowid();");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    cmd.Parameters.AddWithValue("@razonSocial", oProveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("@observacion", oProveedor.Observacion);
                    cmd.Parameters.AddWithValue("@telefono", oProveedor.Telefono);
                    cmd.Parameters.AddWithValue("@correo", oProveedor.Correo);
                    cmd.Parameters.AddWithValue("@estado_id", oProveedor.oEstado.Id);

                    oConexion.Open();
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
        public bool Actualizar(CE_Proveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE Proveedor SET "
                                     + "razonSocial = @razonSocial, "
                                     + "observacion = @obervacion, "
                                     + "telefono = @telefono, "
                                     + "correo = @correo, "
                                     + "WHERE id = @id");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    cmd.Parameters.AddWithValue("@razonSocial", oProveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("@observacion", oProveedor.Observacion);
                    cmd.Parameters.AddWithValue("@telefono", oProveedor.Telefono);
                    cmd.Parameters.AddWithValue("@correo", oProveedor.Correo);
                    cmd.Parameters.AddWithValue("@id", oProveedor.Id);

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
        public bool Eliminar(CE_Proveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM Proveedor WHERE id = @id;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };
                    cmd.Parameters.AddWithValue("@id", oProveedor.Id);

                    oConexion.Open();
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
