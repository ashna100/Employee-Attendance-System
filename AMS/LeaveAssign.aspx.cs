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
    public partial class LeaveAssign : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

        //public object UserID { get; private set; }

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
            txtFrom.Text = txtUpto.Text = txtRemarks.Text = txtleave.Text = "";
        }

        protected void btnInsert_Click(object sender, EventArgs e)//insert
        {
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (txtFrom.Text != "" && txtleave.Text != "" && txtRemarks.Text != "" && txtUpto.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("LeaveAssignInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter FromDate = objcmd.Parameters.Add("@FromDate", SqlDbType.Date);
                    FromDate.Value = txtFrom.Text;
                    SqlParameter UptoDate = objcmd.Parameters.Add("@UptoDate", SqlDbType.Date);
                    UptoDate.Value = txtUpto.Text;
                    objcmd.Parameters.AddWithValue("@LeaveType", txtleave.Text);
                    objcmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
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
                if (txtFrom.Text != "" && txtleave.Text != "" && txtRemarks.Text != "" && txtUpto.Text != "")
                {

                    obj2.Open();
                    SqlCommand objcmd = new SqlCommand("LeaveAssignUpdate", obj2);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@UserID", hfUserID.Value == "" ? 0 : Convert.ToInt32(hfUserID.Value));
                    //objcmd.Parameters.AddWithValue("@UserID", hfUserID.Value);
                    SqlParameter FromDate = objcmd.Parameters.Add("@FromDate", SqlDbType.Date);
                    FromDate.Value = txtFrom.Text;
                    SqlParameter UptoDate = objcmd.Parameters.Add("@UptoDate", SqlDbType.Date);
                    UptoDate.Value = txtUpto.Text;
                    SqlParameter LeaveType = objcmd.Parameters.Add("@LeaveType", SqlDbType.VarChar);
                    LeaveType.Value = txtleave.Text;
                    SqlParameter Remarks = objcmd.Parameters.Add("@Remarks", SqlDbType.VarChar);
                    Remarks.Value = txtRemarks.Text;
                    //objcmd.Parameters.AddWithValue("@LeaveType", txtleave.Text);
                    //objcmd.Parameters.AddWithValue("@Remarks", txtRemarks.Text);
                    objcmd.ExecuteNonQuery();
                    //fillGridView();
                    //SqlDataSource1.DataBind();
                    //GridView1.DataSource = null;
                    //GridView1.DataSourceID = "SqlDataSource1";
                    ////con.Close();
                    //GridView1.SelectedIndex = -1;
                    fillGridView();

                    Clear();
                    //txtFrom.Text = txtUpto.Text = InTime.Text = outTime.Text = Remarks.Text = "";
                    if (hfUserID.Value == "")
                        lblOutput.Text = "not updated";
                    else
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)//select
        {
            // GridViewRow gv = GridView1.SelectedRow;
            //// hfUserID.Value = UserID.ToString();
            // txtFrom.Text = gv.Cells[1].Text;
            // txtleave.Text = gv.Cells[3].Text;
            // txtUpto.Text = gv.Cells[2].Text;
            // txtRemarks.Text = gv.Cells[4].Text;

            int UserID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            SqlConnection obj4 = new SqlConnection(conn);
            {
                obj4.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("LeaveAssignViewById", obj4);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                obj4.Close();
                hfUserID.Value = UserID.ToString();
                txtFrom.Text = string.Format("{0:dd-MM-yyyy}", Convert.ToDateTime(dt.Rows[0]["FromDate"]).ToShortDateString());
                txtUpto.Text = string.Format("{0:dd-MM-yyyy}", Convert.ToDateTime(dt.Rows[0]["UptoDate"]).ToShortDateString());
                //txtFrom.Text = dt.Rows[0]["FromDate"].ToString();
                //txtUpto.Text = dt.Rows[0]["UptoDate"].ToString();
                txtRemarks.Text = dt.Rows[0]["Remarks"].ToString();
                txtleave.Text = dt.Rows[0]["LeaveType"].ToString();



            }
        }

            protected void btndelete_click(object sender, EventArgs e)//delete
        {
            SqlConnection obj3 = new SqlConnection(conn);

            try
            {
                obj3.Open();
                SqlCommand objcmd = new SqlCommand("LeaveAssignDelete", obj3);
                objcmd.CommandType = CommandType.StoredProcedure;
                objcmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(hfUserID.Value));

                //SqlParameter CountryId = objcmd.Parameters.Add("@ConID",SqlDbType.Int);
                //CountryId.Value = TextBox2.Text; 

                objcmd.ExecuteNonQuery();
                //SqlDataSource1.DataBind();
                //GridView1.DataSource = null;
                //GridView1.DataSourceID = "SqlDataSource1";
                //con.Close();
                // Response.Redirect(Request.Url.AbsoluteUri);
                // GridView1.SelectedIndex = -1;
                fillGridView();




                //ClearAll();
                //Response.Redirect("Default.aspx");

                lblOutput.Text = "Record Deleted successfully. ID = " + hfUserID.Value;

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



        void fillGridView()
        {
            SqlConnection obj5 = new SqlConnection(conn);
            {
                obj5.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("LeaveAssignViewAll", obj5);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                obj5.Close();
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        
    }
}
