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

            CE_Usuario oUsuario = new CN_Usuario().Listar().FirstOrDefault(u => u.Documento == txtDocumento.Text.Trim() && u.Clave == txtClave.Text.Trim());
            //FirstOrDefault te regresa el elemento o null.

            if (oUsuario == null)
            {
                MessageBox.Show("DNI y/o Clave invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.Hide();
            frmInicio form = new frmInicio(oUsuario);
            //Cuando se cierra el dashboard vuelve a mostrar el form de login que se oculto.
            form.FormClosing += frm_closing;
            form.Show();

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra completamente el programa.
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = "";
            txtClave.Text = "";
            this.Show();
        }
        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Valida que solo se ingresen números.
            }
        }
    }
}
