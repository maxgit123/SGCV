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
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image imagen = new Bitmap(ms);
            return imagen;
        }
        private void frmComercio_Load(object sender, EventArgs e)
        {
            //Se carga el logo desde BD
            bool leido = true;
            byte[] byteimagen = new CN_Comercio().LeerLogo(out leido);
            if (leido) //y si cargo correctamente se lo transforma en imagen.
                picLogo.Image = ByteToImage(byteimagen);

            List<CE_ResponsableIVA> listaRespIVA = new CN_ResponsableIVA().Listar();

            foreach (CE_ResponsableIVA item in listaRespIVA)
            {
                cbRespIVA.Items.Add(new OpcionCombo() { Valor = item.Id, Texto = item.Nombre });
                cbRespIVA.DisplayMember = "Texto";
                cbRespIVA.ValueMember = "Valor";
                cbRespIVA.SelectedIndex = 0;
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
            txtIngBrutos.Text = oComercio.IngBrutos;
            dtInicioAct.Value = DateTime.ParseExact(oComercio.InicioAct, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            numPuntoVenta.Value = oComercio.PuntoVenta;
            txtNomCalle.Text = oComercio.oDireccion.Calle;
            txtNumCalle.Text = oComercio.oDireccion.Numero;
            txtCP.Text = oComercio.oLocalidad.Id.ToString();
            txtCiudad.Text = oComercio.oLocalidad.Nombre;
            cbRespIVA.SelectedIndex = oComercio.oResponsableIVA.Id - 1;
            cbProvincia.SelectedIndex = oComercio.oProvincia.Id - 1;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            CE_Comercio oComercio = new CE_Comercio()
            {
                Id = 1,
                RazonSocial = txtRazonSocial.Text,
                Cuit = txtCUIT.Text,
                IngBrutos = txtIngBrutos.Text,
                InicioAct = dtInicioAct.Value.ToString("dd/MM/yyyy"),
                PuntoVenta = (int)numPuntoVenta.Value,
                oResponsableIVA = new CE_ResponsableIVA() { Id = Convert.ToInt32(((OpcionCombo)cbRespIVA.SelectedItem).Valor) },
                oDireccion = new CE_Direccion() { Id = 1, Calle = txtNomCalle.Text, Numero = txtNumCalle.Text },
                oLocalidad = new CE_Localidad() { Id = Convert.ToInt32(txtCP.Text), Nombre = txtCiudad.Text},
                oProvincia = new CE_Provincia() { Id = Convert.ToInt32(((OpcionCombo)cbProvincia.SelectedItem).Valor)}
            };
            bool respuesta = new CN_Comercio().Actualizar(oComercio, out mensaje);
            if(respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}