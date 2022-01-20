using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;
using System.Data;

namespace BulletinBoard_Framework_
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        Entities.User.UserEntities userEntity = new Entities.User.UserEntities();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            userEntity.Email = txtEmail.Text.ToString();
            dt = Services.User.UserServices.ResetPassword(userEntity);

        }
    }
}