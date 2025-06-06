using System.Windows.Forms;

namespace CapaPresentacion.Utilidades
{
    public class OpcionCombo
    {
        public string Texto { get; set; }
        public object Valor { get; set; }
        public override string ToString()
        {
            return Texto;
        }
        // Esto hace que si por alguna razón se muestra un OpcionCombo como texto
        // (por ejemplo, en una MessageBox, en el combo si no seteaste DisplayMember,
        // o en una inspección de depuración), aparezca el texto amigable (Texto) en vez de
        // "CapaPresentacion.Utilidades.OpcionCombo".
    }
}
