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
        public frmComercio()
        {
            InitializeComponent();
        }
        private void frmComercio_Load(object sender, EventArgs e)
        {
            byte[] byteimagen = new CN_Comercio().LeerLogo(out bool logoLeido); // Renamed 'leido' to 'logoLeido'  

            if (logoLeido && byteimagen.Length > 0)
                picLogo.Image = ByteToImage(byteimagen);
            else
                picLogo.Image = null;

            List<CE_ResponsableIVA> listaRespIVA = new CN_ResponsableIVA().Listar();
            cbResponsableIVA.DataSource = listaRespIVA
                .Select(r => new OpcionCombo { Valor = r.Id, Texto = r.Nombre })
                .ToList();
            cbResponsableIVA.ValueMember = "Valor";
            cbResponsableIVA.DisplayMember = "Texto";

            List<CE_Provincia> listaProvincia = new CN_Provincia().Listar();
            cbProvincia.DataSource = listaProvincia
                .Select(p => new OpcionCombo { Valor = p.Id, Texto = p.Nombre })
                .ToList();
            cbProvincia.ValueMember = "Valor";
            cbProvincia.DisplayMember = "Texto";

            CE_Comercio oComercio = new CN_Comercio().Leer();

            txtRazonSocial.Text = oComercio.RazonSocial;
            txtCUIT.Text = oComercio.Cuit;
            txtIngresosBrutos.Text = oComercio.IngresosBrutos;
            dtInicioActividad.Value = oComercio.InicioActividad;
            txtFechaActualizacion.Text = oComercio.FechaActualizacion.ToString("dd/MM/yyyy");
            txtFechaActualizacion.Enabled = false; // Deshabilita el campo de fecha de actualización para que no se pueda editar.
            numPuntoVenta.Value = oComercio.PuntoVenta;
            txtTelefono.Text = oComercio.Telefono;
            txtCorreo.Text = oComercio.Correo;
            txtNomCalle.Text = oComercio.oDireccion.Calle;
            txtNumCalle.Text = oComercio.oDireccion.Numero;
            txtCiudad.Text = oComercio.oLocalidad.Nombre;
            txtCP.Text = oComercio.oLocalidad.CodigoPostal;
            cbProvincia.SelectedIndex = oComercio.oProvincia.Id - 1;
            cbResponsableIVA.SelectedValue = oComercio.oResponsableIVA.Id;

            //foreach (OpcionCombo item in cbResponsableIVA.Items)
            //{
            //    if ((int)item.Valor == oComercio.oResponsableIVA.Id)
            //    {
            //        cbResponsableIVA.SelectedItem = item;
            //        break;
            //    }
            //}

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CE_Comercio oComercio = new CE_Comercio()
            {
                Id = 1,
                RazonSocial = txtRazonSocial.Text,
                Cuit = txtCUIT.Text,
                IngresosBrutos = txtIngresosBrutos.Text,
                InicioActividad = dtInicioActividad.Value, // ToString("dd/MM/yyyy"),
                PuntoVenta = (int)numPuntoVenta.Value,
                Telefono = txtTelefono.Text,
                Correo = txtCorreo.Text,
                oDireccion = new CE_Direccion()
                {
                    Id = 1,
                    Calle = txtNomCalle.Text,
                    Numero = txtNumCalle.Text
                },
                oLocalidad = new CE_Localidad()
                {
                    Id = 1,
                    Nombre = txtCiudad.Text,
                    CodigoPostal = txtCP.Text
                },
                oProvincia = new CE_Provincia()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbProvincia.SelectedItem).Valor)
                },
                oResponsableIVA = new CE_ResponsableIVA()
                {
                    Id = Convert.ToInt32(((OpcionCombo)cbResponsableIVA.SelectedItem).Valor)
                }
            };

            bool respuesta = new CN_Comercio().Actualizar(oComercio, out string mensaje);

            if (respuesta)
                MessageBox.Show("Los cambios fueron guardados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnActLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog oOpenFileDialog = new OpenFileDialog())
            {
                oOpenFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png";

                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] byteImagen = File.ReadAllBytes(oOpenFileDialog.FileName);
                    bool actualizado = new CN_Comercio().ActualizarLogo(byteImagen, out string mensaje);

                    if (actualizado)
                    {
                        picLogo.Image = ByteToImage(byteImagen);
                        MessageBox.Show("Logo actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public Image ByteToImage(byte[] imageBytes)
        {
            //MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            //ms.Write(imageBytes, 0, imageBytes.Length);
            //Image imagen = new Bitmap(ms);
            //return imagen;

            /*
                Más clara.
                Más eficiente.
                Menos propensa a errores.
                Recomendada por la documentación de .NET para este caso.
             */

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}