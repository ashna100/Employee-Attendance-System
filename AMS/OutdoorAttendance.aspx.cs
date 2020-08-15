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
    public partial class OutdoorAttendance : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillGridView();
            }

            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        void clear()//clear fields
        {
            txtFrom.Text = TxtRemarks.Text = txtUpto.Text = inTime.Text = outTime.Text = "";
        }
        protected void btnInsert_Click(object sender, EventArgs e)//insert
        {
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {

                obj1.Open();
                SqlCommand objcmd = new SqlCommand("OutdoorAtten", obj1);
                objcmd.CommandType = CommandType.StoredProcedure;
                SqlParameter FromDate = objcmd.Parameters.Add("@FromDate", SqlDbType.Date);
                FromDate.Value = txtFrom.Text;
                SqlParameter UptoDate = objcmd.Parameters.Add("@UptoDate", SqlDbType.Date);
                UptoDate.Value = txtUpto.Text;
                SqlParameter InTime = objcmd.Parameters.Add("@InTime", SqlDbType.Time);
                InTime.Value = inTime.Text;
                SqlParameter OutTime = objcmd.Parameters.Add("@OutTime", SqlDbType.Time);
                OutTime.Value = outTime.Text;
                SqlParameter Remarks = objcmd.Parameters.Add("@Remarks", SqlDbType.VarChar);
                Remarks.Value = TxtRemarks.Text;
                objcmd.ExecuteNonQuery();
                //SqlDataSource1.DataBind();
                //GridView1.DataSource = null;
                //GridView1.DataSourceID = "SqlDataSource1";
                ////con.Close();
                //GridView1.SelectedIndex = -1;
                fillGridView();
                clear();

                //txtFrom.Text = txtUpto.Text = InTime.Text = outTime.Text = Remarks.Text = "";
                lblOutput.Text = "Record inserted successfully";


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

        protected void btnUpdate_Click(object sender, EventArgs e) //update
        {
            SqlConnection obj2 = new SqlConnection(conn);
            try
            {

                obj2.Open();
                SqlCommand objcmd = new SqlCommand("OutdoorUpdate", obj2);
                objcmd.CommandType = CommandType.StoredProcedure;
                objcmd.Parameters.AddWithValue("@UserID", hfUserID.Value == "" ? 0 : Convert.ToInt32(hfUserID.Value));
                //SqlParameter FromDate = objcmd.Parameters.Add("@FromDate", SqlDbType.Date);
                //FromDate.Value = txtFrom.Text;
                objcmd.Parameters.AddWithValue("@FromDate", txtFrom.Text);
                SqlParameter UptoDate = objcmd.Parameters.Add("@UptoDate", SqlDbType.Date);
                UptoDate.Value = txtUpto.Text;
                SqlParameter InTime = objcmd.Parameters.Add("@InTime", SqlDbType.Time);
                InTime.Value = inTime.Text;
                SqlParameter OutTime = objcmd.Parameters.Add("@OutTime", SqlDbType.Time);
                OutTime.Value = outTime.Text;
                SqlParameter Remarks = objcmd.Parameters.Add("@Remarks", SqlDbType.VarChar);
                Remarks.Value = TxtRemarks.Text;
                objcmd.ExecuteNonQuery();
                fillGridView();
                clear();
                //string UserID = hfUserID.Value;
                // SqlDataSource1.DataBind();
                //    GridView1.DataSource = null;
                //    GridView1.DataSourceID = "SqlDataSource1";
                ////con.Close();
                //GridView1.SelectedIndex = -1;

                //if (hfUserID.Value == "")
                if (hfUserID.Value == "")
                    lblOutput.Text = "Record not updated ";
                else
                lblOutput.Text = "Record Updated successfully";
                //txtFrom.Text = txtUpto.Text = InTime.Text = outTime.Text = Remarks.Text = "";


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

        //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        //{
        //    GridViewRow gv = GridView1.SelectedRow;
        //    txtFrom.Text = gv.Cells[2].Text;
        //    txtUpto.Text = gv.Cells[3].Text;
        //    inTime.Text = gv.Cells[4].Text;
        //    outTime.Text = gv.Cells[5].Text;
        //    TxtRemarks.Text = gv.Cells[6].Text;

        //}

        void fillGridView()
        {
            SqlConnection obj3 = new SqlConnection(conn);
            {
                obj3.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("ViewAll", obj3);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                obj3.Close();
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }
        protected void View_Click(object sender, EventArgs e)//Select
        {
            int UserID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            SqlConnection obj4 = new SqlConnection(conn);
            {
                obj4.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("ViewById", obj4);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                obj4.Close();
                hfUserID.Value = UserID.ToString();
                txtFrom.Text = string.Format("{0:dd-MM-yyyy}", Convert.ToDateTime(dt.Rows[0]["FromDate"]).ToShortDateString());
                txtUpto.Text = string.Format("{0:dd-MM-yyyy}", Convert.ToDateTime(dt.Rows[0]["UptoDate"]).ToShortDateString());
                inTime.Text = dt.Rows[0]["InTime"].ToString();
                outTime.Text = dt.Rows[0]["OutTime"].ToString();
                TxtRemarks.Text = dt.Rows[0]["Remarks"].ToString();



            }

        }

        protected void btnDelete_Click(object sender, EventArgs e) //delete
        {
            SqlConnection obj5 = new SqlConnection(conn);
            try
            {
                obj5.Open();
                SqlCommand objcmd = new SqlCommand("OutdoorDeleteById", obj5);
                objcmd.CommandType = CommandType.StoredProcedure;
                objcmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(hfUserID.Value));
                //objcmd.Parameters.AddWithValue("@FromDate", txtFrom.Text);
                ////FromDate.Value = txtUpto.Text;
                //objcmd.Parameters.AddWithValue("@UptoDate", txtUpto.Text);
                ////UptoDate.Value = txtUpto.Text;
                // objcmd.Parameters.AddWithValue("@InTime", inTime.Text);
                ////InTime.Value = inTime.Text;
                //objcmd.Parameters.AddWithValue("@OutTime", outTime.Text);
                ////OutTime.Value = outTime.Text;
                //objcmd.Parameters.AddWithValue("@Remarks", TxtRemarks.Text);
                ////Remarks.Value = TxtRemarks.Text;
                objcmd.ExecuteNonQuery();
                clear();
                fillGridView();
                if (hfUserID.Value == "")
                    lblOutput.Text = "Record not deleted ";
                else
                    lblOutput.Text = "Record deleted successfully:" + hfUserID.Value.ToString();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.Text = "";

            }
            finally
            {
                obj5.Close();
            }
        }
        
    }
}
    
