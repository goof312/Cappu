using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.IO;
using System.Text;
namespace Cappu
{
    public class Encryption
    {
      
            public string EncryptionDES(string strText)
            {
                // Retrieve the key from a secure configuration file or key management system
                string strKey = "AB14BB29";
                byte[] bykey = { };// for encryption key
                byte[] iv = { 0x01, 0x06, 0x06, 0x02, 0x09, 0x06, 0x02, 0x07 };// used in encryption
                try
                {
                    bykey = Encoding.UTF8.GetBytes(strKey);// converts the strKey (encryption key) string into bytes using UTF-8 encoding. tas ibabalik as variable
                    DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                    byte[] input = Encoding.UTF8.GetBytes(strText);
                    MemoryStream ms = new MemoryStream();// to hold the encrypted data 
                    CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(bykey, iv), CryptoStreamMode.Write); //The CryptoStream is initialized with the MemoryStream, the encryption algorithm (des.CreateEncryptor(bykey, iv)), and the mode (CryptoStreamMode.Write).
                    cs.Write(input, 0, input.Length);
                    cs.FlushFinalBlock();// to complete the encryption process and ensure that all data is written.
                    return Convert.ToBase64String(ms.ToArray());// The resulting string represents the encrypted data, which is returned from the method.
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that may occur during encryption
                    // You can log or handle the exception as per your requirement

                }
                return null;
            }




        }
    }
