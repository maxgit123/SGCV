using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

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

            string claveActualHash = ClaveHash.ObtenerSha256(txtClaveActual.Text.Trim());
            string claveNuevaHash = ClaveHash.ObtenerSha256(txtClaveNueva.Text.Trim());
            bool resultado = new CN_Usuario().CambiarClave(usuarioActual, claveActualHash, claveNuevaHash, out mensaje);


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
