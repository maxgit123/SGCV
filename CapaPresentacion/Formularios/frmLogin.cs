using System;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

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
            if (string.IsNullOrWhiteSpace(txtDocumento.Text) || string.IsNullOrWhiteSpace(txtClave.Text))
            {
                MessageBox.Show("Debe ingresar DNI y clave.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string claveHash = ClaveHash.ObtenerSha256(txtClave.Text.Trim());
            CE_Usuario oUsuario = new CN_Usuario().Login(txtDocumento.Text.Trim(), claveHash);

            if (oUsuario == null)
            {
                MessageBox.Show("DNI y/o Clave invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            this.Hide();
            frmInicio form = new frmInicio(oUsuario);
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
            txtDocumento.Text = "";
            txtClave.Text = "";
            txtDocumento.Focus();
            this.Show();
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
