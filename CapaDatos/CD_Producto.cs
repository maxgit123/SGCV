using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Producto
    {
        public List<CE_Producto> Listar(bool? soloActivos = null, bool? soloConStock = null)
        {
            List<CE_Producto> lista = new List<CE_Producto>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                string query = @"SELECT p.id_producto, p.codigo, p.descripcion, p.precioCompra,
                p.precioVenta, p.stock, p.quiebreStock, p.fechaCreacion,
                c.id_categoria, c.nombre AS [categoria],
                e.id_estado, e.nombre AS [estado]
                FROM Producto p
                INNER JOIN Categoria c ON c.id_categoria = p.categoria_id
                INNER JOIN cEstado e ON e.id_estado = p.estado_id";

                if (soloActivos == true)
                    query += " AND e.id_estado = 1";
                if (soloConStock == true)
                    query += " AND p.stock > 0";

                using (SqlCommand cmd = new SqlCommand(query, oConexion))
                {
                    try
                    {
                        oConexion.Open();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lista.Add(new CE_Producto()
                                {
                                    Id = Convert.ToInt32(reader["id_producto"]),
                                    Codigo = reader["codigo"].ToString(),
                                    Descripcion = reader["descripcion"].ToString(),
                                    PrecioCompra = Convert.ToDecimal(reader["precioCompra"]),
                                    PrecioVenta = Convert.ToDecimal(reader["precioVenta"]),
                                    Stock = Convert.ToInt32(reader["stock"]),
                                    QuiebreStock = Convert.ToInt32(reader["quiebreStock"]),
                                    FechaCreacion = reader["fechaCreacion"].ToString(),
                                    oCategoria = new CE_Categoria()
                                    {
                                        Id = Convert.ToInt32(reader["id_categoria"]),
                                        Nombre = reader["categoria"].ToString()
                                    },
                                    oEstado = new CE_Estado()
                                    {
                                        Id = Convert.ToBoolean(reader["id_estado"]),
                                        Nombre = reader["estado"].ToString()
                                    }
                                });
                            }
                        }
                    }
                    catch (SqlException)
                    {
                        //mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                        lista = new List<CE_Producto>();
                    }
                }
            }
            return lista;
        }
        public int Crear(CE_Producto oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            int idProductoCreado = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_crearProducto", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codigo", oProducto.Codigo);
                cmd.Parameters.AddWithValue("@descripcion", oProducto.Descripcion);
                cmd.Parameters.AddWithValue("@quiebreStock", oProducto.QuiebreStock);
                cmd.Parameters.AddWithValue("@categoria_id", oProducto.oCategoria.Id);
                cmd.Parameters.Add("@idProductoCreado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    idProductoCreado = Convert.ToInt32(cmd.Parameters["@idProductoCreado"].Value);
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    idProductoCreado = 0;
                }
            }
            return idProductoCreado;
        }
        public bool Actualizar(CE_Producto oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_actualizarProducto", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@descripcion", oProducto.Descripcion);
                cmd.Parameters.AddWithValue("@quiebreStock", oProducto.QuiebreStock);
                cmd.Parameters.AddWithValue("@categoria_id", oProducto.oCategoria.Id);
                cmd.Parameters.AddWithValue("@id_producto", oProducto.Id);
                cmd.Parameters.Add("@respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    respuesta = Convert.ToBoolean(cmd.Parameters["@respuesta"].Value);
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    respuesta = false;
                }
            }
            return respuesta;
        }
        public bool Eliminar(CE_Producto oProducto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_eliminarProducto", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_producto", oProducto.Id);
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
    }
}
