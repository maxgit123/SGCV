using System.Collections.Generic;
//Lo que agregue:
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private readonly CD_Usuario oCD_Usuario = new CD_Usuario();
        public List<CE_Usuario> Listar()
        {
            return oCD_Usuario.Listar();
            //Retorna la lista que tiene la clase CD_Usuario de la capa de datos.
        }
        public int Crear(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;

            //Validaciones de campos del formulario.
            if (oUsuario.Documento == "")
                mensaje += "Ingrese un nº de documento.\n";
            if (oUsuario.Nombre == "")
                mensaje += "Ingrese el nombre del usuario.\n";
            if (oUsuario.Apellido == "")
                mensaje += "Ingrese el Apellido del usuario.\n";
            if (oUsuario.Clave == "")
                mensaje += "Ingrese la clave del usuario.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Usuario.Crear(oUsuario, out mensaje);
            else
                return 0;
        }
        public bool Actualizar(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;
            
            //Validaciones de campos del formulario.
            if (oUsuario.Documento == "")
                mensaje += "Ingrese un nº de documento.\n";
            if (oUsuario.Nombre == "")
                mensaje += "Ingrese el nombre del usuario.\n";
            if (oUsuario.Apellido == "")
                mensaje += "Ingrese el Apellido del usuario.\n";
            if (oUsuario.Clave == "")
                mensaje += "Ingrese la clave del usuario.\n";
            //Va concatenando con saltos de linea los mensajes de error que surjan.

            if (mensaje == string.Empty)
                return oCD_Usuario.Actualizar(oUsuario, out mensaje);
            else
                return false;
        }
        public bool Eliminar(CE_Usuario oUsuario, out string mensaje)
        {
            return oCD_Usuario.Eliminar(oUsuario, out mensaje);
        }
    }
}