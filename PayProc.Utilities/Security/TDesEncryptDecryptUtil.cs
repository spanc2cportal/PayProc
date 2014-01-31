namespace PayProc.Utilities
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Security.Cryptography;
    using System.Text;

    /// <summary>
    /// Class for Encryption and Decryption
    /// </summary>
    public class TDesEncryptDecryptUtil : IEncryptDecrypt
    {
        #region Class Types
        private byte[] symKey;
        private byte[] symIV;
        #endregion

        /// <summary>
        /// Initializes a new instance of the TDesEncryptDecryptUtil class
        /// </summary>
        public TDesEncryptDecryptUtil()
        {
        }
        
        /// <summary>
        /// Encrypt a string using Triple Data Encryption Standard(TDES) 256 bit symmetric encryption format
        /// and returns the encrypted Base64 string. The encryption key is generated based on the FiWare
        /// framework assembly public key.
        /// </summary>
        /// <param name="valueToEncrypt">A input string value that needs to be encrypted</param>
        /// <returns>The encrypted value will be returned as string</returns>
        public string EncryptString(string valueToEncrypt)
        {
            using (MemoryStream encVal = new MemoryStream())
            {
                using (TripleDESCryptoServiceProvider tds = new TripleDESCryptoServiceProvider())
                {
                    symKey = new byte[24];
                    symIV = new byte[8];
                    byte[] byteKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
                    Encoding encoding = Encoding.UTF8;

                    string strKey = encoding.GetString(byteKey);
                    GenerateKeyVector(strKey);
                    tds.Key = symKey;
                    tds.IV = symIV;

                    using (ICryptoTransform desencrypt = tds.CreateEncryptor())
                    {
                        using (CryptoStream cryptostream = new CryptoStream(encVal, desencrypt, CryptoStreamMode.Write))
                        {
                            byte[] bytearrayinput = Encoding.UTF8.GetBytes(valueToEncrypt);
                            cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length);
                            cryptostream.Flush();
                        }
                    }

                    return Convert.ToBase64String(encVal.ToArray());
                }
            }
        }

        /// <summary>
        /// Decrypt a Base64 string using Triple Data Encryption Standard(TDES) 256 bit symmetric encryption format
        /// and returns the decrypted string. The decryption key is generated based on the FiWare
        /// framework assembly public key.
        /// </summary>
        /// <param name="valueToDecrypt">Input String to decrypy in Base64 format.</param>
        /// <returns>Decrypted output string.</returns>
        public string DecryptString(string valueToDecrypt)
        {
            using (MemoryStream decryVal = new MemoryStream())
            {
                using (TripleDESCryptoServiceProvider cryptoProvider = new TripleDESCryptoServiceProvider())
                {
                    symKey = new byte[24];
                    symIV = new byte[8];
                    byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
                    Encoding encoding = Encoding.UTF8;

                    string keyValue = encoding.GetString(publicKey);
                    GenerateKeyVector(keyValue);
                    cryptoProvider.Key = symKey;
                    cryptoProvider.IV = symIV;

                    using (ICryptoTransform cryptoTrans = cryptoProvider.CreateDecryptor())
                    {
                        using (CryptoStream cryptoStreamDecr = new CryptoStream(decryVal, cryptoTrans, CryptoStreamMode.Write))
                        {
                            byte[] arrayInput = Convert.FromBase64String(valueToDecrypt);
                            cryptoStreamDecr.Write(arrayInput, 0, arrayInput.Length);
                            cryptoStreamDecr.Flush();
                        }
                    }

                    return encoding.GetString(decryVal.ToArray());
                }
            }
        }

        /// <summary>
        /// Generates a key and vector based on the Hash algorithm in SHA256Managed. Basically it takes an 
        /// string and generates a 256 bit hash value for that.
        /// </summary>
        /// <param name="inputValue">Symmetric key</param>
        private void GenerateKeyVector(string inputValue)
        {
            byte[] keyValue = Encoding.UTF8.GetBytes(inputValue);
            byte[] resultValue;
            int idx;

            using (SHA256 hashMgr = new SHA256Managed())
            {
                resultValue = hashMgr.ComputeHash(keyValue);
                hashMgr.Clear();
                for (idx = 0; idx < 24; idx++)
                {
                    symKey[idx] = resultValue[idx];
                }

                for (idx = 24; idx < 32; idx++)
                {
                    symIV[idx - 24] = resultValue[idx];
                }
            }
        }
    }
}
