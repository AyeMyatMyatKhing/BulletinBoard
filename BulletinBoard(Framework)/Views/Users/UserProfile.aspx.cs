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
        #region=====Data declaration=====
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
            if (!IsPostBack)
            {
                BindData();
            }
        }
        /// <summary>
        /// bind user data for user profile
        /// </summary>
        public void BindData()
        {
            userEntity.Id = int.Parse(Request.QueryString["id"]);
            dt = Services.User.UserServices.GetUserData(userEntity);
            if (dt.Rows.Count > 0)
            {
                lblName.Text = dt.Rows[0]["name"].ToString();
                profile.ImageUrl = dt.Rows[0]["profile"].ToString();
                lblEmail.Text = dt.Rows[0]["email"].ToString();
                lblType.Text = Convert.ToString(dt.Rows[0]["type"]);
                lblPhone.Text = dt.Rows[0]["phone"].ToString();
                lblDob.Text = Convert.ToDateTime(dt.Rows[0]["dob"]).ToString("MM-dd-yyyy");
                lblAddress.Text = dt.Rows[0]["address"].ToString();
            }
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/Views/Main/CommonHeader.aspx");
        }
        #endregion
    }
}