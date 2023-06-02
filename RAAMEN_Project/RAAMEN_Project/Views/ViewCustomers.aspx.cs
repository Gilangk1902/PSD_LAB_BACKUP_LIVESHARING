using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Controllers;

namespace RAAMEN_Project.Views
{
    public partial class ViewCustomers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CardRepeater.DataSource = UserController.GetAllCustomer();
            CardRepeater.DataBind();
        }
    }
}