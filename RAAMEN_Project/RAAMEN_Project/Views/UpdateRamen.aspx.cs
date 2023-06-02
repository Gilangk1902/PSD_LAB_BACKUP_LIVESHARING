using RAAMEN_Project.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Handler;
using RAAMEN_Project.Model;

namespace RAAMEN_Project.Views
{
    public partial class UpdateRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                int id = int.Parse(Request["ID"]);

                Ramen ramen = RamenController.Get(id);

                meat_selector.DataSource = MeatController.GetAllNames();
                meat_selector.DataBind();

                ramenName_TextBox.Text = ramen.Name;
                ramenBroth_TextBox.Text = ramen.Broth;
                ramenPrice_TextBox.Text = ramen.Price;
                meat_selector.SelectedValue = ramen.Meat.name;

            }
            
        }

        protected void updateRamen_Button_Click(object sender, EventArgs e)
        {
            int meatId = MeatController.GetMeatId(meat_selector.Text);
            string name = ramenName_TextBox.Text.ToString();
            string broth = ramenBroth_TextBox.Text.ToString();
            string price = ramenPrice_TextBox.Text.ToString();

            RamenController.Update(int.Parse(Request["ID"]), meatId, name, broth, price);
            Response.Redirect("/ViewRamen");
        }
    }
}