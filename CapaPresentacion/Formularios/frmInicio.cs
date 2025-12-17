using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using FontAwesome.Sharp;
using CapaPresentacion.Formularios.Base;

namespace CapaPresentacion.Formularios
{
    public partial class frmInicio : MaterialFormBase
    {
        private static CE_Usuario _usuarioActual;
        private static IconMenuItem _menuActivo = null;
        private static Form _formularioActivo = null;
        private const int DEFAULT_WIDTH = 1300;
        private const int DEFAULT_HEIGHT = 860;
        private const int MIN_WIDTH = 1024;
        private const int MIN_HEIGHT = 860;

        public frmInicio(CE_Usuario oUsuario)
        {
            InitializeComponent();

            _usuarioActual = oUsuario;
            menuTitulo.BackColor = _materialColor;
            lblTitulo.BackColor = _materialColor;
            panelDashboard.BackColor = _materialColorLight;
            StartPosition = FormStartPosition.CenterScreen;
            Size = new Size(DEFAULT_WIDTH, DEFAULT_HEIGHT);
            MinimumSize = new Size(MIN_WIDTH, MIN_HEIGHT);

            menuTituloUsuario.Text = $"{_usuarioActual.Apellido}, {_usuarioActual.Nombre}";
            smenuRol.Text = _usuarioActual.oRol.Nombre;
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            //var bounds = Screen.FromControl(this).Bounds;
            //this.Width = bounds.Width - 100;
            //this.Height = bounds.Height - 100;

            // Obtiene una lista de modulos permitidos para el usuario actual.
            List<CE_Modulo> modulosPermitidos = new CN_Modulo().Listar(_usuarioActual.Id);

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
            if (_menuActivo != null)
                _menuActivo.BackColor = Color.White;

            menu.BackColor = Color.Silver;
            _menuActivo = menu;

            // Si ya mostre uno anteriormente (si no es null), lo cierro para que se pueda mostrar uno nuevo.
            _formularioActivo?.Close();

            _formularioActivo = formulario; // Que sea el form activo.
            formulario.TopLevel = false; // Que no este sobre todo.
            formulario.FormBorderStyle = FormBorderStyle.None; // Que no tenga bordes.
            formulario.Dock = DockStyle.Fill; // Que rellene todo el conetenedor.
            //formulario.BackColor = Color.White;
            panelDashboard.Controls.Add(formulario); // Se le agrega el form al contenedor.
            formulario.Show(); // Se muestra.
        }
        private void HandleMenuClick(object sender, Form forAabrir)
        {
            if (sender is IconMenuItem menuItem)
            {
                AbrirFormulario(menuItem, forAabrir);
            }
        }
        private void menuUsuarios_Click(object sender, EventArgs e)
        {
            //AbrirFormulario((IconMenuItem)sender, new Usuarios.frmUsuarios());
            HandleMenuClick(sender, new frmUsuario());
        }
        private void menuComercio_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmComercio());
        }
        private void smenuProductos_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmProducto());
        }
        private void smenuCategorias_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmCategoria());
        }
        private void menuProveedores_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmProveedor());
        }
        private void menuClientes_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmCliente());
        }
        private void smenuRegistCompra_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmCompra(_usuarioActual));
        }
        private void smenuDetalleCompras_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmCompraDetalle());
        }
        private void smenuRegistrarVenta_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmVenta(_usuarioActual));
        }
        private void smenuDetalleVentas_Click(object sender, EventArgs e)
        {
            HandleMenuClick(sender, new frmVentaDetalle());
        }
        private void smenuCerrarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Modal.mdUsuarioCambiarClave(_usuarioActual);
            form.ShowDialog();
        }
        private void frmInicio_Resize(object sender, EventArgs e)
        {
            // Si se usa dock top en el menu quedan espacios blancos por el padding de la ventana.
            menuTitulo.Width = this.ClientSize.Width;
        }
        private void menuTituloUsuario_DropDownOpening(object sender, EventArgs e)
        {
            // Cambia el color del texto del menu al abrirlo.
            //var item = sender as ToolStripMenuItem;
            //if (item != null)
            //    item.ForeColor = _materialColor;

            menuTituloUsuario.ForeColor = _materialColor;
        }
        private void menuTituloUsuario_DropDownClosed(object sender, EventArgs e)
        {
            menuTituloUsuario.ForeColor = Color.White;
        }
    }
}
