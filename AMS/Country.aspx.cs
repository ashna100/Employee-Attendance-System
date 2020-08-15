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
    public partial class Country : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

     
        protected void btnAdd_Click(object sender, EventArgs e)  //Insert Country
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (TextBox1.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("CountryInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter CountryName = objcmd.Parameters.Add("@ConName", SqlDbType.NVarChar);
                    CountryName.Value = TextBox1.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);



                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record inserted successfully. Country Name = " + TextBox1.Text.ToString();
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


        protected void btnShow_Click(object sender, EventArgs e) //Search all comment
        {
            //string conn = "";
            //conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            //SqlConnection obj2 = new SqlConnection(conn);
            //try
            //{

            //    obj2.Open();
            //    DataSet ds = new DataSet();
            //    SqlCommand objcmd = new SqlCommand("CountrySearch", obj2);
            //    objcmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter CountryName = objcmd.Parameters.Add("@ConName", SqlDbType.NVarChar, 50);
            //    CountryName.Value = 0;

            //    SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);

            //    objAdp.Fill(ds);

            //    grdloadproperties.DataSource = ds;
            //    grdloadproperties.DataBind();

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
                if (TextBox1.Text != "")
                {

                    obj4.Open();
                    SqlCommand objcmd = new SqlCommand("CountryUpdate", obj4);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter CountryName = objcmd.Parameters.Add("@ConName", SqlDbType.NVarChar, 250);
                    CountryName.Value = TextBox1.Text;
                    SqlParameter CountryId = objcmd.Parameters.Add("@ConId", SqlDbType.NVarChar, 250);
                    CountryId.Value = TextBox2.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    GridView1.SelectedIndex = -1;



                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record Updated successfully. Name = " + TextBox1.Text.ToString();
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
                    SqlCommand objcmd = new SqlCommand("CountryDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter CountryID = objcmd.Parameters.Add("@ConID", SqlDbType.Int);
                    CountryID.Value = TextBox2.Text;
                    //SqlParameter CountryId = objcmd.Parameters.Add("@ConID",SqlDbType.Int);
                    //CountryId.Value = TextBox2.Text; 
                  
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    GridView1.SelectedIndex = -1;




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
            //Response.Redirect("HomePage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            GridViewRow gv = GridView1.SelectedRow;
            TextBox1.Text = gv.Cells[2].Text;
            TextBox2.Text = gv.Cells[1].Text;
        }
    }
}