using System.Windows.Forms;
using System.Drawing;

namespace CapaPresentacion.Utilidades
{
    public class PintarDGV
    {
        public static void PintarbtnEditarEliminar (object sender, DataGridViewCellPaintingEventArgs e, int cantColumna)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == cantColumna-2) //Pinta el icono de editar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var w = Properties.Resources.edit16.Width;
                var h = Properties.Resources.edit16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(Properties.Resources.edit16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == cantColumna-1) //Pinta el icono de eliminar
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.delete16.Width;
                var h = Properties.Resources.delete16.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete16, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
