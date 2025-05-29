using System.Security.Cryptography;
using System.Text;

namespace CapaNegocio.Utilidades
{
    public static class ClaveHash
    {
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
    }
    // Algorirtmo paea generar un Hash de un camino para claves de usuario y no de doble camino (ej: AES)
    // asi ni los programadores del proyecto podrian acceder a las claves porque no tienen la llave/semilla que se necesita para desencriptar.
    // Lo logico es que la clave no la sepa nadie más que el usuario y si alguien mas tiene la llave rompe el esquema de todas formas.
}