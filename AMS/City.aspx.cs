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
    public partial class City : System.Web.UI.Page
    {
        void ClearAll()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["PersonalEmail"]==null)
            {
                Response.Redirect("MainWindow1.aspx");
            }

        }

        protected void BtnAdd_Click(object sender, EventArgs e)  //Insert City
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (TextBox1.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("CityInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;

                    //SqlParameter StateID = objcmd.Parameters.Add("@StateID", SqlDbType.NVarChar);
                    //StateID.Value = TextBox2.Text;

                    SqlParameter CityName = objcmd.Parameters.Add("@CityName", SqlDbType.NVarChar);
                    CityName.Value = TextBox1.Text;

                    SqlParameter StateID = objcmd.Parameters.AddWithValue("@StateID", DropDownList1.SelectedItem.Value);
                    StateID.Value = DropDownList1.SelectedValue;

                    SqlParameter StateName = objcmd.Parameters.AddWithValue("@StateName", DropDownList1.SelectedItem.Value);
                    StateName.Value = DropDownList1.SelectedItem.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource2.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource2";
                    GridView1.SelectedIndex = -1;
                   // Response.Redirect(Request.Url.AbsoluteUri);

                    ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record inserted successfully. State Name = " + TextBox1.Text.ToString();
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


        //protected void btnShow_Click(object sender, EventArgs e) //Search all
        //{
        //    string conn = "";
        //    conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        //    SqlConnection obj2 = new SqlConnection(conn);
        //    try
        //    {

        //        obj2.Open();
        //        DataSet ds = new DataSet();
        //        SqlCommand objcmd = new SqlCommand("CitySearch", obj2);
        //        objcmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter CityName = objcmd.Parameters.Add("@CityName", SqlDbType.NVarChar, 50);
        //        CityName.Value = 0;

        //        SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);

        //        objAdp.Fill(ds);

        //        grdloadproperties.DataSource = ds;
        //        grdloadproperties.DataBind();

        //    }
        //    catch (Exception ex)
        //    {
        //        Response.Write(ex.Message.ToString());
        //        lbloutput.Text = "";
        //    }
        //    finally
        //    {
        //        obj2.Close();
        //    }

        //}

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
                    SqlCommand objcmd = new SqlCommand("CityUpdate", obj4);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter CityName = objcmd.Parameters.AddWithValue("@CityName", TextBox1.Text);
                    CityName.Value = TextBox1.Text;
                    SqlParameter CityId = objcmd.Parameters.Add("@CityId", SqlDbType.Int);
                    CityId.Value = TextBox2.Text;
                    SqlParameter StateID = objcmd.Parameters.AddWithValue("@StateID", DropDownList1.SelectedItem.Value);
                    StateID.Value = DropDownList1.SelectedValue;

                    SqlParameter StateName = objcmd.Parameters.AddWithValue("@StateName", DropDownList1.SelectedItem.Value);
                    StateName.Value = DropDownList1.SelectedItem.Text;


                    objcmd.ExecuteNonQuery();
                    objcmd.ExecuteNonQuery();
                    SqlDataSource2.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource2";
                    GridView1.SelectedIndex = -1;
                    //Response.Redirect(Request.Url.AbsoluteUri);
                      ClearAll();
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

        protected void BtnDelete_Click(object sender, EventArgs e) //Delete
        {
            string conn;
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj3 = new SqlConnection(conn);

            try
            {
                if (TextBox1.Text != "")
                {

                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("CityDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter CityName = objcmd.Parameters.AddWithValue("@CityName", TextBox1.Text);
                    CityName.Value = TextBox1.Text;
                    SqlParameter CityId = objcmd.Parameters.Add("@CityId ", SqlDbType.Int);
                    CityId.Value = TextBox2.Text;
                    SqlParameter StateName = objcmd.Parameters.AddWithValue("@StateName", DropDownList1.SelectedItem.Value);
                    StateName.Value = DropDownList1.SelectedItem.Text;

                    SqlParameter StateID = objcmd.Parameters.AddWithValue("@StateID", DropDownList1.SelectedItem.Value);
                    StateID.Value = DropDownList1.SelectedValue;
                    
                    objcmd.ExecuteNonQuery();
                    SqlDataSource2.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource2";
                    GridView1.SelectedIndex = -1;
                    //Response.Redirect(Request.Url.AbsoluteUri);


                    ClearAll();
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

        protected void Button1_Click(object sender, EventArgs e)  //return
        {
            //Response.Redirect("HomePage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            GridViewRow gv = GridView1.SelectedRow;
            TextBox1.Text = gv.Cells[2].Text;
            TextBox2.Text = gv.Cells[1].Text;
            DropDownList1.SelectedItem.Text = gv.Cells[3].Text;
        }
    }
}