using System;
using System.Collections.Generic;
using System.Linq;
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
        public CE_Usuario Login(string documento, string clave, out string mensaje)
        {
            CE_Usuario oUsuario = oCD_Usuario.Login(documento, out mensaje);

            if (oUsuario == null)
                return null;

            bool esValido = Hash.Verificar(oUsuario.Clave, clave);

            if (!esValido)
            {
                mensaje = "Clave incorrecta";
                return null;
            }

            return oUsuario;
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

            if (oUsuario.oRol == null || oUsuario.oRol.Id <= 0)
                errores.AppendLine("Seleccione un rol válido.");

            if (oUsuario.Documento.Length != 8 || !oUsuario.Documento.All(char.IsDigit))
                errores.AppendLine("El documento debe tener ocho (8) caracteres numéricos.");

            // Si se encontraron errores, se construye el mensaje de error.
            if (errores.Length > 0)
            {
                mensaje = $"Se encontraron los siguientes errores:\n\n {errores}";
                return 0;
            }

            // Se genera el hash de la clave antes de enviar a la capa de datos.
            oUsuario.Clave = Hash.Generar(oUsuario.Clave);

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

            if (oUsuario.oRol == null || oUsuario.oRol.Id <= 0)
                errores.AppendLine("Seleccione un rol válido.");

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
        public bool CambiarClave(CE_Usuario oUsuario, string claveActual, string claveNueva, string claveNuevaRep, out string mensaje)
        {
            var errores = new StringBuilder();

            // Validaciones de campos del formulario.
            if (string.IsNullOrWhiteSpace(claveActual))
                errores.AppendLine("Ingrese su clave actual.");

            if (string.IsNullOrWhiteSpace(claveNueva))
                errores.AppendLine("Ingrese la clave nueva.");

            if (string.IsNullOrWhiteSpace(claveNuevaRep))
                errores.AppendLine("Repetir la clave nueva.");

            if (!string.Equals(claveNueva, claveNuevaRep, StringComparison.Ordinal))
                errores.AppendLine("Las claves nuevas no coinciden.");

            // Se verifica si la clave actual ingresada coincide con la almacenada en la base de datos.
            if (!Hash.Verificar(oUsuario.Clave, claveActual))
            errores.AppendLine("La clave actual es incorrecta.");

            // Si se encontraron errores, se construye el mensaje de error.
            if (errores.Length > 0)
            {
                mensaje = "Se encontraron los siguientes errores:\n\n" + errores.ToString();
                return false;
            }

            // Si no hay errores, se genera un nuevo hash y se actualiza el objeto usuario.
            oUsuario.Clave = Hash.Generar(claveNueva?.Trim());

            // Se procede a la capa de datos.
            return oCD_Usuario.CambiarClave(oUsuario, out mensaje);
        }
    }
}