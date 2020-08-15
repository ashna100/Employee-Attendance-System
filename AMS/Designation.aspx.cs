using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class Designation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)  //Insert Designation
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (TextBox2.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("DesignationInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter DesName = objcmd.Parameters.Add("@DesName", SqlDbType.NVarChar);
                    DesName.Value = TextBox2.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record inserted successfully. Name = " + TextBox2.Text.ToString();
                }




            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lbloutput.Text = "";
            }
            finally
            {
                obj1.Close();
            }


            //protected void ClearAll()
            //{
            //    throw new NotImplementedException();
            //}

            //Response.Write("New department created!!!");
        }

        protected void btnShow_Click(object sender, EventArgs e) //Search all
        {
            //string conn = "";
            //conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            //SqlConnection obj2 = new SqlConnection(conn);
            //try
            //{

            //    obj2.Open();
            //    DataSet ds = new DataSet();
            //    SqlCommand objcmd = new SqlCommand("DesignationSearch", obj2);
            //    objcmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter DesId = objcmd.Parameters.Add("@DesId", SqlDbType.Int);
            //    DesId.Value = 0;

            //    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);

            //    objAdp.Fill(ds);

            //    GridView1.DataSource = ds;
            //    GridView1.DataBind();

            //}
            //catch (Exception ex)
            //{
            //    Response.Write(ex.Message.ToString());
            //    lbloutput.Text = "";
            //}
            //finally
            //{
            //    obj2.Close();
            //}

        }

        protected void btnUpdate_Click(object sender, EventArgs e) //Update
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj4 = new SqlConnection(conn);
            try
            {
                if (TextBox2.Text != "")
                {

                    obj4.Open();
                    SqlCommand objcmd = new SqlCommand("DesignationUpdate", obj4);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter DesName = objcmd.Parameters.Add("@DesName", SqlDbType.NVarChar, 50);
                    DesName.Value = TextBox2.Text;
                    SqlParameter DesId = objcmd.Parameters.Add("@DesId", SqlDbType.Int);
                    DesId.Value = TextBox1.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record Updated successfully. Name = " + TextBox2.Text.ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lbloutput.Text = "";
            }
            finally
            {
                obj4.Close();
            }

        }

        protected void btnDelete_Click(object sender, EventArgs e) //Delete
        {
            string conn;
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj3 = new SqlConnection(conn);

            try
            {
                if (TextBox1.Text != "")
                {

                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("DesignationDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter DesId = objcmd.Parameters.Add("@DesId ", SqlDbType.Int);
                    DesId.Value = TextBox1.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record Deleted successfully. ID = " + TextBox1.Text;

                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message.ToString());
                lbloutput.Text = "";
            }
            finally
            {
                obj3.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e) //return
        {
            //string back = Request.UrlReferrer.ToString();
            //Response.Redirect("HomePage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //Select
        {
            GridViewRow gv = GridView1.SelectedRow;
            TextBox1.Text = gv.Cells[1].Text;
            TextBox2.Text = gv.Cells[2].Text;
                
        }
    }
   }
