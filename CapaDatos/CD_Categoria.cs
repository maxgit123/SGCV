using System;
using System.Collections.Generic;
using System.Text;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Categoria
    {
        public List<CE_Categoria> Listar()
        {
            List<CE_Categoria> lista = new List<CE_Categoria>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("SELECT c.id,c.nombre,c.alicuotaIVA_id,a.porcentaje,c.estado_id,e.nombre AS [estado] FROM Categoria c");
                    query.AppendLine("INNER JOIN cAlicuotaIVA a ON a.id = c.alicuotaIVA_id");
                    query.AppendLine("INNER JOIN cEstado e ON e.id = c.estado_id");
                    query.AppendLine("WHERE c.estado_id = 1;");

                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion)
                    { CommandType = CommandType.Text };

                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Categoria()
                            {
                                Id = Convert.ToInt32(reader["id"]),
                                Nombre = reader["nombre"].ToString(),
                                oAlicuotaIVA = new CE_AlicuotaIVA()
                                {
                                    Id = Convert.ToInt32(reader["id"]),
                                    Porcentaje = Convert.ToDecimal(reader["porcentaje"])
                                },
                                oEstado = new CE_Estado()
                                {
                                    Id = Convert.ToBoolean(reader["id"]),
                                    Nombre = reader["nombre"].ToString(),
                                }
                            });
                        }
                    }
                }
                catch (SqlException ex)
                {
                    lista = new List<CE_Categoria>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
        public int Crear(CE_Categoria oCategoria, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("INSERT INTO CATEGORIA (NomCategoria,ID_AlicuotaIVA)" +
                        "VALUES (@NomCategoria,@ID_AlicuotaIVA);");
                    query.AppendLine("SELECT last_insert_rowid();");
                    //last_insert_rowid retorna el ultimo row id que se inserto.
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@NomCategoria", oCategoria.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@ID_AlicuotaIVA", oCategoria.oAlicuotaIVA.Id));
                    cmd.CommandType = CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    //ExecuteScalar devuelve la 1ra columna de la 1ra fila. En este caso el ID.
                    cmd.Parameters.Clear();
                }
                catch (SqlException ex)
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
        public bool Actualizar(CE_Categoria oCategoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = string.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("UPDATE CATEGORIA SET "
                                     + "NomCategoria = @NomCategoria, "
                                     + "ID_AlicuotaIVA = @ID_AlicuotaIVA "
                                     + "WHERE ID_Categoria = @ID_Categoria");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);

                    cmd.Parameters.Add(new SqlParameter("@NomCategoria", oCategoria.Nombre));
                    cmd.Parameters.Add(new SqlParameter("@ID_AlicuotaIVA", oCategoria.oAlicuotaIVA.Id));
                    cmd.Parameters.Add(new SqlParameter("@ID_Categoria", oCategoria.Id));
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
        public bool Eliminar(CE_Categoria oCategoria, out string mensaje)
        {
            bool respuesta = false;
            mensaje = String.Empty;

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            {
                try
                {
                    oConexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("DELETE FROM CATEGORIA WHERE ID_Categoria = @ID_Categoria;");
                    SqlCommand cmd = new SqlCommand(query.ToString(), oConexion);
                    cmd.Parameters.Add(new SqlParameter("@ID_Categoria", oCategoria.Id));
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
    }
}
