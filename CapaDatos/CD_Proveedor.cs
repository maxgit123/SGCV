using System;
using System.Collections.Generic;
using System.Text;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_Proveedor
    {
        public List<CE_Proveedor> Listar()
        {
            List<CE_Proveedor> lista = new List<CE_Proveedor>();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT p.ID_Proveedor,p.RazonSocial,c.ID_Contacto,c.Telefono,c.Correo FROM PROVEEDOR p");
                    query.AppendLine("INNER JOIN CONTACTO c on c.ID_Contacto = p.ID_Contacto");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Proveedor()
                            {
                                IdProveedor = Convert.ToInt32(reader["ID_Proveedor"]),
                                RazonSocial = reader["RazonSocial"].ToString(),
                                oContacto = new CE_Contacto()
                                {
                                    IdContacto = Convert.ToInt32(reader["ID_Contacto"]),
                                    Telefono = reader["Telefono"].ToString(),
                                    Correo = reader["Correo"].ToString()
                                }
                            });
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    lista = new List<CE_Proveedor>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
        public int Crear(CE_Proveedor oProveedor, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO PROVEEDOR (RazonSocial,ID_Contacto");
                    query.AppendLine("VALUES (@RazonSocial,@ID_Contacto");
                    query.AppendLine("SELECT last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@RazonSocial", oProveedor.RazonSocial));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Contacto", oProveedor.oContacto.IdContacto));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID del usuario.
                    cmd.Parameters.Clear();
                }
                catch (SQLiteException ex)
                {
                    respuesta = 0;
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
        public bool Actualizar(CE_Proveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE PROVEEDOR SET "
                                     + "RazonSocial = @RazonSocial, "
                                     + "ID_Contacto = @ID_Contacto "
                                     + "WHERE ID_Proveedor = @ID_Proveedor");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SQLiteParameter("@RazonSocial", oProveedor.RazonSocial));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Contacto", oProveedor.oContacto.IdContacto));
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Proveedor", oProveedor.IdProveedor));

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
        public bool Eliminar(CE_Proveedor oProveedor, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM PROVEEDOR WHERE ID_Proveedor = @ID_Proveedor;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.Parameters.Add(new SQLiteParameter("@ID_Proveedor", oProveedor.IdProveedor));
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
    }
}
