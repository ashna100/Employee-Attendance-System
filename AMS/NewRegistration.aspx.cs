using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication1.AMS
{
    public partial class NewRegistration : System.Web.UI.Page
    {
        void Clear()
        {
            TextBox12.Text = TextBox1.Text = TextBox2.Text = TextBox9.Text = TextBox8.Text = TextBox7.Text = TextBox5.Text = TextBox6.Text = TextBox3.Text
             = TextBox10.Text = TextBox11.Text = TextBox4.Text = txtDob.Text = txtDoj.Text = "";
            //hfUserID.Value = "";
            Label2.Text = "";
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }


    }



        protected void Button1_Click(object sender, EventArgs e)//insert
        {
            string constr = "";
            constr = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(constr);

            {
                try
                {
                    obj1.Open();
                    SqlCommand cmd = new SqlCommand("RegisterInsertOrEdit", obj1);
                    cmd.CommandType = CommandType.StoredProcedure;
                    // cmd.Parameters.AddWithValue("@UserID", Convert.ToInt32(hfUserID.Value == "" ? "0" : hfUserID.Value));
                    cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = TextBox1.Text;
                    cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = TextBox2.Text;
                    cmd.Parameters.Add("@dob", SqlDbType.Date).Value = txtDob.Text;

                    cmd.Parameters.Add("@MStatus", SqlDbType.VarChar).Value = DropDownList1.SelectedItem.Text;
                    cmd.Parameters.Add("@Marital_ID", SqlDbType.Int).Value = DropDownList1.SelectedValue;

                    cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = DropDownList2.SelectedItem.Text;
                    cmd.Parameters.Add("@Gender_ID", SqlDbType.Int).Value = DropDownList2.SelectedValue;

                    cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = DropDownList3.SelectedItem.Text;
                    cmd.Parameters.Add("@Country_ID", SqlDbType.Int).Value = DropDownList3.SelectedValue;

                    cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = DropDownList4.SelectedItem.Text;
                    cmd.Parameters.Add("@State_ID", SqlDbType.Int).Value = DropDownList4.SelectedValue;

                    cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = DropDownList5.SelectedItem.Text;
                    cmd.Parameters.Add("@City_ID", SqlDbType.Int).Value = DropDownList5.SelectedValue;

                    cmd.Parameters.Add("@Pincode", SqlDbType.VarChar).Value = TextBox9.Text;
                    cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = TextBox8.Text;
                    cmd.Parameters.Add("@PersonalEmail", SqlDbType.VarChar).Value = TextBox7.Text;
                    cmd.Parameters.Add("@OfficialEmail", SqlDbType.VarChar).Value = TextBox5.Text;
                    cmd.Parameters.Add("@Contact1", SqlDbType.VarChar).Value = TextBox6.Text;
                    cmd.Parameters.Add("@Contact2", SqlDbType.VarChar).Value = TextBox3.Text;
                    cmd.Parameters.Add("@DOJ", SqlDbType.Date).Value = txtDoj.Text;
                    cmd.Parameters.AddWithValue("@MotherName", TextBox10.Text);
                    cmd.Parameters.Add("@FatherName", SqlDbType.VarChar).Value = TextBox11.Text;

                    cmd.Parameters.Add("@BldGrp", SqlDbType.VarChar).Value = DropDownList9.SelectedItem.Text;
                    cmd.Parameters.Add("@BloodGroup_ID", SqlDbType.Int).Value = DropDownList9.SelectedValue;

                    cmd.Parameters.Add("@Dept", SqlDbType.VarChar).Value = DropDownList6.SelectedItem.Text;
                    cmd.Parameters.Add("@Department_ID", SqlDbType.Int).Value = DropDownList6.SelectedValue;

                    cmd.Parameters.Add("@Desig", SqlDbType.VarChar).Value = DropDownList7.SelectedItem.Text;
                    cmd.Parameters.Add("@Designation_ID", SqlDbType.Int).Value = DropDownList7.SelectedValue;

                    cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = DropDownList8.SelectedItem.Text;
                    cmd.Parameters.Add("@Grade_ID", SqlDbType.Int).Value = DropDownList8.SelectedValue;

                    cmd.Parameters.Add("@CardNum", SqlDbType.VarChar).Value = TextBox4.Text;

                    cmd.Parameters.Add("@ReportingManager", SqlDbType.VarChar).Value = DropDownList10.SelectedItem.Text;
                    cmd.Parameters.Add("@Manager_ID", SqlDbType.Int).Value = DropDownList10.SelectedValue;

                    cmd.ExecuteNonQuery();
                    SqlDataSource10.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource10";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    // Response.Redirect(Request.Url.AbsoluteUri);
                    Clear();
                    Label2.Text = "Details inserted successfully";
                    // Label1.Text = "Total Regitrations";
                    // Label1.Text = counter.ToString();
                    //  counter++;

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

        }

        protected void Home_Click(object sender, EventArgs e)//Return
        {
            //Response.Redirect("HomePage.aspx");

        }


        //void FillDataGridView() //grid view
        //{
        //    string constr = "";
        //    constr = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        //    SqlConnection obj2 = new SqlConnection(constr);
        //    obj2.Open();
        //    SqlDataAdapter Sqlda = new SqlDataAdapter("ViewById", obj2);
        //    Sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
        //    Sqlda.SelectCommand.Parameters.AddWithValue("@UserID", txtSearch.Text);
        //    DataTable dt1 = new DataTable();
        //    Sqlda.Fill(dt1);
        //    GridView1.DataSource = dt1;
        //    GridView1.Columns[0].Visible = true;

        //    obj2.Close();
        //}
        protected void Button2_Click(object sender, EventArgs e)//update
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj2 = new SqlConnection(conn);
            try
            {
                obj2.Open();
                SqlCommand cmd = new SqlCommand("RegisterUpdate", obj2);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = TextBox12.Text;
                cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = TextBox1.Text;
                cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = TextBox2.Text;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = txtDob.Text;

                cmd.Parameters.Add("@MStatus", SqlDbType.VarChar).Value = DropDownList1.SelectedItem.Text;
                cmd.Parameters.Add("@Marital_ID", SqlDbType.Int).Value = DropDownList1.SelectedValue;

                cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = DropDownList2.SelectedItem.Text;
                cmd.Parameters.Add("@Gender_ID", SqlDbType.Int).Value = DropDownList2.SelectedValue;

                cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = DropDownList3.SelectedItem.Text;
                cmd.Parameters.Add("@Country_ID", SqlDbType.Int).Value = DropDownList3.SelectedValue;

                cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = DropDownList4.SelectedItem.Text;
                cmd.Parameters.Add("@State_ID", SqlDbType.Int).Value = DropDownList4.SelectedValue;

                cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = DropDownList5.SelectedItem.Text;
                cmd.Parameters.Add("@City_ID", SqlDbType.Int).Value = DropDownList5.SelectedValue;

                cmd.Parameters.Add("@Pincode", SqlDbType.VarChar).Value = TextBox9.Text;
                cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = TextBox8.Text;
                cmd.Parameters.Add("@PersonalEmail", SqlDbType.VarChar).Value = TextBox7.Text;
                cmd.Parameters.Add("@OfficialEmail", SqlDbType.VarChar).Value = TextBox5.Text;
                cmd.Parameters.Add("@Contact1", SqlDbType.VarChar).Value = TextBox6.Text;
                cmd.Parameters.Add("@Contact2", SqlDbType.VarChar).Value = TextBox3.Text;
                cmd.Parameters.Add("@DOJ", SqlDbType.Date).Value = txtDoj.Text;
                cmd.Parameters.AddWithValue("@MotherName", TextBox10.Text);
                cmd.Parameters.Add("@FatherName", SqlDbType.VarChar).Value = TextBox11.Text;

                cmd.Parameters.Add("@BldGrp", SqlDbType.VarChar).Value = DropDownList9.SelectedItem.Text;
                cmd.Parameters.Add("@BloodGroup_ID", SqlDbType.Int).Value = DropDownList9.SelectedValue;

                cmd.Parameters.Add("@Dept", SqlDbType.VarChar).Value = DropDownList6.SelectedItem.Text;
                cmd.Parameters.Add("@Department_ID", SqlDbType.Int).Value = DropDownList6.SelectedValue;

                cmd.Parameters.Add("@Desig", SqlDbType.VarChar).Value = DropDownList7.SelectedItem.Text;
                cmd.Parameters.Add("@Designation_ID", SqlDbType.Int).Value = DropDownList7.SelectedValue;

                cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = DropDownList8.SelectedItem.Text;
                cmd.Parameters.Add("@Grade_ID", SqlDbType.Int).Value = DropDownList8.SelectedValue;

                cmd.Parameters.Add("@CardNum", SqlDbType.VarChar).Value = TextBox4.Text;

                cmd.Parameters.Add("@ReportingManager", SqlDbType.VarChar).Value = DropDownList10.SelectedItem.Text;
                cmd.Parameters.Add("@Manager_ID", SqlDbType.Int).Value = DropDownList10.SelectedValue;

                cmd.ExecuteNonQuery();
                SqlDataSource10.DataBind();
                GridView1.DataSource = null;
                GridView1.DataSourceID = "SqlDataSource10";

                GridView1.SelectedIndex = -1;
                //Response.Redirect(Request.Url.AbsoluteUri);
                Clear();

                Label2.Text = "Record Updated successfully. ";

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



            //    try
            //    {
            //        FillDataGridView();
            //    }
            //    catch (Exception ex)
            //    {
            //        Response.Write(ex.Message.ToString());
            //        lblOutput.Text = "";
            //    }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            //string conn = "";
            //conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            //SqlConnection obj4 = new SqlConnection(conn);
            ////SqlCommand cmd = new SqlCommand(conn);
            //obj4.Open();
            //using (SqlDataReader reader = conn.ExecuteReader())
            //{
            //    while (reader.Read())
            //    {
            GridViewRow da = GridView1.SelectedRow;
            TextBox12.Text = da.Cells[1].Text;
            TextBox1.Text = da.Cells[2].Text;
            TextBox2.Text = da.Cells[3].Text;
            txtDob.Text = da.Cells[4].Text;                       //(Convert.ToDateTime(reader[4]).ToString("yyyy-MM-dd"));
            DropDownList1.SelectedItem.Text = da.Cells[5].Text;
            DropDownList2.SelectedItem.Text = da.Cells[6].Text;
            DropDownList3.SelectedItem.Text = da.Cells[7].Text;
            DropDownList4.SelectedItem.Text = da.Cells[8].Text;
            DropDownList5.SelectedItem.Text = da.Cells[9].Text;
            TextBox9.Text = da.Cells[10].Text;
            TextBox8.Text = da.Cells[11].Text;
            TextBox7.Text = da.Cells[12].Text;
            TextBox5.Text = da.Cells[13].Text;
            TextBox6.Text = da.Cells[14].Text;
            TextBox3.Text = da.Cells[15].Text;
            txtDoj.Text = da.Cells[16].Text; ;
            TextBox10.Text = da.Cells[17].Text;
            TextBox11.Text = da.Cells[18].Text;
            DropDownList9.SelectedItem.Text = da.Cells[19].Text;
            DropDownList6.SelectedItem.Text = da.Cells[20].Text;
            DropDownList7.SelectedItem.Text = da.Cells[21].Text;
            DropDownList8.SelectedItem.Text = da.Cells[22].Text;
            DropDownList10.SelectedItem.Text = da.Cells[24].Text;
            TextBox4.Text = da.Cells[23].Text;
            ModalPopupExtender1.Show();
            //conn.ExecuteNonQuery();
        }



        protected void Button3_Click(object sender, EventArgs e) //delete
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj3 = new SqlConnection(conn);
            try
            {
                obj3.Open();
                SqlCommand cmd = new SqlCommand("RegisterDelete", obj3);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = TextBox12.Text;
                //cmd.Parameters.Add("@Fname", SqlDbType.VarChar).Value = TextBox1.Text;
                //cmd.Parameters.Add("@Lname", SqlDbType.VarChar).Value = TextBox2.Text;
                //cmd.Parameters.Add("@dob", SqlDbType.Date).Value = txtDob.Text;

                //cmd.Parameters.Add("@MStatus", SqlDbType.VarChar).Value = DropDownList1.SelectedItem.Text;
                //cmd.Parameters.Add("@Marital_ID", SqlDbType.Int).Value = DropDownList1.SelectedValue;

                //cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = DropDownList2.SelectedItem.Text;
                //cmd.Parameters.Add("@Gender_ID", SqlDbType.Int).Value = DropDownList2.SelectedValue;

                //cmd.Parameters.Add("@Country", SqlDbType.VarChar).Value = DropDownList3.SelectedItem.Text;
                //cmd.Parameters.Add("@Country_ID", SqlDbType.Int).Value = DropDownList3.SelectedValue;

                //cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = DropDownList4.SelectedItem.Text;
                //cmd.Parameters.Add("@State_ID", SqlDbType.Int).Value = DropDownList4.SelectedValue;

                //cmd.Parameters.Add("@City", SqlDbType.VarChar).Value = DropDownList5.SelectedItem.Text;
                //cmd.Parameters.Add("@City_ID", SqlDbType.Int).Value = DropDownList5.SelectedValue;

                //cmd.Parameters.Add("@Pincode", SqlDbType.VarChar).Value = TextBox9.Text;
                //cmd.Parameters.Add("@add", SqlDbType.VarChar).Value = TextBox8.Text;
                //cmd.Parameters.Add("@PersonalEmail", SqlDbType.VarChar).Value = TextBox7.Text;
                //cmd.Parameters.Add("@OfficialEmail", SqlDbType.VarChar).Value = TextBox5.Text;
                //cmd.Parameters.Add("@Contact1", SqlDbType.VarChar).Value = TextBox6.Text;
                //cmd.Parameters.Add("@Contact2", SqlDbType.VarChar).Value = TextBox3.Text;
                //cmd.Parameters.Add("@DOJ", SqlDbType.Date).Value = txtDoj.Text;
                //cmd.Parameters.AddWithValue("@MotherName", TextBox10.Text);
                //cmd.Parameters.Add("@FatherName", SqlDbType.VarChar).Value = TextBox11.Text;

                //cmd.Parameters.Add("@BldGrp", SqlDbType.VarChar).Value = DropDownList9.SelectedItem.Text;
                //cmd.Parameters.Add("@BloodGroup_ID", SqlDbType.Int).Value = DropDownList9.SelectedValue;

                //cmd.Parameters.Add("@Dept", SqlDbType.VarChar).Value = DropDownList6.SelectedItem.Text;
                //cmd.Parameters.Add("@Department_ID", SqlDbType.Int).Value = DropDownList6.SelectedValue;

                //cmd.Parameters.Add("@Desig", SqlDbType.VarChar).Value = DropDownList7.SelectedItem.Text;
                //cmd.Parameters.Add("@Designation_ID", SqlDbType.Int).Value = DropDownList7.SelectedValue;

                //cmd.Parameters.Add("@Grade", SqlDbType.VarChar).Value = DropDownList8.SelectedItem.Text;
                //cmd.Parameters.Add("@Grade_ID", SqlDbType.Int).Value = DropDownList8.SelectedValue;

                //cmd.Parameters.Add("@CardNum", SqlDbType.VarChar).Value = TextBox4.Text;

                //cmd.Parameters.Add("@ReportingManager", SqlDbType.VarChar).Value = DropDownList10.SelectedItem.Text;
                //cmd.Parameters.Add("@Manager_ID", SqlDbType.VarChar).Value = DropDownList10.SelectedValue;

                Clear();
                cmd.ExecuteNonQuery();
                SqlDataSource10.DataBind();
                GridView1.DataSource = null;
                GridView1.DataSourceID = "SqlDataSource10";
                //con.Close();                    
                //Response.Redirect(Request.Url.AbsoluteUri);
                GridView1.SelectedIndex = -1;

                Label2.Text = "Record Deleted successfully. ";

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

        protected void button5_Click(object sender, EventArgs e) //calender dob
        {
            //Calendar2.Visible = true;
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e) //cal1 dob
        {
            //txtDob.Text = Calendar2.SelectedDate.ToString("yyyy-MM-dd");
            //Calendar2.Visible = false;
        }

        protected void button6_Click(object sender, EventArgs e) //cal2 doj
        {
            // Calendar1.Visible = true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e) //cal2 doj
        {
            //txtDoj.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
            //Calendar1.Visible = false;
        }

        
    }
}
}



