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
    public partial class WarehouseInventory : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            String s = "select * from WarehouseProduct";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Warehouse_Product_Id"), new DataColumn("Quantity"), new DataColumn("Product_Name"), new DataColumn("Product_Desc")});
            }

        }
        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            GridViewRow row = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Normal);


         //   GridView1.HeaderRow.Parent.Controls.AddAt(0, row);

        }

        protected void Update_Inventory(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = " update WarehouseProduct set Quantity = Quantity + '" + TextBox2.Text + "' where Warehouse_Product_Id = '" + TextBox1.Text + "'";
            cmd2.ExecuteNonQuery();
            con.Close();

            Label3.Text = "Inventory Update Successful";

            TextBox1.Text = "";
            TextBox2.Text = "";
            Response.Redirect("WarehouseInventory.aspx");
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/MWarehouse.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }
    }
}