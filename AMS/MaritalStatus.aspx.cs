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
    public partial class MaritalStatus : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        //protected void btn1_Click(object sender, EventArgs e)   //show all
        //{
        //    string conn = "";
        //    conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

        //    SqlConnection obj1 = new SqlConnection(conn);
        //    try
        //    {
        //        obj1.Open();
        //        DataSet ds = new DataSet();
        //        SqlCommand objcmd = new SqlCommand("MaritalStatus_Search", obj1);
        //        objcmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter MaritalStatus = objcmd.Parameters.AddWithValue("@Mstatus", txt1.Text);
        //        MaritalStatus.Value = 0;

        //        SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);

        //        objAdp.Fill(ds);

        //        grdView1.DataSource = ds;
        //        grdView1.DataBind();

        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message.ToString());
        //        lblOutput.InnerText = "";
        //    }
        //    finally
        //    {
        //        obj1.Close();
        //    }

        //}

        protected void btnReturn_Click(object sender, EventArgs e) //Return Button
        {
            //Response.Redirect("HomePage.aspx");
        }

        protected void BtnAdd_Click(object sender, EventArgs e) //insert
        {
            if (txt1.Text != "")
            {

                string conn = "";
                conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

                SqlConnection obj2 = new SqlConnection(conn);
                string SqlQuery = "insert into[dbo].[MaritalStatus] (MaritalStatus) values(@Mstatus)";
                SqlCommand objcmd = new SqlCommand(SqlQuery, obj2);
                objcmd.Parameters.AddWithValue("@Mstatus", txt1.Text);
                obj2.Open();
                int i = objcmd.ExecuteNonQuery();
                SqlDataSource1.DataBind();
                grdView1.DataSource = null;
                grdView1.DataSourceID = "SqlDataSource1";
                //con.Close();
                grdView1.SelectedIndex = -1;



                if (i != 0)
                {
                    lblOutput.InnerText = "saved";
                }
            }

        }

        protected void grdView1_SelectedIndexChanged(object sender, EventArgs e)  //select
        {
            GridViewRow gv = grdView1.SelectedRow;
            TextBox1.Text = gv.Cells[1].Text;
            txt1.Text = gv.Cells[2].Text;
        }

        protected void btnupdate_click(object sender, EventArgs e) //update
        {

            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoconnectionstring"].ToString();
            SqlConnection obj3 = new SqlConnection(conn);
            try
            {
                if (txt1.Text != "")
                {

                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("MaritalStatus_Update", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter MID = objcmd.Parameters.Add("@MID", SqlDbType.Int);
                    MID.Value = TextBox1.Text;
                    SqlParameter MaritalStatus = objcmd.Parameters.Add("@Mstatus", SqlDbType.VarChar, 50);
                    MaritalStatus.Value = txt1.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    grdView1.DataSource = null;
                    grdView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    grdView1.SelectedIndex = -1;


                    lblOutput.InnerText = "record updated successfully. Marital status = " + txt1.Text.ToString();
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.InnerText = "";
            }
            finally
            {
                obj3.Close();
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)  //delete
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoconnectionstring"].ToString();
            SqlConnection obj4 = new SqlConnection(conn);
            try
            {
                if (txt1.Text != "")
                {

                    obj4.Open();
                    SqlCommand objcmd = new SqlCommand("MaritalStatusDelete", obj4);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter MID = objcmd.Parameters.Add("@MID", SqlDbType.Int);
                    MID.Value = TextBox1.Text;
                    SqlParameter MaritalStatus = objcmd.Parameters.Add("@Mstatus", SqlDbType.VarChar, 50);
                    MaritalStatus.Value = txt1.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    grdView1.DataSource = null;
                    grdView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    grdView1.SelectedIndex = -1;


                    lblOutput.InnerText = "record Deleted successfully. Marital status = " + txt1.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.InnerText = "";
            }
            finally
            {
                obj4.Close();
            }
        }



        //protected void grdView1_RowCancellingEdit(object sender, GridViewCancelEditEventArgs e)
        //{
        //    grdView1.EditIndex = -1;
        //}

       
        //protected void grdView1_RowEditing(object sender, GridViewEditEventArgs e)
        //{
        //    grdView1.EditIndex = e.NewEditIndex;
        //}

        //protected void grdView1_RowUpdating(object sender, GridViewUpdateEventArgs e) //update
        //{
        //    try
        //    {

        //        string conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

        //        SqlConnection obj4 = new SqlConnection(conn);
        //        //DropDownList Drop = grdView1.Rows[e.RowIndex].FindControl("DropDownList1") as DropDownList;
        //        // `q`1string Drop = DropDownList1.SelectedIndex;
        //        SqlCommand objcmd = new SqlCommand("update [dbo].[MaritalStatus] set MaritalStatus=@Mstatus", obj4);
        //        objcmd.Parameters.AddWithValue("@Mstatus", txt1.Text);
        //        //MaritalStatus.Text = @Mstatus.Value();

        //        //objcmd.Parameters.Add("@MStatus", SqlDbType.VarChar).Value = DropDownList1.SelectedItem.Value;

        //        obj4.Open();
        //        objcmd.ExecuteNonQuery();
        //        obj4.Close();
        //        lblOutput.InnerText = "Record updated successfully";
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message.ToString());
        //        lblOutput.InnerText = "";
        //    }

        //}
    }
}
         
         


        //  ------other code---
        //try
        //{
        //    if (DropDownList1 != "")
        //    {

        //        obj2.Open();
        //        SqlCommand objcmd = new SqlCommand("MaritalStatusInsert", obj2);
        //        objcmd.CommandType = CommandType.StoredProcedure;
        //        SqlParameter MaritalStatus = objcmd.Parameters.AddWithValue("@Mstatus", DropDownList1.SelectedItem.Value);
        //        //MaritalStatus.Value = DropDownList2.Text;
        //        objcmd.ExecuteNonQuery();


        //        //ClearAll();
        //        //Response.Redirect("Default.aspx");

        //        lblOutput.InnerText = "Record inserted successfully. Marital Status = " + DropDownList1.InnerText.ToString();
        //    }




        //}
        //catch (Exception ex)
        //{
        //    Response.Write(ex.Message.ToString());
        //    lblOutput.InnerText = "";
        //}
        //finally
        //{
        //    obj2.Close();
        //}


   
    
        