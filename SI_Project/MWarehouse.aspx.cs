using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SI_Project
{
    public partial class MWarehouse : System.Web.UI.Page
    {

       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ReorderRequest.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // view inventory
            Response.Redirect("~/WarehouseInventory.aspx");
        }
    }
}