using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;
//Lo que agregue:
using CapaEntidad;
using System.Data;
using System.Data.SQLite;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<CE_Modulo> Listar(int idUsuario)
        {
            List<CE_Modulo> lista = new List<CE_Modulo>();
            using (SQLiteConnection oConexion = new SQLiteConnection(Conexion.cadenaDB))
            {
                try
                {
                    StringBuilder query = new StringBuilder(); //De esta manera se puede poner mas de una linea.
                    query.AppendLine("SELECT p.ID_Rol, p.NomMenu FROM PERMISO p");
                    query.AppendLine("INNER JOIN ROL r on r.ID_Rol = p.ID_Rol");
                    query.AppendLine("INNER JOIN USUARIO u on u.ID_Rol = r.ID_Rol");
                    query.AppendLine("WHERE u.ID_Usuario = @ID_Usuario");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), oConexion);
                    cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                    cmd.CommandType = CommandType.Text;
                    oConexion.Open();

                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_Modulo()
                            {
                                oRol = new CE_Rol() { IdRol = Convert.ToInt32( reader ["ID_Rol"])},
                                Nombre = reader["NomMenu"].ToString(),
                            });
                        }
                    }
                }
                catch (SQLiteException ex)
                {
                    lista = new List<CE_Modulo>();
                }
                finally
                {
                    if (oConexion != null && oConexion.State != ConnectionState.Closed)
                        oConexion.Close();
                }
            }
            return lista;
        }
    }
}
