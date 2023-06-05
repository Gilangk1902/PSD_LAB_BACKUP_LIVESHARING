using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Controllers;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Views
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ManageNavigationItem();
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            HttpContext.Current.Session.Clear();
            if (HttpContext.Current.Request.Cookies["UserCookie"] != null)
            {
                var userCookie = new HttpCookie("UserCookie");
                userCookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(userCookie);
            }
            Response.Redirect("/LoginPage");
        }

        private void ManageNavigationItem()
        {
            if (Session["User"] == null)
            {
                login_li.Visible = true;
                logout_Button.Visible = false;
                profile_li.Visible = false;
            }
            else
            {
                int id = (int)Session["ID"];
                User user = UserController.Get(id);
                int roleId = user.Roleid;

                login_li.Visible = false;
                logout_Button.Visible = true;
                profile_li.Visible = true;

                ManageItem_BasedOn(roleId);
                
            }
        }

        private void ManageItem_BasedOn(int roleId)
        {
            SetHomeUrl(roleId);
        }

        private void SetHomeUrl(int roleId)
        {
            if (roleId == 1)
            {
                HomeHyperlink.Visible = false;
            }
            else if (roleId == 2)
            {
                HomeHyperlink.Visible = true;
                HomeHyperlink.NavigateUrl = "~/ViewCustomers";
            }
            else if (roleId == 3)
            {
                HomeHyperlink.Visible = true;
                HomeHyperlink.NavigateUrl = "~/ViewStaffs";
            }
        }
    }
}