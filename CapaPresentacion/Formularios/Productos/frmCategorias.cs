using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Productos
{
    public partial class frmCategorias : Form
    {
        public frmCategorias()
        {
            InitializeComponent();
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgvCategorias.Columns)
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

            var listaAlicuotaIVA = new CN_AlicuotaIVA().Listar();

            cbAlicuotaIVA.DataSource = listaAlicuotaIVA
                .Select(a => new OpcionCombo { Valor = a.Id, Texto = Convert.ToString(a.Porcentaje) })
                .ToList();
            cbAlicuotaIVA.DisplayMember = "Texto";
            cbAlicuotaIVA.ValueMember = "Valor";

            foreach (DataGridViewColumn columna in dgvCategorias.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }

            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";

            if (cbBuscar.Items.Count > 0)
                cbBuscar.SelectedIndex = 0;

            MostrarListaCategorias();
            DeshabilitarForm();
        }
        private void dgvCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e, "btnEditar", "btnEliminar");
        }
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || (dgvCategorias.Columns[e.ColumnIndex].Name != "btnEditar" && dgvCategorias.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            int indiceFila = e.RowIndex;

            if (dgvCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                lblIndice.Text = indiceFila.ToString();
                lblID_Categoria.Text = dgvCategorias.Rows[indiceFila].Cells["id_categoria"].Value.ToString();

                txtNomCategoria.Text = dgvCategorias.Rows[indiceFila].Cells["nombre"].Value.ToString(); // error columna nombre
                foreach (OpcionCombo oc in cbAlicuotaIVA.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvCategorias.Rows[indiceFila].Cells["ID_AlicuotaIVA"].Value))
                    {
                        int indice_combo = cbAlicuotaIVA.Items.IndexOf(oc);
                        cbAlicuotaIVA.SelectedIndex = indice_combo;
                        break;
                    }
                }
                HabilitarForm();
            }
            else if (dgvCategorias.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult respuestaEliminar = MessageBox.Show(
                    $"¿Desea eliminar la categoría {dgvCategorias.Rows[indiceFila].Cells["nombre"].Value}?",
                    "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    );

                if (respuestaEliminar == DialogResult.No)
                    return;

                CE_Categoria oCategoria = new CE_Categoria()
                {
                    Id = Convert.ToInt32(dgvCategorias.Rows[indiceFila].Cells["id_categoria"].Value)
                };

                bool respuesta = new CN_Categoria().Eliminar(oCategoria, out string mensaje);

                if (respuesta)
                    dgvCategorias.Rows.RemoveAt(Convert.ToInt32(indiceFila));
                else
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CE_Categoria oCategoria = new CE_Categoria()
            {
                Id = Convert.ToInt32(lblID_Categoria.Text),
                Nombre = txtNomCategoria.Text.Trim(),
                oAlicuotaIVA = new CE_AlicuotaIVA() { Id = Convert.ToInt32(((OpcionCombo)cbAlicuotaIVA.SelectedItem).Valor) },
            };

            if (oCategoria.Id == 0)
            {
                int idCategoriaCreada = new CN_Categoria().Crear(oCategoria, out string mensaje);

                if (idCategoriaCreada == 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                MostrarListaCategorias();
                LimpiarForm();
                DeshabilitarForm();
            }
            else
            {
                bool resultado = new CN_Categoria().Actualizar(oCategoria, out string mensaje);

                if (!resultado)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                MostrarListaCategorias();
                LimpiarForm();
                DeshabilitarForm();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            DeshabilitarForm();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (dgvCategorias.Rows.Count == 0)
                return;

            string textoFiltro = txtBuscar.Text.Trim().ToUpper();
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();

            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                if (row.Cells[columnaFiltro].Value != null &&
                    row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textoFiltro))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                row.Visible = true;
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            HabilitarForm();
        }
        private void MostrarListaCategorias()
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
            lblIndice.Text = "-1"; //Se setea en -1 xq el indiceFila empieza en 0.
            lblID_Categoria.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            txtNomCategoria.Clear();
            cbAlicuotaIVA.SelectedIndex = 0;
            txtNomCategoria.Select();
        }
        private void HabilitarForm()
        {
            txtNomCategoria.Select();
            txtNomCategoria.Enabled = true;
            cbAlicuotaIVA.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void DeshabilitarForm()
        {
            txtNomCategoria.Enabled = false;
            cbAlicuotaIVA.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
