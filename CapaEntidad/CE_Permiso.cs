using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Permiso
    {
        public int ID_Permiso { get; set; }
        public string NomMenu { get; set; }
        public CE_Rol oRol { get; set; }
        //En vez de hacer referencia a ID_Rol se hace a la clase.
    }
}
