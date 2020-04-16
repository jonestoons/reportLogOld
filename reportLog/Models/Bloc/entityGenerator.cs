using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace reportLog.Models.Bloc
{
    public class EntityGenerator
    {
        public static string generateUserID()
        {

            char[] chars = new char[128];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[7];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(7);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }

            return result.ToString();
        }
    }
}