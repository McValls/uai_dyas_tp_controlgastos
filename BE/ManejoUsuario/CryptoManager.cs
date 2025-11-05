using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BE.ManejoUsuario
{
    public class CryptoManager
    {
        public CryptoManager() { }

        public bool Comparar(string textoPlano, string textoHasheado)
        {
            string textoPlanoHasheado = Hash(textoPlano);
            return textoPlanoHasheado.Equals(textoHasheado);
        }

        public string Hash(string textoPlano)
        {
            // hash implementation
            SHA256 sha256 = SHA256.Create();
            byte[] hashedByteArr = sha256.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hashedByteArr)
            {
                stringBuilder.Append(b.ToString("x2"));
            }
            return stringBuilder.ToString();
        }
    }
}
