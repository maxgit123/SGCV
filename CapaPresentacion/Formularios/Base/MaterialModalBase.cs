using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Base
{
    public class MaterialModalBase : MaterialFormBase
    {
        protected MaterialModalBase()
        {
            FormStyle = FormStyles.ActionBar_40;
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(450, 364);
            Padding = new Padding(0,64,0,0);
            ShowInTaskbar = false;
            MaximizeBox = false;
            MinimizeBox = false;
            Sizable = false;
        }
    }
}