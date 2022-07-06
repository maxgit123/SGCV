using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Lo que agregue:
using System.IO;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System.Globalization;

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

            //Carga la lista de responsable IVA
            List<CE_RespIVA> listaRespIVA = new CN_RespIVA().Listar();

            foreach (CE_RespIVA item in listaRespIVA)
            {
                cbRespIVA.Items.Add(new OpcionCombo() { Valor = item.IdRespIVA, Texto = item.ResponsableIVA });
                cbRespIVA.DisplayMember = "Texto";
                cbRespIVA.ValueMember = "Valor";
                cbRespIVA.SelectedIndex = 0;
            }

            //Carga la lista de provincias
            List<CE_Provincia> listaProvincia = new CN_Provincia().Listar();

            foreach (CE_Provincia item in listaProvincia)
            {
                cbProvincia.Items.Add(new OpcionCombo() { Valor = item.IdProvincia, Texto = item.NomProvincia });
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
            txtCP.Text = oComercio.oLocalidad.IdLocalidad.ToString();
            txtCiudad.Text = oComercio.oLocalidad.NomLocalidad;
            cbRespIVA.SelectedIndex = oComercio.oRespIVA.IdRespIVA - 1;
            cbProvincia.SelectedIndex = oComercio.oProvincia.IdProvincia - 1;
            txtTelefono.Text = oComercio.oContacto.Telefono;
            txtCorreo.Text = oComercio.oContacto.Correo;
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
                IdComercio = 1,
                RazonSocial = txtRazonSocial.Text,
                Cuit = txtCUIT.Text,
                IngBrutos = txtIngBrutos.Text,
                InicioAct = dtInicioAct.Value.ToString("dd/MM/yyyy"),
                PuntoVenta = (int)numPuntoVenta.Value,
                oRespIVA = new CE_RespIVA() { IdRespIVA = Convert.ToInt32(((OpcionCombo)cbRespIVA.SelectedItem).Valor) },
                oDireccion = new CE_Direccion() { IdDireccion = 1, Calle = txtNomCalle.Text, Numero = txtNumCalle.Text },
                oLocalidad = new CE_Localidad() { IdLocalidad = Convert.ToInt32(txtCP.Text), NomLocalidad = txtCiudad.Text},
                oProvincia = new CE_Provincia() { IdProvincia = Convert.ToInt32(((OpcionCombo)cbProvincia.SelectedItem).Valor)},
                oContacto = new CE_Contacto() { IdContacto = 1, Telefono = txtTelefono.Text, Correo = txtCorreo.Text }
            };
            bool respuesta = new CN_Comercio().Actualizar(oComercio, out mensaje);
            if(respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}