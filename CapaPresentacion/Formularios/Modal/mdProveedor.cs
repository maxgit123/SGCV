using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Base;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdProveedor : MaterialModalBase
    {
        public CE_Proveedor _proveedor { get; set; }
        private static class NombreColumna
        {
            public const string ID_PROVEEDOR = "id_proveedor";
            public const string RAZON_SOCIAL = "razonSocial";
            public const string OBSERVACION = "observacion";
        }

        public mdProveedor()
        {
            InitializeComponent();
            UtilidadesDGV.Configurar(dgvProveedores);
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvProveedores, NombreColumna.RAZON_SOCIAL);
            ListarProveedoresEnDGV();
        }
        private void dgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var fila = dgvProveedores.Rows[e.RowIndex];

            _proveedor = new CE_Proveedor()
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
        private void txtBuscar_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvProveedores, txtBuscar);
        }

        private void ListarProveedoresEnDGV()
        {
            dgvProveedores.Rows.Clear();
            List<CE_Proveedor> listaProveedores = new CN_Proveedor().Listar(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al listar proveedores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (CE_Proveedor item in listaProveedores)
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
