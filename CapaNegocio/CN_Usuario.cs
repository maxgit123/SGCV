using System;
using System.Collections.Generic;
using System.Text;
using CapaDatos;
using CapaEntidad;
using CapaNegocio.Utilidades;

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
            string claveHash = ClaveHash.ObtenerSha256(clave?.Trim());

            return oCD_Usuario.Login(documento, claveHash);
        }
        public int Crear(CE_Usuario oUsuario, out string mensaje)
        {
            var errores = new StringBuilder();

            // Validaciones de campos del formulario.
            if (string.IsNullOrWhiteSpace(oUsuario.Documento))
                errores.AppendLine("Ingrese un nº de documento.");

            if (string.IsNullOrWhiteSpace(oUsuario.Nombre))
                errores.AppendLine("Ingrese el nombre del usuario.");

            if (string.IsNullOrWhiteSpace(oUsuario.Apellido))
                errores.AppendLine("Ingrese el apellido del usuario.");

            if (string.IsNullOrWhiteSpace(oUsuario.Clave))
                errores.AppendLine("Ingrese la clave del usuario.");

            // Si se encontraron errores, se construye el mensaje de error.
            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return 0;
            }

            // Si no hay errores, se procede a la capa de datos.
            return oCD_Usuario.Crear(oUsuario, out mensaje);
        }
        public bool Actualizar(CE_Usuario oUsuario, out string mensaje)
        {
            var errores = new StringBuilder();

            // Validaciones de campos del formulario.
            if (string.IsNullOrWhiteSpace(oUsuario.Documento))
                errores.AppendLine("Ingrese un nº de documento.");

            if (string.IsNullOrWhiteSpace(oUsuario.Nombre))
                errores.AppendLine("Ingrese el nombre del usuario.");

            if (string.IsNullOrWhiteSpace(oUsuario.Apellido))
                errores.AppendLine("Ingrese el apellido del usuario.");

            // Si se encontraron errores, se construye el mensaje de error.
            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return false;
            }

            // Si no hay errores, se procede a la capa de datos.
            return oCD_Usuario.Actualizar(oUsuario, out mensaje);
        }
        public bool Eliminar(CE_Usuario oUsuario, out string mensaje)
        {
            return oCD_Usuario.Eliminar(oUsuario, out mensaje);
        }
        public bool CambiarClave(CE_Usuario oUsuario, string claveActual, string claveNueva, out string mensaje)
        {
            var errores = new StringBuilder();

            // Validaciones de campos del formulario.
            if (string.IsNullOrWhiteSpace(claveActual))
                errores.AppendLine("Ingrese su clave actual.");

            if (string.IsNullOrWhiteSpace(claveNueva))
                errores.AppendLine("Ingrese la clave nueva.");

            // Si se encontraron errores, se construye el mensaje de error.
            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return false;
            }

            // Si no se encontraron errores, se obtiene el hash de las claves.
            var claveActualHash = ClaveHash.ObtenerSha256(claveActual?.Trim());
            var claveNuevaHash = ClaveHash.ObtenerSha256(claveNueva?.Trim());

            // Se verifica si la clave actual ingresada coincide con la almacenada en la base de datos.
            if (!string.Equals(oUsuario.Clave, claveActualHash, StringComparison.Ordinal))
            {
                mensaje = "La clave actual es incorrecta.";
                return false;
            }

            // Si no hay errores, se procede a la capa de datos.
            oUsuario.Clave = claveNuevaHash;
            return oCD_Usuario.CambiarClave(oUsuario, out mensaje);
        }
    }
}