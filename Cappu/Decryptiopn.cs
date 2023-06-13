using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.IO;
using System.Text;

namespace Cappu
{
    public class Decryptiopn
    {
        public string DecyptionDES(string strText)
        {
            // Retrieve the key from a secure configuration file or key management system
            string strKey = "AB14BB29";
            byte[] bykey = { }; // for encryption key
            byte[] iv = { 0x01, 0x06, 0x06, 0x02, 0x09, 0x06, 0x02, 0x07 }; // used in encryption
            try
            {
                bykey = Encoding.UTF8.GetBytes(strKey); // converts the strKey (encryption key) string into bytes using UTF-8 encoding.
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                byte[] encryptedBytes = Convert.FromBase64String(strText); // Convert the encrypted string back to bytes

                // Create a MemoryStream to hold the decrypted data
                MemoryStream ms = new MemoryStream();

                // Create a CryptoStream to decrypt the data
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(bykey, iv), CryptoStreamMode.Write);

                // Write the encrypted bytes to the CryptoStream
                cs.Write(encryptedBytes, 0, encryptedBytes.Length);
                cs.FlushFinalBlock(); // Complete the decryption process and ensure that all data is written

                // Convert the decrypted bytes to a string
                string decryptedString = Encoding.UTF8.GetString(ms.ToArray());

                return decryptedString; // Return the decrypted string
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during decryption
                // You can log or handle the exception as per your requirement
            }

            return null;

        }
    }
}