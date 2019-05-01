using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Divar.Core.Classes
{
    public static class HashGenerators
    {
        public static string EncodingPassWithMD5(string password)
        {
            Byte[] mainBytes;
            Byte[] encodeBytes;

            MD5 md5;

            md5 = new MD5CryptoServiceProvider();

            mainBytes = ASCIIEncoding.Default.GetBytes(password);
            encodeBytes = md5.ComputeHash(mainBytes);

            return BitConverter.ToString(encodeBytes);
        }
    }
}
