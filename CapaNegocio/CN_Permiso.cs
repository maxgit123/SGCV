using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso oCD_Permiso = new CD_Permiso();
        public List<CE_Permiso> Listar(int idUsuario)
        {
            return oCD_Permiso.Listar(idUsuario);
        }
    }
}
