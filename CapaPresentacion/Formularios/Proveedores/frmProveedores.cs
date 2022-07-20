using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Proveedores
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }
        private void frmProveedores_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvProveedores.Columns)
            {
                if (columna.Visible == true && columna.HeaderText != "")
                {
                    cbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbBuscar.DisplayMember = "Texto";
            cbBuscar.ValueMember = "Valor";
            cbBuscar.SelectedIndex = 0;

            MostrarListaProveedores();
        }
        private void dgvProveedores_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PintarDGV.PintarbtnEditarEliminar(sender, e, dgvProveedores.ColumnCount);
        }
        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || (dgvProveedores.Columns[e.ColumnIndex].Name != "btnEditar" && dgvProveedores.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            if (dgvProveedores.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                //Labels de ayuda para ver el indice del DGV y el ID del Proveedor.
                lblIndice.Text = e.RowIndex.ToString();
                lblID_Proveedor.Text = dgvProveedores.Rows[e.RowIndex].Cells["ID_Proveedor"].Value.ToString();

                txtRazonSocial.Text = dgvProveedores.Rows[e.RowIndex].Cells["RazonSocial"].Value.ToString();
                txtObservacion.Text = dgvProveedores.Rows[e.RowIndex].Cells["Observacion"].Value.ToString();
                txtTelefono.Text = dgvProveedores.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvProveedores.Rows[e.RowIndex].Cells["Correo"].Value.ToString();

                HabilitarForm();
            }
            else if (dgvProveedores.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                if (MessageBox.Show("¿Desea eliminar al proveedor " + dgvProveedores.Rows[e.RowIndex].Cells["RazonSocial"].Value.ToString() + "?", "Eliminar Proveedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;

                    CE_Proveedor oProveedor = new CE_Proveedor()
                    {
                        Id = int.Parse(dgvProveedores.Rows[e.RowIndex].Cells["ID_Proveedor"].Value.ToString())
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(oProveedor, out mensaje);

                    if (respuesta)
                        dgvProveedores.Rows.RemoveAt(Convert.ToInt32(e.RowIndex));
                    else
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Proveedor oProveedor = new CE_Proveedor()
            {
                Id = Convert.ToInt32(lblID_Proveedor.Text),
                Observacion = txtObservacion.Text.Trim(),
                RazonSocial = txtRazonSocial.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim()
            };

            if (oProveedor.Id == 0)
            {
                int idProveedorCreado = new CN_Proveedor().Crear(oProveedor, out mensaje);

                if (idProveedorCreado == 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                MostrarListaProveedores();
                LimpiarForm();
                DeshabilitarForm();
                    
            }
            else
            {
                bool resultado = new CN_Proveedor().Actualizar(oProveedor, out mensaje);

                if (!resultado)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MostrarListaProveedores();
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
            if (e.KeyCode != Keys.Enter || dgvProveedores.Rows.Count < 0)
                return;

            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            foreach (DataGridViewRow row in dgvProveedores.Rows)
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
            foreach (DataGridViewRow row in dgvProveedores.Rows)
            {
                row.Visible = true;
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            HabilitarForm();
        }
        private void MostrarListaProveedores()
        {
            dgvProveedores.Rows.Clear();
            List<CE_Proveedor> listaProveedor = new CN_Proveedor().Listar();

            foreach (CE_Proveedor item in listaProveedor)
            {
                dgvProveedores.Rows.Add(new object[] {
                    item.Id,
                    item.RazonSocial,
                    item.Observacion,
                    item.FechaCreacion,
                    item.Telefono,
                    item.Correo,
                    item.oEstado.Id,
                    item.oEstado.Nombre,
                    "",""
                });
            }
        }
        private void LimpiarForm()
        {
            lblIndice.Text = "-1"; //Se setea en -1 xq el indice empieza en 0.
            lblID_Proveedor.Text = "0"; //Se setea en 0 para que el boton guardar sepa si debe crear o actualizar.
            txtRazonSocial.Text = "";
            txtObservacion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            txtRazonSocial.Select();
        }
        private void HabilitarForm()
        {
            txtRazonSocial.Enabled = true;
            txtObservacion.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void DeshabilitarForm()
        {
            txtRazonSocial.Enabled = false;
            txtObservacion.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
