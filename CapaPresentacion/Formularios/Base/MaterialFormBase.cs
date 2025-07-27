using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Base
{
    public class MaterialFormBase : MaterialForm
    {
        public static readonly Color _materialColor = Color.FromArgb(63, 81, 181);         // Indigo 500
        public static readonly Color _materialColorDark = Color.FromArgb(48, 63, 159);     // Indigo 700
        public static readonly Color _materialColorLight = Color.FromArgb(159, 168, 218);  // Indigo 200
        public static readonly Color _materialColorAccent = Color.FromArgb(206, 147, 216); // Purple 200

        protected MaterialFormBase()
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo200, Accent.Purple200, TextShade.WHITE);
            FormBorderStyle = FormBorderStyle.None;
        }
    }
}