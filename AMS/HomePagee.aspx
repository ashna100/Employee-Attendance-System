<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePagee.aspx.cs" Inherits="WebApplication1.AMS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #menu{
            margin:0px;
            
              
        }

        #menu ul{
            padding: 0;
            list-style: none;
        }
        #menu ul li{
            float: left;
            text-align: center;
            width: 120px;
            margin: 1px;
            position:relative;
        }

        #menu ul li a{
            color:#e85151;
            text-decoration:none;
            font-family:Calibri;
            background:#00ff90;
            display:block;
            padding: 10px;
        }
        #menu ul li a:hover{
            background:#0e0;
            color:black;
        }
        #menu ul li ul{
            display:none;
        }
        #menu ul li:hover ul{
            display:block;
        }
        #menu ul ul{
            position:absolute;

        }
        #menu ul li > ul li{
            background:#3ebfdc;
            color:#d1ce1f;
            border:solid 1px white;
        }
 

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
        <div id="menu">
                <ul>
                    <li><a href="#">Home</a></li>
                    <li><a href="#">About</a></li>
                    <li><a href="#">Master Pages</a>&nbsp;,<ul>
                            <li><a href="BloodGroup.aspx">Blood Group</a></li>
                            <li><a href="City.aspx">City</a></li>
                            <li><a href="Country.aspx">Country</a></li>
                            <li><a href="Department.aspx">Department</a></li>
                            <li><a href="Designation.aspx">Designation</a></li>
                            <li><a href="EmpType.aspx">Employee Type</a></li>
                            <li><a href="Gender.aspx">Gender</a></li>
                            <li><a href="Holidays.aspx">Holiday</a></li>
                            <li><a href="MaritalStatus.aspx">Marital Status</a></li>
                            <li><a href="Grade.aspx">Grade</a></li>
                            <li><a href="State.aspx">State</a></li>
                            <li><a href="ReportingManager.aspx">Reporting Manager</a></li>
                        </ul>
                    </li>
                    <li><a href="#">User Management</a>
                        <ul>
                            <li><a href="Registeration.aspx">User Registration</a></li>
                        </ul>
                    </li>
                    <li><a href="#">Contact Us</a></li>
                </ul>
            </div>
            </header>
        
        <%--<footer>
            <div style="font-weight: bold; color: #FFFFFF; background-color: #3399FF">


            Copyright @Ashna Khanna<br />
        </div>

        </footer>
        --%>    
    </form>
</body>
</html>
