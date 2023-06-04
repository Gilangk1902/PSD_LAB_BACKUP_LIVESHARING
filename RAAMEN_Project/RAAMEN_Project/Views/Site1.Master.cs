using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_Project.Views
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] == null)
            {

            }
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
    }
}