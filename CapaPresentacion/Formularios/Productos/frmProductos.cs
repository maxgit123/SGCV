using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Productos
{
    public partial class frmProductos : Form
    {
        private int idProductoSeleccionado = 0;
        public frmProductos()
        {
            InitializeComponent();
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgvProductos.Columns)
            {
                if (col.Name == "espacio")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                else if (col.Name != "btnEditar" && col.Name != "btnEliminar")
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

            List<CE_Categoria> listaCategoria = new CN_Categoria().Listar();
            cbCategoria.DataSource = listaCategoria
                .Select(c => new OpcionCombo { Valor = c.Id, Texto = c.Nombre })
                .ToList();
            cbCategoria.DisplayMember = "Texto";
            cbCategoria.ValueMember = "Valor";
            cbCategoria.SelectedIndex = 0;

            var columnasVisibles = dgvProductos.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible && !string.IsNullOrWhiteSpace(c.HeaderText))
                .Select(c => new OpcionCombo { Valor = c.Name, Texto = c.HeaderText })
                .ToList();
            cbBuscar.DataSource = columnasVisibles;
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            if (cbBuscar.Items.Count > 0)
                cbBuscar.SelectedIndex = 0;

            MostrarListaProductos();
            DeshabilitarForm();

            //foreach (DataGridViewColumn columna in dgvProductos.Columns)
            //{
            //    if (columna.Visible == true && columna.HeaderText != "")
            //    {
            //        cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            //    }
            //}
        }
        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PintarDGV.PintarbtnEditarEliminar(sender, e, "btnEditar", "btnEliminar");
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || (dgvProductos.Columns[e.ColumnIndex].Name != "btnEditar" && dgvProductos.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            int indiceFila = e.RowIndex;

            if (dgvProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                idProductoSeleccionado = Convert.ToInt32(dgvProductos.Rows[indiceFila].Cells["id_producto"].Value);
                txtCodigo.Text = dgvProductos.Rows[indiceFila].Cells["codigo"].Value?.ToString() ?? "";
                txtDescripcion.Text = dgvProductos.Rows[indiceFila].Cells["descripcion"].Value.ToString();
                nudQuiebreStock.Value = Convert.ToInt32(dgvProductos.Rows[indiceFila].Cells["quiebreStock"].Value);
                
                foreach (OpcionCombo oc in cbCategoria.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProductos.Rows[indiceFila].Cells["id_categoria"].Value))
                    {
                        int indice_combo = cbCategoria.Items.IndexOf(oc);
                        cbCategoria.SelectedIndex = indice_combo;
                        break;
                    }
                }

                HabilitarForm();
            }
            else if (dgvProductos.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DialogResult respuestaEliminar = MessageBox.Show(
                    $"¿Desea eliminar el producto {dgvProductos.Rows[indiceFila].Cells["descripcion"].Value}?",
                    "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                );

                if (respuestaEliminar == DialogResult.No)
                    return;

                CE_Producto oProducto = new CE_Producto()
                {
                    Id = int.Parse(dgvProductos.Rows[indiceFila].Cells["id_producto"].Value.ToString())
                };

                bool respuesta = new CN_Producto().Eliminar(oProducto, out string mensaje);

                if (respuesta)
                    dgvProductos.Rows.RemoveAt(indiceFila);
                else
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CE_Producto oProducto = new CE_Producto()
            {
                Id = idProductoSeleccionado,
                Codigo = txtCodigo.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                QuiebreStock = Convert.ToInt32(nudQuiebreStock.Value),
                oCategoria = new CE_Categoria()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbCategoria.SelectedItem).Valor)
                }
            };

            if (oProducto.Id == 0)
            {
                int idProductoCreado = new CN_Producto().Crear(oProducto, out string mensaje);

                if (idProductoCreado == 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                };

                MostrarListaProductos();
                LimpiarForm();
                DeshabilitarForm();
            }
            else
            {
                bool resultado = new CN_Producto().Actualizar(oProducto, out string mensaje);

                if (!resultado)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                MostrarListaProductos();
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
            if (dgvProductos.Rows.Count == 0)
                return;

            string textoFiltro = txtBuscar.Text.Trim().ToUpper();
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells[columnaFiltro].Value != null &&
                    row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(textoFiltro))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                row.Visible = true;
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            HabilitarForm();
        }
        private void MostrarListaProductos()
        {
            dgvProductos.Rows.Clear();
            List<CE_Producto> listaProducto = new CN_Producto().Listar();

            foreach (CE_Producto item in listaProducto)
            {
                dgvProductos.Rows.Add(new object[] {
                    item.Id,
                    item.Codigo,
                    item.Descripcion,
                    item.Costo,
                    item.Precio,
                    item.Stock,
                    item.QuiebreStock,
                    item.FechaCreacion,
                    item.oCategoria.Id,
                    item.oCategoria.Nombre,
                    item.oEstado.Id,
                    item.oEstado.Nombre,
                    "","",""
                });
            }
        }
        private void LimpiarForm()
        {
            idProductoSeleccionado = 0;
            txtCodigo.Clear();
            txtDescripcion.Clear();
            nudQuiebreStock.Value = nudQuiebreStock.Minimum;
            cbCategoria.SelectedIndex = 0;
            txtCodigo.Select();
        }
        private void HabilitarForm()
        {
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            nudQuiebreStock.Enabled = true;
            cbCategoria.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void DeshabilitarForm()
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            nudQuiebreStock.Enabled = false;
            cbCategoria.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
