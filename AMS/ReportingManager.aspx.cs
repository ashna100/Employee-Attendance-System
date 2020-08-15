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
    public partial class ReportingManager : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e) //return
        {
            //Response.Redirect("HomePage.aspx");
        }


        protected void Button1_Click(object sender, EventArgs e) //insert
        {

            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (TextBox2.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("RMInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter ManagerName = objcmd.Parameters.Add("@ManagerName", SqlDbType.NVarChar);
                    ManagerName.Value = TextBox2.Text;
                    //SqlParameter ManagerID = objcmd.Parameters.Add("@ManagerID", SqlDbType.Int);
                    //ManagerID.Value = TextBox1.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;


                    lblOutput.InnerText = "Record inserted successfully. Name = " + TextBox2.Text.ToString();
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

        
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            GridViewRow gv = GridView1.SelectedRow;
            TextBox2.Text = gv.Cells[2].Text;
            TextBox1.Text = gv.Cells[1].Text;
        }

        protected void Button2_Click(object sender, EventArgs e) //update
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj2 = new SqlConnection(conn);
            try
            {
                if (TextBox2.Text != "")
                {

                    obj2.Open();
                    SqlCommand objcmd = new SqlCommand("RMUpdate", obj2);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter ManagerName = objcmd.Parameters.Add("@ManagerName", SqlDbType.NVarChar, 50);
                    ManagerName.Value = TextBox2.Text;
                    SqlParameter ManagerID = objcmd.Parameters.Add("@ManagerID", SqlDbType.Int);
                    ManagerID.Value = TextBox1.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lblOutput.InnerText = "Record Updated successfully. Name = " + TextBox1.Text.ToString();
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

        protected void Button3_Click(object sender, EventArgs e) //delete
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj3 = new SqlConnection(conn);
            try
            {
                if (TextBox2.Text != "")
                {

                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("RMDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter ManagerID = objcmd.Parameters.Add("@ManagerID", SqlDbType.Int);
                    ManagerID.Value = TextBox1.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lblOutput.InnerText = "Record Deleted successfully. Name = " + TextBox1.Text.ToString();
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
    }

}
