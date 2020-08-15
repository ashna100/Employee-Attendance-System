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
    public partial class EmpType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

            protected void Button1_Click(object sender, EventArgs e) //Return
            {
                //Response.Redirect("HomePage.aspx");
            }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            GridViewRow gv = GridView1.SelectedRow;
            TextBox2.Text = gv.Cells[1].Text;
            txtEmpType.Text = gv.Cells[2].Text;
        }

        /* protected void Button2_Click(object sender, EventArgs e) //show all
         {
             string conn = "";
             conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

             SqlConnection obj1 = new SqlConnection(conn);
             try
             {
                 obj1.Open();
                 DataSet ds = new DataSet();
                 SqlCommand objcmd = new SqlCommand("EmpTypeSearch", obj1);
                 objcmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter EmployeeType = objcmd.Parameters.AddWithValue("@EmployeeType", DropDownList1.SelectedItem.Value);
                 EmployeeType.Value = 0;

                 SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);

                 objAdp.Fill(ds);

                 GridView1.DataSource = ds;
                 GridView1.DataBind();

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

         }*/


        protected void Button2_Click(object sender, EventArgs e) //Insert
        {
            if (txtEmpType.Text != "")
            {
                string conn = "";
                conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

                SqlConnection obj2 = new SqlConnection(conn);
                string SqlQuery = "insert into[dbo].[EmpType] (EmployeeType) values(@EmployeeType)";
                SqlCommand objcmd = new SqlCommand(SqlQuery, obj2);
                objcmd.Parameters.AddWithValue("@EmployeeType", txtEmpType.Text);
                obj2.Open();
                int i = objcmd.ExecuteNonQuery();
                SqlDataSource1.DataBind();
                GridView1.DataSource = null;
                GridView1.DataSourceID = "SqlDataSource1";
                //con.Close();
                Response.Redirect(Request.Url.AbsoluteUri);
                GridView1.SelectedIndex = -1;


                if (i != 0)
                {
                    lblOutput.Text = "Details Inserted successfully";
                }
                obj2.Close();
            }
            
        }

        protected void Button3_Click(object sender, EventArgs e) //Update
        {
            string con = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj3 = new SqlConnection(con);
            {
                try
                {
                    if (txtEmpType.Text != "")
                    {
                        obj3.Open();
                        SqlCommand cmd = new SqlCommand("EmpTypeUpdate", obj3);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter EmpId = cmd.Parameters.Add("@EmpId", SqlDbType.Int);
                        EmpId.Value = TextBox2.Text;
                        SqlParameter EmployeeType = cmd.Parameters.Add("@EmployeeType", SqlDbType.VarChar, 50);
                        EmployeeType.Value = txtEmpType.Text;

                        cmd.ExecuteNonQuery();
                        SqlDataSource1.DataBind();
                        GridView1.DataSource = null;
                        GridView1.DataSourceID = "SqlDataSource1";
                        //con.Close();
                        GridView1.SelectedIndex = -1;
                        Response.Redirect(Request.Url.AbsoluteUri);

                        lblOutput.Text = "Details Updated successfully : " + txtEmpType.Text.ToString();
                    }
                }
                catch(Exception ex)
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

        protected void Button4_Click(object sender, EventArgs e) //delete
        {
            string con = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj4 = new SqlConnection(con);
            try
            {
                if(txtEmpType.Text != "")
                {

                    obj4.Open();
                    SqlCommand cmd = new SqlCommand("EmployeeDelete", obj4);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter EmpId = cmd.Parameters.Add("@EmpId", SqlDbType.Int);
                    EmpId.Value = TextBox2.Text;
                    //SqlParameter EmployeeType = cmd.Parameters.Add("@EmployeeType", SqlDbType.VarChar);
                    //EmployeeType.Value = txtEmpType.Text;

                    cmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);


                    lblOutput.Text = "Details deleted successfully : " + txtEmpType.Text.ToString();
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lblOutput.Text = "";
            }
            finally
            {
                obj4.Close();
            }
        }
    }
}
