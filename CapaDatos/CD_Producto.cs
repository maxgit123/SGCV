using System;
using System.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Producto
    {
        public List<CE_Producto> Listar()
        {
            List<CE_Producto> lista = new List<CE_Producto>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.id,p.descripcion,p.costo,p.precio,p.stock,p.quiebreStock,p.fechaCreacion,c.nombre AS [categoria],e.nombre AS [estado] FROM Producto p");
                    query.AppendLine("INNER JOIN Categoria c ON c.id = p.categoria_id");
                    query.AppendLine("INNER JOIN cEstado e ON e.id = p.estado_id;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Producto()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Descripcion = reader["descripcion"].ToString(),
                                Costo = Convert.ToDecimal(reader["costo"]),
                                Precio = Convert.ToDecimal(reader["precio"]),
                                Stock = Convert.ToInt32(reader["stock"]),
                                QuiebreStock = Convert.ToInt32(reader["quiebreStock"]),
                                FechaCreacion = reader["fechaCreacion"].ToString(),
                                oCategoria = new CE_Categoria()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nombre = reader["categoria"].ToString()
                                },
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
                    lista = new List<CE_Producto>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
        public int Crear(CE_Producto oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO PRODUCTO (Descripcion,QuiebreStock,ID_Categoria)" +
                        "VALUES (@Descripcion,@QuiebreStock,@ID_Categoria);");
                    query.AppendLine("SELECT last_insert_rowid();");
                    //last_insert_rowid retorna el ultimo row id que se inserto.
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", oProducto.Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@QuiebreStock", oProducto.QuiebreStock));
                    cmd.Parameters.Add(new SqlParameter("@ID_Categoria", oProducto.oCategoria.Id));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID.
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
        public bool Actualizar(CE_Producto oProducto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE PRODUCTO SET "
                                     + "Descripcion = @Descripcion, "
                                     + "QuiebreStock = @QuiebreStock, "
                                     + "ID_Categoria = @ID_Categoria "
                                     + "WHERE ID_Producto = @ID_Producto");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", oProducto.Descripcion));
                    cmd.Parameters.Add(new SqlParameter("@QuiebreStock", oProducto.QuiebreStock));
                    cmd.Parameters.Add(new SqlParameter("@ID_Categoria", oProducto.oCategoria.Id));
                    cmd.Parameters.Add(new SqlParameter("@ID_Producto", oProducto.Id));
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
        public bool Eliminar(CE_Producto oProducto, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM PRODUCTO WHERE ID_Producto = @ID_Producto;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.Add(new SqlParameter("@ID_Producto", oProducto.Id));
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
