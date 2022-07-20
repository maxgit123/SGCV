using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Productos
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            List<CE_Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (CE_Categoria item in listaCategoria)
            {
                cbCategoria.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.Nombre });
                cbCategoria.DisplayMember = "Texto";
                cbCategoria.ValueMember = "Valor";
                cbCategoria.SelectedIndex = 0;
            }

            foreach (DataGridViewColumn columna in dgvProductos.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;

            MostrarListaProductos();
        }
        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PintarDGV.PintarbtnEditarEliminar(sender, e, dgvProductos.ColumnCount);
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || (dgvProductos.Columns[e.ColumnIndex].Name != "btnEditar" && dgvProductos.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            if (dgvProductos.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                //Labels de ayuda para ver el indice del DGV y el ID del Producto.
                lblIndice.Text = e.RowIndex.ToString();
                lblID_Producto.Text = dgvProductos.Rows[e.RowIndex].Cells["ID_Producto"].Value.ToString();

                txtCodigo.Text = dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                txtDescripcion.Text = dgvProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                txtQuiebreStock.Text = dgvProductos.Rows[e.RowIndex].Cells["QuiebreStock"].Value.ToString();
                foreach (OpcionCombo oc in cbCategoria.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvProductos.Rows[e.RowIndex].Cells["ID_Categoria"].Value))
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
                if (MessageBox.Show("¿Desea eliminar el producto " + dgvProductos.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString() + "?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    CE_Producto oProducto = new CE_Producto()
                    {
                        Id = int.Parse(dgvProductos.Rows[e.RowIndex].Cells["ID_Producto"].Value.ToString())
                    };

                    bool respuesta = new CN_Producto().Eliminar(oProducto, out mensaje);

                    if (respuesta)
                        dgvProductos.Rows.RemoveAt(Convert.ToInt32(e.RowIndex));
                    else
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Producto oProducto = new CE_Producto()
            {
                Id = Convert.ToInt32(lblID_Producto.Text),
                Codigo = txtCodigo.Text.Trim(),
                Descripcion = txtCodigo.Text.Trim(),
                QuiebreStock = Convert.ToInt32(txtQuiebreStock.Text.Trim()),
                oCategoria = new CE_Categoria() { Id = Convert.ToInt32(((OpcionCombo)cbCategoria.SelectedItem).Valor) },
            };

            if (oProducto.Id == 0)
            {
                int idProductoCreado = new CN_Producto().Crear(oProducto, out mensaje);

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
                bool resultado = new CN_Producto().Actualizar(oProducto, out mensaje);

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
        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                    //Se hace el filtro por la columnaFiltro si contiene lo que se encuentra en txtBuscar.
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
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
                dgvProductos.Rows.Add(new object[] { //Acordate de poner los TODOS los items EN ORDEN
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
                    "",""
                });
            }
        }
        private void LimpiarForm()
        {
            lblIndice.Text = "-1"; //Se setea en -1 xq el indice empieza en 0.
            lblID_Producto.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtQuiebreStock.Text = "";
            cbCategoria.SelectedIndex = 0;
            txtCodigo.Select();
        }
        private void HabilitarForm()
        {
            txtCodigo.Enabled = true;
            txtDescripcion.Enabled = true;
            txtQuiebreStock.Enabled = true;
            cbCategoria.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void DeshabilitarForm()
        {
            txtCodigo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtQuiebreStock.Enabled = false;
            cbCategoria.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
