using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<CE_Categoria> Listar()
        {
            var lista = new List<CE_Categoria>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using(SqlCommand cmd = new SqlCommand(
                @"SELECT c.id_categoria, c.nombre, c.fechaCreacion,
                a.id_alicuotaIVA, a.porcentaje,
                e.id_estado, e.nombre AS [estado]
                FROM Categoria c
                INNER JOIN cAlicuotaIVA a ON a.id_alicuotaIVA = c.alicuotaIVA_id
                INNER JOIN cEstado e ON e.id_estado = c.estado_id
                WHERE c.estado_id = 1;", oConexion))
            {
                try
                {
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Categoria()
                            {
                                Id = Convert.ToInt32(reader["id_categoria"]),
                                Nombre = reader["nombre"].ToString(),
                                FechaCreacion = reader["fechaCreacion"].ToString(),
                                oAlicuotaIVA = new CE_AlicuotaIVA()
                                {
                                    Id = Convert.ToInt32(reader["id_alicuotaIVA"]),
                                    Porcentaje = Convert.ToDecimal(reader["porcentaje"])
                                },
                                oEstado = new CE_Estado()
                                {
                                    Id = Convert.ToBoolean(reader["id_estado"]),
                                    Nombre = reader["estado"].ToString(),
                                }
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    //mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    lista = new List<CE_Categoria>();
                }
            }
            return lista;
        }
        public int Crear(CE_Categoria oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            int idCategoriaCreada = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_crearCategoria", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", oCategoria.Nombre);
                cmd.Parameters.AddWithValue("@alicuotaIVA_id", oCategoria.oAlicuotaIVA.Id);
                cmd.Parameters.Add("@idCategoriaCreada", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    idCategoriaCreada = Convert.ToInt32(cmd.Parameters["@idCategoriaCreada"].Value);
                    mensaje = cmd.Parameters["@mensaje"].Value.ToString();
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    idCategoriaCreada = 0;
                }
            }
            return idCategoriaCreada;
        }
        public bool Actualizar(CE_Categoria oCategoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_actualizarCategoria", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_categoria", oCategoria.Id);
                cmd.Parameters.AddWithValue("@nombre", oCategoria.Nombre);
                cmd.Parameters.AddWithValue("@alicuotaIVA_id", oCategoria.oAlicuotaIVA.Id);
                cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
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
        public bool Eliminar(CE_Categoria oCategoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_eliminarCategoria", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_categoria", oCategoria.Id);
                cmd.Parameters.Add("@respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
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
