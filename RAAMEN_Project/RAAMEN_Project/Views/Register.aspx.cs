using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Model;
using RAAMEN_Project.Controllers;
using RAAMEN_Project.Repository;

namespace RAAMEN_Project.Views
{
    public partial class Register : System.Web.UI.Page
    {
        UserRepository userRepo = new UserRepository();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                List<String> roles = userRepo.getAllRole();
                roleList.DataSource = roles;
                roleList.DataBind();

                List<String> genders = new List<String> { "Male", "Female" };
                genderList.DataSource = genders;
                genderList.DataBind();
            }
        }


        protected void Register_Click(object sender, EventArgs e)
        {
        string email = EmailTxt.Text.ToString();
        string password = PasswordTxt.Text.ToString();
        string confirmPassword = ConfirmPasswordTxt.Text.ToString();
        string username = UsernameTxt.Text.ToString();
        string gender = genderList.Text.ToString();
        int roleId = userRepo.getRoleId(roleList.Text);

        string valid = UserController.validateRegister(roleId, username, email, gender, password, confirmPassword);
        ErrorLbl.Text = valid;
        ErrorLbl.Visible = true;

        if (valid == null)
        {
            Response.Redirect("~/LoginPage");
        }
        }
    }
}