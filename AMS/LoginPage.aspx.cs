using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;


namespace WebApplication1.AMS
{
    public partial class LoginPage : System.Web.UI.Page
    {

        string constr = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)//Admin login button
        {
            try
            {

                SqlDataAdapter sda = new SqlDataAdapter("select * from Registration where PersonalEmail='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", constr);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (TextBox1.Text == "" && TextBox2.Text == "")
                {
                    Label1.Text = "Please fill the details";
                }
                else if (dt.Rows.Count == 1)//Admin login
                {
                    Session["Email"] = dt.Rows[0][16].ToString();
                    Session["Password"] = dt.Rows[0][34].ToString();
                    Session["Name"] = dt.Rows[0][1].ToString();
                    Session["LastNamee"] = dt.Rows[0][2].ToString();

                    Session["PersonalEmail"] = TextBox1.Text;
                    Response.Redirect("MainWindow1.aspx");
                    //Response.Redirect("Registeration.aspx");
                    //Response.Redirect("BloodGroup.aspx");
                    //Response.Redirect("Holidays.aspx");
                    //Response.Redirect("Gender.aspx");
                    //Response.Redirect("Grade.aspx");
                    //Response.Redirect("City.aspx");
                    //Response.Redirect("Country.aspx");
                    //Response.Redirect("Department.aspx");
                    //Response.Redirect("Designation.aspx");
                    //Response.Redirect("EmpType.aspx");
                    //Response.Redirect("LeaveAssign.aspx");
                    //Response.Redirect("LeaveType.aspx");
                    //Response.Redirect("MaritalStatus.aspx");
                    //Response.Redirect("OutdoorAttendance.aspx");
                    //Response.Redirect("ReportingManager.aspx");
                    //Response.Redirect("State.aspx");
                    //Response.Redirect("WeekOff.aspx");
                }

                





                //using (SqlConnection conn = new SqlConnection(constr))
                //{
                //    using (SqlCommand cmd = new SqlCommand(myquery, conn))
                //    {
                //        cmd.Parameters.AddWithValue("@PersonalEmail", TextBox1.Text);
                //        cmd.Parameters.AddWithValue("@Password", TextBox2.Text);
                //        //cmd.connection = conn;
                //        conn.Open();
                //        Session["PersonalEmail"] = TextBox1.Text;
                //        result = (int)cmd.ExecuteScalar();

                //    }
                //}
                else
                {
                    Label1.Text = "Invalid credentials";
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                //Label1.Text = "";
            }
            finally
            {
                //conn.Close();
            }

        }


        //----3rd code-----
        //DataTable dt = new DataTable();
        //sda.Fill(dt);
        // cmd.ExecuteNonQuery();
        // if (dt.Rows[0][0].ToString() == "1")


        // String myquery = "select * from Registration where officialEmail='" + TextBox1.Text+"' and Password='"+TextBox2.Text+"'";
        // SqlCommand cmd = new SqlCommand();
        //cmd.CommandText = myquery;
        // cmd.Connection = scon;
        // SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //  sda.SelectCommand = cmd;
        // DataSet ds = new DataSet();
        //sda.Fill(ds, "Registration");

        // //cmd.ExecuteNonQuery();
        //if (ds.Tables[0].Rows.Count > 0)
        //{
        //String uname;
        //String pass;
        //uname = ds.Tables[0].Rows[0][16]["PersonalEmail"].ToString();
        //pass = ds.Tables[0].Rows[0]["Password"].ToString();

        //if (uname == TextBox1.Text && pass == TextBox2.Text)
        //    Session["PersonalEmail"] = uname;
        // Server.Transfer("Registeration.aspx");

        //}
        //else
        //{
        //    Label1.Text = "invalid username or password - relogin with correct username password";
        //    Response.Write("<script>alert('error in login')</script>");
        //}
        //}


        protected void Button2_Click(object sender, EventArgs e)//cancel button
        {
            Response.Redirect("MainWindow1.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)//Employee login
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Registration where OfficialEmail='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'", constr);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (TextBox1.Text == "" && TextBox2.Text == "")
            {
                Label1.Text = "Please fill the details";
            }
            else if (dt.Rows.Count == 1)
            {
                Session["UserID"] = dt.Rows[0][0].ToString();
                Session["Email"] = dt.Rows[0][17].ToString();
                Session["Password"] = dt.Rows[0][34].ToString();
                Session["Name"] = dt.Rows[0][1].ToString();

                Session["OfficialEmail"] = TextBox1.Text;
                Response.Redirect("HomePageEmployee.aspx");

            }
        }
    }
}
