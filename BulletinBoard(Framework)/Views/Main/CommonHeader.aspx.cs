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
        Entities.Post.PostEntities post = new Entities.Post.PostEntities();
        Entities.User.UserEntities userEntity = new Entities.User.UserEntities();
        Services.Post.PostServices postservice = new Services.Post.PostServices();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName.Text = Request.QueryString["name"].ToString();
            if (!IsPostBack)
            {
                GetData();
            }
        }

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

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditButton")
          {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];
            post.Id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/Views/Posts/EditPost.aspx?id=" + post.Id);
          }
        }

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

        protected void Button1_Click(object sender, EventArgs e)
        {
            userEntity.Id = int.Parse(Request.QueryString["id"].ToString()); ;
            Response.Redirect("~/Views/Posts/PostCreate.aspx?id="+userEntity.Id);
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Users/UserList.aspx");
        }
    }
}