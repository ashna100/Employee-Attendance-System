using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1.AMS
{
    public partial class Feedback : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)//submit button
        {
            if(TextBox1.Text==""&& TextBox2.Text==""&& TextBox3.Text == "")
            {
                lbl1.Text = "Fill the fields.";
                lbl1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                SqlConnection con = new SqlConnection(str);
                if (Session["UserID"] != null)
                {
                    String UserId = Session["UserID"].ToString();
                    SqlCommand cmd = new SqlCommand("insert into Feedback(UserID,Name,Contact,Feedback) values('" + UserId + "' ,'" + TextBox1.Text + "', '" + TextBox2.Text + "','" + TextBox3.Text + "') ", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lbl1.Text = "Thankyou for your valuable feedback!!";
                }
            }
           
        }
    }
}