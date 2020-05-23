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
    public partial class PLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(@"select * from EmployeeLogin where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Write("<script>alert('Log In Sucess')</script>");
               Response.Redirect("~/POS.aspx");

               // Session["User"] = TextBox1.Text;
            }
            else
            {
                Response.Write("<script>alert('Incorect UserName or Password')</script>");
            }
        }
    }
}