using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Infrastructure.Common.Security
{
    public interface IAESCryptography
    {
        string Encrypt(string plainText);

        string Decrypt(string ciphertext);
    }
}
