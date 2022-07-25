using System.Collections.Generic;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_AlicuotaIVA
    {
        private CD_AlicuotaIVA oAlicuotaIVA = new CD_AlicuotaIVA();
        public List<CE_AlicuotaIVA> Listar()
        {
            return oAlicuotaIVA.Listar();
        }
    }
}
