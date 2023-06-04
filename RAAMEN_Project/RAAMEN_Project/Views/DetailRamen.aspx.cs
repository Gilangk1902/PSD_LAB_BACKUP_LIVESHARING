using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Model;
using RAAMEN_Project.Controllers;
using RAAMEN_Project.Handler;
using RAAMEN_Project.Repository;
using RAAMEN_Project.Factory;

namespace RAAMEN_Project.Views
{
    public partial class DetailRamen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {   
                
                int ramenid = int.Parse(Request["ID"]);
                int idUser = (int)Session["Id"];
                if (idUser == 1)
                {
                    //customer
                    orderBtn.Visible = true;
                    updateBtn.Visible = false;
                    deleteBtn.Visible = false;

                }
                else if(idUser == 2)
                {
                    //staff
                    orderBtn.Visible = false;
                    updateBtn.Visible = true;
                    deleteBtn.Visible = true;
                }
                else if(idUser == 3)
                {
                    //admin
                    orderBtn.Visible = true;
                    updateBtn.Visible = true;
                    deleteBtn.Visible = true;
                }

                Ramen ramen = RamenController.Get(ramenid);

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

        protected void orderBtn_Click(object sender, EventArgs e)
        {
            int ramenId = int.Parse(Request["ID"]);
            int UserId = (int)Session["Id"];
            int staffId = GetStaffId();
            int headerId = CreateHeaderId();

            TransactionController.AddHeader(headerId, UserId, staffId, DateTime.Now);
            TransactionController.AddDetail(headerId, ramenId, 1);
        }

        private int CreateHeaderId()
        {
            return 1;
        }
        private int GetStaffId()
        {
            //TODO : 
            return 1;
        }
    }
}