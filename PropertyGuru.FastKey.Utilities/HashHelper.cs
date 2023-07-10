using System.Security.Cryptography;
using System.Text;

namespace PropertyGuru.FastKey.Utilities
{
    public class HashHelper
    {
        public static void ComputeHash(ref string value)
        {
            value = ComputeSha256Hash(value);
        }

        internal static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="clearPassword"></param>
        /// <param name="salt"></param>
        /// <param name="hashedPassword"></param>
        /// <returns></returns>
        public static bool Validate(string clearPassword, string salt, string hashedPassword)
        {
            string computedHash = HashHelper.ComputeSha256Hash(clearPassword + salt);
            if (string.Compare(computedHash, hashedPassword) == 0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }
    }
}