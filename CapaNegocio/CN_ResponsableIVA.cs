using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_ResponsableIVA
    {
        private CD_ResponsableIVA oResponsableIVA = new CD_ResponsableIVA();
        public List<CE_ResponsableIVA> Listar()
        {
            return oResponsableIVA.Listar();
        }
    }
}