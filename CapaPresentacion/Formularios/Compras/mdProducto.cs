using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Compras
{
    public partial class mdProducto : Form
    {
        public CE_Producto Producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }
        private void mdProducto_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;

            List<CE_Producto> listaProducto = new CN_Producto().Listar();

            foreach (CE_Producto item in listaProducto)
            {
                dgvProductos.Rows.Add(new object[] {
                    item.Id,
                    item.Codigo,
                    item.Descripcion,
                    item.Costo,
                    item.Precio,
                    item.Stock,
                    item.oCategoria.Nombre,
                });
            }
        }
        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            Producto = new CE_Producto()
            {
                Id = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ID_Producto"].Value.ToString()),
                //Codigo = dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString(),
                Descripcion = dgvProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString(),
                Costo = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["Costo"].Value.ToString()),
                Precio = Convert.ToDecimal(dgvProductos.Rows[e.RowIndex].Cells["Precio"].Value.ToString()),
                Stock = Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["Stock"].Value.ToString()),
                /*
                oCategoria = new CE_Categoria()
                {
                    Nombre = dgvProductos.Rows[e.RowIndex].Cells["Categoria"].Value.ToString()
                }
                */
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                    //Se hace el filtro por la columnaFiltro si contiene lo que se encuentra en txtBuscar.
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
