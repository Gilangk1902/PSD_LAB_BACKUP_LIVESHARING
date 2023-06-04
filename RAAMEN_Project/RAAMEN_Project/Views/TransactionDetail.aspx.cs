using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RAAMEN_Project.Controllers;

namespace RAAMEN_Project.Views
{
    public partial class TransactionDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int trId = int.Parse(Request.QueryString["ID"]);
                TableRepeater.DataSource = TransactionController.GetDetails(trId);
                TableRepeater.DataBind();
            }
        }
    }
}