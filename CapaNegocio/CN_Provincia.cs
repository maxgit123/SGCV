using System.Collections.Generic;
//Lo que agregue:
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Provincia
    {
        private CD_Provincia oProvincia = new CD_Provincia();
        public List<CE_Provincia> Listar()
        {
            return oProvincia.Listar();
        }
    }
}
