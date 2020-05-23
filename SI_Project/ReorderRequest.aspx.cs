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
    public partial class ReorderRequest : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            String s = "select * from ReOrder";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

            if (!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[3] { new DataColumn("ReOrder_Id"), new DataColumn("Product_Id"), new DataColumn("Quantity")});
            }
        }
        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            GridViewRow row = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Normal);

            //GridView1.HeaderRow.Parent.Controls.AddAt(0, row);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = r.Next();
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Invoice values('" + TextBox1.Text + "','" + TextBox3.Text + "','" + TextBox2.Text + "','" + TextBox4.Text + "','" + num + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = " update WarehouseProduct set Quantity = Quantity - '"+TextBox3.Text+"' where Warehouse_Product_Id = '"+TextBox1.Text+"'";
            cmd2.ExecuteNonQuery();
            con.Close();


            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "Delete from Reorder where Product_Id = '" + TextBox1.Text + "' and Quantity ='" + TextBox3.Text + "'";
            cmd1.ExecuteNonQuery();
            con.Close();

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

           
                Label5.Text = "Succesfully Completed";


            Response.Redirect("ReorderRequest.aspx");
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