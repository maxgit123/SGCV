using System.Collections.Generic;

namespace CapaEntidad
{
    public class CE_Perdida
    {
        public int IdPerdida { get; set; }
        public decimal Total { get; set; }
        public string FechaCreacion { get; set; }
        public List<CE_DetallePerdida> oDetallePerdida { get; set; }
        public CE_Estado oEstado { get; set; }
        public CE_Usuario oUsuario { get; set; }
    }
}