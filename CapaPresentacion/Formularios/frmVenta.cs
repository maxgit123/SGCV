using CapaEntidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class frmVenta : Form
    {
        public frmVenta(CE_Usuario oUsuario = null)
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    dgvProductos.Rows.Add(new object[] {
                        "",
                        "Manaos 1Lt",
                        "160.00",
                        "1",
                        "160.00",
                        ""
                    });
                }
                if (i == 1)
                {
                    dgvProductos.Rows.Add(new object[] {
                        "",
                        "Manzanas 1Kg",
                        "120.00",
                        "1",
                        "120.00",
                        ""
                    });
                }
            }
        }
        private void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgvProductos.ColumnCount - 1) //Pinta el icono de eliminar
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
