using System.Drawing;
using System.Windows.Forms;
using CapaPresentacion.Utilidades;

public abstract class frmMantenimientoBase<TEntity> : Form where TEntity : class
{
    protected int idSeleccionado = 0;
    protected Panel pnlFormulario;
    protected Panel pnlLista;
    protected DataGridView dgvData;
    protected ComboBox cbBuscar;
    
    protected abstract void ConfigurarColumnas();
    protected abstract void CargarCombos();
    protected abstract void MostrarLista();
    protected abstract void LimpiarFormulario();
    protected abstract TEntity CrearEntidad();
    protected virtual void HabilitarFormulario()
    {
        foreach (Control ctrl in pnlFormulario.Controls)
        {
            if (ctrl.EsInteractivo())
                ctrl.Enabled = true;
        }

        pnlFormulario.BackColor = SystemColors.ActiveCaption;
        pnlLista.BackColor = Color.Lavender;

        foreach (Control c in pnlLista.Controls)
        {
            if (c.EsInteractivo())
                c.Enabled = false;
        }
    }
    protected virtual void DeshabilitarFormulario()
    {
        foreach (Control c in pnlFormulario.Controls)
        {
            if (c.EsInteractivo())
                c.Enabled = false;
        }

        pnlFormulario.BackColor = Color.Lavender;
        pnlLista.BackColor = SystemColors.ActiveCaption;

        foreach (Control c in pnlLista.Controls)
        {
            if (c.EsInteractivo())
                c.Enabled = true;
        }
    }
    protected virtual void ConfigurarDGV()
    {
        foreach (DataGridViewColumn col in dgvData.Columns)
        {
            if (col.Name != "btnEditar" && col.Name != "btnEliminar")
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            else
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                col.Width = 30;
                col.Resizable = DataGridViewTriState.False;
            }
        }
    }
    protected virtual void CargarComboBusqueda()
    {
        foreach (DataGridViewColumn columna in dgvData.Columns)
        {
            if (columna.Visible && !string.IsNullOrEmpty(columna.HeaderText))
            {
                cbBuscar.Items.Add(new OpcionCombo
                {
                    Valor = columna.Name,
                    Texto = columna.HeaderText
                });
            }
        }
        
        cbBuscar.DisplayMember = "Texto";
        cbBuscar.ValueMember = "Valor";
        
        if (cbBuscar.Items.Count > 0)
            cbBuscar.SelectedIndex = 0;
    }
}