using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdUsuarioCambiarClave : Form
    {
        private static CE_Usuario usuarioActual;
        public mdUsuarioCambiarClave(CE_Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool resultado = new CN_Usuario().CambiarClave(usuarioActual, txtClaveActual.Text, txtClaveNueva.Text, out string mensaje);

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
