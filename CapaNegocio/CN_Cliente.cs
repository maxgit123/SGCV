using System.Collections.Generic;
//Lo que agregue:
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private readonly CD_Cliente oCD_Cliente = new CD_Cliente();
        public List<CE_Cliente> Listar()
        {
            return oCD_Cliente.Listar();
            //Retorna la lista que tiene la clase CD_Cliente de la capa de datos.
        }
        public int Crear(CE_Cliente oCliente, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oCliente.Documento == "")
                mensaje += "Ingrese un nº de documento.\n";
            if (oCliente.Nombre == "")
                mensaje += "Ingrese el nombre del cliente.\n";
            if (oCliente.Apellido == "")
                mensaje += "Ingrese el Apellido del cliente.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Cliente.Crear(oCliente, out mensaje);
            else
                return 0;
        }
        public bool Actualizar(CE_Cliente oCliente, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oCliente.Documento == "")
                mensaje += "Ingrese un nº de documento.\n";
            if (oCliente.Nombre == "")
                mensaje += "Ingrese el nombre del cliente.\n";
            if (oCliente.Apellido == "")
                mensaje += "Ingrese el Apellido del cliente.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Cliente.Actualizar(oCliente, out mensaje);
            else
                return false;
        }
        public bool Eliminar(CE_Cliente oCliente, out string mensaje)
        {
            return oCD_Cliente.Eliminar(oCliente, out mensaje);
        }
    }
}
