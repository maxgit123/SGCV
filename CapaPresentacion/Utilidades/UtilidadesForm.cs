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
    }
}
