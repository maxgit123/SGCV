using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class CD_ResponsableIVA
    {
        public List<CE_ResponsableIVA> Listar()
        {
            var lista = new List<CE_ResponsableIVA>();

            using (SqlConnection oConexion = new SqlConnection(Conexion.cadenaDB))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT id_responsableIVA, codigo, nombre
                FROM cResponsableIVA
                WHERE estado_id = 1;", oConexion))
            {
                try
                {
                    oConexion.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new CE_ResponsableIVA()
                            {
                                Id = Convert.ToInt32(reader["id_responsableIVA"]),
                                Codigo = Convert.ToInt32(reader["codigo"]),
                                Nombre = reader["nombre"].ToString(),
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    //mensaje = $"Código de error: {ex.ErrorCode}\n{ex.Message}";
                    lista = new List<CE_ResponsableIVA>();
                }
            }
            return lista;
        }
    }
}