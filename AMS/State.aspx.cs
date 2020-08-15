using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class State : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)  //Insert State
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (TextBox1.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("StateInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;

                    //SqlParameter StateID = objcmd.Parameters.Add("@StateID", SqlDbType.NVarChar);
                    //StateID.Value = TextBox2.Text;

                    SqlParameter StateName = objcmd.Parameters.Add("@StateName", SqlDbType.NVarChar);
                    StateName.Value = TextBox1.Text;

                    SqlParameter CountryID = objcmd.Parameters.AddWithValue("@CountryID", DropDownList1.SelectedItem.Value);
                    CountryID.Value = DropDownList1.SelectedValue;

                    SqlParameter CountryName = objcmd.Parameters.AddWithValue("@CountryName",  DropDownList1.SelectedItem.Value);
                    CountryName.Value = DropDownList1.SelectedItem.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource2.DataBind();
                    grdloadproperties.DataSource = null;
                    grdloadproperties.DataSourceID = "SqlDataSource2";
                    //con.Close();
                    grdloadproperties.SelectedIndex = -1;




                    //ClearAll();
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


        protected void btnShow_Click(object sender, EventArgs e) //Search all commented
        {
            //string conn = "";
            //conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            //SqlConnection obj2 = new SqlConnection(conn);
            //try
            //{

            //    obj2.Open();
            //    DataSet ds = new DataSet();
            //    SqlCommand objcmd = new SqlCommand("StateSearch", obj2);
            //    objcmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter StateName = objcmd.Parameters.Add("@StateName", SqlDbType.NVarChar, 50);
            //    StateName.Value = TextBox1.Text;
            //    grdloadproperties.DataBind();

            //    objcmd.ExecuteNonQuery();
            //    lbloutput.Text = "Results showed";

                //SqlDataAdapter objAdp = new SqlDataAdapter(objcmd);

                //objAdp.Fill(ds);

                //grdloadproperties.DataSource = ds;
                //grdloadproperties.DataBind();

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
                    SqlCommand objcmd = new SqlCommand("StateUpdate", obj4);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter StateName = objcmd.Parameters.Add("@StateName", SqlDbType.NVarChar, 250);
                    StateName.Value = TextBox1.Text;
                    SqlParameter StateId = objcmd.Parameters.Add("@StateId", SqlDbType.Int);
                    StateId.Value = TextBox2.Text;

                    SqlParameter CountryID = objcmd.Parameters.AddWithValue("@CountryID", DropDownList1.SelectedItem.Value);
                    CountryID.Value = DropDownList1.SelectedValue;

                    SqlParameter CountryName = objcmd.Parameters.AddWithValue("@CountryName", DropDownList1.SelectedItem.Value);
                    CountryName.Value = DropDownList1.SelectedItem.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource2.DataBind();
                    grdloadproperties.DataSource = null;
                    grdloadproperties.DataSourceID = "SqlDataSource2";
                    //con.Close();
                    grdloadproperties.SelectedIndex = -1;

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
                    SqlCommand objcmd = new SqlCommand("StateDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter StateId = objcmd.Parameters.Add("@StateId ", SqlDbType.NVarChar, 250);
                    StateId.Value = TextBox2.Text;
                    SqlParameter StateName = objcmd.Parameters.Add("@StateName", DropDownList1.SelectedItem.Value);
                    StateName.Value = DropDownList1.SelectedValue;

                    SqlParameter CountryID = objcmd.Parameters.AddWithValue("@CountryID", DropDownList1.SelectedItem.Value);
                    CountryID.Value = DropDownList1.SelectedValue;

                    SqlParameter CountryName = objcmd.Parameters.AddWithValue("@CountryName", DropDownList1.SelectedItem.Value);
                    CountryName.Value = DropDownList1.SelectedItem.Text;
                   objcmd.ExecuteNonQuery();
                    SqlDataSource2.DataBind();
                    grdloadproperties.DataSource = null;
                    grdloadproperties.DataSourceID = "SqlDataSource2";
                    //con.Close();
                    grdloadproperties.SelectedIndex = -1;


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
        
        protected void grdloadproperties_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            GridViewRow gv = grdloadproperties.SelectedRow;
            DropDownList1.SelectedItem.Text = gv.Cells[3].Text;
            TextBox2.Text = gv.Cells[1].Text;
            TextBox1.Text = gv.Cells[2].Text;
        }

        protected void Button1_Click(object sender, EventArgs e) //return
        {
            Response.Redirect("HomePage.aspx");
        }

        
    }
}