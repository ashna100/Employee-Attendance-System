using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.AMS
{
    public partial class MasterEmployee : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["OfficialEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }

            LabelMaster.Text = "Hello &nbsp"+Session["Name"].ToString()+" Welcome!!";
        }
    }
}