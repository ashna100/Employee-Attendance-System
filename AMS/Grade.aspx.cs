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
    public partial class Grade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)  //Insert grade
        {
               string conn = "";
                conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
                SqlConnection obj1 = new SqlConnection(conn);
                try
                {
                    if (TextBox2.Text != "")
                    {

                        obj1.Open();
                        SqlCommand objcmd = new SqlCommand("GradeInsert", obj1);
                        objcmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter GradeName = objcmd.Parameters.Add("@GradeName", SqlDbType.NVarChar);
                        GradeName.Value = TextBox2.Text;
                        objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    grdloadproperties.DataSource = null;
                    grdloadproperties.DataSourceID = "SqlDataSource1";
                    grdloadproperties.SelectedIndex = -1;
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

        protected void btnShow_Click(object sender, EventArgs e) //Search all commented
        {
            //string conn = "";
            //conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            //SqlConnection obj2 = new SqlConnection(conn);
            //try
            //{

            //    obj2.Open();
            //    DataSet ds = new DataSet();
            //    SqlCommand objcmd = new SqlCommand("GradeSearch", obj2);
            //    objcmd.CommandType = CommandType.StoredProcedure;

            //    SqlParameter GradeId = objcmd.Parameters.Add("@GradeId", SqlDbType.Int);
            //    GradeId.Value = 0;

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

        protected void BtnUpdate_Click(object sender, EventArgs e) //Update
        {
            string conn = "";
            conn = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
            SqlConnection obj4 = new SqlConnection(conn);
            try
            {
                if (TextBox2.Text != "")
                {

                    obj4.Open();
                    SqlCommand objcmd = new SqlCommand("GradeUpdate", obj4);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter GradeName = objcmd.Parameters.Add("@GradeName", SqlDbType.NVarChar,250);
                    GradeName.Value = TextBox2.Text;
                    SqlParameter GradeId = objcmd.Parameters.Add("@GradeID", SqlDbType.Int);
                    GradeId.Value = TextBox1.Text;


                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    grdloadproperties.DataSource = null;
                    grdloadproperties.DataSourceID = "SqlDataSource1";
                    grdloadproperties.SelectedIndex = -1;
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
                    SqlCommand objcmd = new SqlCommand("GradeDelete", obj3);
                    objcmd.CommandType = CommandType.StoredProcedure;
                    SqlParameter GradeId = objcmd.Parameters.Add("@GradeId ", SqlDbType.Int);
                    GradeId.Value = TextBox1.Text;
                    objcmd.ExecuteNonQuery();
                    SqlDataSource1.DataBind();
                    grdloadproperties.DataSource = null;
                    grdloadproperties.DataSourceID = "SqlDataSource1";
                    grdloadproperties.SelectedIndex = -1;

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

        protected void grdloadproperties_SelectedIndexChanged(object sender, EventArgs e)//select
        {
            GridViewRow gv = grdloadproperties.SelectedRow;
            TextBox1.Text = gv.Cells[1].Text;
            TextBox2.Text = gv.Cells[2].Text;
        }

        
    }
}