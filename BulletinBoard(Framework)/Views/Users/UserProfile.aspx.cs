using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_.Views.Users
{
    public partial class UserProfile : System.Web.UI.Page
    {
        Entities.User.UserEntities userEntity = new Entities.User.UserEntities();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }

        public void BindData()
        {
            userEntity.Id = int.Parse(Request.QueryString["id"]);
            dt = Services.User.UserServices.GetUserData(userEntity);
            if(dt.Rows.Count > 0)
            {
                lblName.Text = dt.Rows[0]["name"].ToString();
                profile.ImageUrl = dt.Rows[0]["profile"].ToString();
                lblEmail.Text = dt.Rows[0]["email"].ToString();
                lblType.Text = Convert.ToString(dt.Rows[0]["type"]);
                lblPhone.Text = dt.Rows[0]["phone"].ToString();
                //DateTime t = dt.Rows[0]["dob"].Field<DateTime>("Date");
                //lblDob.Text = Convert.ToString(t);
                lblDob.Text = Convert.ToDateTime(dt.Rows[0]["dob"]).ToString("MM-dd-yyyy");
                lblAddress.Text = dt.Rows[0]["address"].ToString();
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Views/Main/CommonHeader.aspx");
        }
    }
}