using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;

namespace Cryptography
{
   
    public partial class MainWindow : Window
    {
      public  byte[] encry;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {

        
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();
            String encode_text = BitConverter.ToString(md5.ComputeHash(encode.GetBytes(txt1.Text)));
            MessageBox.Show(encode_text);

        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
          SHA1CryptoServiceProvider md5 = new SHA1CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();
            String encode_text = BitConverter.ToString(md5.ComputeHash(encode.GetBytes(txt1.Text)));
            MessageBox.Show(encode_text);
        }

        private void encrypted_Click(object sender, RoutedEventArgs e)
        {
           md5encrypt();
           //sha512encrypt();
        }

       
     

        private void decrypted_Click(object sender, RoutedEventArgs e)
        {
            md5decrypt();
         //sha512decrypt();
        }

        private void md5encrypt()
        {
            //
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding encode = new UTF8Encoding();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = md5.ComputeHash(encode.GetBytes(txt3.Text));
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform icrypto = tdes.CreateEncryptor();
            //

            encry = icrypto.TransformFinalBlock(encode.GetBytes(txt1.Text), 0, encode.GetBytes(txt1.Text).Length);

            // Method 1

            tdes.Clear();
            txt4.Text = Convert.ToBase64String(encry, 0, encry.Length);

            //Method 2

            //txt4.Text = BitConverter.ToString(encry);

        }

        private void md5decrypt()
        {
            try
            {
                //
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                UTF8Encoding encode = new UTF8Encoding();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = md5.ComputeHash(encode.GetBytes(txt5.Text));
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform icrypto = tdes.CreateDecryptor();
                //

                //Method 1

                byte[] toEncryptArray = Convert.FromBase64String(txt4.Text);
                txt6.Text = encode.GetString(icrypto.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length));

                //Method 2

                // txt6.Text = encode.GetString(icrypto.TransformFinalBlock(encry,0, encry.Length));
            }
            catch (CryptographicException ex)
            {
                txt6.Text = ex.Message;
            }
        }
        private void sha512encrypt()
        {
            try
            {
                //
                SHA512 md5 = new System.Security.Cryptography.SHA512Managed();

                UTF32Encoding encode = new UTF32Encoding();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = md5.ComputeHash(encode.GetBytes(txt3.Text));
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform icrypto = tdes.CreateEncryptor();
                //

                encry = icrypto.TransformFinalBlock(encode.GetBytes(txt1.Text), 0, encode.GetBytes(txt1.Text).Length);

                // Method 1

                tdes.Clear();
                txt4.Text = Convert.ToBase64String(encry, 0, encry.Length);

                //Method 2

                //txt4.Text = BitConverter.ToString(encry);
            }
            catch (CryptographicException ex)
            {
                txt6.Text = ex.Message;
            }
        }


        private void sha512decrypt()
        {
            try
            {
                //
                SHA512CryptoServiceProvider md5 = new SHA512CryptoServiceProvider();
                UTF8Encoding encode = new UTF8Encoding();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = md5.ComputeHash(encode.GetBytes(txt5.Text));
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform icrypto = tdes.CreateDecryptor();
                //

                //Method 1

                byte[] toEncryptArray = Convert.FromBase64String(txt4.Text);
                txt6.Text = encode.GetString(icrypto.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length));

                //Method 2

                // txt6.Text = encode.GetString(icrypto.TransformFinalBlock(encry,0, encry.Length));
            }
            catch (CryptographicException ex)
            {
                txt6.Text = ex.Message;
            }
        }

        private void txt5_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
