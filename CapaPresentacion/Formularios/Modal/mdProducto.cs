using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Base;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdProducto : MaterialModalBase
    {
        public CE_Producto _producto { get; set; }
        private bool _requerirStock = true;
        private static class NombreColumna
        {
            public const string ID_PRODUCTO = "id_producto";
            public const string CODIGO = "codigo";
            public const string DESCRIPCION = "descripcion";
            public const string COSTO = "costo";
            public const string PRECIO = "precio";
            public const string STOCK = "stock";
            public const string CATEGORIA = "categoria";
        }

        public mdProducto(bool requerirStock = true)
        {
            InitializeComponent();
            _requerirStock = requerirStock;
            UtilidadesDGV.Configurar(dgvProductos);
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvProductos, NombreColumna.CODIGO);
            ListarProductosEnDGV();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var fila = dgvProductos.Rows[e.RowIndex];

            _producto = new CE_Producto()
            {
                Id = Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value),
                Codigo = fila.Cells[NombreColumna.CODIGO].Value.ToString(),
                Descripcion = fila.Cells[NombreColumna.DESCRIPCION].Value.ToString(),
                PrecioCompra = Convert.ToDecimal(fila.Cells[NombreColumna.COSTO].Value),
                PrecioVenta = Convert.ToDecimal(fila.Cells[NombreColumna.PRECIO].Value),
                Stock = Convert.ToInt32(fila.Cells[NombreColumna.STOCK].Value),
                //oCategoria = new CE_Categoria()
                //{
                //    Nombre = fila.Cells[NombreColumna.CATEGORIA].Value.ToString()
                //}
            };

            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvProductos, cbBuscar, txtBuscar.Text);
        }
        private void txtBuscar_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvProductos, txtBuscar);
        }

        private void ListarProductosEnDGV()
        {
            dgvProductos.Rows.Clear();
            List<CE_Producto> listaProducto = new CN_Producto().Listar(soloActivos: true, soloConStock: _requerirStock);

            // TODO: mensaje de error si listaProducto es null o vacía
            //if (!string.IsNullOrEmpty(mensaje))
            //{
            //    MessageBox.Show(mensaje, "Error al listar productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    return;
            //}

            foreach (CE_Producto item in listaProducto)
            {
                dgvProductos.Rows.Add(new object[] {
                    item.Id,
                    item.Codigo,
                    item.Descripcion,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    item.Stock,
                    item.oCategoria.Nombre
                });
            }
        }
    }
}
