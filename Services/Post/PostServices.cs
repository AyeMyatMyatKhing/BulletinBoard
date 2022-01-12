using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Post;
using System.Data;

namespace Services.Post
{
    public class PostServices
    {
        public static int Insert(PostEntities post)
        {
            try
            {
                var dt = new DAO.Post.PostDao();
                return DAO.Post.PostDao.Insert(post);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetAllData()
        {
            try
            {
                return DAO.Post.PostDao.GetAllData();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable EditPost(PostEntities post)
        {

            try
            {
                return DAO.Post.PostDao.EditData(post);
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
                return DAO.Post.PostDao.Update(post);
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
                return DAO.Post.PostDao.Delete(post);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
