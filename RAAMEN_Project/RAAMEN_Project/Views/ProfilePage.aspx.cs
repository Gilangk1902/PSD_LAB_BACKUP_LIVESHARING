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
                if (Session["User"] != null)
                {
                    BindUserData();
                }
            }

        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("/UpdateProfile?ID=" + (int)Session["ID"]);
        }


        private void BindUserData()
        {
            if (Request.Cookies["UserId"] != null)
            {
                int id = int.Parse(Request.Cookies["UserId"].Value);

                User user = UserController.Get(id);
                username_Label.Text = user.Username;
                email_Label.Text = user.Email;
                gender_Label.Text = user.Gender;
            }
            else
            {
                int id = (int)Session["ID"];

                User user = UserController.Get(id);
                username_Label.Text = user.Username;
                email_Label.Text = user.Email;
                gender_Label.Text = user.Gender;
            }
        }
    }
}