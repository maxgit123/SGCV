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
    public partial class frmCompraDetalle : Form
    {
        public frmCompraDetalle()
        {
            InitializeComponent();
        }

        private void txtNroCompra_TrailingIconClick(object sender, EventArgs e)
        {
            UtilidadesModal.BuscarCompra(this, CargarDatosCompra);
        }
        private void txtNroCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (string.IsNullOrWhiteSpace(txtNroCompra.Text))
                return;

            CE_Compra oCompra = new CN_Compra().ObtenerCompra(Convert.ToInt32(txtNroCompra.Text));
            CargarDatosCompra(oCompra);
        }
        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            UtilidadesForm.ReiniciarControles(pnlInfoCompra);
            txtNroCompra.SetErrorState(false);
            dgvProductos.Rows.Clear();
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
                FileName = $"Compra_{txtNroCompra.Text}.pdf"
            };

            if (saveFile.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string texto_html = Properties.Resources.PlantillaCompra2.ToString();
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
                texto_html = texto_html.Replace("@Direccion", $"{oComercio.oDireccion.Calle} {oComercio.oDireccion.Numero}");
                texto_html = texto_html.Replace("@RespIVA", oComercio.oResponsableIVA.Nombre);
                // --- Proveedor ---
                texto_html = texto_html.Replace("@PrRazonSocial", txtRazonSocial.Text);
                texto_html = texto_html.Replace("@PrTelefono", txtTelefono.Text);
                texto_html = texto_html.Replace("@PrCorreo", txtCorreo.Text);
                // --- Compra ---
                texto_html = texto_html.Replace("@FechaPedido", txtFechaPedido.Text);
                texto_html = texto_html.Replace("@FechaEntrega", txtFechaEntrega.Text);
                texto_html = texto_html.Replace("@FechaCreacion", txtFechaCreacion.Text);
                texto_html = texto_html.Replace("@NroCompra", txtNroCompra.Text);
                texto_html = texto_html.Replace("@Usuario", txtUsuario.Text);
                //texto_html = texto_html.Replace("@Documento", txtDocumento.Text);
                texto_html = texto_html.Replace("@CondCompra", "Condicion de compra"); // No implementado
                // --- Detalle de productos ---
                string filas = string.Empty;
                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    filas += "<tr>";
                    filas += $"<td class=\"text-left\">{fila.Cells["codigo"].Value}</td>";
                    filas += $"<td class=\"text-left\">{fila.Cells["descripcion"].Value}</td>";
                    filas += $"<td class=\"text-right\">{fila.Cells["cantidad"].Value}</td>";
                    filas += $"<td class=\"text-right\">{Convert.ToDecimal(fila.Cells["precioUnit"].Value):N2}</td>";
                    filas += $"<td class=\"text-center\">{Convert.ToDecimal(fila.Cells["subtotal"].Value):N2}</td>";
                    filas += $"<td class=\"text-right\">Alicuota IVA</td>"; // TODO: Agregar campo IVA en el futuro
                    filas += $"<td class=\"text-right\">Subtotal c/IVA</td>"; // TODO: Agregar campo Subtotal c/IVA en el futuro
                    filas += "</tr>";
                }
                texto_html = texto_html.Replace("@Filas", filas);
                texto_html = texto_html.Replace("@Total", txtTotal.Text);

                using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    ConverterProperties converterProperties = new ConverterProperties();
                    PdfDocument pdf = new PdfDocument(new PdfWriter(fs));
                    Document pdfDoc = new Document(pdf, PageSize.A4);
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
        }

        private void CargarDatosCompra(CE_Compra oCompra)
        {
            if (oCompra.Id == 0)
            {
                txtNroCompra.SetErrorState(true);
                return;
            }

            txtNroCompra.Text = oCompra.Id.ToString();
            txtNroCompra.SetErrorState(false);

            txtFechaPedido.Text = oCompra.FechaPedido.ToString("dd/MM/yyyy");
            txtFechaEntrega.Text = oCompra.FechaEntrega.ToString("dd/MM/yyyy");
            txtUsuario.Text = oCompra.oUsuario.NombreCompleto;
            txtDocumento.Text = oCompra.oUsuario.Documento;
            txtFechaCreacion.Text = oCompra.FechaCreacion.ToString("dd/MM/yyyy HH:mm:ss");
            txtRazonSocial.Text = oCompra.oProveedor.RazonSocial;
            txtTelefono.Text = oCompra.oProveedor.Telefono;
            txtCorreo.Text = oCompra.oProveedor.Correo;
            txtTotal.Text = oCompra.Total.ToString("N2");

            dgvProductos.Rows.Clear();
            foreach (CE_CompraDetalle cd in oCompra.oCompraDetalle)
            {
                dgvProductos.Rows.Add(new object[]
                {
                    cd.oProducto.Codigo,
                    cd.oProducto.Descripcion,
                    cd.Cantidad,
                    cd.PrecioCompraUnitario,
                    cd.Subtotal,
                    "Alicuota IVA", // TODO: Placeholder, no implementado
                    "Subtotal c/IVA" // TODO: Placeholder, no implementado
                });
            }
        }
    }
}
