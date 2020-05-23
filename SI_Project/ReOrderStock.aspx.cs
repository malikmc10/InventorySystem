﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SI_Project
{
    public partial class ReOrderStock : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();
            String s = "select * from Product where quantity <= 5";
            SqlDataAdapter da = new SqlDataAdapter(s, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ReOrder values('" + TextBox1.Text + "','" + TextBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            if(!this.IsPostBack)
            {
                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[5] { new DataColumn("product_id"), new DataColumn("quantity"), new DataColumn("price"), new DataColumn("expire_date"), new DataColumn ("product_name") });
            }

            
            Response.Redirect("ReOrderStock.aspx");
            Label4.Text = "Submit Successfully";
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            GridViewRow row = new GridViewRow(0, 0, DataControlRowType.Header, DataControlRowState.Normal);
          

          //  GridView1.HeaderRow.Parent.Controls.AddAt(0, row);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StoreMan.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }


    }
}