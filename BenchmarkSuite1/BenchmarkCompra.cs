using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VSDiagnostics;

namespace CapaDatos
{
    [CPUUsageDiagnoser]
    public class BenchmarkCompra
    {
        private DataTable compraDetalle;
        private const string ConnectionString = @"Server=.;Database=SGCV;User Id=admin;Password=1234;";
        private const int TestUsuarioId = 1;
        private const int TestProveedorId = 1;
        private const decimal TestTotal = 1000.00m;
        [GlobalSetup]
        public void Setup()
        {
            // Crear tabla de detalle de compra con datos de prueba
            compraDetalle = new DataTable();
            compraDetalle.Columns.Add("id_producto", typeof(int));
            compraDetalle.Columns.Add("precioCompraUnitario", typeof(decimal));
            compraDetalle.Columns.Add("cantidad", typeof(int));
            compraDetalle.Columns.Add("subtotal", typeof(decimal));
            // Agregar 5 productos de prueba
            for (int i = 1; i <= 5; i++)
            {
                compraDetalle.Rows.Add(new object[] { i, 100.00m, 10, 1000.00m });
            }
        }

        [Benchmark]
        public void CrearCompra()
        {
            using (SqlConnection oConexion = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand("usp_crearCompra", oConexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@usuario_id", TestUsuarioId);
                cmd.Parameters.AddWithValue("@proveedor_id", TestProveedorId);
                cmd.Parameters.AddWithValue("@total", TestTotal);
                cmd.Parameters.AddWithValue("@fechaPedido", DateTime.Now);
                cmd.Parameters.AddWithValue("@fechaEntrega", DateTime.Now.AddDays(5));
                cmd.Parameters.AddWithValue("@compraDetalle", compraDetalle);
                cmd.Parameters.Add("@respuesta", SqlDbType.Bit).Direction = ParameterDirection.Output;
                cmd.Parameters.Add("@mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                oConexion.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}