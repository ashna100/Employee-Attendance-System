using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class sessionState : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (password.Text == "admin")
            {
                Session["email"] = email.Text;
            }

            if (Session["email"] != null)
            {
                Label3.Text = "this email is stored to the session";
                Label4.Text = Session["email"].ToString();
            }
        }


    }
}