using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Base;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdCompra : MaterialModalBase
    {
        public int _IdCompraSeleccionada { get; set; }

        public mdCompra()
        {
            InitializeComponent();
            UtilidadesDGV.Configurar(dgvCompras);
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvCompras /* , NombreColumna. */);
            ListarComprasEnDGV();
        }

        private void dgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            _IdCompraSeleccionada = Convert.ToInt32(dgvCompras.Rows[e.RowIndex].Cells["id_compra"].Value);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvCompras, cbBuscar, txtBuscar.Text);
        }
        private void txtBuscar_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvCompras, txtBuscar);
        }
        
        private void ListarComprasEnDGV()
        {
            List<CE_Compra> listaCompras = new CN_Compra().Listar(out String mensaje);
            dgvCompras.Rows.Clear();
            
            foreach (var compra in listaCompras)
            {
                dgvCompras.Rows.Add(new object[]
                {
                    compra.Id,
                    compra.Total.ToString("N2"),
                    compra.FechaPedido.ToString("dd/MM/yyyy"),
                    compra.FechaEntrega.ToString("dd/MM/yyyy"),
                    compra.FechaCreacion.ToString("dd/MM/yyyy HH:mm:ss"),
                    compra.oUsuario.NombreCompleto,
                    compra.oProveedor.RazonSocial,
                    compra.oEstado.Nombre
                });
            }
        }
    }
}
