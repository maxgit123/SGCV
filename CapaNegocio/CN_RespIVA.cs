using System.Collections.Generic;
//Lo que agregue:
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_RespIVA
    {
        private CD_RespIVA oRespIVA = new CD_RespIVA();
        public List<CE_RespIVA> Listar()
        {
            return oRespIVA.Listar();
        }
    }
}