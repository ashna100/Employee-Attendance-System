using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.AMS
{
    public partial class EmployeeDocument : System.Web.UI.Page
    {
        string constr = ConfigurationManager.ConnectionStrings["infoConnectionString"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["PersonalEmail"] != null)
            {
                Response.Redirect("MainWindow1.aspx");
            }

            SqlConnection con = new SqlConnection(constr);
            con.Open();
            SqlCommand cmd = new SqlCommand("select DocumentType, UploadedFiles  as Files from Documents where UserID=@1 and EmployeeName=@2", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            
            cmd.Parameters.AddWithValue("@1", Session["UserID"].ToString());
            cmd.Parameters.AddWithValue("@2", Session["Name"].ToString());

            dt.Columns.Add("UploadedFiles", typeof(string));
            dt.Columns.Add("DocumentType", typeof(string));

            foreach(string strFile in Directory.GetFiles(Server.MapPath("~/Images/Documents_Folder/")))
            {
                FileInfo fi = new FileInfo(strFile);
                dt.Rows.Add(fi.Name, GetFileTypeByExtension(fi.Extension));
            }
           
            sda.Fill(dt);

            grdview1.DataSource = dt;
            grdview1.DataBind();        
            cmd.ExecuteNonQuery();

            con.Close();



        }

        private string GetFileTypeByExtension(string extention)
        {
            switch (extention.ToLower())
            {
                case ".doc":
                case ".docx":
                    return "Microsoft Word File";

                case ".xlsx":
                case ".xls":
                    return "Microsoft Excel File";

                case ".png":
                case ".jpg":
                case ".jpeg":
                    return "Image";
                default:
                    return "Unknown";
            }
        }
        

        
        protected void grdview1_RowCommand(object sender, GridViewCommandEventArgs e)//download
        {
            if (e.CommandName == "Download")
            {
                Response.Clear();
                Response.ContentType = "application/octect-stream";
                Response.AppendHeader("Content-Disposition", "filename=" + e.CommandArgument);
                Response.TransmitFile(Server.MapPath("~/Images/Documents_Folder/") + e.CommandArgument);
                Response.End();
            }
        }
    }
}