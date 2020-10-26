using System.Configuration;

namespace InfinityLibrary.Helpers
{
    public static class CnnHelper
    {
        /// <summary>
        /// Getting the connection string from app.config
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string CnnVal(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
