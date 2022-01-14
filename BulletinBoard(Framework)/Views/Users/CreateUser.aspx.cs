using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace BulletinBoard_Framework_.Views.Users
{
    public partial class CreateUser : System.Web.UI.Page
    {
        #region=====Data declaration=====
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
        DataTable da = new DataTable();
        #endregion

        #region=====fill data=====
        /// <summary>
        /// insert user data
        /// </summary>
        private void InsertUser()
        {
            int len = uploadProfile.PostedFile.ContentLength;
            byte[] pic = new byte[len + 1];
            uploadProfile.PostedFile.InputStream.Read(pic, 0, len);
            user.Name = txtName.Text.ToString();
            user.Email = txtEmail.Text.ToString();
            user.Password = txtPassword.Text.ToString();
            user.Profile = pic.ToString();
            user.Type = DropDownList1.SelectedItem.Value.ToString();
            user.Phone = txtPhone.Text.ToString();
            user.Address = txtAddress.Text.ToString();
            user.Dateofbirth = Convert.ToDateTime(txtDob.Text.ToString());
            user.Createuserid = 1;
            user.Updateduserid = 1;
            user.Deleteduserid = 1;
            user.Createdat = DateTime.Now;
            user.Updatedat = DateTime.Now;
            user.Deletedat = DateTime.Now;
            user.Isdelete = 0;
        }
        #endregion

        #region=====Design generated code=====
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// insert user data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            InsertUser();
            int id = Services.User.UserServices.Insert(user);
            if (id > 0)
            {
                Response.Write("<script>alert('Data inserted!')</script>");
                Response.Redirect("UserList.aspx");
            }
        }
        #endregion
    }
}