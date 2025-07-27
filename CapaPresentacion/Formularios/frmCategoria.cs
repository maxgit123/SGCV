using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios
{
    public partial class frmCategoria : Form
    {
        private int _idCategoriaSeleccionada = 0;
        private static class NombreColumna
        {
            public const string ID_CATEGORIA = "id_categoria";
            public const string NOMBRE = "nombre";
            public const string ALICUOTA_IVA_ID = "id_alicuotaIVA";
            public const string BTN_EDITAR = "btnEditar";
            public const string BTN_ELIMINAR = "btnEliminar";
        }
        public frmCategoria()
        {
            InitializeComponent();

            BackColor = System.Drawing.Color.FromArgb(63, 81, 181); // Indigo 500
            UtilidadesDGV.Configurar(dgvCategorias);

            UtilidadesCB.Cargar(cbAlicuotaIva, new CN_AlicuotaIVA().Listar(), r => r.Id, r => Convert.ToString(r.Porcentaje));
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvCategorias, NombreColumna.NOMBRE);
            ListarCategoriasEnDGV();
        }
        private void dgvCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e,
                nombreColEditar: NombreColumna.BTN_EDITAR,
                nombreColEliminar: NombreColumna.BTN_ELIMINAR
            );
        }
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            string nombreColumna = dgvCategorias.Columns[e.ColumnIndex].Name;

            if (nombreColumna != NombreColumna.BTN_EDITAR && nombreColumna != NombreColumna.BTN_ELIMINAR)
                return;

            if (nombreColumna == NombreColumna.BTN_EDITAR)
            {
                CargarDatosParaEdicion(e.RowIndex);
                ConfigurarFormularioParaEdicion(false);
            }
            else if (nombreColumna == NombreColumna.BTN_ELIMINAR)
            {
                EliminarCategoria(e.RowIndex);
            }
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvCategorias, cbBuscar, txtBuscar.Text);
        }
        private void txtBuscar_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvCategorias, txtBuscar);
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            ConfigurarFormularioParaEdicion(true);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            CE_Categoria oCategoria = new CE_Categoria()
            {
                Id = _idCategoriaSeleccionada,
                Nombre = txtNombre.Text.Trim(),
                oAlicuotaIVA = new CE_AlicuotaIVA()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbAlicuotaIva.SelectedItem).Valor)
                }
            };

            string mensaje;
            bool operacionExitosa;

            if (_idCategoriaSeleccionada == 0)
                operacionExitosa = new CN_Categoria().Crear(oCategoria, out mensaje) != 0;
            else
                operacionExitosa = new CN_Categoria().Actualizar(oCategoria, out mensaje);

            ListarCategoriasEnDGV();
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaCategorias, pnlFormCategoria, txtBuscar);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaCategorias, pnlFormCategoria, txtBuscar);
        }
        private void pnlListaCategorias_Resize(object sender, EventArgs e)
        {
            UtilidadesForm.CentrarHorizontalmente(lblListaCategorias);
        }

        private void ListarCategoriasEnDGV()
        {
            dgvCategorias.Rows.Clear();
            List<CE_Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (CE_Categoria item in listaCategoria)
            {
                dgvCategorias.Rows.Add(new object[] {
                    item.Id,
                    item.Nombre,
                    item.FechaCreacion,
                    item.oAlicuotaIVA.Id,
                    item.oAlicuotaIVA.Porcentaje,
                    item.oEstado.Id,
                    item.oEstado.Nombre,
                    "",""
                });
            }
        }
        private void LimpiarForm()
        {
            _idCategoriaSeleccionada = 0;
            UtilidadesForm.ReiniciarControles(pnlFormCategoria);
        }
        private bool ValidarCampos()
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                errores.AppendLine("Ingrese el nombre de la categoría.");

            if (cbAlicuotaIva.SelectedItem == null || !(cbAlicuotaIva.SelectedItem is OpcionCombo))
                errores.AppendLine("Seleccione una alícuota IVA.");

            if (errores.Length > 0)
            {
                MessageBox.Show(
                    $"Se encontraron los siguientes errores:\n\n {errores}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return false;
            }

            return true;
        }
        private void ConfigurarFormularioParaEdicion(bool esNuevaCategoria)
        {
            if (esNuevaCategoria)
            {
                _idCategoriaSeleccionada = 0;
                LimpiarForm();
            }
            UtilidadesForm.AlternarPanelHabilitado(pnlFormCategoria, pnlListaCategorias, txtNombre);
        }
        private void CargarDatosParaEdicion(int indiceFilaSeleccionada)
        {
            DataGridViewRow filaSeleccionada = dgvCategorias.Rows[indiceFilaSeleccionada];

            _idCategoriaSeleccionada = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ID_CATEGORIA].Value);
            txtNombre.Text = filaSeleccionada.Cells[NombreColumna.NOMBRE].Value.ToString();

            int idAlicuotaIvaSelecionada = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ALICUOTA_IVA_ID].Value);
            cbAlicuotaIva.SelectedItem = cbAlicuotaIva.Items
                .Cast<OpcionCombo>()
                .FirstOrDefault(oc => Convert.ToInt32(oc.Valor) == idAlicuotaIvaSelecionada);
        }
        private bool EliminarCategoria(int indiceFilaSeleccionada)
        {
            var filaSeleccionada = dgvCategorias.Rows[indiceFilaSeleccionada];
            var nombreCategoria = filaSeleccionada.Cells[NombreColumna.NOMBRE].Value.ToString();

            if (!UtilidadesForm.ConfirmarAccion($"¿Desea eliminar la categoría {nombreCategoria}?"))
                return false;

            var oCategoria = new CE_Categoria()
            {
                Id = Convert.ToInt32(dgvCategorias.Rows[indiceFilaSeleccionada].Cells[NombreColumna.ID_CATEGORIA].Value)
            };

            if (!new CN_Categoria().Eliminar(oCategoria, out string mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            
            
            dgvCategorias.Rows.RemoveAt(indiceFilaSeleccionada);
            return true;
        }

    }
}
