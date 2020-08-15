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
    public partial class LeaveType : System.Web.UI.Page
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

        void Clear() //clear
        {
            txtLimit.Text = txtleave.Text = "";
        }
        protected void btnInsert_Click(object sender, EventArgs e) //insert
        {
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (txtleave.Text != "" && txtLimit.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("LeaveInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter LeaveName = objcmd.Parameters.Add("@LeaveName", SqlDbType.VarChar);
                    LeaveName.Value = txtleave.Text;
                    objcmd.Parameters.AddWithValue("@YearlyLimit", txtLimit.Text);
                    objcmd.ExecuteNonQuery();
                    fillGridView();
                    //SqlDataSource1.DataBind();
                    //GridView1.DataSource = null;
                    //GridView1.DataSourceID = "SqlDataSource1";
                    ////con.Close();
                    //GridView1.SelectedIndex = -1;

                    Clear();
                    //txtFrom.Text = txtUpto.Text = InTime.Text = outTime.Text = Remarks.Text = "";
                    lblOutput.Text = "Record inserted successfully";
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

        protected void btnUpdate_Click(object sender, EventArgs e)//update
        {
            SqlConnection obj2 = new SqlConnection(conn);
            try
            {
                if (txtleave.Text != "" && txtLimit.Text != "")
                {
                    obj2.Open();
                    SqlCommand objcmd = new SqlCommand("LeaveUpdate", obj2);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@LeaveID", hfLeaveID.Value == "" ? 0 : Convert.ToInt32(hfLeaveID.Value));
                    SqlParameter LeaveName = objcmd.Parameters.Add("@LeaveName", SqlDbType.VarChar);
                    LeaveName.Value = txtleave.Text;
                    objcmd.Parameters.AddWithValue("@YearlyLimit", txtLimit.Text);

                    objcmd.ExecuteNonQuery();
                    fillGridView();
                    //SqlDataSource1.DataBind();
                    //GridView1.DataSource = null;
                    //GridView1.DataSourceID = "SqlDataSource1";
                    ////con.Close();
                    //GridView1.SelectedIndex = -1;

                    Clear();
                    //txtFrom.Text = txtUpto.Text = InTime.Text = outTime.Text = Remarks.Text = "";
                    lblOutput.Text = "Record updated successfully";
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

        void fillGridView()
        {
            SqlConnection obj3 = new SqlConnection(conn);
            {
                obj3.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("LeaveTypeViewAll", obj3);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                obj3.Close();
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)//select
        {
            //    GridViewRow gv = GridView1.SelectedRow;
            //    txtleave.Text = gv.Cells[1].Text;
            //    txtLimit.Text = gv.Cells[2].Text;
            int LeaveID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            SqlConnection obj4 = new SqlConnection(conn);
            {
                obj4.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("LeaveTypeViewById", obj4);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("@LeaveID", LeaveID);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                obj4.Close();
                hfLeaveID.Value = LeaveID.ToString();
                txtleave.Text = dt.Rows[0]["LeaveName"].ToString();
                txtLimit.Text = dt.Rows[0]["YearlyLimit"].ToString();

            }
        }


            protected void delete_click(object sender, EventArgs e)//delete
        {
            SqlConnection obj3 = new SqlConnection(conn);
            try
            {
                obj3.Open();
                SqlCommand objcmd = new SqlCommand("LeaveDelete", obj3);
                objcmd.CommandType = CommandType.StoredProcedure;
                objcmd.Parameters.AddWithValue("@LeaveID", Convert.ToString(hfLeaveID.Value));
                SqlParameter LeaveName = objcmd.Parameters.Add("@LeaveName", SqlDbType.VarChar);
                LeaveName.Value = txtleave.Text;
                objcmd.Parameters.AddWithValue("@YearlyLimit", txtLimit.Text);
                
                objcmd.ExecuteNonQuery();
                fillGridView();
                //SqlDataSource1.DataBind();
                //GridView1.DataSource = null;
                //GridView1.DataSourceID = "SqlDataSource1";
                //GridView1.SelectedIndex = -1;

                Clear();
                if (hfLeaveID.Value == "")
                    lblOutput.Text = "Record not deleted";
                else
                    lblOutput.Text = "Record deleted successfully";
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


        
    }       
            
        
    
}