using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SI_Project
{
    public partial class Invoices : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            String s = "select * from DailySale";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("DailySales_Id"), new DataColumn("Product_Id"), new DataColumn("Date"), new DataColumn("Quantity") });
            }
        }

            protected void GridView1_DataBound(object sender, EventArgs e)
            {
                GridViewRow row = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Normal);

                //GridView1.HeaderRow.Parent.Controls.AddAt(0, row);

            }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StoreMan.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }
    }
}