using System;
using System.Text;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_Comercio
    {
        public CE_Comercio Leer()
        {
            CE_Comercio oComercio = new CE_Comercio();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.ID_Comercio,c.RazonSocial,c.Cuit,c.IngBrutos,c.InicioAct,c.PuntoVenta,");
                    query.AppendLine("r.ID_RespIVA,r.ResponsableIVA,d.ID_Direccion,d.NomCalle,d.NumCalle,");
                    query.AppendLine("l.ID_LocCP,l.NomLocalidad,p.ID_Provincia,p.NomProvincia,o.ID_Contacto,o.Telefono,o.Correo FROM COMERCIO c");
                    query.AppendLine("INNER JOIN RESP_IVA r ON r.ID_RespIVA = c.ID_RespIVA");
                    query.AppendLine("INNER JOIN DIRECCION d ON d.ID_Direccion = c.ID_Direccion");
                    query.AppendLine("INNER JOIN LOCALIDAD l ON l.ID_LocCP = c.ID_LocCP");
                    query.AppendLine("INNER JOIN PROVINCIA p ON p.ID_Provincia = c.ID_Provincia");
                    query.AppendLine("INNER JOIN CONTACTO o ON o.ID_Contacto = c.ID_Contacto;");
                  
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            oComercio = new CE_Comercio()
                            {
                                IdComercio = Convert.ToInt32(reader["ID_Comercio"]),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                Cuit = reader["Cuit"].ToString(),
                                IngBrutos = reader["IngBrutos"].ToString(),
                                InicioAct = reader["InicioAct"].ToString(),
                                PuntoVenta = Convert.ToInt32(reader["PuntoVenta"]),
                                oRespIVA = new CE_RespIVA()
                                {
                                    IdRespIVA = Convert.ToInt32(reader["ID_RespIVA"]),
                                    ResponsableIVA = reader["ResponsableIVA"].ToString(),
                                },
                                oDireccion = new CE_Direccion()
                                {
                                    IdDireccion = Convert.ToInt32(reader["ID_Direccion"]),
                                    Calle = reader["NomCalle"].ToString(),
                                    Numero = reader["NumCalle"].ToString(),
                                },
                                oLocalidad = new CE_Localidad()
                                {
                                    IdLocalidad = Convert.ToInt32(reader["ID_LocCP"]),
                                    NomLocalidad = reader["NomLocalidad"].ToString(),
                                },
                                oProvincia = new CE_Provincia()
                                {
                                    IdProvincia = Convert.ToInt32(reader["ID_Provincia"]),
                                    NomProvincia = reader["NomProvincia"].ToString(),
                                },
                                oContacto = new CE_Contacto()
                                {
                                    IdContacto = Convert.ToInt32(reader["ID_Contacto"]),
                                    Telefono = reader["Telefono"].ToString(),
                                    Correo = reader["Correo"].ToString(),
                                }
                            };
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    oComercio = new CE_Comercio(); //Si hay un error lo retorna vacio.
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

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
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
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@RazonSocial", oComercio.RazonSocial));
                    cmd.Parameters.Add(new SQLiteParameter("@Cuit", oComercio.Cuit));
                    cmd.Parameters.Add(new SQLiteParameter("@IngBrutos", oComercio.IngBrutos));
                    cmd.Parameters.Add(new SQLiteParameter("@InicioAct", oComercio.InicioAct));
                    cmd.Parameters.Add(new SQLiteParameter("@PuntoVenta", oComercio.PuntoVenta));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Direccion", oComercio.oDireccion.IdDireccion));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_LocCP", oComercio.oLocalidad.IdLocalidad));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Provincia", oComercio.oProvincia.IdProvincia));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Contacto", oComercio.oContacto.IdContacto));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Comercio", oComercio.IdComercio));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    cmd.Parameters.Clear();
                }
                catch (SQLiteException ex)
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
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    string query = "SELECT Logo FROM COMERCIO WHERE ID_Comercio = 1;";
                    SQLiteCommand cmd = new SQLiteCommand(query, oConexion);
                    cmd.CommandType = CommandType.Text;

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
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
                catch (SQLiteException ex)
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
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    string query = "UPDATE COMERCIO SET Logo = @imagen WHERE ID_Comercio = 1;";
                    SQLiteCommand cmd = new SQLiteCommand(query, oConexion);
                    SQLiteParameter parameter = new SQLiteParameter("@imagen", DbType.Binary);
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
                catch (SQLiteException ex)
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
