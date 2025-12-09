using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Venta
    {
        public List<CE_Venta> Listar()
        {
            return new List<CE_Venta>();
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
