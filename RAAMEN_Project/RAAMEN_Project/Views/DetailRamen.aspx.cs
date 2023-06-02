using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Model;
using RAAMEN_Project.Controllers;

namespace RAAMEN_Project.Views
{
    public partial class DetailRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = int.Parse(Request["ID"]);
                Ramen ramen = RamenController.Get(id);

                ramenName.Text = ramen.Name;
                ramenMeat.Text = ramen.Meat.name;
                ramenBroth.Text = ramen.Broth;
                ramenPrice.Text = ramen.Price;
            }

        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["ID"]);

            Response.Redirect("/UpdateRamen?ID=" + id);
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Request["ID"]);

            RamenController.Delete(id);
            Response.Redirect("/ViewRamen");
        }
    }
}