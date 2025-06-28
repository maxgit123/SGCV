using System;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!CN_Conexion.VerificarConexion(out string errorMessage))
            {
                MessageBox.Show($"No se pudo conectar a la base de datos:\n\n{errorMessage}",
                               "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validacion de campos del formulario.
            if (string.IsNullOrWhiteSpace(txtDocumento.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar DNI y clave.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Procesamiento de inicio de sesión.
            CE_Usuario oUsuario = new CN_Usuario().Login(txtDocumento.Text.Trim(), txtClave.Text.Trim(), out string mensaje);

            if (oUsuario == null)
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Acceso exitoso.
            Hide();
            var form = new frmInicio(oUsuario);
            // Cuando se cierra el dashboard vuelve a mostrar el form de login que se oculto.
            form.FormClosing += frm_closing;
            form.Show();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Clear();
            txtClave.Clear();
            txtDocumento.Focus();
            Show();
        }
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
