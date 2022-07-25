using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Compras
{
    public partial class frmDetalleCompra : Form
    {
        public frmDetalleCompra()
        {
            InitializeComponent();
        }

        private void frmDetalleCompra_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    dgvUsuarios.Rows.Add(new object[] {
                        "Manaos 1Lt",
                        "120.00",
                        "1",
                        "120.00",
                    });
                }
                if (i == 1)
                {
                    dgvUsuarios.Rows.Add(new object[] {
                        "Manzanas 1Kg",
                        "80.00",
                        "1",
                        "80.00",
                    });
                }
            }
        }
    }
}
