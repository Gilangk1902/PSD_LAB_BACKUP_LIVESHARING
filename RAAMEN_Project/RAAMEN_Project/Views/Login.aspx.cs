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
                Response.Redirect("/ViewRamen");
            }
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTxt.Text.ToString();
            string password = PasswordTxt.Text.ToString();
            bool rememberMe = RememberCheckBox.Checked;
            string valid = UserController.validateLogin(username, password, rememberMe);

            if (valid == null || valid == "")
            {
                int id = (int)Session["ID"];
                User user = UserController.Get(id);
                int roleId = user.Roleid;

                if(roleId == 1)
                {
                    Response.Redirect("~/ViewRamen");
                }
                else if (roleId == 2)
                {
                    Response.Redirect("~/ViewCustomers");
                }
                else if (roleId == 3)
                {
                    Response.Redirect("~/ViewStaffs");
                }
            }
            else
            {
                ErrorLbl.Text = valid;
                ErrorLbl.Visible = true;
            }
        }
    }
}