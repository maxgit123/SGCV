using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion.Utilidades
{
    /// <summary>
    /// Clase auxiliar para pintar iconos de editar y eliminar en un DataGridView.
    /// </summary>
    public class PintarDGV
    {
        /// <summary>
        /// Dibuja los iconos de editar y eliminar en las columnas especificadas del DataGridView.
        /// </summary>
        /// <param name="sender">El DataGridView que dispara el evento.</param>
        /// <param name="e">Datos del evento CellPainting.</param>
        /// <param name="nombreColEditar">Nombre de la columna de editar.</param>
        /// <param name="nombreColEliminar">Nombre de la columna de eliminar.</param>
        public static void PintarbtnEditarEliminar (object sender, DataGridViewCellPaintingEventArgs e, string nombreColEditar, string nombreColEliminar)
        {
            if (e.RowIndex < 0)
                return;

            if (!(sender is DataGridView dgv))
                return;

            var colNombre = dgv.Columns[e.ColumnIndex].Name;

            if (colNombre == nombreColEditar)
                PintarIcono(e, Properties.Resources.edit16);

            if (colNombre == nombreColEliminar)
                PintarIcono(e, Properties.Resources.delete16);
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
