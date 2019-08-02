using System;
using System.Security.Cryptography;
using System.Text;

namespace StrategyPattern_EncodingStrategyDemo
{
    /// <summary>
    /// Concrete Strategy class RSA Encoding
    /// </summary>
    public class RSAEncodingStrategy : IEncodingStrategy
    {
        private readonly UnicodeEncoding _unicodeEncoding = new UnicodeEncoding();
        private readonly RSACryptoServiceProvider _rsaCryptoServiceProvider = new RSACryptoServiceProvider();
        private byte[] _plaintext;
        private byte[] _encryptedtext;

        // Implement Encoding strategy
        public void EncodeValue(string value)
        {
            _plaintext = _unicodeEncoding.GetBytes(value);
            _encryptedtext = Encryption(_plaintext, _rsaCryptoServiceProvider.ExportParameters(false), false);
            string encodeValue = _unicodeEncoding.GetString(_encryptedtext);

            Console.WriteLine("Value {0} is Encoded using RSA Algorithm to {1}", value, encodeValue);

            byte[] decryptedtex = Decryption(_encryptedtext, _rsaCryptoServiceProvider.ExportParameters(true), false);
            string decryptedValue = _unicodeEncoding.GetString(decryptedtex);
        }

        /// <summary>
        /// https://www.c-sharpcorner.com/UploadFile/75a48f/rsa-algorithm-with-C-Sharp2/
        /// </summary>
        private static byte[] Encryption(byte[] data, RSAParameters rsaKey, bool doOaepPadding)
        {
            try
            {
                byte[] encryptedData;
                using (var rsaCryptoServiceProvider = new RSACryptoServiceProvider())
                {
                    rsaCryptoServiceProvider.ImportParameters(rsaKey);
                    encryptedData = rsaCryptoServiceProvider.Encrypt(data, doOaepPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        /// <summary>
        /// https://www.c-sharpcorner.com/UploadFile/75a48f/rsa-algorithm-with-C-Sharp2/
        /// </summary>
        private static byte[] Decryption(byte[] data, RSAParameters rsaKey, bool doOaepPadding)
        {
            try
            {
                byte[] decryptedData;
                using (var rsaCryptoServiceProvider = new RSACryptoServiceProvider())
                {
                    rsaCryptoServiceProvider.ImportParameters(rsaKey);
                    decryptedData = rsaCryptoServiceProvider.Decrypt(data, doOaepPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

    }
}