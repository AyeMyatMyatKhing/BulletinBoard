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
        /// postservice
        /// </summary>
        Services.Post.PostServices postservice = new Services.Post.PostServices();

        /// <summary>
        /// 
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
            post.Createuserid = 1;
            post.Updateduserid = 1;
            post.Deleteduserid = 1;
            post.Createdat = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            post.Updatedat = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            post.Deletedat = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
        }
        #endregion

        #region=====Design Generated Code=====
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            InsertData();
            int id = Services.Post.PostServices.Insert(post);
            if (id != 0)
            {
                Response.Write("<script>alert('Data inserted!')</script>");
                Response.Redirect("~/Views/Main/CommonHeader.aspx");
            }
        }


        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Main/CommonHeader.aspx");
        }
        #endregion
    }
}