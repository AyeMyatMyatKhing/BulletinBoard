using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_.Views.Users
{
    public partial class EditUser : System.Web.UI.Page
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

        #region=====Fill data=====
        /// <summary>
        /// bind text box value from gridview
        /// </summary>
        public void BindTextBoxvalues()
        {
            user.Id = int.Parse(Request.QueryString["id"].ToString());
            dt = Services.User.UserServices.GetUserData(user);
            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0][0].ToString();
                txtemail.Text = dt.Rows[0][1].ToString();
                txtphone.Text = dt.Rows[0][2].ToString();
                txtaddr.Text = dt.Rows[0][3].ToString();
            }
        }
        #endregion

        #region=====Design generated code=====
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindTextBoxvalues();
            }
        }

        /// <summary>
        /// confirm edit data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnconfirm_Click(object sender, EventArgs e)
        {
            user.Name = txtname.Text;
            user.Email = txtemail.Text;
            user.Phone = int.Parse(txtphone.Text);
            user.Address = txtaddr.Text;
            user.Id = int.Parse(Request.QueryString["id"].ToString());
            bool update = Services.User.UserServices.Update(user);
            if (update == true)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "ShowSuccess", "javascript:alert('Data updated successfully');", true);
            }
            Response.Redirect("UserList.aspx");
        }

        /// <summary>
        /// cancel edit data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserList.aspx");
        }
        #endregion
    }
}