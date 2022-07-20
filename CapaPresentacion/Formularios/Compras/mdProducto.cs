using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Compras
{
    public partial class mdProducto : Form
    {
        public CE_Producto Producto { get; set; }
        public mdProducto()
        {
            InitializeComponent();
        }
        private void mdProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
