using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using FontAwesome.Sharp;

namespace CapaPresentacion.Formularios
{
    public partial class frmInicio : Form
    {
        private static CE_Usuario usuarioActual;
        private static IconMenuItem menuActivo = null;
        private static Form formularioActivo = null;
        public frmInicio(CE_Usuario oUsuario)
        {
            usuarioActual = oUsuario;
            InitializeComponent();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // ------ Configuraciones del Formulario ------
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1024, 600);
            this.MinimumSize = new Size(850, 600);

            menuTituloUsuario.Text = $"{usuarioActual.Apellido}, {usuarioActual.Nombre}";
            smenuRol.Text = usuarioActual.oRol.Nombre;

            // Obtiene una lista de modulos permitidos para el usuario actual.
            List<CE_Modulo> modulosPermitidos = new CN_Modulo().Listar(usuarioActual.Id);

            // Filtra los item del menu en base a los permisos del usuario.
            foreach (IconMenuItem iconmenu in menuPrincipal.Items) 
            {
                iconmenu.Visible = modulosPermitidos.Any(m =>
                    string.Equals(m.Nombre, iconmenu.Name, StringComparison.OrdinalIgnoreCase));
                //bool encontrado = modulosPermitidos.Any(m => m.Nombre == iconmenu.Name);
            }
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (menuActivo != null)
                menuActivo.BackColor = Color.White;

            menu.BackColor = Color.Silver;
            menuActivo = menu;

            // Si ya mostre uno anteriormente (si no es null), lo cierro para que se pueda mostrar uno nuevo.
            formularioActivo?.Close();

            formularioActivo = formulario; // Que sea el form activo.
            formulario.TopLevel = false; // Que no este sobre todo.
            formulario.FormBorderStyle = FormBorderStyle.None; // Que no tenga bordes.
            formulario.Dock = DockStyle.Fill; // Que rellene todo el conetenedor.
            //formulario.BackColor = Color.White;
            panelDashboard.Controls.Add(formulario); // Se le agrega el form al contenedor.
            formulario.Show(); // Se muestra.
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
            AbrirFormulario((IconMenuItem)sender, new Compras.frmCompras(usuarioActual));
        }
        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Clientes.frmClientes());
        }
        private void smenuCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Usuarios.mdCambiarClave(usuarioActual);
            form.ShowDialog();
        }
        private void smenuDetalleCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Compras.frmDetalleCompra());
        }
        private void smenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Ventas.frmVentas(usuarioActual));
        }
    }
}
