using System;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

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

            // FirstOrDefault te regresa el elemento o null.
            //CE_Usuario oUsuario = new CN_Usuario().Listar()
            //    .FirstOrDefault(u => u.Documento == txtDocumento.Text.Trim() && u.Clave == txtClave.Text.Trim());

            CE_Usuario oUsuario = new CN_Usuario().Login(txtDocumento.Text.Trim(), txtClave.Text.Trim());

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
