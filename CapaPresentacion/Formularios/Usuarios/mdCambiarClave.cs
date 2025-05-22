using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Formularios.Usuarios
{
    public partial class mdCambiarClave : Form
    {
        private static CE_Usuario usuarioActual;
        public mdCambiarClave(CE_Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            bool resultado = new CN_Usuario().CambiarClave(usuarioActual, txtClaveActual.Text, txtClaveNueva.Text, out mensaje);

            if (resultado)
            {
                MessageBox.Show("Clave cambiada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
