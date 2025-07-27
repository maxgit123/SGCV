using System;

namespace CapaEntidad
{
    public class CE_Comercio
    {
        public int Id { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string IngresosBrutos { get; set; }
        public DateTime InicioActividad { get; set; } 
        public int PuntoVenta { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public byte[] Logo { get; set; }
        public CE_Direccion oDireccion { get; set; }
        public CE_Localidad oLocalidad { get; set; }
        public CE_Provincia oProvincia { get; set; }
        public CE_ResponsableIVA oResponsableIVA { get; set; }
    }
}
