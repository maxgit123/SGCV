using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdProveedor : Form
    {
        public CE_Proveedor Proveedor { get; set; }
        private static class NombreColumna
        {
            public const string ID_PROVEEDOR = "id_proveedor";
            public const string RAZON_SOCIAL = "razonSocial";
            public const string OBSERVACION = "observacion";
        }
        public mdProveedor()
        {
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Size = new Size(466, 327);
            InitializeComponent();
        }
        private void mdProveedor_Load(object sender, EventArgs e)
        {
            UtilidadesDGV.Configurar(dgvProveedores);
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvProveedores, NombreColumna.RAZON_SOCIAL);
            ListarProveedoresEnDGV();
        }
        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex <0 || e.ColumnIndex <0) return;

            var fila = dgvProveedores.Rows[e.RowIndex];

            Proveedor = new CE_Proveedor()
            {
                Id = Convert.ToInt32(fila.Cells[NombreColumna.ID_PROVEEDOR].Value),
                RazonSocial = fila.Cells[NombreColumna.RAZON_SOCIAL].Value.ToString(),
                Observacion = fila.Cells[NombreColumna.OBSERVACION].Value.ToString()
            };

            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvProveedores, cbBuscar, txtBuscar.Text);
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvProveedores, txtBuscar);
        }
        private void ListarProveedoresEnDGV()
        {
            dgvProveedores.Rows.Clear();
            List<CE_Proveedor> listaProveedor = new CN_Proveedor().Listar(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al listar proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (CE_Proveedor item in listaProveedor)
            {
                dgvProveedores.Rows.Add(new object[] {
                    item.Id,
                    item.RazonSocial,
                    item.Observacion
                });
            }
        }

    }
}
