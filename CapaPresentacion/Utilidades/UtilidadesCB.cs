using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace CapaPresentacion.Utilidades
{
    public static class UtilidadesCB
    {
        /// <summary>
        /// Carga un ComboBox con una lista genérica.
        /// </summary>
        /// <typeparam name="T">Tipo de los elementos de la lista.</typeparam>
        /// <param name="cb">ComboBox que se desea llenar.</param>
        /// <param name="lista">Lista de elementos a cargar.</param>
        /// <param name="getValor">Función para obtener el valor del elemento.</param>
        /// <param name="getTexto">Función para obtener el texto a mostrar del elemento.</param>
        public static void Cargar<T>(ComboBox cb, List<T> lista, Func<T, object> getValor, Func<T, string> getTexto)
        {
            cb.Items.Clear();

            var opciones = lista
                .Select(item => new OpcionCombo
                {
                    Valor = getValor(item),
                    Texto = getTexto(item)
                })
                .ToList();

            cb.DataSource = opciones;
            cb.ValueMember = "Valor";
            cb.DisplayMember = "Texto";

            if (cb.Items.Count > 0)
                cb.SelectedIndex = -1;
        }

        /// <summary>
        /// Carga un ComboBox con los encabezados visibles y no vacíos de un DataGridView.
        /// </summary>
        /// <param name="cb">ComboBox que se desea llenar.</param>
        /// <param name="dgv">DataGridView desde el cual se toman los encabezados de columna visibles y no vacíos.</param>
        /// <param name="nomColumnaPorDefecto">Nombre de columna a seleccionar por defecto. Si no se encuentra, selecciona el primer ítem.</param>
        public static void CargarHeadersDesdeDGV(ComboBox cb, DataGridView dgv, string nomColumnaPorDefecto = null)
        {
            var columnasVisibles = dgv.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible && !string.IsNullOrWhiteSpace(c.HeaderText))
                .Select(c => new OpcionCombo
                {
                    Valor = c.Name,
                    Texto = c.HeaderText
                })
                .ToList();

            cb.DataSource = columnasVisibles;
            cb.ValueMember = "Valor";
            cb.DisplayMember = "Texto";

            var indicePorDefecto = columnasVisibles.FindIndex(o => o.Valor.ToString() == nomColumnaPorDefecto);
            cb.SelectedIndex = indicePorDefecto >= 0 ? indicePorDefecto : 0;
        }
        public static void CargarHeadersDesdeDGV(MaterialComboBox cb, DataGridView dgv, string nomColumnaPorDefecto = null)
        {
            var columnasVisibles = dgv.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible && !string.IsNullOrWhiteSpace(c.HeaderText))
                .Select(c => new OpcionCombo
                {
                    Valor = c.Name,
                    Texto = c.HeaderText
                })
                .ToList();

            cb.DataSource = columnasVisibles;
            cb.ValueMember = "Valor";
            cb.DisplayMember = "Texto";

            var indicePorDefecto = columnasVisibles.FindIndex(o => o.Valor.ToString() == nomColumnaPorDefecto);
            cb.SelectedIndex = indicePorDefecto >= 0 ? indicePorDefecto : 0;
        }
    }
}
