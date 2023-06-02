using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RAAMEN_Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute("ViewRamen", "ViewRamen", "~/Views/ViewRamen.aspx");
            routes.MapPageRoute("UpdateRamen", "UpdateRamen", "~/Views/UpdateRamen.aspx");
            routes.MapPageRoute("InsertRamen", "InsertRamen", "~/Views/InsertRamen.aspx");
            routes.MapPageRoute("LoginPage", "LoginPage", "~/Views/Login.aspx");
            routes.MapPageRoute("RegisterPage", "RegisterPage", "~/Views/Register.aspx");
            routes.MapPageRoute("DetailPage", "DetailPage", "~/Views/DetailRamen.aspx");
            routes.MapPageRoute("ViewCustomers", "ViewCustomers", "~/Views/ViewCustomers.aspx");
            routes.MapPageRoute("ProfilePage", "ProfilePage", "~/Views/ProfilePage.aspx");
            routes.MapPageRoute("TransactionPage", "TransactionPage", "~/Views/Transaction.aspx");
            routes.MapPageRoute("UpdateProfile", "UpdateProfile", "~/Views/UpdateProfile.aspx");
        }
    }
}
