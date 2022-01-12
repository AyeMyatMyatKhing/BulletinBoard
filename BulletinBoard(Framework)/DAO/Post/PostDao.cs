using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Post;
using System.Data;

namespace DAO.Post
{
    public class PostDao
    {
        public static int Insert(PostEntities post)
        {
            try
            {
                var arr = new object[10];
                arr[0] = post.Title;
                arr[1] = post.Description;
                arr[2] = post.Status;
                arr[3] = post.Createuserid;
                arr[4] = post.Updateduserid;
                arr[5] = post.Deleteduserid;
                arr[6] = post.Createdat;
                arr[7] = post.Updatedat;
                arr[8] = post.Deletedat;

                int id = (int)CommonDao.Insert(arr, "title,description,status,create_user_id,updated_user_id,deleted_user_id,created_at,updated_at,deleted_at", "posts");
                if(id != 0)
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


        public static DataTable GetAllData()
        {
            try
            {
                return CommonDao.GetData("select id,title,description,create_user_id,created_at from posts where status = 0", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool EditData(PostEntities post)
        {
            try
            {
                var arr = new object[4];
                arr[0] = post.Title;
                arr[1] = post.Description;
                arr[2] = post.Id;
                CommonDao.Update("select title,description from posts where id =@3", arr);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Update(PostEntities post)
        {
            try
            {
                var arr = new object[4];
                arr[0] = post.Title;
                arr[1] = post.Description;
                arr[2] = post.Id;
                CommonDao.Update("Update posts set title=@1,description=@2 where id=@3", arr);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Delete(PostEntities post)
        {
            try
            {
                var arr = new object[3];
                arr[0] = post.Status;
                arr[1] = post.Id;
                return CommonDao.Delete("Update posts set status=@1 where id=@2", arr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
