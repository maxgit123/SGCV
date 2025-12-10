using System.Windows.Forms;
using System.Drawing;
using MaterialSkin.Controls;

namespace CapaPresentacion.Utilidades
{
    public static class UtilidadesDGV
    {
        private static readonly Color _materialColor = Color.FromArgb(63, 81, 181); // Indigo 500
        //private static readonly Color _foreColor = Color.FromArgb(235, 230, 255); // Indigo 500

        /// <summary>
        /// Aplica configuración general a un DataGridView para ajuste automático de columnas y tamaño fijo en botones.
        /// </summary>
        /// <param name="dgv">El DataGridView a configurar.</param>
        public static void Configurar(DataGridView dgv)
        {
            // --- Comportamiento ---
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.ReadOnly = true;

            // --- Estilo ---
            dgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv.ColumnHeadersHeight = 28;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 30;

            // --- Fuente ---
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 10, FontStyle.Regular);

            // --- Colores ---
            dgv.GridColor = Color.LightGray;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.Black;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                //if (col.Name == "espacio") // Si se quiere que los botones se mantengan pegados al borde izquierdo
                //{
                //    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //}
                if (col.Name == "btnEditar" || col.Name == "btnEliminar")
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    col.Width = 30;
                    col.Resizable = DataGridViewTriState.False;
                }
                else
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        /// <summary>
        /// Aplica un filtro sobre un DataGridView en base al texto y la columna seleccionada.
        /// </summary>
        /// <param name="dgv">El DataGridView al que se le aplica el filtro.</param>
        /// <param name="cbFiltro">El ComboBox que contiene la columna a filtrar (con valores de tipo OpcionCombo).</param>
        /// <param name="tbFiltro">El texto del TextBox a buscar.</param>
        public static void AplicarFiltro(DataGridView dgv, MaterialComboBox cbFiltro, string tbFiltro)
        {
            if (dgv.Rows.Count == 0) return;
            if (!(cbFiltro.SelectedItem is OpcionCombo opcion)) return;

            string columnaFiltro = opcion.Valor.ToString();
            string textoFiltro = tbFiltro.Trim().ToUpper();

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                var valorCelda = fila.Cells[columnaFiltro].Value?.ToString().Trim().ToUpper();
                fila.Visible = !string.IsNullOrEmpty(valorCelda) && valorCelda.Contains(textoFiltro);
            }
        }
        public static void AplicarFiltro(DataGridView dgv, ComboBox cbFiltro, string tbFiltro)
        {
            if (dgv.Rows.Count == 0) return;
            if (!(cbFiltro.SelectedItem is OpcionCombo opcion)) return;

            string columnaFiltro = opcion.Valor.ToString();
            string textoFiltro = tbFiltro.Trim().ToUpper();

            foreach (DataGridViewRow fila in dgv.Rows)
            {
                var valorCelda = fila.Cells[columnaFiltro].Value?.ToString().Trim().ToUpper();
                fila.Visible = !string.IsNullOrEmpty(valorCelda) && valorCelda.Contains(textoFiltro);
            }
        }

        /// <summary>
        /// Quita cualquier filtro aplicado sobre un DataGridView y limpia el TextBox de búsqueda.
        /// </summary>
        /// <param name="dgv">El DataGridView al que se le quitará el filtro.</param>
        /// <param name="txtFiltro">El TextBox a limpiar.</param>
        public static void QuitarFiltro(DataGridView dgv, MaterialTextBox2 txtFiltro)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                fila.Visible = true;
            }

            txtFiltro.Clear();
        }
        public static void QuitarFiltro(DataGridView dgv, TextBox txtFiltro)
        {
            foreach (DataGridViewRow fila in dgv.Rows)
            {
                fila.Visible = true;
            }

            txtFiltro.Clear();
        }

        /// <summary>
        /// Dibuja los iconos de editar y eliminar en las columnas especificadas del DataGridView.
        /// </summary>
        /// <param name="sender">El DataGridView que dispara el evento.</param>
        /// <param name="e">Datos del evento CellPainting.</param>
        /// <param name="nombreColEditar">Nombre de la columna de editar (opcional).</param>
        /// <param name="nombreColEliminar">Nombre de la columna de eliminar (opcional).</param>
        public static void PintarbtnEditarEliminar(
            object sender,
            DataGridViewCellPaintingEventArgs e,
            string nombreColEditar = null,
            string nombreColEliminar = null)
        {
            if (e.RowIndex < 0)
                return;

            if (!(sender is DataGridView dgv))
                return;

            var colNombre = dgv.Columns[e.ColumnIndex].Name;

            if (colNombre == nombreColEditar)
            {
                PintarIcono(e, Properties.Resources.edit16);
                return;
            }

            if (colNombre == nombreColEliminar)
            {
                PintarIcono(e, Properties.Resources.delete16);
                return;
            }
        }

        /// <summary>
        /// Dibuja un icono centrado en la celda del DataGridView.
        /// </summary>
        /// <param name="e">Datos del evento CellPainting.</param>
        /// <param name="icono">Icono a dibujar.</param>
        private static void PintarIcono(DataGridViewCellPaintingEventArgs e, Image icono)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            var w = icono.Width;
            var h = icono.Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            e.Graphics.DrawImage(icono, new Rectangle(x, y, w, h));
            e.Handled = true;
        }
    }
}
