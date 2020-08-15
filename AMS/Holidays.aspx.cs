using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;



namespace WebApplication1
{
    public partial class Holidays : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            //CalendarExtender1.StartDate = DateTime.Now.Date;
            //CalendarExtender2.StartDate = DateTime(!CalendarExtender1.SelectedDate);

            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        

        protected void Button3_Click(object sender, EventArgs e) //Return
        {
            //Response.Redirect("HomePage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            GridViewRow gv = GridView1.SelectedRow;
            txtHoliday.Text = gv.Cells[2].Text;
            txtFrom.Text = gv.Cells[3].Text;
            txtUpto.Text = gv.Cells[4].Text;
            TextBox1.Text = gv.Cells[1].Text;
        }

        protected void Button2_Click(object sender, EventArgs e) //insert
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (txtHoliday.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("HolidayInsert", obj1);
                    //objcmd.CommandType = CommandType.StoredProcedure;
                    //SqlParameter HolidayType = objcmd.Parameters.Add("@HolidayType", SqlDbType.VarChar ,250);
                    //HolidayType.Value = txtHoliday.Text;
                    objcmd.CommandType = CommandType.Text;
                    //objcmd.CommandText = "insert into Holidays values('" + txtHoliday.Text + "')";
                    
                    objcmd.CommandText = ("insert into Holidays"+ "(HolidayType, FromDate, UptoDate) values(@HolidayType, @FromDate, @UptoDate)");
                    objcmd.Parameters.AddWithValue("@FromDate", txtFrom.Text);
                    objcmd.Parameters.AddWithValue("@UptoDate", txtUpto.Text);
                    objcmd.Parameters.AddWithValue("@HolidayType", txtHoliday.Text);

                    
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;

                    txtFrom.Text = txtHoliday.Text= txtUpto.Text = TextBox1.Text="";
                    
                    //Response.Redirect(Request.Url.AbsoluteUri);
                    //Response.Redirect("Default.aspx");

                    lblOutput.Text = "Record inserted successfully. Name = " + txtHoliday.Text.ToString();
                }




            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.Text = "";
            }
            finally
            {
                obj1.Close();
            }

        }

        protected void Button6_Click(object sender, EventArgs e) //calendar1 
        {
            //Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e) //calendar1 
        {
            //txtFrom.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            //Calendar1.Visible = false;
        }

        protected void Button5_Click(object sender, EventArgs e) //calendar2 
        {
            //Calendar2.Visible = true;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e) //calendar2 
        {
            //txtUpto.Text = Calendar2.SelectedDate.ToString("yyyy-MM-dd");
            //Calendar2.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e) //update
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj2 = new SqlConnection(conn);
            try
            {
                if (TextBox1.Text != "")
                {

                    obj2.Open();
                    SqlCommand objcmd = new SqlCommand("HolidayUpdate", obj2);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    DateTime dt = DateTime.ParseExact(txtFrom.Text, "dd-mm-yyyy", null);
                    string dt1 = dt.ToString("mm/dd/yyyy");
                    DateTime dtt = DateTime.ParseExact(txtUpto.Text, "dd-mm-yyyy", null);
                    string dt2 = dtt.ToString("mm/dd/yyyy");
                    SqlParameter HolidayType = objcmd.Parameters.Add("@HolidayType", SqlDbType.NVarChar, 50);
                    HolidayType.Value = txtHoliday.Text;
                    SqlParameter FromDate = objcmd.Parameters.Add("@FromDate", SqlDbType.Date);
                    FromDate.Value = txtFrom.Text;
                    SqlParameter UptoDate = objcmd.Parameters.Add("@UptoDate", SqlDbType.Date);
                    UptoDate.Value = txtUpto.Text;
                    SqlParameter HolidayID = objcmd.Parameters.Add("@Holiday_ID", SqlDbType.Int);
                    HolidayID.Value = TextBox1.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    //Response.Redirect(Request.Url.AbsoluteUri);
                    txtFrom.Text = txtHoliday.Text = txtUpto.Text = TextBox1.Text = "";




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lblOutput.Text = "Record Updated successfully. Name = " + txtHoliday.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.Text = "";
            }
            finally
            {
                obj2.Close();
            }
        }

        protected void Button4_Click(object sender, EventArgs e) //delete
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj3 = new SqlConnection(conn);
            try
            {
                if (TextBox1.Text != "")
                {

                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("HolidayDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter HolidayID = objcmd.Parameters.Add("@HolidayID", SqlDbType.Int);
                    HolidayID.Value = TextBox1.Text;
                    //SqlParameter HolidayType = objcmd.Parameters.Add("@HolidayType", SqlDbType.VarChar, 50);
                    //HolidayType.Value = txtHoliday.Text;
                    //SqlParameter FromDate = objcmd.Parameters.Add("@FromDate", SqlDbType.Date);
                    //FromDate.Value = txtFrom.Text;
                    //SqlParameter UptoDate = objcmd.Parameters.Add("@UptoDate", SqlDbType.Date);
                    //UptoDate.Value = txtUpto.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    // Response.Redirect(Request.Url.AbsoluteUri);
                    txtFrom.Text = txtHoliday.Text = txtUpto.Text = TextBox1.Text = "";
                    lblOutput.Text = "Record deleted successfully. Name = " + txtHoliday.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.Text = "";
            }
            finally
            {
                obj3.Close();
            }
        }

       

        //protected void Button1_Click(object sender, EventArgs e) //Show
        //{
        //    string conn = "";
        //    conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

        //    SqlConnection obj2 = new SqlConnection(conn);
        //    try
        //    {
        //        obj2.Open();
        //        DataSet ds = new DataSet();
        //        SqlCommand objcmd = new SqlCommand("HolidaysSearch", obj2);
        //        //        objcmd.CommandType = CommandType.StoredProcedure;

        //        //        SqlParameter HolidayID = objcmd.Parameters.AddWithValue("@HolidayID", SqlDbType.Int);
        //        //        HolidayID.Value = 0;


        //        objcmd.CommandType = CommandType.Text;
        //        objcmd.CommandText = "Select * from Holidays";
        //        SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);

        //        objAdp.Fill(ds);

        //        GridView1.DataSource = ds;
        //        GridView1.DataBind();

        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message.ToString());
        //        lblOutput.Text = "";
        //    }
        //    finally
        //    {
        //        obj2.Close();
        //    }
        //}
    }
}