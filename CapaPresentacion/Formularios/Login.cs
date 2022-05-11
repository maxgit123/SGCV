using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
//Lo que agregue:
using CapaNegocio;
using CapaEntidad;

namespace CapaPresentacion.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            CE_Usuario oUsuario = new CN_Usuario().Listar().FirstOrDefault(u => u.Documento == txtDocumento.Text.Trim() && u.Clave == txtClave.Text.Trim()); //Expresion lambda.
            //FirstOrDefault te regresa el elemento o null.
            if (oUsuario != null) //Y si es diferente a null . . . es porque si existe.
            {
                Dashboard form = new Dashboard(oUsuario);
                form.Show(); //Muestra el dashboard
                this.Hide(); //y oculta el login.
                form.FormClosing += frm_closing; //Cuando se cierra el dashboard vuelve a mostrar el form de login que se oculto.
            }
            else
            {
                MessageBox.Show("DNI y/o Clave invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra completamente el programa.
        }
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = ""; //Se limpian las cajas de texto para evitar
            txtClave.Text = ""; //que quede los datos del usuario en el form.
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
