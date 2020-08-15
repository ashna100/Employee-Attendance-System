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
    public partial class Gender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        protected void btn1_Click(object sender, EventArgs e) //show all
        {
            //string conn = "";
            //conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

            //SqlConnection obj1 = new SqlConnection(conn);
            //try
            //{
            //    obj1.Open();
            //    DataSet ds = new DataSet();
            //    SqlCommand objcmd = new SqlCommand("GenderSearch", obj1);
            //    objcmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter GenderName = objcmd.Parameters.AddWithValue("@Gname", DropDownList1.SelectedItem.Value);
            //    GenderName.Value = 0;

            //SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);

            //objAdp.Fill(ds);

            //grdView1.DataSource = ds;
            //grdView1.DataBind();

            //}
            //    catch (Exception ex)
            //    {
            //        Response.Write(ex.Message.ToString());
            //        lblOutput.InnerText = "";
            //    }
            //    finally
            //    {
            //        obj1.Close();
            //    }

        } //---comment---

        protected void BtnAdd_Click(object sender, EventArgs e)  //Insert
        {
            if (txtGender.Text != "")
            {

                string conn = "";
                conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

                SqlConnection obj2 = new SqlConnection(conn);
                string SqlQuery = "insert into[dbo].[Gender] (GenderName) values(@Gname)";
                SqlCommand objcmd = new SqlCommand(SqlQuery, obj2);
                // objcmd.Parameters.AddWithValue("@Gname", DropDownList1.SelectedItem.Value);
                objcmd.Parameters.AddWithValue("@Gname", txtGender.Text);
                obj2.Open();
                int i = objcmd.ExecuteNonQuery();
                SqlDataSource1.DataBind();
                grdView1.DataSource = null;
                grdView1.DataSourceID = "SqlDataSource1";
                //con.Close();
                grdView1.SelectedIndex = -1;


                if (i != 0)
                {
                    lblOutput.InnerText = "Details saved successfully";
                }
                txtGender.Text = "";
                txtID.Text = "";
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e) //Return
        {
            //Response.Redirect("HomePage.aspx");
        }

        protected void GrdView1_SelectedIndexChanged(object sender, EventArgs e) //Select
        {
            GridViewRow gr = grdView1.SelectedRow;
            txtID.Text = gr.Cells[1].Text;
            txtGender.Text = gr.Cells[2].Text;

            //    string conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            //    SqlConnection obj3 = new SqlConnection();
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.CommandType = CommandType.Text;
            //    cmd.CommandText = "Select * from Gender where Id= '" + grdView1 + "'";

            //    obj3.Open();
            //    cmd.ExecuteNonQuery();
            //    DataTable dt = new DataTable();
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    da.Fill(dt);
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        txtGender.Text = dr["GenderName"].ToString();
            //    }
            //    obj3.Close();
            //}


        }

        protected void BtnUpdate_Click(object sender, EventArgs e)//Update
        {
            String con = "";
            con = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj3 = new SqlConnection(con);
            try
            {
                if (txtGender.Text != "")
                {
                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("GenderUpdate", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter GenderName = objcmd.Parameters.Add("@GenderName", SqlDbType.VarChar, 50);
                    GenderName.Value = txtGender.Text;
                    SqlParameter GenderID = objcmd.Parameters.Add("@GenderID", SqlDbType.VarChar, 40);
                    GenderID.Value = txtID.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    grdView1.DataSource = null;
                    grdView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    grdView1.SelectedIndex = -1;

                    lblOutput.InnerText = "Record Updated Successfully: " + txtGender.Text.ToString();
                    txtGender.Text = "";
                    txtID.Text = "";
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

        protected void BtnDelete_Click(object sender, EventArgs e)//Delete
        {
            String con = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj4 = new SqlConnection(con);
            try
            {
                if(txtGender.Text!="")
                {
                    obj4.Open();
                    SqlCommand objcmd = new SqlCommand("GenderDelete", obj4);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter GenderName = objcmd.Parameters.Add("@GenderName", SqlDbType.VarChar, 50);
                     GenderName.Value = txtGender.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    grdView1.DataSource = null;
                    grdView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    grdView1.SelectedIndex = -1;
                    lblOutput.InnerText = "Record Deleted successfully: " + txtGender.Text.ToString();
                    txtGender.Text = "";
                    txtID.Text = "";
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.InnerText = "";

            }
            finally
            {
                obj4.Close();
            }
        }
    }
}