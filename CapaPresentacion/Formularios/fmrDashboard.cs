using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;

namespace CapaPresentacion.Formularios
{
    public partial class fmrDashboard : Form
    {
        private static CE_Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        public fmrDashboard(CE_Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            menuTituloUsuario.Text = usuarioActual.Apellido + ", " + usuarioActual.Nombre;
            smenuRol.Text = usuarioActual.oRol.NomRol;
            //----Muestra el menu segun los permisos del usuario----
            List<CE_Modulo> ListaModulos = new CN_Modulo().Listar(usuarioActual.Id); //Obtiene los permisos del usuario.

            foreach (IconMenuItem iconmenu in menuPrincipal.Items) //En cada uno comprueba
            {
                bool encontrado = ListaModulos.Any(m => m.Nombre == iconmenu.Name); //que el nombre sea el mismo
                if (encontrado == false) //si no lo encuentra
                    iconmenu.Visible = false; //lo oculta.
            }
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
                menuActivo.BackColor = Color.White;

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            if (formularioActivo != null) //Si ya mostre uno anteriormente
                formularioActivo.Close(); //lo cierro para que se pueda mostrar uno nuevo.

            formularioActivo = formulario; //Que sea el form activo.
            formulario.TopLevel = false; //Que no este sobre todo.
            formulario.FormBorderStyle = FormBorderStyle.None; //Que no tenga bordes.
            formulario.Dock = DockStyle.Fill; //Que rellene todo el conetenedor.
            //formulario.BackColor = Color.White;
            panelDashboard.Controls.Add(formulario); //Se le agrega el form al contenedor.
            formulario.Show(); //Se muestra.
        }
        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Usuarios.frmUsuarios());
        }
        private void menuComercio_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Comercio.frmComercio());
        }
        private void smenuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Productos.frmProductos());
        }
        private void smenuCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Productos.frmCategorias());
        }
        private void menuProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Proveedores.frmProveedores());
        }
        private void smenuRegistCompra_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Compras.frmCompras());
        }
        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Clientes.frmClientes());
        }
        private void smenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
