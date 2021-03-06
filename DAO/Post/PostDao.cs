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
        #region=====Insert,Update,Delete=====
        public static int InsertData(PostEntities post)
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

                int id = (int)CommonDao.InsertData(arr, "insert into posts values (@1,@2,@3,@4,@5,@6,@7,@8,@9)");
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

        /// <summary>
        /// Get post data
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllData()
        {
            try
            {
                return CommonDao.GetData("select posts.id,posts.title,posts.description,[users].name,convert(varchar,  posts.created_at, 111)as PostedDate from posts inner join [users] on posts.create_user_id = [users].id where posts.status=0", CommandType.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get edit data
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public static DataTable EditData(PostEntities post)
        {
            try
            {
                var arr = new object[2];
                arr[0] = post.Id;
                var dt = CommonDao.GetEditData(arr, "select title,description from posts where id =@1", CommandType.Text);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update data
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Delete data
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
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
        #endregion
    }
}
