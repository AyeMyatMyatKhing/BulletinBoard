﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.User;
using System.Data;

namespace DAO.Users
{
    public class UserDao
    {
        public static int Insert(UserEntities user)
        {
            try
            {
                var arr = new object[16];
                arr[0] = user.Name;
                arr[1] = user.Email;
                arr[2] = user.Password;
                arr[3] = user.Profile;
                arr[4] = user.Type;
                arr[5] = user.Phone;
                arr[6] = user.Address;
                arr[7] = user.Dateofbirth;
                arr[8] = user.Createuserid;
                arr[9] = user.Updateduserid;
                arr[10] = user.Deleteduserid;
                arr[11] = user.Createdat;
                arr[12] = user.Updatedat;
                arr[13] = user.Deletedat;
                arr[14] = user.Isdelete;

                int id = (int)CommonDao.Insert(arr, "name,email,password,profile,type,phone,address,dob,create_user_id,updated_user_id,deleted_user_id,created_at,updated_at,deleted_at,is_delete", "users");
                if (id != 0)
                {
                    return id;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Convert.ToInt32(false);
        }

        public static DataTable GetData()
        {
            try
            {
                return CommonDao.GetData("select id,name,email,type,address from users where is_delete=0", CommandType.Text);
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
                var arr = new object[3];
                arr[0] = user.Isdelete;
                arr[1] = user.Id;
                return CommonDao.Delete("Update users set is_delete=@1 where id=@2", arr);
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
                var arr = new object[6];
                arr[0] = user.Name;
                arr[1] = user.Email;
                arr[2] = user.Phone;
                arr[3] = user.Address;
                arr[4] = user.Id;
                CommonDao.Update("Update users set name=@1,email=@2,phone=@3,address=@4 where id=@5", arr);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static bool GetPostList(UserEntities user)
        {
            try
            {
                var arr = new Object[3];
                arr[0] = user.Email;
                arr[1] = user.Password;
                CommonDao.Update("select count(1) from users where email=@1 and password=@2", arr);
                return true;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static bool GetUserData(UserEntities user)
        {
            try
            {
                var arr = new object[2];
                arr[0] = user.Id;
                CommonDao.Update("select name,email,phone,address from users where id=@1", arr);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}