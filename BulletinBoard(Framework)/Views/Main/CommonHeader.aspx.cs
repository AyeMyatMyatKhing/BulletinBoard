using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_.Views.Main
{
    public partial class CommonHeader : System.Web.UI.Page
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

        #region======Fill data=====
        public void GetData()
        {
            dt = Services.Post.PostServices.GetAllData();
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.Visible = true;
            }
        }

        public void GetUserName()
        {
            userEntity.Id = int.Parse(Session["user.Id"].ToString());
            dt = Services.User.UserServices.GetUserData(userEntity);
            UserName.Text = dt.Rows[0]["name"].ToString();
        }
        #endregion

        #region=====Design generated code=====
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
            GetUserName();
        }
        /// <summary>
        /// Edit command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                post.Id = Convert.ToInt32(row.Cells[0].Text);
                Response.Redirect("~/Views/Posts/EditPost.aspx?id="+post.Id);
            }
        }
        /// <summary>
        /// bound data to gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                int id = int.Parse(e.Row.Cells[0].Text);
                foreach (Button button in e.Row.Cells[6].Controls.OfType<Button>())
                {
                    if (button.CommandName == "Delete")
                    {
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + "?')){ return false; };";
                    }
                }
            }
        }
        /// <summary>
        /// delete rows of gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            post.Status = 1;
            post.Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["id"]);
            bool DeleteRow = Services.Post.PostServices.Delete(post);
            if (DeleteRow == true)
            {
                GetData();
            }
        }
        /// <summary>
        /// create post
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            userEntity.Id = int.Parse(Session["user.Id"].ToString());
            Response.Redirect("~/Views/Posts/PostCreate.aspx?id="+ userEntity.Id);
        }
        /// <summary>
        /// user list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Views/Users/UserList.aspx");
        }
        /// <summary>
        /// logout from common screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Users/CreateUser.aspx");
        }
        #endregion

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.GetData();
        }

        protected void UserName_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Views/Users/UserProfile.aspx");
        }
    }
}