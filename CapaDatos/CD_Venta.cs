using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Venta
    {
        public List<CE_Venta> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            var lista = new List<CE_Venta>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT
                        v.id_venta, v.tipoFactura, v.total, v.fechaVenta, v.fechaCreacion,
                        u.apellido, u.nombre,
                        c.nombre AS nomCliente, c.apellido AS apellidoCliente,
                        e.nombre AS estado
                    FROM Venta v
                    INNER JOIN Usuario u ON u.id_usuario = v.usuario_id
                    LEFT JOIN Cliente c ON c.id_cliente = v.cliente_id
                    INNER JOIN cEstado e ON e.id_estado = v.estado_id;", oConexion))
            {
                try
                {
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Venta()
                            {
                                Id = Convert.ToInt32(reader["Id_venta"]),
                                TipoFactura = reader["TipoFactura"].ToString(),
                                FechaVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                oUsuario = new CE_Usuario()
                                {
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString()
                                },
                                oCliente = new CE_Cliente()
                                {
                                    Nombre = reader["nomCliente"].ToString(),
                                    Apellido = reader["apellidoCliente"].ToString()
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
                    lista = new List<CE_Venta>();
                }
            }
            return lista;
        }
        public CE_Venta ObtenerVentaPorId(int idVenta)
        {
            var venta = new CE_Venta();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT
                        v.id_venta, v.tipoFactura, v.total, v.pago, v.vuelto, v.fechaVenta, v.fechaCreacion,
                        u.id_usuario, u.apellido, u.nombre, u.documento,
                        c.documento AS docCliente, c.nombre AS nomCliente, c.apellido AS apellidoCliente, c.telefono, c.correo,
                        e.nombre AS estado
                    FROM Venta v
                    INNER JOIN Usuario u ON u.id_usuario = v.usuario_id
                    LEFT JOIN Cliente c ON c.id_cliente = v.cliente_id
                    INNER JOIN cEstado e ON e.id_estado = v.estado_id
                    WHERE v.id_venta = @idVenta;", oConexion))
            {
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                try
                {
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            venta = new CE_Venta()
                            {
                                Id = Convert.ToInt32(reader["Id_venta"]),
                                TipoFactura = reader["TipoFactura"].ToString(),
                                FechaVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                                Total = Convert.ToDecimal(reader["Total"]),
                                Pago = Convert.ToDecimal(reader["Pago"]),
                                Vuelto = Convert.ToDecimal(reader["Vuelto"]),
                                oUsuario = new CE_Usuario()
                                {
                                    Id = Convert.ToInt32(reader["id_usuario"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Apellido"].ToString(),
                                    Documento = reader["Documento"].ToString()
                                },
                                oCliente = new CE_Cliente()
                                {
                                    Documento = reader["docCliente"].ToString(),
                                    Nombre = reader["nomCliente"].ToString(),
                                    Apellido = reader["apellidoCliente"].ToString(),
                                    Telefono = reader["Telefono"].ToString(),
                                    Correo = reader["Correo"].ToString()
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
                    venta = new CE_Venta();
                }
            }
            return venta;
        }
        public List<CE_VentaDetalle> ObtenerVentaDetallePorId(int idVenta)
        {
            var lista = new List<CE_VentaDetalle>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT
                        p.codigo, p.descripcion,
                        vd.precioVentaUnitario, vd.cantidad, vd.subtotal,
	                    a.porcentaje AS alicuotaIVA
                    FROM VentaDetalle vd
                    INNER JOIN Producto p ON p.id_producto = vd.producto_id
                    INNER JOIN Categoria c ON c.id_categoria = p.categoria_id
                    INNER JOIN cAlicuotaIVA a ON a.id_alicuotaIVA = c.alicuotaIVA_id
                    WHERE vd.venta_id = @idVenta;", oConexion))
            {
                cmd.Parameters.AddWithValue("@idVenta", idVenta);
                try
                {
                    oConexion.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_VentaDetalle()
                            {
                                oProducto = new CE_Producto()
                                {
                                    Codigo = reader["codigo"].ToString(),
                                    Descripcion = reader["descripcion"].ToString(),
                                    oCategoria = new CE_Categoria()
                                    {
                                        oAlicuotaIVA = new CE_AlicuotaIVA()
                                        {
                                            Porcentaje = Convert.ToDecimal(reader["alicuotaIVA"])
                                        }
                                    }
                                },
                                PrecioVentaUnitario = Convert.ToDecimal(reader["precioVentaUnitario"]),
                                Cantidad = Convert.ToInt32(reader["cantidad"]),
                                Subtotal = Convert.ToDecimal(reader["subtotal"])
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    lista = new List<CE_VentaDetalle>();
                }
            }
            return lista;
        }
        public int Crear(CE_Venta oVenta, DataTable ventaDetalle, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_crearVenta", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario_id", oVenta.oUsuario.Id);
                cmd.Parameters.AddWithValue("@comercio_id", oVenta.oComercio.Id);

                if (oVenta.oCliente != null && oVenta.oCliente.Id > 0)
                    cmd.Parameters.AddWithValue("@cliente_id", oVenta.oCliente.Id);
                else
                    cmd.Parameters.AddWithValue("@cliente_id", DBNull.Value);

                cmd.Parameters.AddWithValue("@tipoFactura", oVenta.TipoFactura);
                cmd.Parameters.AddWithValue("@total", oVenta.Total);
                cmd.Parameters.AddWithValue("@pago", oVenta.Pago);
                cmd.Parameters.AddWithValue("@vuelto", oVenta.Vuelto);
                cmd.Parameters.AddWithValue("@fechaVenta", oVenta.FechaVenta);
                cmd.Parameters.AddWithValue("@ventaDetalle", ventaDetalle);
                cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    respuesta = Convert.ToInt32(cmd.Parameters["@respuesta"].Value);
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    respuesta = 0;
                }
            }

            return respuesta;
        }
    }
}
