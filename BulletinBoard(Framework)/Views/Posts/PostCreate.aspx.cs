using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_.Views.Posts
{
    public partial class PostCreate : System.Web.UI.Page
    {
        #region=====Data Decalaration=====
        /// <summary>
        /// post
        /// </summary>
        Entities.Post.PostEntities post = new Entities.Post.PostEntities();

        /// <summary>
        /// user entity
        /// </summary>
        Entities.User.UserEntities userEntity = new Entities.User.UserEntities();

        /// <summary>
        /// postservice
        /// </summary>
        Services.Post.PostServices postservice = new Services.Post.PostServices();

        /// <summary>
        /// data table
        /// </summary>
        DataTable dt = new DataTable();
        #endregion

        #region=====Fill Data=====
       /// <summary>
       /// insert post data
       /// </summary>
        private void InsertData()
        {
            post.Title = txtTitle.Text.ToString();
            post.Description = txtDescription.Text.ToString();
            post.Status = 0;
            post.Createuserid = userEntity.Id;
            post.Updateduserid = userEntity.Id;
            post.Deleteduserid = userEntity.Id;
            post.Createdat = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            post.Updatedat = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            post.Deletedat = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
          
        }
        #endregion

        #region=====Design Generated Code=====
        protected void Page_Load(object sender, EventArgs e)
        {
            userEntity.Id = int.Parse(Request.QueryString["id"].ToString());
        }
        /// <summary>
        /// create post
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCreate_Click(object sender, EventArgs e)
        {
            InsertData();
            int id = Services.Post.PostServices.InsertData(post);
        if (id != 0)
        {
            Response.Write("<script>alert('Data inserted!')</script>");

                Server.Transfer("~/Views/Main/CommonHeader.aspx?id=" +userEntity.Id);
            }
        }

        /// <summary>
        /// cancel create post
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Views/Main/CommonHeader.aspx");
        }
        #endregion
    }
}