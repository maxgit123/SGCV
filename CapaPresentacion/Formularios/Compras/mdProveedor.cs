using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Compras
{
    public partial class mdProveedor : Form
    {
        public CE_Proveedor Proveedor { get; set; }
        public mdProveedor()
        {
            InitializeComponent();
        }
        private void mdProveedor_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvProveedores.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;

            List<CE_Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (CE_Proveedor item in listaProveedor)
            {
                dgvProveedores.Rows.Add(new object[] {
                    item.Id,
                    item.RazonSocial
                });
            }
        }
        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex <0 || e.ColumnIndex <0)
                return;

            Proveedor = new CE_Proveedor()
            {
                Id = Convert.ToInt32(dgvProveedores.Rows[e.RowIndex].Cells["ID_Proveedor"].Value.ToString()),
                RazonSocial = dgvProveedores.Rows[e.RowIndex].Cells["RazonSocial"].Value.ToString()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvProveedores.Rows.Count < 0)
                return;

            //e.KeyCode != Keys.Enter || 

            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            foreach (DataGridViewRow row in dgvProveedores.Rows) //Recorre cada fila que encuentre en dgvProveedores.
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
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
