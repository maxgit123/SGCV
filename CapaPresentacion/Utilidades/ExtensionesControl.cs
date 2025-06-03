using System;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace CapaPresentacion.Utilidades
{
    /// <summary>
    /// Métodos de extensión y utilidades para controles.
    /// </summary>
    public static class ExtensionesControl
    {
        // Tipos de controles interactivos (aceptan interacción del usuario).
        private static readonly Type[] tiposInteractivos =
        {
            typeof(TextBox),
            typeof(ComboBox),
            typeof(Button),
            typeof(IconButton), // IconButton es un tipo de botón con icono, parte de FontAwesome.Sharp
            typeof(DateTimePicker),
            typeof(CheckBox),
            typeof(RadioButton),
            typeof(NumericUpDown),
            typeof(MaskedTextBox),
            typeof(ListBox),
            typeof(ListView)
        };

        /// <summary>
        /// Determina si un control es interactivo (acepta interacción del usuario).
        /// </summary>
        /// <param name="ctrl">El control a verificar.</param>
        /// <returns>True si el control es interactivo, false en caso contrario.</returns>
        public static bool EsInteractivo(this Control ctrl)
        {
            return Array.Exists(tiposInteractivos, t => t == ctrl.GetType());
        }

        /// <summary>
        /// Centra horizontalmente un control dentro de su contenedor padre.
        /// </summary>
        /// <param name="ctrl">El control a centrar.</param>
        public static void CentrarH(this Control ctrl)
        {
            if (ctrl?.Parent != null)
                ctrl.Left = (ctrl.Parent.Width - ctrl.Width) / 2;
        }
    }
}
