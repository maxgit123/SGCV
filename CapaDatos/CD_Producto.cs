using System;
using System.Collections.Generic;
using System.Text;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

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
                    query.AppendLine("SELECT p.ID_Producto,p.Descripcion,p.PrecioCompra,p.PrecioVenta,p.Stock,p.QuiebreStock,c.ID_Categoria,c.NomCategoria FROM PRODUCTO p");
                    query.AppendLine("INNER JOIN CATEGORIA c on c.ID_Categoria = p.ID_Categoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Producto()
                            {
                                IdProducto = Convert.ToInt32(reader["ID_Producto"]),
                                Nombre = reader["Descripcion"].ToString(),
                                Costo = Convert.ToDecimal(reader["PrecioCompra"]),
                                Precio = Convert.ToDecimal(reader["PrecioVenta"]),
                                Stock = Convert.ToInt32(reader["Stock"]),
                                QuiebreStock = Convert.ToInt32(reader["QuiebreStock"]),
                                oCategoria = new CE_Categoria()
                                {
                                    IdCategoria = Convert.ToInt32(reader["ID_Categoria"]),
                                    NomCategoria = reader["NomCategoria"].ToString()
                                }
                            });
                        }
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

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", oProducto.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@QuiebreStock", oProducto.QuiebreStock));
                    cmd.Parameters.Add(new SqlParameter("@ID_Categoria", oProducto.oCategoria.IdCategoria));
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

                    cmd.Parameters.Add(new SqlParameter("@Descripcion", oProducto.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@QuiebreStock", oProducto.QuiebreStock));
                    cmd.Parameters.Add(new SqlParameter("@ID_Categoria", oProducto.oCategoria.IdCategoria));
                    cmd.Parameters.Add(new SqlParameter("@ID_Producto", oProducto.IdProducto));
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
                    cmd.Parameters.Add(new SqlParameter("@ID_Producto", oProducto.IdProducto));
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
