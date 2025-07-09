using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Compra
    {
        public List<CE_Compra> Listar()
        {
            return new List<CE_Compra>();
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

