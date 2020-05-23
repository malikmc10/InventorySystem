using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using System.Configuration;
namespace SI_Project
{
    public partial class Surveillance : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            String date = DateTime.Today.ToShortDateString();
            TextBox2.Text = date;
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            string strConnString = @"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select Id, Location, Date from Survil";
                    cmd.Connection = con;
                    con.Open();
                    DataList1.DataSource = cmd.ExecuteReader();
                    DataList1.DataBind();
                    con.Close();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
            {
                byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);
                string strConnString = @"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(strConnString))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "insert into Survil(Location, Date, ContentType, Data) values (@Location, @Date, @ContentType, @Data)";
                        cmd.Parameters.AddWithValue("@Location", TextBox1.Text);
                        cmd.Parameters.AddWithValue("@Date", TextBox2.Text);
                        cmd.Parameters.AddWithValue("@ContentType", "video/mp4");
                        cmd.Parameters.AddWithValue("@Data", bytes);
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        cmd.CommandTimeout = 0;
                        con.Close();

                        Label1.Text = "Successfully Uploaded";
                    }
                }
            }
            Response.Redirect(Request.Url.AbsoluteUri);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/StoreMan.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Index.aspx");
        }
    }
}