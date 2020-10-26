using Dapper;
using InfinityLibrary.Helpers;
using InfinityLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfinityLibrary.DataAccess
{
    public class UserDataAccess
    {
        /// <summary>
        /// User Login Function
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User Login(string username, string password)
        {
            User user = null;
            try
            {
                user = DbConnector.connection.Query<User>("dbo.spUsers_Login @Username, @Password", new { Username = username, Password = Crypto.Hash(password) }).SingleOrDefault();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return user;
        }

        /// <summary>
        /// Get Active Developers Function
        /// </summary>
        /// <returns></returns>
        public List<User> GetActiveDevelopers()
        {
            List<User> users = new List<User>();
            try
            {
                users = DbConnector.connection.Query<User>("dbo.spUsers_GetActiveDevelopers").ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return users;
        }

        /// <summary>
        /// Update User Status Function
        /// </summary>
        /// <param name="username"></param>
        /// <param name="userStatus"></param>
        /// <returns></returns>
        public bool UpdateUserStatus(string username, string userStatus)
        {
            try
            {
                List<User> users = new List<User>();
                users.Add(new User
                {
                    Username = username,
                    IsUserActive = userStatus
                });
                DbConnector.connection.Execute("dbo.spUsers_UpdateStatus @Username, @IsUserActive", users);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
