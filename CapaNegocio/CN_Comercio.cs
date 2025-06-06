using System;
using System.Text;
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
        }
        public bool Actualizar(CE_Comercio oComercio, out string mensaje)
        {
            var errores = new StringBuilder();

            // Validaciones de campos del formulario.
            if (string.IsNullOrWhiteSpace(oComercio.RazonSocial))
                errores.AppendLine("Ingrese la razón social.\n");

            if (string.IsNullOrWhiteSpace(oComercio.Cuit))
                errores.AppendLine("Ingrese el CUIT.\n");

            if (string.IsNullOrWhiteSpace(oComercio.IngresosBrutos))
                errores.AppendLine("Ingrese el número de ingresos brutos.\n");

            if (oComercio.InicioActividad == DateTime.MinValue)
                errores.AppendLine("Ingrese la fecha de inicio de actividad.\n");

            if (oComercio.PuntoVenta < 1)
                errores.AppendLine("Ingrese un punto de venta válido.\n");

            if (string.IsNullOrWhiteSpace(oComercio.Telefono))
                errores.AppendLine("Ingrese un número de teléfono.\n");

            if (string.IsNullOrWhiteSpace(oComercio.Correo))
                errores.AppendLine("Ingrese un correo electrónico.\n");

            if (string.IsNullOrWhiteSpace(oComercio.oDireccion.Calle))
                errores.AppendLine("Ingrese el nombre de la calle.\n");

            if (string.IsNullOrWhiteSpace(oComercio.oDireccion.Numero))
                errores.AppendLine("Ingrese el número de la calle.\n");

            if (string.IsNullOrWhiteSpace(oComercio.oLocalidad.Nombre))
                errores.AppendLine("Ingrese la localidad.\n");

            if (string.IsNullOrWhiteSpace(oComercio.oLocalidad.CodigoPostal))
                errores.AppendLine("Ingrese el código postal.\n");

            if (oComercio.oProvincia.Id < 1 || oComercio.oProvincia.Id > 23)
                errores.AppendLine("Seleccione una provincia válida.\n");

            if (oComercio.oResponsableIVA.Id < 1 || oComercio.oResponsableIVA.Id > 16)
                errores.AppendLine("Seleccione un responsable de IVA válido.\n");

            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return false;
            }
            
            return oCD_Comercio.Actualizar(oComercio, out mensaje);
        }
        public byte[] LeerLogo(out bool leido)
        {
            return oCD_Comercio.LeerLogo(out leido);
        }
        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            if (imagen == null || imagen.Length == 0)
            {
                mensaje = "Seleccione una imagen válida.";
                return false;
            }

            return oCD_Comercio.ActualizarLogo(imagen, out mensaje);
        }
    }
}