using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Edux_API.Utils
{
    public class Crypto
    {
        //gerar salt + hash
        public string GerarHash(string Senha, string Salt)
        {
            using (SHA256 sha256hash = SHA256.Create())
            {
                //ComputeHash - Retorna um array de bytes
                byte[] bytes = sha256hash.ComputeHash(Encoding.UTF8.GetBytes(Salt + Senha));

                //Converte o array de bytes para string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
