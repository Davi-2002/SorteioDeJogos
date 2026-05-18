using System;
using System.Security.Cryptography;
using System.Text;

namespace SistemaSorteio.Service
{
    public static class Criptografia
    {
        public static string Encriptar(string senha)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(senha);
            byte[] hashBytes;

            using (SHA512 sha512 = SHA512.Create())
            {
                hashBytes = sha512.ComputeHash(bytes);
            }
            string senhaCriptografada = Convert.ToBase64String(hashBytes);
            return senhaCriptografada;
        }
    }
}
