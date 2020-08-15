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
    public partial class Admin_Application : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"]== null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
            if (!IsPostBack)
            {
                grdview1.DataSource = SqlDataSource1;
                grdview1.DataBind();
            }

            
        }

        protected void btn1_Click(object sender, EventArgs e)//submit button
        {
            foreach (GridViewRow row in grdview1.Rows)
            {
                CheckBox status = (row.Cells[3].FindControl("CheckBox1") as CheckBox);
                int applicationid = Convert.ToInt32(row.Cells[1].Text);
                if (status.Checked)
                {
                    updaterow(applicationid, "Approved");
                }
                else
                {
                    updaterow(applicationid,"N");

                }



            }
            lbl1.Text = "Applications Has Been Approved Successfully";
            SqlDataSource1.DataBind();
            grdview1.DataSource = SqlDataSource1;
            grdview1.DataBind();


        }

        private void updaterow(int applicationid, String approval)
        {
            String updatedata = "Update Application_Details set Approval='" + approval + "' where ApplicationID=" + applicationid;
            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updatedata;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        }
    }
}