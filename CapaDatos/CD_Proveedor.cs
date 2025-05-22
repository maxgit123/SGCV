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
        public List<CE_Proveedor> Listar(out string mensaje)
        {
            mensaje = string.Empty;

            List<CE_Proveedor> lista = new List<CE_Proveedor>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id_proveedor,p.razonSocial,p.observacion,p.fechaCreacion,p.telefono,p.correo,e.nombre AS [estado] FROM Proveedor p");
                    query.AppendLine("INNER JOIN cEstado e ON e.id_estado = p.estado_id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Proveedor()
                            {
                                Id = Convert.ToInt32(reader["id_proveedor"]),
                                RazonSocial = reader["razonSocial"].ToString(),
                                Observacion = reader["observacion"].ToString(),
                                FechaCreacion = reader["fechaCreacion"].ToString(),
                                Telefono = reader["telefono"].ToString(),
                                Correo = reader["correo"].ToString(),
                                oEstado = new CE_Estado()
                                {
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
                    mensaje = "Codigo de error: " + ex.ErrorCode + "\n" + ex.Message;
                    //Console.WriteLine("Error en Listar(): " + ex.Message);
                    //Log.Error("Error al listar proveedores", ex);
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

                    query.AppendLine("INSERT INTO Proveedor (razonSocial,observacion,telefono,correo)");
                    query.AppendLine("VALUES (@razonSocial,@observacion,@telefono,@correo);");
                    query.AppendLine("SELECT SCOPE_IDENTITY();");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    cmd.Parameters.AddWithValue("@razonSocial", oProveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("@observacion", oProveedor.Observacion);
                    cmd.Parameters.AddWithValue("@telefono", oProveedor.Telefono);
                    cmd.Parameters.AddWithValue("@correo", oProveedor.Correo);

                    oConexion.Open();
                    
                    object result = cmd.ExecuteScalar();
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID del usuario.

                    if (result != null)
                    {
                        respuesta = Convert.ToInt32(result);
                    }
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
                                     + "observacion = @observacion, "
                                     + "telefono = @telefono, "
                                     + "correo = @correo "
                                     + "WHERE id_proveedor = @id_proveedor");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    cmd.Parameters.AddWithValue("@razonSocial", oProveedor.RazonSocial);
                    cmd.Parameters.AddWithValue("@observacion", oProveedor.Observacion);
                    cmd.Parameters.AddWithValue("@telefono", oProveedor.Telefono);
                    cmd.Parameters.AddWithValue("@correo", oProveedor.Correo);
                    cmd.Parameters.AddWithValue("@id_proveedor", oProveedor.Id);
                    
                    respuesta = cmd.ExecuteNonQuery() > 0;
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
                    query.AppendLine("DELETE FROM Proveedor WHERE id_proveedor = @id_proveedor;");
                    
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    cmd.Parameters.AddWithValue("@id_proveedor", oProveedor.Id);

                    oConexion.Open();
                    respuesta = cmd.ExecuteNonQuery() > 0;
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
