using System;
using System.Collections.Generic;
using System.Drawing;
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
            List<CE_AlicuotaIVA> listaAlicuotaIVA = new CN_AlicuotaIVA().Listar();

            foreach (CE_AlicuotaIVA item in listaAlicuotaIVA)
            {
                cbAlicuotaIVA.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = Convert.ToString(item.Porcentaje) });
                cbAlicuotaIVA.DisplayMember = "Texto";
                cbAlicuotaIVA.ValueMember = "Valor";
                cbAlicuotaIVA.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgvCategorias.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;

            MostrarListaCategorias();
        }
        private void dgvCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PintarDGV.PintarbtnEditarEliminar(sender, e, dgvCategorias.ColumnCount);
        }
        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || (dgvCategorias.Columns[e.ColumnIndex].Name != "btnEditar" && dgvCategorias.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            if (dgvCategorias.Columns[e.ColumnIndex].Name == "btnEditar")
            {

                lblIndice.Text = e.RowIndex.ToString();
                lblID_Categoria.Text = dgvCategorias.Rows[e.RowIndex].Cells["ID_Categoria"].Value.ToString();

                txtNomCategoria.Text = dgvCategorias.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                foreach (OpcionCombo oc in cbAlicuotaIVA.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells["ID_AlicuotaIVA"].Value))
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
                if (MessageBox.Show("¿Desea eliminar la categoría " + dgvCategorias.Rows[e.RowIndex].Cells["NomCategoria"].Value.ToString() + "?", "Eliminar Categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    CE_Categoria oCategoria = new CE_Categoria()
                    {
                        Id = int.Parse(dgvCategorias.Rows[e.RowIndex].Cells["ID_Categoria"].Value.ToString())
                    };

                    bool respuesta = new CN_Categoria().Eliminar(oCategoria, out mensaje);

                    if (respuesta)
                        dgvCategorias.Rows.RemoveAt(Convert.ToInt32(e.RowIndex));
                    else
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Categoria oCategoria = new CE_Categoria()
            {
                Id = Convert.ToInt32(lblID_Categoria.Text),
                Nombre = txtNomCategoria.Text.Trim(),
                oAlicuotaIVA = new CE_AlicuotaIVA() { Id = Convert.ToInt32(((OpcionCombo)cbAlicuotaIVA.SelectedItem).Valor) },
            };

            if (oCategoria.Id == 0)
            {
                int idCategoriaCreada = new CN_Categoria().Crear(oCategoria, out mensaje);

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
                bool resultado = new CN_Categoria().Actualizar(oCategoria, out mensaje);

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
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (dgvCategorias.Rows.Count < 0)
                return;

            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();

            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            foreach (DataGridViewRow row in dgvCategorias.Rows)
            {
                row.Visible = true;
            }
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
            lblIndice.Text = "-1"; //Se setea en -1 xq el indice empieza en 0.
            lblID_Categoria.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            txtNomCategoria.Text = "";
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
