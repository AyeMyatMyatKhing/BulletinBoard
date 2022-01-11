using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_.Views.Users
{
    public partial class UserList : System.Web.UI.Page
    {
        Entities.User.UserEntities user = new Entities.User.UserEntities();
        Services.User.UserServices userservice = new Services.User.UserServices();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetUserData();
            }
        }

        public void GetUserData()
        {
            dt = Services.User.UserServices.GetData();
            if(dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                GridView1.Visible = true;
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
                        button.Attributes["onclick"] = "if(!confirm('Do you want to delete " + id + "?')){ return false; };";
                    }
                }
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            user.Isdelete = 1;
            user.Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values["id"]);
            bool delete = Services.User.UserServices.Delete(user);
            if(delete == true)
            {
                GetUserData();
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "EditButton")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = GridView1.Rows[index];
                user.Id = Convert.ToInt32(row.Cells[0].Text);
                Response.Redirect("EditUser.aspx?id=" + user.Id);
            }
        }
    }
}