using System;
using System.Security.Cryptography;
using System.Text;

namespace TP.Infrastructure.Common.Security
{
    public class AESCryptography : IAESCryptography
    {
        private readonly string key = "d2g)w!l8e1r@p#";
        private readonly string iv = "aescrypt";

        public string Encrypt(string plainText)
        {
            if (string.IsNullOrWhiteSpace(plainText)) return "";

            using(AesCryptoServiceProvider aesCSP = new AesCryptoServiceProvider())
            {
                aesCSP.Key = Encoding.Unicode.GetBytes(key);
                aesCSP.IV = Encoding.Unicode.GetBytes(iv);

                var encryptArray = Encoding.Unicode.GetBytes(plainText);
                
                ICryptoTransform cTransform = aesCSP.CreateEncryptor();
                byte[] outBlock = cTransform.TransformFinalBlock(encryptArray, 0, encryptArray.Length);

                return Convert.ToBase64String(outBlock);
            }
        }
        public string Decrypt(string ciphertext)
        {
            if (string.IsNullOrWhiteSpace(ciphertext)) return "";

            using (AesCryptoServiceProvider aesCSP = new AesCryptoServiceProvider())
            {
                aesCSP.Key = Encoding.Unicode.GetBytes(key);
                aesCSP.IV = Encoding.Unicode.GetBytes(iv);

                var encryptArray = Convert.FromBase64String(ciphertext);

                ICryptoTransform cTransform = aesCSP.CreateDecryptor();
                byte[] outBlock = cTransform.TransformFinalBlock(encryptArray, 0, encryptArray.Length);

                return Encoding.Unicode.GetString(outBlock);
            }
        }
    }
}
