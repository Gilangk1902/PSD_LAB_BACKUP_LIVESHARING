﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Model;
using RAAMEN_Project.Controllers;


namespace RAAMEN_Project.Views
{
    public partial class Transaction : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                int id = (int)Session["ID"];
                List<Header> trHeaders = TransactionController.getAllHeaderById(id);
                trGridView.DataSource = trHeaders;
                trGridView.DataBind();
            }
        }

        protected void trGridview_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Redirect("/ViewRamen");
        }
    }
}