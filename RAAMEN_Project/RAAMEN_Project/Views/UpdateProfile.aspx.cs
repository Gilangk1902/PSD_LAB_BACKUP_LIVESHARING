using RAAMEN_Project.Controllers;
using RAAMEN_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_Project.Views
{
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindUserData();
            }
        }

        protected void UpdateProfile_Button_Click(object sender, EventArgs e)
        {
            int roleid = 0, id = (int)Session["ID"];
            string username , password , email , gender, confirmPassword;

            username = username_TextBox.Text;
            password = password_TextBox.Text;
            confirmPassword = confirmPassword_TextBox.Text;
            email = email_TextBox.Text;
            gender = gender_DropDownList.Text;

            UserController.Update(id, roleid, username, gender, email, password, confirmPassword);
            errorMessage.Text = UserController.SetErrorMessage(password, confirmPassword);
        }

        private void BindUserData()
        {
            int id = (int)Session["ID"];

            User user = UserController.Get(id);
            username_TextBox.Text = user.Username;
            email_TextBox.Text = user.Email;

            List<String> genders = new List<String> { "Male", "Female" };
            gender_DropDownList.DataSource = genders;
            gender_DropDownList.DataBind();

            foreach(ListItem item in gender_DropDownList.Items)
            {
                if(item.Text == user.Gender)
                {
                    item.Selected = true;
                    gender_DropDownList.Text = user.Gender;
                    break;
                }
            }
        }
    }
}