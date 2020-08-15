using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1.AMS
{
    public partial class EmployeeHolidays : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = ConfigurationManager.ConnectionStrings["infoConnectionString"].ConnectionString;
            SqlDataAdapter sda = new SqlDataAdapter("Select HolidayType as Holidays, convert(varchar,cast(convert(varchar(10), FromDate, 110)as DateTime), 106) as FromDate from Holidays", str);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}