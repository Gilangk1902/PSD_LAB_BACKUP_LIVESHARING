using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Controllers;
using RAAMEN_Project.Factory;
using RAAMEN_Project.Model;
using RAAMEN_Project.Repository;

namespace RAAMEN_Project.Views
{
    public partial class InsertRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                meat_selector.DataSource = MeatController.GetAllNames();
                meat_selector.DataBind();
            }
        }

        protected void InsertRamen_Button_Click(object sender, EventArgs e)
        {
            int meatId;
            string name, broth, price;

            meatId = MeatController.GetMeatId(meat_selector.Text);
            name = ramenName_TextBox.Text.ToString();
            broth = ramenBroth_TextBox.Text.ToString();
            price = price_TextBox.Text.ToString();

            RamenController.Add(meatId, name, broth, price);
            error_Label.Text = RamenController.SetErrorMsg(meatId, name, broth, price);

            if(error_Label.Text.Length == 0)
            {
                Response.Redirect("/ViewRamen");
            }
        }
    }
}