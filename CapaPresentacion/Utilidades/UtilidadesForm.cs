using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Utilidades
{
    public static class UtilidadesForm
    {
        public static readonly Color ColorActivo = SystemColors.Control;
        public static readonly Color ColorInactivo = Color.Lavender;

        /// <summary>
        /// Habilita un panel y deshabilita otro.
        /// También alterna sus colores de fondo y enfoca un control opcional.
        /// </summary>
        public static void AlternarPanelHabilitado(Panel panelActivo, Panel panelInactivo, Control controlFocus = null)
        {
            panelActivo.Enabled = true;
            panelActivo.BackColor = ColorActivo;
            panelActivo.BorderStyle = BorderStyle.FixedSingle;

            panelInactivo.Enabled = false;
            panelInactivo.BackColor = ColorInactivo;
            panelInactivo.BorderStyle = BorderStyle.None;

            controlFocus?.Focus();
        }

        /// <summary>
        /// Reinicia a los valores por defecto los controles de un contenedor, como un TextBox o ComboBox.
        /// </summary>
        /// <param name="contenedor">El control contenedor que contiene los controles a reiniciar.</param>
        public static void ReiniciarControles(Control contenedor)
        {
            foreach (Control control in contenedor.Controls)
            {
                switch (control)
                {
                    case TextBox txt:
                        txt.Clear();
                        txt.BackColor = SystemColors.Window;
                        break;
                    case ComboBox cb:
                        cb.SelectedIndex = -1;
                        break;
                    case NumericUpDown nud:
                        nud.Value = nud.Minimum;
                        break;
                    case DateTimePicker dtp:
                        dtp.Value = DateTime.Now;
                        break;
                    case CheckBox chk:
                        chk.Checked = false;
                        break;
                    case RadioButton rb:
                        rb.Checked = false;
                        break;
                }
            }
        }

        /// <summary>
        /// Muestra un cuadro de diálogo de confirmación y retorna true si el usuario selecciona "Sí".
        /// </summary>
        /// <param name="mensaje">El mensaje a mostrar en el cuadro de diálogo.</param>
        /// <returns>true si el usuario selecciona "Sí", false en caso contrario.</returns>
        public static bool ConfirmarAccion(string mensaje)
        {
            return MessageBox.Show(mensaje, "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        /// <summary>
        /// Centra horizontalmente un control dentro de su contenedor padre.
        /// </summary>
        /// <param name="ctrl">El control a centrar.</param>
        public static void CentrarHorizontalmente(Control ctrl)
        {
            if (ctrl?.Parent != null)
                ctrl.Left = (ctrl.Parent.Width - ctrl.Width) / 2;
        }

        /// <summary>
        /// Permite solo números, un punto decimal y teclas de control en un TextBox para precios.
        /// Usar en el evento KeyPress del TextBox.
        /// </summary>
        public static void EsEntradaPrecioValida(object sender, KeyPressEventArgs e)
        {
            // CultureInfo en el programa esta seteada como "es-AR" en el archivo Program.cs

            if (!(sender is TextBox textBox))
            {
                e.Handled = true;
                return;
            }

            // Permitir teclas de control (backspace, etc)
            if (char.IsControl(e.KeyChar))
                return;

            // Permitir solo una sola coma decimal, pero no como primer carácter
            if (e.KeyChar == ',')
            {
                // No permitir el punto como primer carácter o si ya hay un punto
                if (textBox.Text.Length == 0 || textBox.Text.Contains(","))
                {
                    e.Handled = true;
                    return;
                }
                return;
            }

            // Permitir números
            if (char.IsDigit(e.KeyChar))
            {
                // Si ya hay una coma, limitar a dos decimales
                int indiceComa = textBox.Text.IndexOf(',');

                if (indiceComa >= 0)
                {
                    // Si el cursor está después del punto, contar los decimales actuales
                    int decimalesActuales = textBox.Text.Length - indiceComa - 1;

                    // Si el cursor está después del punto y ya hay dos decimales, bloquear
                    if (textBox.SelectionStart > indiceComa && decimalesActuales >= 2)
                    {
                        e.Handled = true;
                        return;
                    }
                }
                return;
            }

            // Bloquear cualquier otro carácter
            e.Handled = true;
        }

        /// <summary>
        /// Valida que el string ingresado sea un precio válido (decimal positivo, hasta 2 decimales).
        /// </summary>
        /// <param name="texto">El precio a validar.</param>
        public static bool EsPrecioValido(string texto)
        {
            // CultureInfo en el programa esta seteada como "es-AR" en el archivo Program.cs

            if (string.IsNullOrWhiteSpace(texto))
                return false;

            if (!decimal.TryParse(texto, out decimal valor))
                return false;

            if (valor < 0)
                return false;

            // Validar hasta 2 decimales
            int decimales = texto.Contains(",") ? texto.Split(',')[1].Length : 0;
            if (decimales > 2)
                return false;

            return true;
        }
    }
}
