using System;
using System.Security.Cryptography;
using System.Text;

namespace ChangeMgmt.Common
{
    public class Cryptography
    {
        public Cryptography()
        {
        }

        public byte[] GetSHA256(string text)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                return sHA256.ComputeHash(Encoding.ASCII.GetBytes(text));
            }
        }
    }
}
