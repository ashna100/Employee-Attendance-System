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
    public partial class Department : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }
        
        protected void btnNew_Click(object sender, EventArgs e) //Insert
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj1 = new SqlConnection(conn);
            try
            {
                if (lblName.Text != "")
                {

                    obj1.Open();
                    SqlCommand objcmd = new SqlCommand("DepartmentInsert", obj1);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter Name = objcmd.Parameters.Add("@name", SqlDbType.NVarChar);
                    Name.Value = lblName.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record inserted successfully. Name = " + lblName.Text.ToString();
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



        protected void Button2_Click(object sender, EventArgs e)  //Update
        {
            
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj4 = new SqlConnection(conn);
            try
            {
                if (lblName.Text != "")
                {

                    obj4.Open();
                    SqlCommand objcmd = new SqlCommand("DepartmentUpdate", obj4);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter Name = objcmd.Parameters.Add("@name", SqlDbType.NVarChar,50);
                    Name.Value = lblName.Text;
                    SqlParameter deptid = objcmd.Parameters.Add("@DeptId", SqlDbType.Int);
                    deptid.Value = lblDept.Text;

                   
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    GridView1.SelectedIndex = -1;
                    Response.Redirect(Request.Url.AbsoluteUri);




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record Updated successfully. Name = " + lblName.Text.ToString();
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

    
        protected void btnDelete_Click(object sender, EventArgs e)//Delete
        {
            string conn;
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj3 = new SqlConnection(conn);

            try
            {
                if (lblDept.Text != "")
                {

                    obj3.Open();
                    SqlCommand objcmd = new SqlCommand("DepartmentDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter DeptId = objcmd.Parameters.Add("@DeptId", SqlDbType.Int);
                    DeptId.Value = lblDept.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    GridView1.DataSource = null;
                    GridView1.DataSourceID = "SqlDataSource1";
                    //con.Close();
                    Response.Redirect(Request.Url.AbsoluteUri);
                    GridView1.SelectedIndex = -1;




                    //ClearAll();
                    //Response.Redirect("Default.aspx");

                    lbloutput.Text = "Record Deleted successfully. ID = " + lblDept.Text;

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



        protected void btnSearch_Click(object sender, EventArgs e) //Search all
        {

            //string conn = "";
            //conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            //SqlConnection obj2 = new SqlConnection(conn);
            //try
            //{
                
            //    obj2.Open();
            //    DataSet ds = new DataSet();
            //    SqlCommand objcmd = new SqlCommand("DepartmentSearch", obj2);
            //    objcmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter DeptId = objcmd.Parameters.Add("@DeptId", SqlDbType.Int);
            //    DeptId.Value = 0;

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

        protected void Button1_Click(object sender, System.EventArgs e) //return 
        {
            {
                //history.go(1);
                //return true;

            //    string prevPage = Request.UrlReferrer.ToString();
            //    Response.Redirect("HomePage.aspx");
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e) //select
        {
            GridViewRow gv = GridView1.SelectedRow;
            lblDept.Text = gv.Cells[1].Text;
            lblName.Text = gv.Cells[2].Text;
        }
    }
}

