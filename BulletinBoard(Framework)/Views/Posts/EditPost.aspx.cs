using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_.Views.Posts
{
    public partial class EditPost : System.Web.UI.Page
    {
        #region=====Data declaration=====
        /// <summary>
        /// post entity
        /// </summary>
        Entities.Post.PostEntities post = new Entities.Post.PostEntities();
        /// <summary>
        /// user entity
        /// </summary>
        Entities.User.UserEntities userEntity = new Entities.User.UserEntities();
        /// <summary>
        /// post service
        /// </summary>
        Services.Post.PostServices postservice = new Services.Post.PostServices();
        /// <summary>
        /// data table
        /// </summary>
        DataTable dt = new DataTable();
        #endregion

        #region=====fill data=====
        /// <summary>
        /// bind text box values
        /// </summary>
        public void BindTextBoxvalues()
        {
            post.Id = int.Parse(Request.QueryString["id"].ToString());
            dt = Services.Post.PostServices.EditPost(post);
            if (dt.Rows.Count > 0)
            {
                txtTitle.Text = dt.Rows[0][0].ToString();
                txtDescription.Text = dt.Rows[0][1].ToString();
            }
        }
        #endregion

        #region=====Design generated code=====
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTextBoxvalues();
            }
        }
        /// <summary>
        /// update post data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            post.Title = txtTitle.Text;
            post.Description = txtDescription.Text;
            post.Id = int.Parse(Request.QueryString["id"].ToString());
            bool update = Services.Post.PostServices.Update(post);
            if (update == true)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowSuccess", "javascript:alert('Data updated successfully');", true);
            }
            Response.Redirect("~/Views/Main/CommonHeader.aspx");
        }
        /// <summary>
        /// cancel update
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Main/CommonHeader.aspx");
        }
        #endregion
    }
}