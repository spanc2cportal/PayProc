namespace PayProc.Utilities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public static class ConfigEncryptDecryptUtil
    {
       /// <summary>
       /// Reads the connection string values and returns a decrypted connnection string
       /// </summary>
       /// <param name="conVal"></param>
       /// <param name="decryptor"></param>
       /// <returns></returns>
        public static string DecryptConVal(string conVal, IEncryptDecrypt decryptor)
        {
            string[] conVals = conVal.Split(';');
            string proVal = string.Empty;
            string decVal = string.Empty;
            for (int cnt = 0; cnt < conVals.Count(); cnt++)
            {
                if (conVals[cnt].Contains("User ID"))
                {
                    proVal = string.Empty;
                    proVal = conVals[cnt].ToString().Replace("User ID=", " ");
                    conVals[cnt] = "User ID=" + decryptor.DecryptString(proVal);
                }

                if (conVals[cnt].Contains("Password"))
                {
                    proVal = string.Empty;
                    proVal = conVals[cnt].ToString().Replace("Password=", " ");
                    conVals[cnt] = "Password=" + decryptor.DecryptString(proVal);
                }

                decVal = decVal + conVals[cnt] + ";";
            }

            return decVal;
        }
    }
}
