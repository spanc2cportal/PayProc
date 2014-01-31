namespace PayProc.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEncryptDecrypt
    {
        /// <summary>
        /// Interface to encrypt the input string
        /// </summary>
        /// <param name="valueToEncrypt"></param>
        /// <returns></returns>
        string EncryptString(string valueToEncrypt);

        /// <summary>
        /// Interface to Decrypt the passed value
        /// </summary>
        /// <param name="valueToDecrypt"></param>
        /// <returns></returns>
        string DecryptString(string valueToDecrypt);

    }
}
