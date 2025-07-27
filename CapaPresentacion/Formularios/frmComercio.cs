using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios
{
    public partial class frmComercio : Form
    {
        private byte[] _logoBytes = null;

        public frmComercio()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(63, 81, 181); // Indigo 500
        }

        private void frmComercio_Load(object sender, EventArgs e)
        {
            List<CE_ResponsableIVA> listaRespIVA = new CN_ResponsableIVA().Listar();
            cbCondicionIva.DataSource = listaRespIVA
                .Select(r => new OpcionCombo { Valor = r.Id, Texto = r.Nombre })
                .ToList();
            cbCondicionIva.ValueMember = "Valor";
            cbCondicionIva.DisplayMember = "Texto";

            List<CE_Provincia> listaProvincia = new CN_Provincia().Listar();
            cbProvincia.DataSource = listaProvincia
                .Select(p => new OpcionCombo { Valor = p.Id, Texto = p.Nombre })
                .ToList();
            cbProvincia.ValueMember = "Valor";
            cbProvincia.DisplayMember = "Texto";

            CE_Comercio oComercio = new CN_Comercio().Leer();

            txtRazonSocial.Text = oComercio.RazonSocial;
            txtCuit.Text = oComercio.Cuit;
            txtIngresosBrutos.Text = oComercio.IngresosBrutos;
            //dtInicioActividad.Value = oComercio.InicioActividad;
            txtInicioActividad.Text = oComercio.InicioActividad.ToString("dd/MM/yyyy");
            txtFechaActualizacion.Text = oComercio.FechaActualizacion.ToString("dd/MM/yyyy");
            txtFechaActualizacion.Enabled = false; // Deshabilita el campo de fecha de actualización para que no se pueda editar.
            txtPuntoVenta.Text = Convert.ToString(oComercio.PuntoVenta);
            txtTelefono.Text = oComercio.Telefono;
            txtCorreo.Text = oComercio.Correo;
            txtCalleNombre.Text = oComercio.oDireccion.Calle;
            txtCalleNumero.Text = oComercio.oDireccion.Numero;
            txtCiudad.Text = oComercio.oLocalidad.Nombre;
            txtCodigoPostal.Text = oComercio.oLocalidad.CodigoPostal;
            cbProvincia.SelectedIndex = oComercio.oProvincia.Id - 1;
            cbCondicionIva.SelectedValue = oComercio.oResponsableIVA.Id;

            if (oComercio.Logo != null && oComercio.Logo.Length > 0)
            {
                picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                picLogo.Image = ByteToImage(oComercio.Logo);
            }
            else
            {
                picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
                picLogo.Image = Properties.Resources.image_logo_96;
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar los cambios?", "Guardar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (!EsFechaValida(txtInicioActividad.Text, out DateTime fechaInicioActividad))
            {
                MessageBox.Show("La fecha de inicio de actividad no es válida", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CE_Comercio oComercio = new CE_Comercio()
            {
                Id = 1,
                RazonSocial = txtRazonSocial.Text,
                Cuit = txtCuit.Text,
                IngresosBrutos = txtIngresosBrutos.Text,
                InicioActividad = fechaInicioActividad,
                PuntoVenta = int.TryParse(txtPuntoVenta.Text, out int pv) ? pv : 0,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                Logo = _logoBytes,
                oDireccion = new CE_Direccion()
                {
                    Id = 1,
                    Calle = txtCalleNombre.Text,
                    Numero = txtCalleNumero.Text
                },
                oLocalidad = new CE_Localidad()
                {
                    Id = 1,
                    Nombre = txtCiudad.Text,
                    CodigoPostal = txtCodigoPostal.Text
                },
                oProvincia = new CE_Provincia()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbProvincia.SelectedItem).Valor)
                },
                oResponsableIVA = new CE_ResponsableIVA()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbCondicionIva.SelectedItem).Valor)
                }
            };

            if (new CN_Comercio().Actualizar(oComercio, out string mensaje))
            {
                MessageBox.Show("Los cambios fueron guardados con éxito.", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                _logoBytes = null;
            }
            else
                MessageBox.Show(mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool EsFechaValida(string fecha, out DateTime fechaValida)
        {
            fechaValida = DateTime.MinValue;

            if (string.IsNullOrWhiteSpace(fecha))
                return false;

            fecha = fecha.Replace('-', '/').Replace('.', '/');

            return DateTime.TryParseExact(fecha,
                "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None,
                out fechaValida);
        }
        private void btnCambiarLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog oOpenFileDialog = new OpenFileDialog())
            {
                oOpenFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _logoBytes = File.ReadAllBytes(oOpenFileDialog.FileName);
                    picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    picLogo.Image = ByteToImage(_logoBytes);
                }
            }
        }
        private void btnQuitarLogo_Click(object sender, EventArgs e)
        {
            picLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            picLogo.Image = Properties.Resources.image_logo_96;
            _logoBytes = null;
        }
        public Image ByteToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void txtPuntoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y teclas de control (backspace, etc)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void frmComercio_Resize(object sender, EventArgs e)
        {
            UtilidadesForm.CentrarHorizontalmente(pnlComercioDatos);
        }
    }
}