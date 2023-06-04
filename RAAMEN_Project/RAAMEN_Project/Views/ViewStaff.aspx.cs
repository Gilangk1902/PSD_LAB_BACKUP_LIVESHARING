using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Controllers;

namespace RAAMEN_Project.Views
{
    public partial class ViewStaff : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CardRepeater.DataSource = UserController.GetAllStaff();
            CardRepeater.DataBind();
        }
    }
}