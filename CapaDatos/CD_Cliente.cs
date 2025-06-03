using System;
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
            var lista = new List<CE_Cliente>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT c.id_cliente, c.documento, c.nombre, c.apellido, c.telefono, c.correo, c.fechaCreacion,
                    r.id_responsableIVA, r.nombre AS responsableIVA,
                    e.id_estado, e.nombre AS estado
                    FROM Cliente c
                    INNER JOIN cResponsableIVA r ON r.id_responsableIVA = c.responsableIVA_id
                    INNER JOIN cEstado e ON e.id_estado = c.estado_id;", oConexion))
            {
                try
                {
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
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    lista = new List<CE_Cliente>();
                }
            }
            return lista;
        }
        public int Crear(CE_Cliente oCliente, out string mensaje)
        {
            int idClienteCreado = 0;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_crearCliente", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@documento", oCliente.Documento);
                cmd.Parameters.AddWithValue("@nombre", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oCliente.Apellido);
                cmd.Parameters.AddWithValue("@telefono", oCliente.Telefono);
                cmd.Parameters.AddWithValue("@correo", oCliente.Correo);
                cmd.Parameters.AddWithValue("@responsableIVA_id", oCliente.oRespIVA.Id);
                cmd.Parameters.Add("@idClienteCreado", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    idClienteCreado = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    idClienteCreado = 0;
                }
            }
            return idClienteCreado;
        }
        public bool Actualizar(CE_Cliente oCliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_actualizarCliente", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_cliente", oCliente.Id);
                cmd.Parameters.AddWithValue("@documento", oCliente.Documento);
                cmd.Parameters.AddWithValue("@nombre", oCliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", oCliente.Apellido);
                cmd.Parameters.AddWithValue("@telefono", oCliente.Telefono);
                cmd.Parameters.AddWithValue("@correo", oCliente.Correo);
                cmd.Parameters.AddWithValue("@responsableIVA_id", oCliente.oRespIVA.Id);
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
        public bool Eliminar(CE_Cliente oCliente, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_eliminarCliente", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", oCliente.Id);
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
