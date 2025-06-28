using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdProducto : Form
    {
        public CE_Producto Producto { get; set; }
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
        public mdProducto()
        {
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Size = new Size(466, 327);
            InitializeComponent();
        }
        private void mdProducto_Load(object sender, EventArgs e)
        {
            UtilidadesDGV.Configurar(dgvProductos);
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvProductos, NombreColumna.CODIGO);
            ListarProductosEnDGV();
        }
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var fila = dgvProductos.Rows[e.RowIndex];

            Producto = new CE_Producto()
            {
                Id = Convert.ToInt32(fila.Cells[NombreColumna.ID_PRODUCTO].Value),
                Codigo = fila.Cells[NombreColumna.CODIGO].Value.ToString(), // TODO: agregar en diseñador
                Descripcion = fila.Cells[NombreColumna.DESCRIPCION].Value.ToString(),
                Costo = Convert.ToDecimal(fila.Cells[NombreColumna.COSTO].Value),
                Precio = Convert.ToDecimal(fila.Cells[NombreColumna.PRECIO].Value),
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
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvProductos, txtBuscar);
        }
        private void ListarProductosEnDGV()
        {
            dgvProductos.Rows.Clear();
            List<CE_Producto> listaProducto = new CN_Producto().Listar();

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
                    item.Costo,
                    item.Precio,
                    item.Stock,
                    item.oCategoria.Nombre
                });
            }
        }
    }
}
