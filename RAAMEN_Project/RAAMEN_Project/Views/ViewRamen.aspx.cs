using RAAMEN_Project.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RAAMEN_Project.Views
{
    public partial class ViewRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CardRepeater.DataSource = RamenController.GetAll();
            CardRepeater.DataBind();
        }
       

        protected void OpenDetail_Click1(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)(sender);
            int id = int.Parse(btn.CommandArgument);

            Response.Redirect("/DetailPage?ID=" + id);
        }
    }
}