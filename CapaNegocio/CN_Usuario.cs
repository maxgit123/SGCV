using System.Collections.Generic;
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
        }
        public CE_Usuario Login(string documento, string clave)
        {
            return oCD_Usuario.Login(documento, clave);
        }
        public int Crear(CE_Usuario oUsuario, out string mensaje)
        {
            mensaje = string.Empty;

            if (oUsuario.Documento == "")
                mensaje += "Ingrese un nº de documento.\n";
            if (oUsuario.Nombre == "")
                mensaje += "Ingrese el nombre del usuario.\n";
            if (oUsuario.Apellido == "")
                mensaje += "Ingrese el Apellido del usuario.\n";
            if (oUsuario.Clave == "")
                mensaje += "Ingrese la clave del usuario.\n";

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
            //if (oUsuario.Clave == "")
            //    mensaje += "Ingrese la clave del usuario.\n";

            if (mensaje == string.Empty)
                return oCD_Usuario.Actualizar(oUsuario, out mensaje);
            else
                return false;
        }
        public bool Eliminar(CE_Usuario oUsuario, out string mensaje)
        {
            return oCD_Usuario.Eliminar(oUsuario, out mensaje);
        }
        public bool CambiarClave(CE_Usuario oUsuario, string claveActual, string claveNueva, out string mensaje)
        {
            mensaje = string.Empty;

            claveActual = claveActual.Trim();
            claveNueva = claveNueva.Trim();

            if (oUsuario.Clave == "")
                mensaje += "Ingrese su clave actual.\n";
            if (claveNueva == "")
                mensaje += "Ingrese la clave nueva.\n";
            if (oUsuario.Clave != claveActual)
                mensaje += "La clave actual es incorrecta.\n";

            if (mensaje == string.Empty)
            {
                oUsuario.Clave = claveNueva;
                return oCD_Usuario.CambiarClave(oUsuario, out mensaje);
            }
            else
            {
                return false;
            }
        }
    }
}