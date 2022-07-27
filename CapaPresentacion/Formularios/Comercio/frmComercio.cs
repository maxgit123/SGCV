using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;

namespace CapaPresentacion.Formularios.Comercio
{
    public partial class frmComercio : Form
    {
        public frmComercio()
        {
            InitializeComponent();
        }
        private void frmComercio_Load(object sender, EventArgs e)
        {
            bool leido = true;
            byte[] byteimagen = new CN_Comercio().LeerLogo(out leido);
            if (leido) //Si leyo correctamente se lo transforma en imagen.
                picLogo.Image = ByteToImage(byteimagen);

            List<CE_ResponsableIVA> listaRespIVA = new CN_ResponsableIVA().Listar();

            foreach (CE_ResponsableIVA item in listaRespIVA)
            {
                cbResponsableIVA.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.Nombre });
                cbResponsableIVA.DisplayMember = "Texto";
                cbResponsableIVA.ValueMember = "Valor";
                cbResponsableIVA.SelectedIndex = 0;
            }

            List<CE_Provincia> listaProvincia = new CN_Provincia().Listar();

            foreach (CE_Provincia item in listaProvincia)
            {
                cbProvincia.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.Nombre });
                cbProvincia.DisplayMember = "Texto";
                cbProvincia.ValueMember = "Valor";
                cbProvincia.SelectedIndex = 0;
            }

            CE_Comercio oComercio = new CN_Comercio().Leer();
            txtRazonSocial.Text = oComercio.RazonSocial;
            txtCUIT.Text = oComercio.Cuit;
            txtIngresosBrutos.Text = oComercio.IngresosBrutos;
            cbResponsableIVA.SelectedIndex = oComercio.oResponsableIVA.Id - 1;
            //dtInicioActividad.Value = DateTime.ParseExact(oComercio.InicioActividad,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            dtInicioActividad.Value = Convert.ToDateTime(oComercio.InicioActividad);
            txtFechaActualizacion.Text = oComercio.FechaActualizacion;
            numPuntoVenta.Value = oComercio.PuntoVenta;
            txtNomCalle.Text = oComercio.oDireccion.Calle;
            txtNumCalle.Text = oComercio.oDireccion.Numero;
            txtCiudad.Text = oComercio.oLocalidad.Nombre;
            txtCP.Text = oComercio.oLocalidad.CodigoPostal;
            cbProvincia.SelectedIndex = oComercio.oProvincia.Id - 1;
            txtTelefono.Text = oComercio.Telefono;
            txtCorreo.Text = oComercio.Correo;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CE_Comercio oComercio = new CE_Comercio()
            {
                Id = 1,
                RazonSocial = txtRazonSocial.Text,
                Cuit = txtCUIT.Text,
                IngresosBrutos = txtIngresosBrutos.Text,
                InicioActividad = dtInicioActividad.Value.ToString("dd/MM/yyyy"),
                PuntoVenta = (int)numPuntoVenta.Value,
                oResponsableIVA = new CE_ResponsableIVA() { Id = Convert.ToInt32(((OpcionCombo)cbResponsableIVA.SelectedItem).Valor) },
                oDireccion = new CE_Direccion() { Id = 1, Calle = txtNomCalle.Text, Numero = txtNumCalle.Text },
                oLocalidad = new CE_Localidad() { Id = Convert.ToInt32(txtCP.Text), Nombre = txtCiudad.Text },
                oProvincia = new CE_Provincia() { Id = Convert.ToInt32(((OpcionCombo)cbProvincia.SelectedItem).Valor) }
            };
            bool respuesta = new CN_Comercio().Actualizar(oComercio, out mensaje);
            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnActLogo_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";
            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImagen = File.ReadAllBytes(oOpenFileDialog.FileName);
                bool respuesta = new CN_Comercio().ActualizarLogo(byteImagen, out mensaje);
                if (respuesta)
                    picLogo.Image = ByteToImage(byteImagen);
                else
                    MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = new Bitmap(ms);
            return imagen;
        }
    }
}