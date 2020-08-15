using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.AMS
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] != null)
            {
                // Response.Redirect ("LoginPage.aspx");
                LabelMaster.Text = "Welcome &nbsp" + Session["Name"].ToString() + "!!";
                LinkButton1.Visible = false;  //login button
                LinkButton2.Visible = true; //logout button
                
            }
            else
            {
                LabelMaster.Text = "Hello Visitor, Welcome!!";
                LinkButton1.Visible = true;  //login button
                LinkButton2.Visible = false; //logout button
                

            }
        }

        protected void LinkButton2_Click(object sender, EventArgs e)//logout
        {
            Session.Abandon();
            Response.Redirect("MainWindow1.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)//login click
        {
            Response.Redirect("LoginPage.aspx");
        }

      
    }
}