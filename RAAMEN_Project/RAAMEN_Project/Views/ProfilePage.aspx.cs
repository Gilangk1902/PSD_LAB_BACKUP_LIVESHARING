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
    public partial class ProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = (int)Session["ID"];

                User user = UserController.Get(id);
                username_Label.Text = user.Username;
                email_Label.Text = user.Email;
                gender_Label.Text = user.Gender;
            }

        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UpdateProfile?ID=" + (int)Session["ID"]);
        }
    }
}