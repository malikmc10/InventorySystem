using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SI_Project
{
    public partial class StoreMan : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            // read from database DailySale
            Response.Redirect("~/Invoices.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // Read from database Product
            Response.Redirect("~/StoreInventory.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/ReOrderStock.aspx");
            //Display all product with quantity 5 or under then allows the manager to reorder them
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Surveillance.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/UpdateInventory.aspx");
        }
    }
}