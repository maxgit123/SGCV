//Lo que agregue:
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Comercio
    {
        private readonly CD_Comercio oCD_Comercio = new CD_Comercio();
        public CE_Comercio Leer()
        {
            return oCD_Comercio.Leer();
        } //Retorna los datos que tiene la clase CD_Comercio de la capa de datos.
        public bool Actualizar(CE_Comercio oComercio, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oComercio.RazonSocial == "")
                mensaje += "Ingrese la razon social.\n";
            if (oComercio.Cuit == "")
                mensaje += "Ingrese el CUIT.\n";
            if (oComercio.IngBrutos == "")
                mensaje += "Ingrese el número de ingresos brutos.\n";
            //if (oComercio.oDireccion.NomCalle == "")
            //    mensaje += "Ingrese el nombre de la calle.\n";
            //if (oComercio.oDireccion.NumCalle == "")
            //    mensaje += "Ingrese el número de la calle.\n";
            //if (oComercio.oLocalidad.IdLocCP.ToString() == "")
            //    mensaje += "Ingrese el codigo postal.\n";
            //if (oComercio.oLocalidad.NomLocalidad == "")
            //    mensaje += "Ingrese la localidad.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Comercio.Actualizar(oComercio, out mensaje);
            else
                return false;
        }
        public byte[] LeerLogo(out bool leido)
        {
            return oCD_Comercio.LeerLogo(out leido);
        }
        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return oCD_Comercio.ActualizarLogo(imagen, out mensaje);
        }
    }
}