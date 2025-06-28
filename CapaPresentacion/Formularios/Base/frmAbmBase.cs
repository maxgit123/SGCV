using System;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Base
{
    public abstract class frmAbmBase<TEntity> : Form where TEntity : class
    {
        protected int idSeleccionado = 0;
        protected Panel pnlForm;
        protected Panel pnlLista;
        protected DataGridView dgvEntidades;
        protected ComboBox cbBuscar;
        protected TextBox txtBuscar;

        // Método abstracto que debe implementar cada formulario específico
        protected abstract void ListarEntidadEnDGV();
        protected abstract bool ValidarCampos(out StringBuilder errores);
        protected abstract void CargarDatosParaEdicion(int indiceFilaSeleccionada);
        protected abstract void LimpiarFormulario();
        protected abstract TEntity CrearEntidad();
        protected abstract bool GuardarEntidad(TEntity entidad, out string mensaje);
        protected abstract bool EliminarEntidad(TEntity entidad, out string mensaje);

        protected virtual void ConfigurarFormularioParaEdicion(bool esNuevo)
        {
            if (esNuevo)
            {
                idSeleccionado = 0;
                LimpiarFormulario();
            }
            UtilidadesForm.AlternarPanelHabilitado(pnlForm, pnlLista, GetFirstControl());
        }
        protected virtual Control GetFirstControl()
        {
            return pnlForm.Controls[0] as Control;
        }
        protected virtual void OnGuardar()
        {
            StringBuilder errores = new StringBuilder();
            if (!ValidarCampos(out errores))
            {
                MessageBox.Show(
                    $"Se encontraron los siguientes errores:\n\n {errores}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning
                );
                return;
            }

            TEntity entidad = CrearEntidad();
            string mensaje;
            bool operacionExitosa = GuardarEntidad(entidad, out mensaje);

            if (!operacionExitosa)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListarEntidadEnDGV();
            LimpiarFormulario();
            UtilidadesForm.AlternarPanelHabilitado(pnlLista, pnlForm, txtBuscar);
        }
        protected virtual void OnEliminar(int indiceFilaSeleccionada)
        {
            if (!UtilidadesForm.ConfirmarAccion("¿Desea eliminar este registro?"))
                return;

            TEntity entidad = CrearEntidad(); // Crear entidad solo con ID para eliminar

            if (!EliminarEntidad(entidad, out string mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            dgvEntidades.Rows.RemoveAt(indiceFilaSeleccionada);
        }

        // Eventos base comunes 
        protected virtual void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            string nombreColumna = dgvEntidades.Columns[e.ColumnIndex].Name;
            if (nombreColumna == "btnEditar")
            {
                CargarDatosParaEdicion(e.RowIndex);
                ConfigurarFormularioParaEdicion(false);
            }
            else if (nombreColumna == "btnEliminar")
            {
                OnEliminar(e.RowIndex);
            }
        }
        protected virtual void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvEntidades, cbBuscar, txtBuscar.Text);
        }
        protected virtual void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvEntidades, txtBuscar);
        }
        protected virtual void btnCrear_Click(object sender, EventArgs e)
        {
            ConfigurarFormularioParaEdicion(true);
        }
        protected virtual void btnGuardar_Click(object sender, EventArgs e)
        {
            OnGuardar();
        }
        protected virtual void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            UtilidadesForm.AlternarPanelHabilitado(pnlLista, pnlForm, txtBuscar);
        }
    }
}