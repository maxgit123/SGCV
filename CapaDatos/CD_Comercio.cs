using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Comercio
    {
        public CE_Comercio Leer()
        {
            var oComercio = new CE_Comercio();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT c.id_comercio, c.razonSocial, c.cuit, c.ingresosBrutos, c.inicioActividad, c.puntoVenta, c.telefono, c.correo, c.fechaActualizacion,
                    d.id_direccion, d.calle, d.numero,
                    l.id_localidad, l.nombre AS localidad_nombre, l.codigoPostal,
                    p.id_provincia, p.nombre AS provincia_nombre,
                    r.id_responsableIVA, r.nombre AS respIVA_nombre
                    FROM Comercio c
                    INNER JOIN Direccion d ON d.id_direccion = c.direccion_id
                    INNER JOIN Localidad l ON l.id_localidad = c.localidad_id
                    INNER JOIN cProvincia p ON p.id_provincia = c.provincia_id
                    INNER JOIN cResponsableIVA r ON r.id_responsableIVA = c.responsableIVA_id;", oConexion))
            {
                try
                {
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            oComercio = new CE_Comercio()
                            {
                                Id = Convert.ToInt32(reader["id_comercio"]),
                                RazonSocial = reader["razonSocial"].ToString(),
                                Cuit = reader["cuit"].ToString(),
                                IngresosBrutos = reader["ingresosBrutos"].ToString(),
                                InicioActividad = Convert.ToDateTime(reader["inicioActividad"]),
                                PuntoVenta = Convert.ToInt32(reader["puntoVenta"]),
                                Telefono = reader["telefono"].ToString(),
                                Correo = reader["correo"].ToString(),
                                FechaActualizacion = Convert.ToDateTime(reader["fechaActualizacion"]),
                                oDireccion = new CE_Direccion()
                                {
                                    Id = Convert.ToInt32(reader["id_direccion"]),
                                    Calle = reader["calle"].ToString(),
                                    Numero = reader["numero"].ToString()
                                },
                                oLocalidad = new CE_Localidad()
                                {
                                    Id = Convert.ToInt32(reader["id_localidad"]),
                                    Nombre = reader["localidad_nombre"].ToString(),
                                    CodigoPostal = reader["codigoPostal"].ToString(),
                                },
                                oProvincia = new CE_Provincia()
                                {
                                    Id = Convert.ToInt32(reader["id_provincia"]),
                                    Nombre = reader["provincia_nombre"].ToString()
                                },
                                oResponsableIVA = new CE_ResponsableIVA()
                                {
                                    Id = Convert.ToInt32(reader["id_responsableIVA"]),
                                    Nombre = reader["respIVA_nombre"].ToString()
                                }
                            };
                        }
                    }
                }
                catch (SqlException)
                {
                    //mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    oComercio = new CE_Comercio();
                }
                return oComercio;
            }
        }
        public bool Actualizar(CE_Comercio oComercio, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = false;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("usp_actualizarComercio", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // ------ Comercio ------
                cmd.Parameters.AddWithValue("@razonSocial", oComercio.RazonSocial);
                cmd.Parameters.AddWithValue("@cuit", oComercio.Cuit);
                cmd.Parameters.AddWithValue("@ingresosBrutos", oComercio.IngresosBrutos);
                cmd.Parameters.AddWithValue("@inicioActividad", oComercio.InicioActividad);
                cmd.Parameters.AddWithValue("@puntoVenta", oComercio.PuntoVenta);
                cmd.Parameters.AddWithValue("@telefono", oComercio.Telefono);
                cmd.Parameters.AddWithValue("@correo", oComercio.Correo);
                cmd.Parameters.AddWithValue("@direccion_id", oComercio.oDireccion.Id);
                cmd.Parameters.AddWithValue("@localidad_id", oComercio.oLocalidad.Id);
                cmd.Parameters.AddWithValue("@provincia_id", oComercio.oProvincia.Id);
                cmd.Parameters.AddWithValue("@responsableIVA_id", oComercio.oResponsableIVA.Id);
                cmd.Parameters.AddWithValue("@id_Comercio", oComercio.Id);
                // ------ Direccion ------
                cmd.Parameters.AddWithValue("@calle", oComercio.oDireccion.Calle);
                cmd.Parameters.AddWithValue("@numero", oComercio.oDireccion.Numero);
                // ------ Localidad ------
                cmd.Parameters.AddWithValue("@nombre", oComercio.oLocalidad.Nombre);
                cmd.Parameters.AddWithValue("@codigoPostal", oComercio.oLocalidad.CodigoPostal);
                // ------ Salidas ------
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
                }
            }
            return respuesta;
        }
        public byte[] LeerLogo(out bool logoLeido)
        {
            logoLeido = false;
            byte[] logoBytes = Array.Empty<byte>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand("SELECT logo FROM Comercio WHERE id_comercio = 1;", oConexion))
            {
                try
                {
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() && reader["logo"] != DBNull.Value)
                        {
                            //logoBytes = reader["logo"] != DBNull.Value ? (byte[])reader["logo"] : new byte[0];
                            logoBytes = (byte[])reader["Logo"];
                            logoLeido = true;
                            // La BD lo va a guardar distinto a ese array
                            // por eso la conversion a byte, pero de un formato de codigo
                            // no uno de base de datos.
                        }
                    }
                }
                catch (SqlException)
                {
                    //mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                }
            }
            return logoBytes;
        }
        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(
                @"UPDATE Comercio SET logo = @imagen
                WHERE id_comercio = 1;", oConexion))
            {
                cmd.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = imagen ?? Array.Empty<byte>();
                
                try
                {
                    oConexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas < 1)
                    {
                        mensaje = "No se pudo actualizar el logo.";
                        return false;
                    }

                    return true;
                }
                catch (SqlException ex)
                {
                    mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    return false;
                }
            }
        }
    }
}