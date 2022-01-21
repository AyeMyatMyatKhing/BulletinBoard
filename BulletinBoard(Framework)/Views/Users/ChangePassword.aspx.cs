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

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Users/EditUser.aspx");
        }
        #endregion
    }
}