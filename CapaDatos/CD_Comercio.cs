using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_Comercio
    {
        public CE_Comercio Leer()
        {
            CE_Comercio oComercio = new CE_Comercio();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.id,c.razonSocial,c.cuit,c.ingresosBrutos,c.inicioActividad,c.puntoVenta,c.telefono,c.correo,c.fechaActualizacion,");
                    query.AppendLine("d.id,d.calle,d.numero,l.id,l.nombre,p.id,p.nombre FROM Comercio c");
                    query.AppendLine("INNER JOIN Direccion d ON d.id = c.direccion_id");
                    query.AppendLine("INNER JOIN Localidad l ON l.id = c.localidad_id");
                    query.AppendLine("INNER JOIN cProvincia p ON p.id = c.provincia_id");
                    query.AppendLine("INNER JOIN cResponsableIVA r ON r.id = c.responsableIVA_id;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            oComercio = new CE_Comercio()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                RazonSocial = reader["razonSocial"].ToString(),
                                Cuit = reader["cuit"].ToString(),
                                IngBrutos = reader["ingresosBrutos"].ToString(),
                                InicioAct = reader["inicioActividad"].ToString(),
                                PuntoVenta = Convert.ToInt32(reader["puntoVenta"]),
                                Telefono = reader["telefono"].ToString(),
                                Correo = reader["correo"].ToString(),
                                FechaActualizacion = reader["fechaActualizacion"].ToString(),
                                oDireccion = new CE_Direccion()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Calle = reader["calle"].ToString(),
                                    Numero = reader["numero"].ToString()
                                },
                                oLocalidad = new CE_Localidad()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nombre = reader["nombre"].ToString()
                                },
                                oProvincia = new CE_Provincia()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nombre = reader["Nombre"].ToString()
                                },
                                oResponsableIVA = new CE_ResponsableIVA()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Nombre = reader["ResponsableIVA"].ToString()
                                }
                            };
                        }
                        reader.Close();
                    }
                }
                catch (SqlException ex)
                {
                    oComercio = new CE_Comercio();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
                return oComercio;
            }
        }
        public bool Actualizar(CE_Comercio oComercio, out string mensaje)
        {
            bool respuesta = true;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE COMERCIO SET "
                                     + "RazonSocial = @RazonSocial, "
                                     + "Cuit = @Cuit, "
                                     + "IngBrutos = @IngBrutos, "
                                     + "InicioAct = @InicioAct, "
                                     + "PuntoVenta = @PuntoVenta, "
                                     + "ID_Direccion = @ID_Direccion, "
                                     + "ID_LocCP = @ID_LocCP, "
                                     + "ID_Provincia = @ID_Provincia, "
                                     + "ID_Contacto = @ID_Contacto "
                                     + "WHERE ID_Comercio = @ID_Comercio");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@RazonSocial", oComercio.RazonSocial));
                    cmd.Parameters.Add(new SqlParameter("@Cuit", oComercio.Cuit));
                    cmd.Parameters.Add(new SqlParameter("@IngBrutos", oComercio.IngBrutos));
                    cmd.Parameters.Add(new SqlParameter("@InicioAct", oComercio.InicioAct));
                    cmd.Parameters.Add(new SqlParameter("@PuntoVenta", oComercio.PuntoVenta));
                    cmd.Parameters.Add(new SqlParameter("@ID_Direccion", oComercio.oDireccion.Id));
                    cmd.Parameters.Add(new SqlParameter("@ID_LocCP", oComercio.oLocalidad.Id));
                    cmd.Parameters.Add(new SqlParameter("@ID_Provincia", oComercio.oProvincia.Id));
                    cmd.Parameters.Add(new SqlParameter("@ID_Comercio", oComercio.Id));
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
        public byte[] LeerLogo(out bool leido)
        {
            leido = true;
            byte[] LogoBytes = new byte[0];
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    string query = "SELECT Logo FROM COMERCIO WHERE ID_Comercio = 1;";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            LogoBytes = (byte[])reader["Logo"];
                            //La BD lo va a guardar distinto a ese array
                            //por eso la conversion a byte, pero de un formato de codigo
                            //no uno de base de datos.
                        }
                    }

                }
                catch (SqlException ex)
                {
                    leido = false;
                    LogoBytes = new byte[0];
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return LogoBytes;
        }
        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    string query = "UPDATE COMERCIO SET Logo = @imagen WHERE ID_Comercio = 1;";
                    SqlCommand cmd = new SqlCommand(query, oConexion);
                    SqlParameter parameter = new SqlParameter("@imagen", DbType.Binary);
                    parameter.Value = imagen;
                    cmd.Parameters.Add(parameter);
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());

                    if (cmd.ExecuteNonQuery() < 1) //Si no actualizo ninguna fila:
                    {
                        respuesta = false;
                        mensaje = "No se pudo actualizar el logo.";
                    }

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
