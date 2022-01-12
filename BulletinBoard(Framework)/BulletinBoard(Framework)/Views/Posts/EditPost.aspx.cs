using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace BulletinBoard_Framework_.Views.Posts
{
    public partial class EditPost : System.Web.UI.Page
    {
        Entities.Post.PostEntities post = new Entities.Post.PostEntities();
        Services.Post.PostServices postservice = new Services.Post.PostServices();
        DataTable dt = new DataTable();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = int.Parse(Request.QueryString["id"].ToString());
            if (!IsPostBack)
            {
                BindTextBoxvalues();
            }
        }

        public void BindTextBoxvalues()
        {
            string strcon = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = new SqlCommand("select title,description from posts where id = " + id, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtTitle.Text = dt.Rows[0][0].ToString();
            txtDescription.Text = dt.Rows[0][1].ToString();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            post.Title = txtTitle.Text;
            post.Description = txtDescription.Text;
            post.Id = int.Parse(Request.QueryString["id"].ToString());
            bool update = Services.Post.PostServices.Update(post);
            if(update == true)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowSuccess", "javascript:alert('Data updated successfully');", true);
            }
            Response.Redirect("PostList.aspx");
        }
    }
}