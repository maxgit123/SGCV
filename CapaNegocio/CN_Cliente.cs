using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private readonly CD_Cliente oCD_Cliente = new CD_Cliente();
        public List<CE_Cliente> Listar(out string mensaje)
        {
            return oCD_Cliente.Listar(out mensaje);
        }
        public int Crear(CE_Cliente oCliente, out string mensaje)
        {
            var errores = new StringBuilder();

            if(string.IsNullOrWhiteSpace(oCliente.Documento))
                errores.AppendLine("Ingrese un nº de documento.");

            if (string.IsNullOrWhiteSpace(oCliente.Nombre))
                errores.AppendLine("Ingrese el nombre del cliente.");

            if (string.IsNullOrWhiteSpace(oCliente.Apellido))
                errores.AppendLine("Ingrese el apellido del cliente.");

            if (string.IsNullOrWhiteSpace(oCliente.Telefono))
                errores.AppendLine("Ingrese el número de teléfono del cliente.");

            if(string.IsNullOrWhiteSpace(oCliente.Correo))
                errores.AppendLine("Ingrese el correo electrónico del cliente.");

            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return 0;
            }
            
            return oCD_Cliente.Crear(oCliente, out mensaje);
        }
        public bool Actualizar(CE_Cliente oCliente, out string mensaje)
        {
            var errores = new StringBuilder();

            if (string.IsNullOrWhiteSpace(oCliente.Documento))
                errores.AppendLine("Ingrese un nº de documento.");

            if (string.IsNullOrWhiteSpace(oCliente.Nombre))
                errores.AppendLine("Ingrese el nombre del cliente.");

            if (string.IsNullOrWhiteSpace(oCliente.Apellido))
                errores.AppendLine("Ingrese el apellido del cliente.");

            if (string.IsNullOrWhiteSpace(oCliente.Telefono))
                errores.AppendLine("Ingrese el número de teléfono del cliente.");

            if (string.IsNullOrWhiteSpace(oCliente.Correo))
                errores.AppendLine("Ingrese el correo electrónico del cliente.");

            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return false;
            }

            return oCD_Cliente.Actualizar(oCliente, out mensaje);
        }
        public bool Eliminar(CE_Cliente oCliente, out string mensaje)
        {
            return oCD_Cliente.Eliminar(oCliente, out mensaje);
        }
    }
}
