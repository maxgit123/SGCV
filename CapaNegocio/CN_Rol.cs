//using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//Lo que agregue:
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol oCD_Rol = new CD_Rol();
        public List<CE_Rol> Listar()
        {
            return oCD_Rol.Listar();
        }
    }
}
