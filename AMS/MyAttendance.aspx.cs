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
    public partial class MyAttendance : System.Web.UI.Page
    {
        string str = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        

        string CurrentMonthYear = "";
        int Year = 0;
        int Month = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindAttendance();
            }
            //string date = labeldate.Text + DateTime.Now.ToShortTimeString();
        }

        //private void HightlightAttendance()
        //{
        //    if (Session["UserID"] != null)
        //    {
        //        SqlDataAdapter adp = new SqlDataAdapter( "select * from EmployeeAttendance where AttendanceStatus = 1 ",str);
        //        DataTable dt = new DataTable();
        //        adp.Fill(dt);
        //        if (dt.Rows.Count > 0)
        //        {
        //            GridView1.DataSource = dt;
        //            //GridView1.DataBind();
        //            GridView1.BackColor = System.Drawing.Color.Yellow;
                    
                    
        //        }
        //    }
        //}

        protected void bindAttendance()
        {
            //current year
            Year = DateTime.Now.Year;

            //current month
            Month = DateTime.Now.Month;

            //Getting Days in current month
            int Days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            //declare data columns
            DataTable dt = new DataTable("dtDays");
            DataColumn auto = new DataColumn("AutoID", typeof(System.Int32));
            dt.Columns.Add(auto);

            DataColumn DaysNames = new DataColumn("DaysNames", typeof(string));
            dt.Columns.Add(DaysNames);

            DataColumn Date = new DataColumn("Date", typeof(string));
            dt.Columns.Add(Date);

            //declare data rows
            DataRow dr = null;
            DateTime days;
            DateTime strDate;
            for(int i = 1; i <= Days; i++)
            {
                //create row in data table
                dr = dt.NewRow();
                days = new DateTime(Year, Month, i);  //find days name
                strDate = new DateTime(Year, Month, i);  //find days w.r.t days
                dr["AutoID"] = i;
                dr["DaysNames"] = days.DayOfWeek;
                dr["Date"] = strDate.Date.ToShortDateString();
                dt.Rows.Add(dr); //add row in datatable
            }

            //current date month year
            CurrentMonthYear = DateTime.Now.ToString("dd") + "" + DateTime.Now.ToString("MMMM") + "" + Year;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)//mark Attendance
            

        {
            try
            {
                if (Session["UserID"] != null)
                {
                    string strRemarks = "";
                    string currenthour = DateTime.Now.Hour.ToString();
                    string currentmin = DateTime.Now.Minute.ToString();

                    foreach (GridViewRow gdrow in GridView1.Rows)
                    {
                        string strDay = gdrow.Cells[1].Text; //Day
                        string strDate = gdrow.Cells[2].Text; //Date
                        TextBox Txtbox = (TextBox)gdrow.FindControl("TextBox1");
                        CheckBox chk = (CheckBox)gdrow.FindControl("chkbox");
                        if (chk.Checked == true)
                        {

                            if (Convert.ToInt32(currenthour) > 10 || Convert.ToInt32(currentmin) > 60)
                            {
                                strRemarks = "Sorry you are late you have marked your attendance on " + currenthour + ":" + currentmin + "";
                                strRemarks = Txtbox.Text;
                                    
                            }
                            else
                            {
                                strRemarks = Txtbox.Text.Trim();
                            }

                            //Save Data
                            DateTime dt = Convert.ToDateTime(strDate);
                            string strDateTime = dt.Month + "/" + dt.Day + "/" + dt.Year;
                            SaveData(1, strRemarks, strDateTime);

                            label1.Text = "Your attendance is marked";
                        }
                        else
                        {
                            label1.Text = "Please Mark your attendance";
                            label1.Text = "Your attendance is marked";
                        }


                    }
                }
            }


            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                label1.Text = "";
            }

            //bind Attendance
            bindAttendance();
        }







            

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            String currDate = DateTime.Now.ToShortDateString();
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                String RowDate = e.Row.Cells[2].Text;
                String RowDay = e.Row.Cells[1].Text;
                CheckBox chk = (CheckBox)e.Row.FindControl("chkbox");
                TextBox Txtbox = (TextBox)e.Row.FindControl("TextBox1");
                String strRemarks = "";
                bool boolAttStatus = false;
                bindPrevAtt(out boolAttStatus, out strRemarks, RowDate);
                Txtbox.Text = strRemarks;
                chk.Checked = boolAttStatus;

                if((Convert.ToDateTime(RowDate)<Convert.ToDateTime(currDate))|| chk.Checked == true)
                {
                    chk.Enabled = false;
                    Txtbox.Enabled = false;

                }
                if ((Convert.ToDateTime(RowDate) > Convert.ToDateTime(currDate)) || chk.Checked == true)
                {
                     
                    chk.Enabled = false;
                    Txtbox.Enabled = false;
                }
                //we make saturday and sunday with red forecolor
                if (RowDay.Equals("Saturday") || RowDay.Equals("Sunday"))
                {

                    e.Row.Cells[1].ForeColor = System.Drawing.Color.Red;
                    chk.Enabled = false;
                    Txtbox.Enabled = false;
                }

            }
        }


        protected void SaveData(int attStatus, string strRemarks, string strDate)
        {
            try
            {
                if (Session["UserID"] != null)
                {
                    SqlConnection con = new SqlConnection(str);
                    //let's assume that are student id is 1
                    string strQry = "INSERT INTO EmployeeAttendance (UserID, AttendanceMonth, AttendanceYear, AttendanceStatus, " +
                        "Remarks, AttendanceDate, LoggedInDate ) VALUES (@1," + DateTime.Now.Month + "," + DateTime.Now.Year + "," + attStatus + ", '" + strRemarks + "', '" + strDate + "',getDate())";

                    SqlCommand cmd = new SqlCommand(strQry, con);
                    cmd.Parameters.AddWithValue("@1", Session["UserID"]);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    label1.Text = "Time is up to Mark attendnce!!";
                    cmd.Dispose();
                    con.Close();

                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
                label1.Text = "";
            }
            
        }
        protected void bindPrevAtt(out bool attStatus, out string strRemarks, string strAttDate)
        {
            SqlConnection con = new SqlConnection(str);
            attStatus = false;
            strRemarks = "Remarks";
            string strQry = "SELECT UserID, AttendanceStatus, Remarks FROM EmployeeAttendance WHERE Convert(varchar(12),AttendanceDate,103) = '" + strAttDate + "'";
            SqlCommand cmd = new SqlCommand(strQry, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                strRemarks = dt.Rows[0]["Remarks"].ToString();
                attStatus = Convert.ToBoolean(dt.Rows[0]["AttendanceStatus"]);
            }
            dt.Dispose();
            da.Dispose();
            cmd.Dispose();
            con.Close();
        }
    }
}