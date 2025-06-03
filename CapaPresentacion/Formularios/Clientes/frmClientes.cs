using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Clientes
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dgvClientes.Columns["btnEditar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvClientes.Columns["btnEditar"].Width = 30;

            dgvClientes.Columns["btnEliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvClientes.Columns["btnEliminar"].Width = 30;

            List<CE_ResponsableIVA> listaRespIVA = new CN_ResponsableIVA().Listar();

            foreach (CE_ResponsableIVA item in listaRespIVA)
            {
                cbRespIVA.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.Nombre });
            }

            cbRespIVA.DisplayMember = "Texto";
            cbRespIVA.ValueMember = "Valor";

            if (cbRespIVA.Items.Count > 0)
                cbRespIVA.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvClientes.Columns)
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

            MostrarListaClientes();
        }
        private void dgvClientes_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            PintarDGV.PintarbtnEditarEliminar(sender, e, "btnEditar", "btnEliminar");
        }
        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || (dgvClientes.Columns[e.ColumnIndex].Name != "btnEditar" && dgvClientes.Columns[e.ColumnIndex].Name != "btnEliminar"))
                return;

            int indice = e.RowIndex;

            if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                lblIndice.Text = indice.ToString();
                lblID_Cliente.Text = dgvClientes.Rows[indice].Cells["ID_Cliente"].Value.ToString();

                txtDocumento.Text = dgvClientes.Rows[indice].Cells["Documento"].Value.ToString();
                txtNombre.Text = dgvClientes.Rows[indice].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.Rows[indice].Cells["Apellido"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[indice].Cells["Telefono"].Value.ToString();
                txtCorreo.Text = dgvClientes.Rows[indice].Cells["Correo"].Value.ToString();
                foreach (OpcionCombo oc in cbRespIVA.Items)
                {
                    if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvClientes.Rows[indice].Cells["ID_RespIVA"].Value))
                    {
                        int indice_combo = cbRespIVA.Items.IndexOf(oc);
                        cbRespIVA.SelectedIndex = indice_combo;
                        break;
                    }
                }

                HabilitarForm();
            }
            else if (dgvClientes.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                if (MessageBox.Show("¿Desea eliminar al cliente " + dgvClientes.Rows[indice].Cells["Nombre"].Value.ToString() +
                    "?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                CE_Cliente oCliente = new CE_Cliente()
                {
                    Id = Convert.ToInt32(dgvClientes.Rows[indice].Cells["ID_Cliente"].Value)
                };

                bool respuesta = new CN_Cliente().Eliminar(oCliente, out string mensaje);

                if (respuesta)
                    dgvClientes.Rows.RemoveAt(indice);
                else
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Cliente oCliente = new CE_Cliente()
            {
                Id = Convert.ToInt32(lblID_Cliente.Text),
                Documento = txtDocumento.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                oRespIVA = new CE_ResponsableIVA() { Id = Convert.ToInt32(((OpcionCombo)cbRespIVA.SelectedItem).Valor) },
            };

            if (oCliente.Id == 0)
            {
                int idClienteCreado = new CN_Cliente().Crear(oCliente, out mensaje);

                if (idClienteCreado == 0)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MostrarListaClientes();
                LimpiarForm();
                DeshabilitarForm();
            }
            else
            {
                bool resultado = new CN_Cliente().Actualizar(oCliente, out mensaje);

                if (!resultado)
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                MostrarListaClientes();
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
            string columnaFiltro = ((OpcionCombo)cbBuscar.SelectedItem).Valor.ToString();
            if (dgvClientes.Rows.Count > 0) //Si no hay elementos en la tabla no tiene sentido hacer la busqueda.
            {
                foreach (DataGridViewRow row in dgvClientes.Rows) //Recorre cada fila que encuentre en dgvClientes.
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBuscar.Text.Trim().ToUpper()))
                        //Se hace el filtro por la columnaFiltro si contiene lo que se encuentra en txtBuscar.
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }
        private void btnLimpiarBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();

            foreach (DataGridViewRow row in dgvClientes.Rows)
            {
                row.Visible = true;
            }
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            HabilitarForm();
        }
        private void MostrarListaClientes()
        {
            dgvClientes.Rows.Clear();
            List<CE_Cliente> listaCliente = new CN_Cliente().Listar(out string mensaje);

            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error al listar clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (CE_Cliente item in listaCliente)
            {
                dgvClientes.Rows.Add(new object[] {
                    item.Id,
                    item.Documento,
                    item.Nombre,
                    item.Apellido,
                    item.Telefono,
                    item.Correo,
                    item.FechaCreacion,
                    item.oRespIVA.Id,
                    item.oRespIVA.Nombre,
                    item.oEstado.Id,
                    item.oEstado.Nombre,
                    "",""
                });
            }
        }
        private void LimpiarForm()
        {
            lblIndice.Text = "-1";
            lblID_Cliente.Text = "0";

            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cbRespIVA.SelectedIndex = 0;

            txtDocumento.Select();
        }
        private void HabilitarForm()
        {
            txtDocumento.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtTelefono.Enabled = true;
            txtCorreo.Enabled = true;
            cbRespIVA.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }
        private void DeshabilitarForm()
        {
            txtDocumento.Enabled = false;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
            cbRespIVA.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

    }
}
