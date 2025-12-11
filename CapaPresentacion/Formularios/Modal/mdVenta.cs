using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Base;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdVenta : MaterialModalBase
    {
        public int _IdVentaSeleccionada { get; set; }

        public mdVenta()
        {
            InitializeComponent();
            UtilidadesDGV.Configurar(dgvVentas);
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvVentas /* , NombreColumna. */);
            ListarVentasEnDGV();
        }

        private void dgvVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _IdVentaSeleccionada = Convert.ToInt32(dgvVentas.Rows[e.RowIndex].Cells["id_venta"].Value);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvVentas, cbBuscar, txtBuscar.Text);
        }
        private void txtBuscar_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvVentas, txtBuscar);
        }

        private void ListarVentasEnDGV()
        {
            List<CE_Venta> listaVentas = new CN_Venta().Listar(out String mensaje);
            dgvVentas.Rows.Clear();
            
            foreach (var venta in listaVentas)
            {
                dgvVentas.Rows.Add(new object[]
                {
                    venta.Id,
                    venta.Total.ToString("N2"),
                    venta.TipoFactura,
                    venta.FechaVenta.ToString("dd/MM/yyyy"),
                    venta.FechaCreacion.ToString("dd/MM/yyyy HH:mm:ss"),
                    venta.oUsuario.NombreCompleto,
                    venta.oCliente.NombreCompleto,
                    venta.oEstado.Nombre
                });
            }
        }

    }
}
