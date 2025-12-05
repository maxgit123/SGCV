using System;
using System.Drawing;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Base;
using CapaPresentacion.Utilidades;
using MaterialSkin.Controls;

namespace CapaPresentacion.Formularios.Modal
{
    public partial class mdUsuarioCambiarClave : MaterialModalBase
    {
        private static CE_Usuario _usuarioActual;

        public mdUsuarioCambiarClave(CE_Usuario oUsuario)
        {
            InitializeComponent();
            _usuarioActual = oUsuario;
            Size = new Size(292, 375); //321
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            bool resultado = new CN_Usuario().CambiarClave(
                _usuarioActual,
                txtClaveActual.Text,
                txtClaveNueva.Text,
                txtClaveNueva2.Text,
                out string mensaje
            );

            if (resultado)
            {
                MessageBox.Show("Clave cambiada con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtClave_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesTextBox.MostrarClave((MaterialTextBox2)sender);
        }
    }
}
