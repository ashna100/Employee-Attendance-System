using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1.AMS
{
    public partial class EmployeeReports : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreport_Click(object sender, EventArgs e)
        {
            try
            {


                if (Session["UserID"] != null)
                {


                    if (drpmonth.SelectedIndex == 0 && txtDate.Text == "")
                    {
                        lblShow.Text = "Fill The Details";
                    }
                    else
                    {
                        //EmpDT = EmpDT.Select_FirstName(Session["Name"].ToString());

                        //AttDT = AttAdp.(StuDT.Rows[0]["rollno"].ToString(), "%" + drpmonth.SelectedValue + "%");

                        String myquery = "select convert(varchar, cast(convert(varchar(10), AttendanceDate, 110) as datetime), 106) as AttendanceDate," +
                            " AttendanceStatus as Attendance_Status , Remarks from EmployeeAttendance where UserID=@1 and month(AttendanceDate)=" + drpmonth.SelectedItem.Value + " and year(AttendanceDate)=" + txtDate.Text;
                        SqlConnection con = new SqlConnection(conn);
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = myquery;
                        cmd.Connection = con;
                        SqlDataAdapter da = new SqlDataAdapter();
                        cmd.Parameters.AddWithValue("@1", Session["UserID"].ToString());
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        Gridview1.DataSource = ds;
                        Gridview1.DataBind();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblShow.Text = "";
            }

        }
    }
}