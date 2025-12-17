using System;
using System.IO;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using iText.Html2pdf;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;

namespace CapaPresentacion.Formularios
{
    public partial class frmVentaDetalle : Form
    {
        private bool _datosCargados = false;

        public frmVentaDetalle()
        {
            InitializeComponent();
            UtilidadesDGV.Configurar(dgvProductos);
        }

        private void txtNroVenta_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarVenta(this, CargarDatosVenta);
        }
        private void txtNroVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilidadesTextBox.PermitirSoloDigitos(sender, e);
        }
        private void txtNroVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (string.IsNullOrWhiteSpace(txtNroVenta.Text))
                return;

            if (!int.TryParse(txtNroVenta.Text, out int idVenta))
            {
                txtNroVenta.SetErrorState(true);
                MessageBox.Show("Ingrese un número de venta válido.", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CE_Venta oVenta = new CN_Venta().ObtenerVenta(idVenta);
            CargarDatosVenta(oVenta);
        }
        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            UtilidadesForm.ReiniciarControles(pnlInfoVenta);
            txtNroVenta.SetErrorState(false);
            dgvProductos.Rows.Clear();

            _datosCargados = false;
            txtNroVenta_AlternarTrailingIcon();
        }
        private void btnGenerarPdf_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBox.Show("No hay datos caragdos para generar el PDF.", "Generar PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Guardar archivo PDF",
                Filter = "Archivo PDF (*.pdf)|*.pdf",
                FileName = $"Venta_{txtNroVenta.Text}.pdf"
            };

            if (saveFile.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                string texto_html = Properties.Resources.PlantillaVenta.ToString();
                CE_Comercio oComercio = new CN_Comercio().Leer();

                // --- Logo ---
                if (oComercio.Logo != null && oComercio.Logo.Length > 0)
                {
                    byte[] byteImage = oComercio.Logo;
                    string imgBase64 = Convert.ToBase64String(byteImage);
                    texto_html = texto_html.Replace("@Logo", $"data:image/png;base64,{imgBase64}");
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        Properties.Resources.image_logo_96.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] byteImage = ms.ToArray();
                        string imgBase64 = Convert.ToBase64String(byteImage);
                        texto_html = texto_html.Replace("@Logo", $"data:image/png;base64,{imgBase64}");
                    }
                }
                // --- Comercio ---
                texto_html = texto_html.Replace("@RazonSocial", oComercio.RazonSocial);
                texto_html = texto_html.Replace("@Cuit", oComercio.Cuit);
                texto_html = texto_html.Replace("@IngresosBrutos", oComercio.IngresosBrutos);
                texto_html = texto_html.Replace("@Direccion", $"{oComercio.oDireccion.Calle} {oComercio.oDireccion.Numero}");
                texto_html = texto_html.Replace("@CodigoPostal", oComercio.oLocalidad.CodigoPostal);
                texto_html = texto_html.Replace("@Localidad", oComercio.oLocalidad.Nombre);
                texto_html = texto_html.Replace("@Provincia", oComercio.oProvincia.Nombre);
                texto_html = texto_html.Replace("@TelefonoComercio", oComercio.Telefono);
                texto_html = texto_html.Replace("@InicioActividad", oComercio.InicioActividad.ToString("dd/MM/yyyy"));
                texto_html = texto_html.Replace("@RespIVA", oComercio.oResponsableIVA.Nombre);
                texto_html = texto_html.Replace("@PuntoVenta", oComercio.PuntoVenta.ToString());
                // --- Venta ---
                texto_html = texto_html.Replace("@FechaVenta", txtFechaVenta.Text);
                texto_html = texto_html.Replace("@NroVenta", txtNroVenta.Text);
                texto_html = texto_html.Replace("@TipoFactura", txtTipoFactura.Text);

                switch (txtTipoFactura.Text)
                {
                    case "A":
                        texto_html = texto_html.Replace("@ClienteRespIVA", "RESPONSABLE INSCRIPTO");
                        break;
                    case "B":
                        texto_html = texto_html.Replace("@ClienteRespIVA", "CONSUMIDOR FINAL");
                        break;
                    case "C":
                        texto_html = texto_html.Replace("@ClienteRespIVA", "CONSUMIDOR FINAL");
                        break;
                }

                // --- Detalle de productos ---
                string filas = string.Empty;
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    filas += "<tr>";
                    filas += $"<td class=\"text-left\">{fila.Cells["descripcion"].Value}</td>";
                    filas += "</tr>";
                    filas += "<tr>";
                    filas += $"<td class=\"text-left\">{fila.Cells["cantidad"].Value}x{Convert.ToDecimal(fila.Cells["precioUnit"].Value):N2} / {fila.Cells["codigo"].Value}</td>";
                    filas += $"<td class=\"text-right\">{Convert.ToDecimal(fila.Cells["subtotal"].Value):N2}</td>";
                    filas += "</tr>";
                }
                texto_html = texto_html.Replace("@Filas", filas);
                texto_html = texto_html.Replace("@Total", txtTotal.Text);
                texto_html = texto_html.Replace("@Pago", txtPago.Text);
                texto_html = texto_html.Replace("@Vuelto", txtVuelto.Text);

                using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    ConverterProperties converterProperties = new ConverterProperties();
                    PdfDocument pdf = new PdfDocument(new PdfWriter(fs));
                    Document pdfDoc = new Document(pdf, PageSize.A6);
                    HtmlConverter.ConvertToPdf(texto_html, pdf, converterProperties);
                }

                MessageBox.Show("PDF generado correctamente.", "Generar PDF",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el PDF: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Cursor = Cursors.Default;
        }

        private void CargarDatosVenta(CE_Venta oVenta)
        {
            if (oVenta.Id == 0)
            {
                txtNroVenta.SetErrorState(true);
                return;
            }

            txtNroVenta.SetErrorState(false);
            txtNroVenta.Text = oVenta.Id.ToString();
            txtFechaVenta.Text = oVenta.FechaVenta.ToString("dd/MM/yyyy");
            txtTipoFactura.Text = oVenta.TipoFactura;
            txtUsuario.Text = oVenta.oUsuario.NombreCompleto;
            txtUsuarioDocumento.Text = oVenta.oUsuario.Documento;
            txtFechaCreacion.Text = oVenta.FechaCreacion.ToString("dd/MM/yyyy HH:mm:ss");
            txtClienteDocumento.Text = oVenta.oCliente.Documento;
            txtClienteNombre.Text = oVenta.oCliente.NombreCompleto;
            txtTelefono.Text = oVenta.oCliente.Telefono;
            txtCorreo.Text = oVenta.oCliente.Correo;
            txtTotal.Text = oVenta.Total.ToString("N2");
            txtPago.Text = oVenta.Pago.ToString("N2");
            txtVuelto.Text = oVenta.Vuelto.ToString("N2");

            dgvProductos.Rows.Clear();
            foreach (CE_VentaDetalle vd in oVenta.oVentaDetalle)
            {
                dgvProductos.Rows.Add(new object[]
                {
                    vd.oProducto.Codigo,
                    vd.oProducto.Descripcion,
                    vd.Cantidad,
                    vd.PrecioVentaUnitario,
                    vd.Subtotal
                });
            }

            _datosCargados = true;
            txtNroVenta_AlternarTrailingIcon();
        }
        private void ActualizarTrailingIcon()
        {
            txtNroVenta.ReadOnly = _datosCargados;
            txtNroVenta.TrailingIcon = _datosCargados
                ? Properties.Resources.cancel_32
                : Properties.Resources.search_32;
        }
        private void txtNroVenta_AlternarTrailingIcon()
        {
            ActualizarTrailingIcon();

            if (_datosCargados)
            {
                txtNroVenta.ReadOnly = true;
                txtNroVenta.TrailingIconClick -= txtNroVenta_TrailingIconClick;
                txtNroVenta.TrailingIconClick += btnBorrarCampos_Click;
            }
            else
            {
                txtNroVenta.ReadOnly = false;
                txtNroVenta.TrailingIconClick -= btnBorrarCampos_Click;
                txtNroVenta.TrailingIconClick += txtNroVenta_TrailingIconClick;
            }
        }

    }
}