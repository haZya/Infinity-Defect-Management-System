using System.Data;
using System.Data.SqlClient;

namespace InfinityLibrary.Helpers
{
    public static class DbConnector
    {
        public static IDbConnection connection;

        /// <summary>
        /// Getting SQL Connection
        /// </summary>
        private static void GetSQLConnection()
        {
            connection = new SqlConnection(CnnHelper.CnnVal("InfinityDB"));
        }

        /// <summary>
        /// Opening the Connection
        /// </summary>
        /// <returns></returns>
        public static bool OpenSQLConnection()
        {
            try
            {
                GetSQLConnection();
                connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Closing the Connection
        /// </summary>
        /// <returns></returns>
        public static bool CloseSQLConnection()
        {
            try
            {
                connection?.Close();
                connection = null;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
