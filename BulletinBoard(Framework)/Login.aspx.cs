﻿using System;
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
        Entities.User.UserEntities user = new Entities.User.UserEntities();
        Services.User.UserServices userservice = new Services.User.UserServices();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            user.Email = Convert.ToString(txtemail.Text);
            user.Password = Convert.ToString(txtpwd.Text);
            bool loginSuccess = Services.User.UserServices.GetPostList(user);
            if (loginSuccess == true)
            {
                Response.Redirect("~/Views/Posts/PostList.aspx");
            }
            else
            {
                Label3.Text = "Your username and password is incorrect";
                Label3.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btncancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}