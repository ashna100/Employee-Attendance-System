using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainWindow.aspx");
        }

        //    protected void Button1_Click(object sender, EventArgs e)
        //    {
        //        //MultiView1.ActiveViewIndex = 0;
        //        Response.Redirect ("Department.aspx");
        //    }

        //    protected void Button2_Click(object sender, EventArgs e)
        //    {
        //        Response.Redirect("Designation.aspx");
        //    }

        //    protected void Button3_Click(object sender, EventArgs e)
        //    {
        //        //MultiView1.ActiveViewIndex = 2;
        //        Response.Redirect("Grade.aspx");
        //    }

        //    protected void Button4_Click(object sender, EventArgs e)
        //    {
        //        //MultiView1.ActiveViewIndex = 3;
        //        Response.Redirect("Country.aspx");
        //    }

        //    protected void Button5_Click(object sender, EventArgs e)
        //    {
        //        //MultiView1.ActiveViewIndex = 4;
        //        Response.Redirect("State.aspx");
        //    }

        //    protected void Button6_Click(object sender, EventArgs e)
        //    {
        //        Response.Redirect("City.aspx");
        //    }



        //    protected void Button7_Click(object sender, EventArgs e)
        //    {
        //        Response.Redirect("Marital Status.aspx");
        //    }

        //    protected void Button8_Click(object sender, EventArgs e)
        //    {
        //        Response.Redirect("Gender.aspx");
        //    }

        //    protected void Button9_Click(object sender, EventArgs e)
        //    {
        //        Response.Redirect("EmpType.aspx");
        //    }

        //    protected void Button10_Click(object sender, EventArgs e)
        //    {
        //        Response.Redirect("Blood Group.aspx");
        //    }

        //    protected void Button11_Click(object sender, EventArgs e)
        //    {
        //        Response.Redirect("Holidays.aspx");
        //    }
    }
    }