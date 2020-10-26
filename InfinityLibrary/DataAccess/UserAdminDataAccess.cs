using Dapper;
using InfinityLibrary.Helpers;
using InfinityLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfinityLibrary.DataAccess
{
    public class UserAdminDataAccess : UserDataAccess
    {
        /// <summary>
        /// Get Users List Function
        /// </summary>
        /// <returns></returns>
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                users = DbConnector.connection.Query<User>("dbo.spUsers_GetAll").ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return users;
        }

        /// <summary>
        /// Search Users Function
        /// </summary>
        /// <returns></returns>
        public List<User> SearchUsers(string input)
        {
            List<User> users = new List<User>();
            try
            {
                // Search with LIKE querys
                users = DbConnector.connection.Query<User>("dbo.spUsers_Search @Input", new { Input = $"%{ input }%" }).ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return users;
        }

        /// <summary>
        /// Insert User Function
        /// </summary>
        /// <param name="username"></param>
        /// <param name="usertype"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="pass"></param>
        /// <param name="userStatus"></param>
        /// <param name="accStatus"></param>
        /// <returns></returns>
        public bool InsertUser(string username, string usertype, string fname, string lname, string pass, string userStatus, string accStatus)
        {
            try
            {
                List<User> users = new List<User>();
                users.Add(new User
                {
                    Username = username,
                    UserType = usertype,
                    FName = fname,
                    LName = lname,
                    Password = Crypto.Hash(pass),
                    IsUserActive = userStatus,
                    IsAccActive = accStatus
                });
                DbConnector.connection.Execute("dbo.spUsers_Insert @Username, @UserType, @FName, @LName, @Password, @IsUserActive, @IsAccActive", users);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Update User Function
        /// </summary>
        /// <param name="username"></param>
        /// <param name="usertype"></param>
        /// <param name="fname"></param>
        /// <param name="lname"></param>
        /// <param name="pass"></param>
        /// <param name="userStatus"></param>
        /// <param name="accStatus"></param>
        /// <returns></returns>
        public bool UpdateUser(string username, string usertype, string fname, string lname, string pass, string userStatus, string accStatus)
        {
            try
            {
                List<User> users = new List<User>();
                users.Add(new User
                {
                    Username = username,
                    UserType = usertype,
                    FName = fname,
                    LName = lname,
                    Password = Crypto.Hash(pass),
                    IsUserActive = userStatus,
                    IsAccActive = accStatus
                });
                DbConnector.connection.Execute("dbo.spUsers_Update @Username, @UserType, @FName, @LName, @Password, @IsUserActive, @IsAccActive", users);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Delete User Function
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool DeleteUser(string username)
        {
            try
            {
                DbConnector.connection.Execute("dbo.spUsers_Delete @Username", new { Username = username });
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Find User Function
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public User FindUser(string username)
        {
            User user = null;
            try
            {
                user = DbConnector.connection.Query<User>("dbo.spUsers_FindUser @Username", new { Username = username }).Single();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return user;
        }

        /// <summary>
        /// Get Active Users Function
        /// </summary>
        /// <returns></returns>
        public List<User> GetActiveUsers()
        {
            List<User> users = new List<User>();
            try
            {
                users = DbConnector.connection.Query<User>("dbo.spUsers_GetActiveUsers").ToList();
            }
            catch (Exception ex)
            {
                new Exception(ExceptionHandler.dbCorruptedEx.ToString(), ex).Log().Display();
            }
            return users;
        }

        /// <summary>
        /// Check if username already exists in the database
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool IsUsernameExist(string username)
        {
            try
            {
                DbConnector.connection.Query<User>("dbo.spUsers_IsUsernameExists @Username", new { Username = username }).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
