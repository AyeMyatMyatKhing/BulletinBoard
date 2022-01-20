using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_
{
    public partial class Login : System.Web.UI.Page
    {
        #region=====data declaration=====
        /// <summary>
        /// user entity
        /// </summary>
        Entities.User.UserEntities user = new Entities.User.UserEntities();
        /// <summary>
        /// user service
        /// </summary>
        Services.User.UserServices userservice = new Services.User.UserServices();
        /// <summary>
        /// data table
        /// </summary>
        DataTable dt = new DataTable();
        #endregion

        #region=====design generated code=====
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// login into common screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnlogin_Click(object sender, EventArgs e)
        {
            user.Email = txtemail.Text.ToString();
            user.Password = DAO.CommonDao.Encrypt(txtpwd.Text.ToString());
            dt = Services.User.UserServices.GetPostList(user);
            if (dt.Rows.Count > 0)
            {
                Session["user.Id"] = Convert.ToInt32(dt.Rows[0][0].ToString());
                user.Name = dt.Rows[0][1].ToString();
                Server.Transfer("~/Views/Main/CommonHeader.aspx?id="+ Session["user.Id"]);
            }
            else
            {
                Label3.Text = "Your username or password is incorrect.";
                Label3.ForeColor = System.Drawing.Color.Red;
            }
        }
        /// <summary>
        /// cancel login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        #endregion

        protected void forgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ForgotPassword.aspx");
        }
    }
}