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
    public class AesEncryptDecryptUtil : IEncryptDecrypt
    {
        #region Class Types
        private byte[] symKey;
        private byte[] symIV;
        #endregion

        /// <summary>
        /// Initializes a new instance of the AesEncryptDecryptUtil class
        /// </summary>
        public AesEncryptDecryptUtil()
        {
        }

        /// <summary>
        /// Encrypt a string using Advanced Encryption Standard(AES) 256 bit symmetric encryption format
        /// and generates the encrypted output file. Key is generated from the public key from assembly
        /// </summary>
        /// <param name="stringToEncrypt">Input string to encrypt.</param>
        /// <returns>encrypted string</returns>
        public string EncryptString(string valueToEncrypt)
        {
            // Declare the stream used to encrypt to an in memory array of bytes.
            // and create the streams used for encryption.
            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (RijndaelManaged cryptoProvider = new RijndaelManaged())
                {
                    //Generate Key and Vector
                    symKey = new byte[16];
                    symIV = new byte[16];
                    byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();
                    Encoding encoding = Encoding.UTF8;

                    //Generate key and vector
                    string keyValue = encoding.GetString(publicKey);
                    GenerateKeyVector(keyValue);
                    //Limit the size to 128 bit, this can be increased to 192 or 256 to improve
                    //the strength of encryption
                    cryptoProvider.KeySize = 128;
                    cryptoProvider.Key = symKey;
                    cryptoProvider.IV = symIV;

                    // Create a decrytor to perform the stream transform.
                    using (ICryptoTransform cryptoTrans = cryptoProvider.CreateEncryptor(cryptoProvider.Key, cryptoProvider.IV))
                    {
                        using (CryptoStream cryptoStreamEncr = new CryptoStream(msEncrypt, cryptoTrans, CryptoStreamMode.Write))
                        {
                            byte[] arrayInput = Encoding.UTF8.GetBytes(valueToEncrypt);
                            cryptoStreamEncr.Write(arrayInput, 0, arrayInput.Length);
                            cryptoStreamEncr.Flush();
                        }
                    }
                    //Return encrypted string in Base64 format
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        /// <summary>
        /// Decrypt a Base64 string using Advanced Encryption Standard(AES) 256 bit symmetric encryption format
        /// and returns the decrypted string. The decryption key is generated based on the
        /// assembly public key.
        /// </summary>
        /// <param name="stringToDecrypt">Input String to decrypy in Base64 format.</param>
        /// <returns>Decrypted output string.</returns>
        public string DecryptString(string valueToDecrypt)
        {
            using (MemoryStream msDecrypted = new MemoryStream())
            {
                // Create a new instance of the RijndaelManaged
                // class.  This generates a new key and initialization 
                // vector (IV).
                using (RijndaelManaged cryptoProvider = new RijndaelManaged())
                {
                    //A (128/192/256) bit key and 128 bit IV is required for this provider.
                    symKey = new byte[16];
                    symIV = new byte[16];

                    //Get the public key from the executing assembly,
                    //this will be based on the strong name associated with the dll/with which
                    //the project was build
                    byte[] publicKey = Assembly.GetExecutingAssembly().GetName().GetPublicKey();

                    Encoding encoding = Encoding.UTF8;
                    string keyValue = encoding.GetString(publicKey);
                    GenerateKeyVector(keyValue);

                    cryptoProvider.KeySize = 128;
                    cryptoProvider.Key = symKey;
                    cryptoProvider.IV = symIV;

                    // Create a decryptor to perform the stream transform.
                    using (ICryptoTransform cryptoTrans = cryptoProvider.CreateDecryptor())
                    {

                        //AES decryption transform on incoming bytes.
                        using (CryptoStream cryptoStreamDecr = new CryptoStream(msDecrypted, cryptoTrans, CryptoStreamMode.Write))
                        {

                            byte[] arrayInput = Convert.FromBase64String(valueToDecrypt);
                            cryptoStreamDecr.Write(arrayInput, 0, arrayInput.Length);
                            cryptoStreamDecr.Flush();
                        }
                    }
                    //Return decrypted string
                    return encoding.GetString(msDecrypted.ToArray());
                }
            }
        }

        /// <summary>
        /// Generates a key and vector based on the Hash algorithm in SHA256Managed. Basically it takes an 
        /// string and generates a 256 bit hash value for that.
        /// </summary>
        /// <param name="key">String symmetric key</param>
        /// <returns>None</returns>
        private void GenerateKeyVector(string inputValue)
        {
            byte[] keyValue = Encoding.UTF8.GetBytes(inputValue); //Byte Key
            byte[] resultValue; // Result Key- contains the hash value of actual key
            int iIdx; // Indexer

            using (SHA256 hashMgr = new SHA256Managed())
            {
                //Generate the hashed key- 256 bits/ 32 bytes
                resultValue = hashMgr.ComputeHash(keyValue);
                //clear resources
                hashMgr.Clear();

                //now Initialize the 'Key' array with the lower 16 bytes/128 bits of the
                //Hash of the 'key' string provided
                for (iIdx = 0; iIdx < 16; iIdx++)
                {
                    symKey[iIdx] = resultValue[iIdx];
                }
                //Initialize the 'Vector' array with the upper 16 Bytes/128 bits of
                //Hash result
                for (iIdx = 16; iIdx < 32; iIdx++)
                {
                    symIV[iIdx - 16] = resultValue[iIdx];
                }
            }
        }
    }
}
