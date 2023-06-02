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
                int id = int.Parse(Request.QueryString["ID"]);

                User user = UserController.Get(id);
                username_TextBox.Text = user.Username;
                email_TextBox.Text = user.Email;

                List<String> genders = new List<String> { "Male", "Female" };
                gender_DropDownList.DataSource = genders;
            }
        }

        protected void UpdateProfile_Button_Click(object sender, EventArgs e)
        {
            int roleid = 0, id = (int)Session["ID"];
            string username = "", password = "", email = "", gender = "";

            username = username_TextBox.Text;
            password = password_TextBox.Text;
            email = email_TextBox.Text;
            gender = gender_DropDownList.Text;
            UserController.Update(id, roleid, username, gender, email, password);
        }
    }
}