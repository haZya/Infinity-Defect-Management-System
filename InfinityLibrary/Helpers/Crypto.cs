using System;
using System.Text;

namespace InfinityLibrary.Helpers
{
    public static class Crypto
    {
        /// <summary>
        /// Method for hashing using SHA256
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static String Hash(string value)
        {
            return Convert.ToBase64String(
                System.Security.Cryptography.SHA256.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(value))
                );
        }
    }
}
