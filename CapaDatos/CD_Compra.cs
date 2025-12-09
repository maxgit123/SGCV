using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Compra
    {
        public List<CE_Compra> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            var lista = new List<CE_Compra>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT
	                    c.id_compra, c.total, c.fechaPedido, c.fechaEntrega, c.fechaCreacion,
	                    u.apellido, u.nombre, u.documento,
                        p.razonSocial AS proveedor, p.telefono, p.correo,
	                    e.nombre AS estado
                    FROM Compra c
                    INNER JOIN Usuario u ON u.id_usuario = c.usuario_id
                    INNER JOIN Proveedor p ON p.id_proveedor = c.proveedor_id
                    INNER JOIN cEstado e ON e.id_estado = c.estado_id;", oConexion))
            {
                try
                {
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Compra()
                            {
                                Id = Convert.ToInt32(reader["id_compra"]),
                                Total = Convert.ToDecimal(reader["total"]),
                                FechaPedido = Convert.ToDateTime(reader["fechaPedido"]),
                                FechaEntrega = Convert.ToDateTime(reader["fechaEntrega"]),
                                FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]),
                                oUsuario = new CE_Usuario()
                                {
                                    Nombre = reader["nombre"].ToString(),
                                    Apellido = reader["apellido"].ToString(),
                                    Documento = reader["documento"].ToString()
                                },
                                oProveedor = new CE_Proveedor()
                                {
                                    RazonSocial = reader["proveedor"].ToString(),
                                    Telefono = reader["telefono"].ToString(),
                                    Correo = reader["correo"].ToString()
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
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    lista = new List<CE_Compra>();
                }
            }
            return lista;
        }
        public CE_Compra ObtenerCompraPorId(int idCompra)
        {
            var compra = new CE_Compra();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT
                        c.id_compra, c.total, c.fechaPedido, c.fechaEntrega, c.fechaCreacion,
                        u.apellido, u.nombre, u.documento,
                        p.razonSocial AS proveedor, p.telefono, p.correo,
                        e.nombre AS estado
                    FROM Compra c
                    INNER JOIN Usuario u ON u.id_usuario = c.usuario_id
                    INNER JOIN Proveedor p ON p.id_proveedor = c.proveedor_id
                    INNER JOIN cEstado e ON e.id_estado = c.estado_id
                    WHERE c.id_compra = @idCompra;", oConexion))
            {
                cmd.Parameters.AddWithValue("@idCompra", idCompra);
                try
                {
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            compra = new CE_Compra()
                            {
                                Id = Convert.ToInt32(reader["id_compra"]),
                                Total = Convert.ToDecimal(reader["total"]),
                                FechaPedido = Convert.ToDateTime(reader["fechaPedido"]),
                                FechaEntrega = Convert.ToDateTime(reader["fechaEntrega"]),
                                FechaCreacion = Convert.ToDateTime(reader["fechaCreacion"]),
                                oUsuario = new CE_Usuario()
                                {
                                    Nombre = reader["nombre"].ToString(),
                                    Apellido = reader["apellido"].ToString(),
                                    Documento = reader["documento"].ToString()
                                },
                                oProveedor = new CE_Proveedor()
                                {
                                    RazonSocial = reader["proveedor"].ToString(),
                                    Telefono = reader["telefono"].ToString(),
                                    Correo = reader["correo"].ToString()
                                },
                                oEstado = new CE_Estado()
                                {
                                    Nombre = reader["estado"].ToString()
                                }
                            };
                        }
                    }
                }
                catch (SqlException)
                {
                    compra = new CE_Compra();
                }
            }
            return compra;
        }
        public List<CE_CompraDetalle> ObtenerCompraDetallePorId(int idCompra)
        {
            var lista = new List<CE_CompraDetalle>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT
	                    p.codigo, p.descripcion,
	                    cd.precioCompraUnitario, cd.cantidad, cd.subtotal
                    FROM CompraDetalle cd
                    INNER JOIN Producto p ON p.id_producto = cd.producto_id
                    WHERE cd.compra_id = @idCompra;", oConexion))
            {
                cmd.Parameters.AddWithValue("@idCompra", idCompra);
                try
                {
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_CompraDetalle()
                            {
                                //Id = Convert.ToInt32(reader["id_compraDetalle"]),
                                oProducto = new CE_Producto()
                                {
                                    Codigo = reader["codigo"].ToString(),
                                    Descripcion = reader["descripcion"].ToString()
                                },
                                PrecioCompraUnitario = Convert.ToDecimal(reader["precioCompraUnitario"]),
                                Cantidad = Convert.ToInt32(reader["cantidad"]),
                                Subtotal = Convert.ToDecimal(reader["subtotal"])
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    lista = new List<CE_CompraDetalle>();
                }
            }
            return lista;
        }
        public bool Crear(CE_Compra oCompra, DataTable compraDetalle, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_crearCompra", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario_id", oCompra.oUsuario.Id);
                cmd.Parameters.AddWithValue("@proveedor_id", oCompra.oProveedor.Id);
                cmd.Parameters.AddWithValue("@total", oCompra.Total);
                cmd.Parameters.AddWithValue("@fechaPedido", oCompra.FechaPedido);
                cmd.Parameters.AddWithValue("@fechaEntrega", oCompra.FechaEntrega);
                cmd.Parameters.AddWithValue("@compraDetalle", compraDetalle);
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
    }
}

