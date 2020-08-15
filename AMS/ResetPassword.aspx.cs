//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace WebApplication1.AMS
//{
//    public partial class ResetPassword : System.Web.UI.Page
//    {

//        string conn = ConfigurationManager.ConnectionStrings["infoConnectionstring"].ToString();
//        SqlCommand cmd;
//        protected void Page_Load(object sender, EventArgs e)
//        {

//        }

//        protected void Button1_Click(object sender, EventArgs e)//reset password
//        {
//            try
//            {
//                string email, pw;
//                pw = txtpassword.Text;
//                email = TextBox3.Text;
//                string query = "update [Registration] set [pw]='" + Password + "' where [email]='" + officialEmail + "'";
//                cmd = new SqlCommand(query, conn);
//                conn.open();
//                cmd.ExecuteNonQuery();
//            }
//            catch
//            {
//                Label1.Visible = true;
//            }
//        }
//    }
//}
//using System;
//using System.collections;
//using System.configuration;
//using System.data;
//using System.linq;
//using System.web;
//using System.web.security;
//using System.web.ui;
//using System.web.ui.htmlcontrols;
//using System.web.ui.webcontrols;
//using System.web.ui.webcontrols.webparts;
//using System.xml.linq;
//using System.data.sqlclient;
//using System.text;=

using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Text;

namespace WebApplication1.AMS
{

    public partial class ResetPassword : System.Web.UI.Page
{
    SqlCommand cmd;
    DataTable dt;
    SqlConnection con = new SqlConnection();
    SqlDataAdapter adp;

    protected void Page_Load(object sender, EventArgs e)
    {
        //with the help of the last page a link will be sent to the user's email address. the user can use this link only
        //one time to change his/her password
        con = new SqlConnection();
        //  here i am declairing connection  with the database
        con.ConnectionString = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        con.Open();
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
        // at the .aspx i am creating two panels. inside the second panel am holding a image named images.jpg that will show thae there is a invalid link,if
        // any user use this link second time.
        //if any user use this link first time then he will see the design that will show the structure of change password
        try
        {
            // here in SqlDataAdapter i am executing sql query if after the execution of this query there will be any data inside the datatable then
            // it will go inside the else condition otherwise it will go inside the if
            adp = new SqlDataAdapter("select FirstName, PersonalEmail, code from Registration where code=@code and(PersonalEmail=@PersonalEmail or FirstName=@FirstName)", con);
            adp.SelectCommand.Parameters.AddWithValue("@code", Request.QueryString["code"].ToString());
            adp.SelectCommand.Parameters.AddWithValue("@PersonalEmail", Request.QueryString["PersonalEmail"].ToString());
            adp.SelectCommand.Parameters.AddWithValue("@FirstName", Request.QueryString["FirstName"].ToString());

            dt = new DataTable();
            adp.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                //if this condition will be setisfy then Pane_image will true and  Panel_reset_pwd will false

                Panel1.Visible = true;
                Panel_reset_pwd.Visible = false;

                return;
            }
            else
            {
                //if this condition will be setisfy then Pane_image will be false and  Panel_reset_pwd will be true
                Panel1.Visible = true;
                Panel_reset_pwd.Visible = true;

            }
        }
        catch
        {

        }
        finally
        {

        }
    }
    protected void btn_change_pwd_Click(object sender, EventArgs e)
    {
        //if the else condition will be setisfy then   Panel_reset_pwd will be true and after entering the new password by the user,
        //this code will be executed
        if (con.State == ConnectionState.Closed)
        { con.Open(); }
        try

        {
            // in the below quesry, after changing the password by the user, i am clearing the code column's value from the table tb_employee_with_code
            // if there will be no value inside the code column of the table and user will try to open the link again then at the time of
            //page load the user goes inside the first panel
            // and the first panel dislay message thar this link is invalid
            cmd = new SqlCommand("update Registration set code='',Password=@Password where   code=@code  and (PersonalEmail=@PersonalEmail or FirstName=@FirstName)", con);
            cmd.Parameters.AddWithValue("@Password", txt_pwd.Text);

            cmd.Parameters.AddWithValue("@code", Request.QueryString["code"].ToString());
            cmd.Parameters.AddWithValue("@PersonalEmail", Request.QueryString["PersonalEmail"].ToString());
            cmd.Parameters.AddWithValue("@FirstName", Request.QueryString["FirstName"].ToString());

            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
                //lbl_msg.Text = "Your Password has been Changed successfully";
                Response.Write("<script>alert('Your password has changed successfully')</script>");
            txt_pwd.Text = "";
            txt_retype_pwd.Text = "";
                RedirectLogin.Visible = true;
                RequiredFieldValidator1.Visible = false;
                RequiredFieldValidator2.Visible = false;

        }
        catch(Exception ex)
        {
                lbl_msg.Text = ex.Message.ToString();
        }
        finally
        {
            con.Close();
        }

    }

        protected void RedirectLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}