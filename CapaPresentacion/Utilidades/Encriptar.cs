//using System;
//using System.Collections.Generic;
//using System.Linq;
using System.Security.Cryptography;
using System.Text;
//using System.Threading.Tasks;

namespace CapaPresentacion.Utilidades
{
    public class Encriptar
    {
        public static string GetSHA256(string str) //Recibe y retorna un string.
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        //Algorirtmo de encriptacion de un camino para claves de usuario y no de doble camino (ej: AES)
        //asi ni los programadores del proyecto podrian acceder a las claves porque no tienen la llave/semilla que se necesita para desencriptar.
        //Lo logico es que la clave no la sepa nadie más que el usuario y si alguien mas tiene la llave rompe el esquema de todas formas.
    }
}
