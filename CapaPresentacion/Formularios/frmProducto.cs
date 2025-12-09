using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios
{
    public partial class frmProducto : Form
    {
        private int _idProductoSeleccionado = 0;
        private const string FormatoPrecio = "0.00";
        private static readonly CultureInfo _culturaArgentina = new CultureInfo("es-AR");

        private static class NombreColumna
        {
            public const string ID_PRODUCTO = "id_producto";
            public const string CODIGO = "codigo";
            public const string DESCRIPCION = "descripcion";
            public const string PRECIO = "precio";
            public const string QUIEBRE_STOCK = "quiebreStock";
            public const string CATEGORIA_ID = "id_categoria";
            public const string BTN_EDITAR = "btnEditar";
            public const string BTN_ELIMINAR = "btnEliminar";
        }

        public frmProducto()
        {
            InitializeComponent();

            BackColor = System.Drawing.Color.FromArgb(63, 81, 181); // Indigo 500
            UtilidadesDGV.Configurar(dgvProductos);

            UtilidadesCB.Cargar(cbCategoria, new CN_Categoria().Listar(), c => c.Id, c => c.Nombre);
            UtilidadesCB.CargarHeadersDesdeDGV(cbBuscar, dgvProductos, "descripcion");
            UtilidadesForm.AlternarPanelHabilitado(pnlListaProductos, pnlFormProducto, txtBuscar);
            ListarProductosEnDGV();
        }

        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            UtilidadesDGV.PintarbtnEditarEliminar(sender, e,
                nombreColEditar: NombreColumna.BTN_EDITAR,
                nombreColEliminar: NombreColumna.BTN_ELIMINAR
            );
        }
        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;

            string nombreColumna = dgvProductos.Columns[e.ColumnIndex].Name;

            if (nombreColumna != NombreColumna.BTN_EDITAR && nombreColumna != NombreColumna.BTN_ELIMINAR)
                return;

            if (nombreColumna == NombreColumna.BTN_EDITAR)
            {
                CargarDatosParaEdicion(e.RowIndex);
                ConfigurarFormularioParaEdicion(false);
            }
            else if (nombreColumna == NombreColumna.BTN_ELIMINAR)
            {
                EliminarProducto(e.RowIndex);
            }
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            UtilidadesDGV.AplicarFiltro(dgvProductos, cbBuscar, txtBuscar.Text);
        }
        private void txtBuscar_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesDGV.QuitarFiltro(dgvProductos, txtBuscar);
        }
        private void btnCrear_Click(object sender, EventArgs e)
        {
            ConfigurarFormularioParaEdicion(true);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int.TryParse(txtQuiebreStock.Text, out int quiebreStock);
            decimal.TryParse(txtPrecio.Text, NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, _culturaArgentina, out decimal precioVenta);

            CE_Producto oProducto = new CE_Producto()
            {
                Id = _idProductoSeleccionado,
                Codigo = txtCodigo.Text.Trim(),
                Descripcion = txtDescripcion.Text.Trim(),
                PrecioVenta = precioVenta,
                QuiebreStock = quiebreStock,
                oCategoria = new CE_Categoria()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbCategoria.SelectedItem).Valor)
                }
            };

            string mensaje;
            bool operacionExitosa;

            if (_idProductoSeleccionado == 0)
                operacionExitosa = new CN_Producto().Crear(oProducto, out mensaje) != 0;
            else
                operacionExitosa = new CN_Producto().Actualizar(oProducto, out mensaje);

            if (!operacionExitosa)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ListarProductosEnDGV();
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaProductos, pnlFormProducto, txtBuscar);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
            UtilidadesForm.AlternarPanelHabilitado(pnlListaProductos, pnlFormProducto, txtBuscar);
        }
        private void pnlListaProductos_Resize(object sender, EventArgs e)
        {
            UtilidadesForm.CentrarHorizontalmente(lblListaProductos);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesTextBox.PermitirSoloPrecio(sender, e);
        }
        private void txtQuiebreStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;
            
            e.Handled = true;
        }

        private void ListarProductosEnDGV()
        {
            dgvProductos.Rows.Clear();
            List<CE_Producto> listaProducto = new CN_Producto().Listar();

            foreach (CE_Producto item in listaProducto)
            {
                dgvProductos.Rows.Add(new object[] {
                    item.Id,
                    item.Codigo,
                    item.Descripcion,
                    item.PrecioCompra,
                    item.PrecioVenta,
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
            _idProductoSeleccionado = 0;
            UtilidadesForm.ReiniciarControles(pnlFormProducto);
        }
        private bool ValidarCampos()
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                errores.AppendLine("Ingrese un código para el producto.");

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                errores.AppendLine("Ingrese la descripción del producto.");

            if(string.IsNullOrWhiteSpace(txtPrecio.Text))
                errores.AppendLine("Ingrese un precio para el producto.");

            if (!int.TryParse(txtQuiebreStock.Text, out int quiebreStock) || quiebreStock < 0)
                errores.AppendLine("Ingrese un quiebre de stock válido.");

            if (cbCategoria.SelectedItem == null || !(cbCategoria.SelectedItem is OpcionCombo))
                errores.AppendLine("Seleccione una categoría para el producto.");

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
        private void ConfigurarFormularioParaEdicion(bool esNuevoProducto)
        {
            if (esNuevoProducto)
            {
                _idProductoSeleccionado = 0;
                LimpiarForm();
            }
            UtilidadesForm.AlternarPanelHabilitado(pnlFormProducto, pnlListaProductos, txtCodigo);
        }
        private void CargarDatosParaEdicion(int indiceFilaSeleccionada)
        {
            DataGridViewRow filaSeleccionada = dgvProductos.Rows[indiceFilaSeleccionada];

            _idProductoSeleccionado = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ID_PRODUCTO].Value);
            txtCodigo.Text = filaSeleccionada.Cells[NombreColumna.CODIGO].Value.ToString();
            txtDescripcion.Text = filaSeleccionada.Cells[NombreColumna.DESCRIPCION].Value.ToString();
            txtPrecio.Text = filaSeleccionada.Cells[NombreColumna.PRECIO].Value.ToString();
            txtQuiebreStock.Text = filaSeleccionada.Cells[NombreColumna.QUIEBRE_STOCK].Value.ToString();

            int idCategoriaSeleccionada = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.CATEGORIA_ID].Value);
            cbCategoria.SelectedItem = cbCategoria.Items
                .Cast<OpcionCombo>()
                .FirstOrDefault(oc => Convert.ToInt32(oc.Valor) == idCategoriaSeleccionada);
        }
        private bool EliminarProducto(int indiceFilaSeleccionada)
        {
            DataGridViewRow filaSeleccionada = dgvProductos.Rows[indiceFilaSeleccionada];

            var nombreProducto = filaSeleccionada.Cells[NombreColumna.DESCRIPCION].Value.ToString();
            
            if (!UtilidadesForm.ConfirmarAccion($"¿Desea eliminar el producto {nombreProducto}?"))
                return false;

            var oProducto = new CE_Producto()
            {
                Id = Convert.ToInt32(filaSeleccionada.Cells[NombreColumna.ID_PRODUCTO].Value)
            };

            if (!new CN_Producto().Eliminar(oProducto, out string mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            dgvProductos.Rows.RemoveAt(indiceFilaSeleccionada);
            return true;
        }

    }
}
