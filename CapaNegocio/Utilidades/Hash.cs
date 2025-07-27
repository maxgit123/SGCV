using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace CapaNegocio.Utilidades
{
    public static class Hash
    {
        private const int _ITERACION = 1000;    // numero de veces que se hashea
        private const int _LONGITUD_CLAVE = 32; // longitud en bytes
        private const int _LONGITUD_SAL = 16;   // longitud en bytes

        /// <summary>
        /// Genera el hash SHA256 en formato hexadecimal de una cadena de texto.
        /// </summary>
        /// <param name="texto">Texto original (clave en texto plano)</param>
        /// <returns>Hash SHA256 en forma de cadena hexadecimal</returns>
        public static string ObtenerSha256(string texto)
        {
            StringBuilder sb = new StringBuilder();
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(texto));
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2")); // formato hexadecimal en minúscula
            }
            return sb.ToString();
        }

        /// <summary>
        /// Genera un hash de un string en texto plano utilizando PBKDF2 con salt y un marcador de versión.
        /// </summary>
        /// <param name="claveTextoPlano">La clave del usuario en texto plano.</param>
        /// <returns>El hash resultante codificado en Base64, que incluye el marcador de versión, el salt y la clave derivada.</returns>
        /// <exception cref="ArgumentNullException">Se lanza si <paramref name="claveTextoPlano"/> es null.</exception>
        public static string Generar(string claveTextoPlano)
        {
            if (claveTextoPlano == null)
                throw new ArgumentNullException(nameof(claveTextoPlano));

            byte[] sal;
            byte[] buffer;

            using (var deriveBytes = new Rfc2898DeriveBytes(claveTextoPlano, _LONGITUD_SAL, _ITERACION))
            {
                // obtiene el salt aleatorio
                sal = deriveBytes.Salt;
                // obtiene el texto plano hasheado por el numero de iteraciones
                buffer = deriveBytes.GetBytes(_LONGITUD_CLAVE);
            }

            var dst = new byte[1 + _LONGITUD_SAL + _LONGITUD_CLAVE];
            dst[0] = 0; // Versión
            Buffer.BlockCopy(sal, 0, dst, 1, _LONGITUD_SAL);
            Buffer.BlockCopy(buffer, 0, dst, 1 + _LONGITUD_SAL, _LONGITUD_CLAVE);
            return Convert.ToBase64String(dst);
        }

        /// <summary>
        /// Verifica si un texto plano coincide con un hash previamente generado.
        /// </summary>
        /// <param name="claveHasheada">El hash previamente generado (con marcador de versión, salt y clave derivada).</param>
        /// <param name="claveTextoPlano">La clave en texto plano ingresada por el usuario.</param>
        /// <returns>True si la clave coincide con el hash almacenado; de lo contrario, false.</returns>
        /// <exception cref="ArgumentNullException">Se lanza si <paramref name="claveTextoPlano"/> es null.</exception>
        public static bool Verificar(string claveHasheada, string claveTextoPlano)
        {
            if (claveHasheada == null)
                return false;

            if (claveTextoPlano == null)
                throw new ArgumentNullException(nameof(claveTextoPlano));

            byte[] src = Convert.FromBase64String(claveHasheada);
            if (src.Length != 1 + _LONGITUD_SAL + _LONGITUD_CLAVE || src[0] != 0)
                return false;

            var dst = new byte[_LONGITUD_SAL];
            Buffer.BlockCopy(src, 1, dst, 0, _LONGITUD_SAL);

            var buffer3 = new byte[_LONGITUD_CLAVE];
            Buffer.BlockCopy(src, 1 + _LONGITUD_SAL, buffer3, 0, _LONGITUD_CLAVE);

            using (var deriveBytes = new Rfc2898DeriveBytes(claveTextoPlano, dst, _ITERACION))
            {
                byte[] buffer4 = deriveBytes.GetBytes(_LONGITUD_CLAVE);
                return buffer3.SequenceEqual(buffer4);
            }
        }
    }
}
// Algorirtmo paea generar un Hash de un camino para claves de usuario y no de doble camino (ej: AES)
// asi ni los programadores del proyecto podrian acceder a las claves porque no tienen la llave/semilla que se necesita para desencriptar.
// Lo logico es que la clave no la sepa nadie más que el usuario y si alguien mas tiene la llave rompe el esquema de todas formas.