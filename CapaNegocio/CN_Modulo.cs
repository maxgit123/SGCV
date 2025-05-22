using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Modulo
    {
        private CD_Modulo oCD_Modulo = new CD_Modulo();
        public List<CE_Modulo> Listar(int idUsuario)
        {
            return oCD_Modulo.Listar(idUsuario);
        }
    }
}