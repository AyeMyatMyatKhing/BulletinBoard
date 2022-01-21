using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BulletinBoard_Framework_.Views.Users
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        Entities.User.UserEntities userEntity = new Entities.User.UserEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            userEntity.Id = int.Parse(Request.QueryString["id"]);
            userEntity.Password = txtOldpass.Text.ToString();
            bool update = Services.User.UserServices.ChangePassword(userEntity);
            if(update == true)
            {
                userEntity.Password = txtNewpass.Text.ToString();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Users/EditUser.aspx");
        }
    }
}