using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Base;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdCliente : MaterialModalBase
    {
        public CE_Cliente _cliente { get; set; }
        private static class NombreColumna
        {
            public const string ID_CLIENTE = "id_cliente";
            public const string DOCUMENTO = "documento";
            public const string NOMBRE = "nombre";
            public const string APELLIDO = "apellido";
        }

        public mdCliente()
        {
            InitializeComponent();
            UtilidadesDGV.Configurar(dgvClientes);
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvClientes, NombreColumna.DOCUMENTO);
            ListarClientesEnDGV();
        }
        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            var fila = dgvClientes.Rows[e.RowIndex];

            _cliente = new CE_Cliente()
            {
                Id = Convert.ToInt32(fila.Cells[NombreColumna.ID_CLIENTE].Value),
                Documento = fila.Cells[NombreColumna.DOCUMENTO].Value.ToString(),
                Nombre = fila.Cells[NombreColumna.NOMBRE].Value.ToString(),
                Apellido = fila.Cells[NombreColumna.APELLIDO].Value.ToString()
            };

            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvClientes, cbBuscar, txtBuscar.Text);
        }
        private void txtBuscar_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvClientes, txtBuscar);
        }

        private void ListarClientesEnDGV()
        {
            dgvClientes.Rows.Clear();
            List<CE_Cliente> listaClientes = new CN_Cliente().Listar(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al listar clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (CE_Cliente cliente in listaClientes)
            {
                dgvClientes.Rows.Add(
                    cliente.Id,
                    cliente.Documento,
                    cliente.Nombre,
                    cliente.Apellido
                );
            }
        }
    }
}
