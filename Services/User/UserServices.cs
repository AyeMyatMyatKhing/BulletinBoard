using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.User;
using System.Data;

namespace Services.User
{
    public class UserServices
    {
        #region=====Insert,Update,Delete=====
        /// <summary>
        /// insert data into database
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int Insert(UserEntities user)
        {
            try
            {
                var dt = new DAO.Users.UserDao();
                return DAO.Users.UserDao.InsertData(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// get data from database
        /// </summary>
        /// <returns></returns>
        public static DataTable GetData()
        {
            try
            {
                return DAO.Users.UserDao.GetData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// delete selected data
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Delete(UserEntities user)
        {
            try
            {
                return DAO.Users.UserDao.Delete(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// update selected data
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool Update(UserEntities user)
        {
            try
            {
                return DAO.Users.UserDao.Update(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// get post list for edit and delete
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static DataTable GetPostList(UserEntities user)
        {
            try
            {
                return DAO.Users.UserDao.GetPostList(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// get user data
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static DataTable GetUserData(UserEntities user)
        {
            try
            {
                return DAO.Users.UserDao.GetUserData(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// get user name and password for reset password
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static DataTable ResetPassword(UserEntities user)
        {
            try
            {
                return DAO.Users.UserDao.ResetPassword(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
