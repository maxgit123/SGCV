using System.Windows.Forms;
using MaterialSkin.Controls;

namespace CapaPresentacion.Utilidades
{
    public static class UtilidadesTextBox
    {
        /// <summary>
        /// Alterna entre mostrar y ocultar la clave en un TextBox y cambia su TrailingIcon.
        /// Usar en el evento TrailingIconClick de un MaterialTextBox2.
        /// </summary>
        /// <param name="txtClave">El TextBox usado para ingresar claves.</param>
        public static void MostrarClave(MaterialTextBox2 txtClave)
        {
            if (txtClave.UseSystemPasswordChar)
            {
                txtClave.UseSystemPasswordChar = false;
                txtClave.PasswordChar = '\0';
                txtClave.TrailingIcon = Properties.Resources.visible_32;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
                txtClave.PasswordChar = '●';
                txtClave.TrailingIcon = Properties.Resources.hide_32;
            }
        }

        /// <summary>
        /// Permite solo números y teclas de control en un TextBox.
        /// Usar en el evento KeyPress del TextBox.
        /// </summary>
        public static void PermitirSoloDigitos(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                return;

            e.Handled = true;
        }

        /// <summary>
        /// Permite solo números, un punto decimal y teclas de control en un TextBox para precios.
        /// Usar en el evento KeyPress del TextBox.
        /// </summary>
        public static void PermitirSoloPrecio(object sender, KeyPressEventArgs e)
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
        /// <param name="texto">El String de precio a validar.</param>
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

        public static void DesplegarCalendario(DateTimePicker datePicker)
        {
            datePicker.Focus();
            SendKeys.Send("%{DOWN}"); // Alt + flecha abajo
        }
    }
}
