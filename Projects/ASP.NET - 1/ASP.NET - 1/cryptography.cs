using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

 namespace ASP.NET___1
{
    public class cryptography
    {
        public byte[] encry;
        public string encrypt(String txt3)
        {
            //
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = md5.ComputeHash(encode.GetBytes("computer"));
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform icrypto = tdes.CreateEncryptor();
            //

            encry = icrypto.TransformFinalBlock(encode.GetBytes(txt3), 0, encode.GetBytes(txt3).Length);

            // Method 1

            tdes.Clear();
           return Convert.ToBase64String(encry, 0, encry.Length);

            //Method 2

            //txt4.Text = BitConverter.ToString(encry);

        }

       public string decrypt(String txt5)
        {
           
                //
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding encode = new UTF8Encoding();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = md5.ComputeHash(encode.GetBytes("computer"));
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform icrypto = tdes.CreateDecryptor();
                //

                //Method 1

                byte[] toEncryptArray = Convert.FromBase64String(txt5);
                return encode.GetString(icrypto.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length));

                //Method 2

                // txt6.Text = encode.GetString(icrypto.TransformFinalBlock(encry,0, encry.Length));
           
        }
    }
}