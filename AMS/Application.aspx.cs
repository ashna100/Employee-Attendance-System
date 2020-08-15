using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1.AMS
{
    public partial class Application : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeaveType1();
            }
        }

        private void LeaveType1()
        {
            SqlConnection con = new SqlConnection(str);
            
            SqlCommand cmd = new SqlCommand("Select * from LeaveType",con);
            con.Open();
            DropDownList1.DataSource= cmd.ExecuteReader();
            DropDownList1.DataTextField = "LeaveName";
            DropDownList1.DataValueField = "LeaveID";
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, "Leave Type");
            con.Close();

        }

        protected void btn1_Click(object sender, EventArgs e)//submit button
        {
            if( txtPurpose.Text == "" && DropDownList1.SelectedValue == "Leave Type")
            {
                lblshow.Text = "Fill all the fields";
                lblshow.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (Session["UserID"] != null)
                {
                    string Status;
                    string FName = Session["Name"].ToString();
                    //string LName = Session["LastNamee"].ToString();
                    //string FullName = FName + LName;
                    if (RadioButton1.Checked)
                    {
                        Status = "Full Day";
                    }
                    else
                    {
                        Status = "Half Day";
                    }
                    SqlConnection con = new SqlConnection(str);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Application_Details(UserId,FromDate,UptoDate,LeaveType,Purpose,FirstName, Approval) values(@1,@2,@3,@4,@5,@6,'N')", con);
                    cmd.Parameters.AddWithValue("@1", Session["UserID"].ToString());
                    cmd.Parameters.AddWithValue("@2", txtfrom.Text);
                    cmd.Parameters.AddWithValue("@3", txtUpto.Text);
                    cmd.Parameters.AddWithValue("@4", Status);
                    cmd.Parameters.AddWithValue("@5", txtPurpose.Text);
                    cmd.Parameters.AddWithValue("@6", FName);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    lblshow.Text = "Request Sent Successfully";
                    lblshow.ForeColor = System.Drawing.Color.Green;
                }
            }
            
        }
    }
}