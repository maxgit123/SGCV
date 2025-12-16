using System;
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
            var lista = new List<CE_Proveedor>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT p.id_proveedor, p.razonSocial, p.observacion, p.fechaCreacion, p.telefono, p.correo,
                    e.id_estado, e.nombre AS estado
                    FROM Proveedor p
                    INNER JOIN cEstado e ON e.id_estado = p.estado_id;", oConexion))
            {
                try
                {
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
                    }
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    lista = new List<CE_Proveedor>();
                }
            }
            return lista;
        }
        public int Crear(CE_Proveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            int idProveedorCreado = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_crearProveedor", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@razonSocial", oProveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@observacion", oProveedor.Observacion);
                cmd.Parameters.AddWithValue("@telefono", oProveedor.Telefono);
                cmd.Parameters.AddWithValue("@correo", oProveedor.Correo);
                cmd.Parameters.Add("@idProveedorCreado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                    idProveedorCreado = Convert.ToInt32(cmd.Parameters["@idProveedorCreado"].Value);
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    idProveedorCreado = 0;
                }
            }
            return idProveedorCreado;
        }
        public bool Actualizar(CE_Proveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_actualizarProveedor", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_proveedor", oProveedor.Id);
                cmd.Parameters.AddWithValue("@razonSocial", oProveedor.RazonSocial);
                cmd.Parameters.AddWithValue("@observacion", oProveedor.Observacion);
                cmd.Parameters.AddWithValue("@telefono", oProveedor.Telefono);
                cmd.Parameters.AddWithValue("@correo", oProveedor.Correo);
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
        public bool Eliminar(CE_Proveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_eliminarProveedor", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_proveedor", oProveedor.Id);
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