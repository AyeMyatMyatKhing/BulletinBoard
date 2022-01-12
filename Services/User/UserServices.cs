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

        public static int Insert(UserEntities user)
        {
            try
            {
                var dt = new DAO.Users.UserDao();
                return DAO.Users.UserDao.Insert(user);

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetData()
        {
            try
            {
                return DAO.Users.UserDao.GetData();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool Delete(UserEntities user)
        {
            try
            {
                return DAO.Users.UserDao.Delete(user);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

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
    }
}
