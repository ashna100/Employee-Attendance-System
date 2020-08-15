using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class BloodGroup : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        //public void refreshdata()
        //{
        //    string conn = "";
        //    conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        //    SqlConnection obj1 = new SqlConnection(conn);
        //    SqlCommand cmd = new SqlCommand("select * from BloodGroup", obj1);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //    GridView1.DataSource = dt;
        //    GridView1.DataBind();

        //}



        protected void ShowData()
        {
        //    string conn = "";
        //    conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        //    SqlConnection con;
        //    SqlDataAdapter adapt;
        //    DataTable dt;
        //    con = new SqlConnection(conn);
        //    dt = new DataTable();
        //    con.Open();
        //    adapt = new SqlDataAdapter("Select * from BloodGroup ", con);
        //    adapt.Fill(dt);
        //    con.Close();
        //    if (dt.Rows.Count > 0)
        //    {
        //        GridView1.DataSource = dt;
        //        GridView1.DataBind();
        //    }
        }

        protected void Button1_Click(object sender, EventArgs e) //insert
        {

            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (txtBG.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("BloodGroupInsert", obj1);
                    objcmd.CommandType = CommandType.Text;
                    objcmd.CommandText = "insert into BloodGroup values('" + txtBG.Text + "')";
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);
                    lblOutput.InnerText = "Record inserted successfully. Name = " + txtBG.Text.ToString();
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

        protected void btnReturn_Click(object sender, EventArgs e) //return
        {
            //Response.Redirect("HomePage.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            GridViewRow gv = GridView1.SelectedRow;
            txtBG.Text = gv.Cells[2].Text;
            TextBox1.Text = gv.Cells[1].Text;
        }

        protected void Button2_Click(object sender, EventArgs e) //update
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj2 = new SqlConnection(conn);
            try
            {
                if (txtBG.Text != "")
                {

                    obj2.Open();
                    SqlCommand objcmd = new SqlCommand("BloodUpdate", obj2);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter BloodGroup_Type = objcmd.Parameters.Add("@BloodGroup_Type", SqlDbType.NVarChar, 50);
                    BloodGroup_Type.Value = txtBG.Text;
                    SqlParameter BloodGroup_ID = objcmd.Parameters.Add("@BloodGroup_ID", SqlDbType.Int);
                    BloodGroup_ID.Value = TextBox1.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);



                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lblOutput.InnerText = "Record Updated successfully. Name = " + txtBG.Text.ToString();
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
                if (txtBG.Text != "")
                {

                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("BloodDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter BloodGroup_ID = objcmd.Parameters.Add("@BloodGroup_ID", SqlDbType.Int);
                    BloodGroup_ID.Value = TextBox1.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);


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
                obj3.Close();
            }
        }

       

        protected void Save(object sender, GridViewUpdateEventArgs e) //Ajax update
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            String updateData = "UPDATE[BloodGroup] SET[BloodGroup_Type] = @BloodGroup_Type WHERE[BloodGroup_ID] = @BloodGroup_ID";
            SqlConnection con;
            con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = updateData;
            cmd.Connection = con;
            //TextBox TextBox1 = GridView1.Rows[e.RowIndex].FindControl("BloodGroup_ID") as TextBox;
            //TextBox txtBG = GridView1.Rows[e.RowIndex].FindControl("BloodGroup_ID") as TextBox;
            //con = new SqlConnection(conn);
            //con.Open();

            cmd.ExecuteNonQuery();
            SqlDataSource1.DataBind();
            GridView1.DataSource = null;
            GridView1.DataSourceID = "SqlDataSource1";
            //con.Close();
            GridView1.SelectedIndex = -1;
            //ShowData();
        }
    }
}
