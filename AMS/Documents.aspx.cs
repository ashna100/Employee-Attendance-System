using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace WebApplication1.AMS
{
    public partial class Documents : System.Web.UI.Page
    {

        string str = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDrownShow();
            }
            if (Session["PersonalEmail"] == null)
            {
                Response.Redirect("MainWindow1.aspx");
            }
        }

        private void DropDrownShow()
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Registration", conn);
            drpdown1.DataSource = cmd.ExecuteReader();
            drpdown1.DataValueField = "UserID";
            drpdown1.DataTextField = "FirstName";
            drpdown1.DataBind();
            drpdown1.Items.Insert(0, "Select Employee");
            conn.Close();
        }
        protected void btn1_Click(object sender, EventArgs e)//submit
        {
            if (drpdown1.SelectedValue == "Select Employee" && txtDoc.Text == "")
            {
                lblAlert.Text = "Fill all the details.";
            }
            if (fileupload1.PostedFile != null)
            {
                SaveDocFile();
            }
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Documents(UserID,EmployeeName,DocumentType,UploadedFiles)values(@1,@2,@3,@4)", conn);
            cmd.Parameters.AddWithValue("@1", drpdown1.SelectedValue);
            cmd.Parameters.AddWithValue("@2", drpdown1.SelectedItem.Text);
            cmd.Parameters.AddWithValue("@3", txtDoc.Text);
            cmd.Parameters.AddWithValue("@4",  fileupload1.FileName);

            cmd.ExecuteNonQuery();
            Label1.Text = "Document submitted successfully";
            //lblAlert.ForeColor = System.Drawing.Color.Green; 
            conn.Close();
            txtDoc.Text = "";
            

        }

        private void SaveDocFile()
        {
            if (fileupload1.PostedFile != null)
            {
                string filename = fileupload1.PostedFile.FileName;
                string FileExt = System.IO.Path.GetExtension(fileupload1.FileName);

                //Check file name length
                if (filename.Length > 96)
                {
                    lblAlert.Text = "Image name should not exceed 96 characters.";
                }
                //check file type
                else if (FileExt != ".jpeg" && FileExt != ".jpg" && FileExt != ".png" && FileExt != ".bmp" && FileExt!=".docx")
                {
                    lblAlert.Text = "Only jpeg, jpg, png, docx and bmp file type is allowed";
                }
                //check file size
                else if (fileupload1.PostedFile.ContentLength > 40000000)
                {
                    lblAlert.Text = "Image size should not exceed 4 MB!";
                }
                else
                {
                    fileupload1.SaveAs(Server.MapPath("~/Images/Documents_Folder/" + filename));
                }
            }
        }
    }
}
