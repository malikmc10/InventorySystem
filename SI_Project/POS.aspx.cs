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
    public partial class POS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Label1.Text = Session["User"].ToString();

            String date = DateTime.Today.ToShortDateString();
            Label2.Text = date;

           Response.Write(hdnUserInput.Value);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Cheese Patty
            Session["1"] = 1;
            HttpCookie cookie = new HttpCookie("quantity");
            cookie["1"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);




        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           // Session.Remove("largef");
            Session["2"] = 2;
            HttpCookie cookie = new HttpCookie("quantity2");
            cookie["2"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
            // Session.Remove("water");
         //  Response.Write("<script> int quant; quant = prompt('Enter Quantity'); Session["3"] = 90 * int32.Parse(quant); </script>");
            Session["3"] = 3;
            HttpCookie cookie = new HttpCookie("quantity3");
            cookie["3"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True");

            int total =0;
            int item = 0;
            int firstv = 0;
          String qq;
           String qu = String.Empty;
           
           foreach (string Key in Session.Keys)
            {
                item = Int32.Parse(Session[Key].ToString());
               qq = item.ToString();
                 using (SqlCommand cmd = new SqlCommand(@" select price from Product where product_id = '" + item + "'", con))
                {
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            firstv = Int32.Parse(reader[0].ToString());
                            


                        }
                    }
                    con.Close();

                }

                // HttpCookie cookie = Request.Cookies["quantity"];
                // qu = cookie["qq"].;
                //  int quu = Int32.Parse(qu);
                //  int quantity = quu;
                //   Response.Write("quantity" + quantity);
                //   int fcost = quantity * firstv;
                if (item == 1)
                {


                    HttpCookie cookie = Request.Cookies["quantity"];
                    String quantity11 = cookie["1"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }
                else
                    if (item == 2)
                {


                    HttpCookie cookie = Request.Cookies["quantity2"];
                    String quantity11 = cookie["2"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }
                else if(item == 3)
                {


                    HttpCookie cookie = Request.Cookies["quantity3"];
                    String quantity11 = cookie["3"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }
                else
                    if (item == 4)
                {


                    HttpCookie cookie = Request.Cookies["quantity4"];
                    String quantity11 = cookie["4"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }
                else
                    if (item == 5)
                {


                    HttpCookie cookie = Request.Cookies["quantity5"];
                    String quantity11 = cookie["5"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }
                else
                    if (item == 6)
                {


                    HttpCookie cookie = Request.Cookies["quantity6"];
                    String quantity11 = cookie["6"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }
                else
                    if (item == 7)
                {


                    HttpCookie cookie = Request.Cookies["quantity7"];
                    String quantity11 = cookie["7"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }
                else
                    if (item == 8)
                {


                    HttpCookie cookie = Request.Cookies["quantity8"];
                    String quantity11 = cookie["8"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }
                else
                    if (item == 9)
                {


                    HttpCookie cookie = Request.Cookies["quantity9"];
                    String quantity11 = cookie["9"];
                    int final = Int32.Parse(quantity11) * firstv;

                    // Response.Write("quantity"+final);
                    total = total + final;
                }


            }
           // int total = Int32.Parse(Session["water"].ToString()) + Int32.Parse(Session["largef"].ToString()) + Int32.Parse(Session["cp"].ToString())+ Int32.Parse(Session["smallf"].ToString())+ Int32.Parse(Session["soda"].ToString())+ Int32.Parse(Session["orangej"].ToString())+ Int32.Parse(Session["sp"].ToString())+ Int32.Parse(Session["bread"].ToString())+ Int32.Parse(Session["bp"].ToString());
          // Response.Write(total);

           // Session["total"] = total;
            totaltxt.Text = "$ " + total;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
           // Session.Remove("smallf");
            Session["4"] = 4;
            HttpCookie cookie = new HttpCookie("quantity4");
            cookie["4"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
           // Session.Remove("soda");
            Session["5"] = 5;
            HttpCookie cookie = new HttpCookie("quantity5");
            cookie["5"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            // Session.Remove("bread");
            Session["6"] = 6;
            HttpCookie cookie = new HttpCookie("quantity6");
            cookie["6"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
           // Session.Remove("bp");
            Session["7"] = 7;
            HttpCookie cookie = new HttpCookie("quantity7");
            cookie["7"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);

        }

        protected void Button9_Click(object sender, EventArgs e)
        { 

           // Session.Remove("sp");
            Session["8"] = 8;
            HttpCookie cookie = new HttpCookie("quantity8");
            cookie["8"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
           // Session.Remove("orangej");
            Session["9"] = 9;
            HttpCookie cookie = new HttpCookie("quantity9");
            cookie["9"] = hdnUserInput.Value;
            Response.Cookies.Add(cookie);

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Index.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-UQV39AGU;Initial Catalog=Software;Integrated Security=True");

             int item = 0;
            int quantity;

            String date = DateTime.Today.ToShortDateString();

            foreach (string key in Session.Keys)
                    {

                  item = Int32.Parse(Session[key].ToString());
                int id = Int32.Parse(Session[key].ToString());
                if (item == 1)
                {


                    HttpCookie cookie = Request.Cookies["quantity"];
                    String quantity11 = cookie["1"];
                    quantity = Int32.Parse(quantity11);

                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";

                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }
                else
                     if (item == 2)
                {


                    HttpCookie cookie = Request.Cookies["quantity2"];
                    String quantity11 = cookie["2"];
                    quantity = Int32.Parse(quantity11);

                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";

                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }
                else
                     if (item == 3)
                {


                    HttpCookie cookie = Request.Cookies["quantity3"];
                    String quantity11 = cookie["3"];
                    quantity = Int32.Parse(quantity11);

                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";

                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }
                else
                     if (item == 4)
                {


                    HttpCookie cookie = Request.Cookies["quantity4"];
                    String quantity11 = cookie["4"];
                    quantity = Int32.Parse(quantity11);

                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";

                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }
                else
                     if (item == 5)
                {


                    HttpCookie cookie = Request.Cookies["quantity5"];
                    String quantity11 = cookie["5"];
                    quantity = Int32.Parse(quantity11);

                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";

                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }
                else
                     if (item == 6)
                {


                    HttpCookie cookie = Request.Cookies["quantity6"];
                    String quantity11 = cookie["6"];
                    quantity = Int32.Parse(quantity11);

                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";

                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }
                else
                     if (item == 7)
                {


                    HttpCookie cookie = Request.Cookies["quantity7"];
                    String quantity11 = cookie["7"];
                    quantity = Int32.Parse(quantity11);

                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";

                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }
                else
                     if (item == 8)
                {


                    HttpCookie cookie = Request.Cookies["quantity8"];
                    String quantity11 = cookie["8"];
                    quantity = Int32.Parse(quantity11);

                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";

                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }
                if (item == 9)
                {


                    HttpCookie cookie = Request.Cookies["quantity9"];
                    String quantity11 = cookie["9"];
                    quantity = Int32.Parse(quantity11);
                    //updates the product inventory
                    SqlCommand cmd = new SqlCommand(@" update Product set quantity = quantity - '" + quantity + "' where product_id = '" + id + "'", con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet dt = new DataSet();
                    sda.Fill(dt);
                    Response.Write(quantity);


                    // Response.Write("quantity"+final);
                    con.Open();
                    SqlCommand command;
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    String sql = "";
                    // add to daily sales
                    sql = "insert into DailySale(Product_id, Date, Quantity) values('" + id + "', '" + date + "', '" + quantity + "')";
                    command = new SqlCommand(sql, con);
                    adapter.InsertCommand = new SqlCommand(sql, con);
                    adapter.InsertCommand.ExecuteNonQuery();

                    command.Dispose();
                    con.Close();

                }


              




            }

            
            Session.Clear();
            totaltxt.Text = "";
            Label3.Text = "Checkout Successful";
        }

        
           
        
    }
}