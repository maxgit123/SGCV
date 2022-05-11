using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Categoria
    {
        public int IdCategoria { get; set; }
        public string NomCategoria { get; set; }
        public CE_AlicuotaIVA oAlicuotaIVA { get; set; }
        //En vez de hacer referencia a ID_AlicuotaIVA se hace a la clase.
    }
}
