using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_.Views.Users
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        #region=====data declaration=====
        /// <summary>
        /// user entity
        /// </summary>
        Entities.User.UserEntities userEntity = new Entities.User.UserEntities();
        /// <summary>
        /// data table
        /// </summary>
        DataTable dt = new DataTable();
        #endregion

        #region=====design generated code=====
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            string OldPassword = DAO.CommonDao.Encrypt(txtOldpass.Text.ToString());
            userEntity.Id = int.Parse(Session["user.Id"].ToString());
            dt = Services.User.UserServices.GetUserData(userEntity);
            userEntity.Password = dt.Rows[0]["password"].ToString();
            if(OldPassword == userEntity.Password)
            {
                bool update = Services.User.UserServices.ChangePassword(userEntity);
                if(update == true)
                {
                    userEntity.Password = DAO.CommonDao.Encrypt(txtNewpass.Text.ToString());
                    Response.Write("<script>alert('Password changed successfully!')</script>");
                }               
            }
            else
            {
                Response.Write("<script>alert('Please enter valid password.')</script>");
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Views/Users/EditUser.aspx");
        }
        #endregion
    }
}