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
        #region=====Insert,Update,Delete=====
        /// <summary>
        /// insert data into database
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
        public static int InsertData(PostEntities post)
        {
            try
            {
                //var dt = new DAO.Post.PostDao();
                return DAO.Post.PostDao.InsertData(post);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// select data from database
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// edit selected data
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
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
        /// <summary>
        /// update selected post
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
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
        /// <summary>
        /// delete selected post
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
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
        #endregion
    }
}
