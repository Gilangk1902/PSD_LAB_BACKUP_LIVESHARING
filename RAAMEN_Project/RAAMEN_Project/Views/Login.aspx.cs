using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Repository;
using RAAMEN_Project.Model;
using RAAMEN_Project.Controllers;

namespace RAAMEN_Project.Views
{
    public partial class Login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null || Request.Cookies["UserCookie"] != null)
            {
                Response.Redirect("~/Views/Home.aspx");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text.ToString();
            string password = PasswordTxt.Text.ToString();
            bool rememberMe = RememberCheckBox.Checked;
            string valid = UserController.validateLogin(username, password, rememberMe);
            ErrorLbl.Visible = true;
            ErrorLbl.Text = valid;
        }
    }
}