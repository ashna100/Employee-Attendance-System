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
    public partial class WeekOff : System.Web.UI.Page
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



        void fillGridView()
        {
            SqlConnection obj3 = new SqlConnection(conn);
            {
                obj3.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("WeekViewAll", obj3);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                obj3.Close();
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)//insert
        {
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (txtweekoff.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("WeekOffInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter WeekOffDate = objcmd.Parameters.Add("@WeekOffDate", SqlDbType.Date);
                    objcmd.Parameters.AddWithValue("@DateID", Convert.ToInt32(hfDateID.Value));
                    WeekOffDate.Value = txtweekoff.Text;
                    objcmd.ExecuteNonQuery();
                    fillGridView();
                    //SqlDataSource1.DataBind();
                    //GridView1.DataSource = null;
                    //GridView1.DataSourceID = "SqlDataSource1";
                    ////con.Close();
                    //GridView1.SelectedIndex = -1;
                    txtweekoff.Text = "";


                    //txtFrom.Text = txtUpto.Text = InTime.Text = outTime.Text = Remarks.Text = "";
                    lblOutput.InnerText = "Record inserted successfully";
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.InnerText = "";
            }
            finally
            {
                obj1.Close();
            }
        }
        //void fillGridView()
        //{
        //    SqlConnection obj3 = new SqlConnection(conn);
        //    {
        //        obj3.Open();
        //        SqlDataAdapter sqlda = new SqlDataAdapter("ViewAll", obj3);
        //        sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        DataTable dt = new DataTable();
        //        sqlda.Fill(dt);
        //        obj3.Close();
        //        GridView1.DataSource = dt;
        //        GridView1.DataBind();

        //    }
        //}

        protected void View_Click(object sender, EventArgs e)//Select --commented
        {

            //    int UserID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            //    SqlConnection obj4 = new SqlConnection(conn);
            //    {
            //        obj4.Open();
            //        SqlDataAdapter sqlda = new SqlDataAdapter("ViewById", obj4);
            //        sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
            //        sqlda.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
            //        DataTable dt = new DataTable();
            //        sqlda.Fill(dt);
            //        obj4.Close();
            //        hfUserID.Value = UserID.ToString();
            //        txtFrom.Text = dt.Rows[0]["FromDate"].ToString();
            //        txtUpto.Text = dt.Rows[0]["UptoDate"].ToString();
            //        inTime.Text = dt.Rows[0]["InTime"].ToString();
            //        outTime.Text = dt.Rows[0]["OutTime"].ToString();
            //        TxtRemarks.Text = dt.Rows[0]["Remarks"].ToString();
            // }

        }
        protected void btnDelete_Click(object sender, EventArgs e) //delete
        {
            SqlConnection obj3 = new SqlConnection(conn);
            try
            {
                if (txtweekoff.Text != "")
                {
                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("WeekOffDeleteById", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@DateID", Convert.ToInt32(hfDateID.Value));
                    objcmd.ExecuteNonQuery();
                    fillGridView();
                    lblOutput.InnerText = "Record deleted successfully";
                    //SqlDataSource1.DataBind();
                    //GridView1.DataSource = null;
                    //GridView1.DataSourceID = "SqlDataSource1";
                    ////con.Close();
                    //GridView1.SelectedIndex = -1;
                    txtweekoff.Text = "";
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.InnerText = "";

            }
            finally
            {
                obj3.Close();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)//update
        {
            SqlConnection obj2 = new SqlConnection(conn);
            try
            {
                if (txtweekoff.Text != "")
                {

                    obj2.Open();
                    SqlCommand objcmd = new SqlCommand("WeekOffUpdate", obj2);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    objcmd.Parameters.AddWithValue("@DateID", hfDateID.Value == "" ? 0 : Convert.ToInt32(hfDateID.Value));
                    //objcmd.Parameters.AddWithValue("@WeekOffDate", txtweekoff.Text);
                    SqlParameter WeekOffDate = objcmd.Parameters.Add("@WeekOffDate", SqlDbType.Date);
                    WeekOffDate.Value = txtweekoff.Text;
                    objcmd.ExecuteNonQuery();
                    fillGridView();
                    //string DateID = hfDateID.Value;
                    //SqlDataSource1.DataBind();
                    //GridView1.DataSource = null;
                    //GridView1.DataSourceID = "SqlDataSource1";
                    //GridView1.SelectedIndex = -1;
                    txtweekoff.Text = "";

                    //if (hfUserID.Value == "")
                    lblOutput.InnerText = "Record Updated successfully";
                    //txtFrom.Text = txtUpto.Text = InTime.Text = outTime.Text = Remarks.Text = "";
                }

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.InnerText = "";
            }
            finally
            {
                obj2.Close();
            }


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)//select
        {
            int DateID = Convert.ToInt32((sender as LinkButton).CommandArgument);
            SqlConnection obj4 = new SqlConnection(conn);
            {
                obj4.Open();
                SqlDataAdapter sqlda = new SqlDataAdapter("WeekViewById", obj4);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("@DateID", DateID);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                obj4.Close();
                hfDateID.Value = DateID.ToString();
                txtweekoff.Text = dt.Rows[0]["WeekOffDate"].ToString();
            }
        }
    }
}