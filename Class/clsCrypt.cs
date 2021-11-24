using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Collections;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace AES_Encrypt_Decrypt
{
    public class clsCrypt
    {
        public string ENCRYPT_DECRYPT_KEY { get; set; }
        public string keyString { get; set; }
        public string ivString { get; set; }

        public clsCrypt()
        {
            this.ENCRYPT_DECRYPT_KEY = "";
            this.keyString = "";
            this.ivString = "";
        }

        public clsCrypt(string cryptKey)
        {
            string resultKey = Get(ENCRYPT_DECRYPT_KEY: ENCRYPT_DECRYPT_KEY);
            if (resultKey == "" || resultKey == null) throw new Exception("Key not found");
            else
            {
                this.ENCRYPT_DECRYPT_KEY = resultKey;
                this.keyString = resultKey;
                this.ivString = keyString.Substring(0, 16);
            }
        }

        public static string Get(string ENCRYPT_DECRYPT_KEY = "")
        {
            try
            {
                return ENCRYPT_DECRYPT_KEY;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string EncryptString(string plainText, string keyString, string ivString)
        {
            // Convert string to array of bytes
            byte[] key = Encoding.UTF8.GetBytes(keyString);
            byte[] iv = Encoding.UTF8.GetBytes(ivString);

            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;
            //encryptor.KeySize = 256;
            //encryptor.BlockSize = 128;
            //encryptor.Padding = PaddingMode.Zeros;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            // Convert the plainText string into a byte array
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            // Encrypt the input plaintext string
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            // Complete the encryption process
            cryptoStream.FlushFinalBlock();

            // Convert the encrypted data from a MemoryStream to a byte array
            byte[] cipherBytes = memoryStream.ToArray();

            // Close both the MemoryStream and the CryptoStream
            memoryStream.Close();
            cryptoStream.Close();

            // Convert the encrypted byte array to a base64 encoded string
            //string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);
            string cipherText = BitConverter.ToString(cipherBytes);

            // Return the encrypted data as a string
            return cipherText.ToLower().Replace("-", "");
        }

        public static string DecryptString(string cipherText, string keyString, string ivString)
        {
            // Convert string to array of bytes
            byte[] key = Encoding.UTF8.GetBytes(keyString);
            byte[] iv = Encoding.UTF8.GetBytes(ivString);

            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;
            //encryptor.KeySize = 256;
            //encryptor.BlockSize = 128;
            //encryptor.Padding = PaddingMode.Zeros;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            // Will contain decrypted plaintext
            string plainText = String.Empty;

            try
            {
                try
                {
                    //Start
                    byte[] bytess = Enumerable.Range(0, cipherText.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(cipherText.Substring(x, 2), 16)).ToArray();
                    //End

                    // Convert the ciphertext string into a byte array
                    //byte[] cipherBytes = Convert.FromBase64String(cipherText);
                    byte[] cipherBytes = bytess;

                    // Decrypt the input ciphertext string
                    cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                    // Complete the decryption process
                    cryptoStream.FlushFinalBlock();

                    // Convert the decrypted data from a MemoryStream to a byte array
                    byte[] plainBytes = memoryStream.ToArray();

                    // Convert the encrypted byte array to a base64 encoded string
                    plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
                }
                finally
                {
                    // Close both the MemoryStream and the CryptoStream
                    memoryStream.Close();
                    cryptoStream.Close();
                }

                // Return the encrypted data as a string
                return plainText;
            }
            catch (Exception ex)
            {
                // Return the encrypted data as a string
                return "Exception : " + ex.Message;
            }
        }

    }
}