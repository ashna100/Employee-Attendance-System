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
    public partial class AdminFeedbacks : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
            SqlConnection con = new SqlConnection(str);
            SqlDataAdapter sda = new SqlDataAdapter("Select Name, Contact, Feedback from Feedback", con);
            con.Open();
            sda.Fill(dt);
            gridview1.DataSource = dt;
            gridview1.DataBind();


        }
        
    }
}