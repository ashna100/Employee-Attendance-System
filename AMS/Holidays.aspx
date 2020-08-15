<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/AMS/Holidays.aspx.cs" Inherits="WebApplication1.Holidays" MasterPageFile="~/AMS/Site1.Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<%--<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <link rel="stylesheet" href="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/themes/smoothness/jquery-ui.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>


    <style type="text/css">
        #form1 {
            height: 292px;
        }
    </style>
    <script>
         $(function () {
             $("#txtFrom").datepicker({
                 
                 numberOfMonths:1,
                 dateFormat: 'dd/mm/yy',
                 //ChangeMonth: true,
                 //ChangeYear: true,
                 //yearRange: "1950-2030",
                 onSelect: function (selectdate) {
                     var dt = new Date(selectdate);
                     dt.setDate(dt.getDate()+1)
                     $("#txtUpto").datepicker("option", "minDate", dt);
                 }
             });

             $("#txtUpto").datepicker({
                
                 numberOfMonths: 1,
                 dateFormat: 'dd/mm/yy',
                 //ChangeMonth: true,
                 //ChangeYear: true,
                 //yearRange: "1950-2030",
                 onSelect: function (selectdate) {
                     var dt = new Date(selectdate);
                     dt.setDate(dt.getDate() - 1)
                     $("#txtFrom").datepicker("option", "maxDate", dt);
                 }

             });
         });
    </script>

</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="Content9" ContentPlaceHolderID="Content" runat="server">
    <asp:ScriptManager ID="sm1" runat="server"></asp:ScriptManager>
    <%-- <head>
        <script>
            function compareDates() {
                var txtFrom = new Date(document.getElementById('txtFrom').value);
                var txtUpto = new Date(document.getElementById('txtUpto').value);
                var result;
                if (txtFrom > txtUpto) {
                    result = "From date must be less than Upto Date";
                    document.getElementById("lblOutput").style.color = 'green';
                }
                else {
                    result = "PLease select the dates";
                    document.getElementById("lblOutput").style.color = 'red';
                }

            }
        </script>
    </head>--%>
    <div>

        <div class="filter-box">
            <div class="form-group">
                 <asp:Label ID="label4" Text="Enter Holiday ID" runat="server" ></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>

            <div class="form-group">
                <asp:Label ID="label1" Text="Enter Holiday Name" runat="server"></asp:Label>
                <asp:TextBox ID="txtHoliday" runat="server"></asp:TextBox>
                </div>

            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="From Date (dd-mm-yyyy)"></asp:Label>
                 <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                        ControlToValidate="txtFrom" Display="Dynamic"
                        ErrorMessage="Select Date"></asp:RequiredFieldValidator>

                    <asp:CompareValidator runat="server" ID="cmp1"
                        ErrorMessage="The Upto date must be greater than From Date"
                        ControlToValidate="txtUpto" ControlToCompare="txtFrom" Type="Date" Operator="GreaterThanEqual" />
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFrom" Format="dd-MM-yyyy" />

                </div>

            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Upto Date (dd-mm-yyyy)"></asp:Label>
                <asp:TextBox ID="txtUpto" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                        ControlToValidate="txtUpto" Display="Dynamic"
                        ErrorMessage="Select Upto Date"></asp:RequiredFieldValidator>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtUpto" Format="dd-MM-yyyy" />

                </div>
             <div class="form-group btn-box">
                <asp:Button ID="Button2" runat="server" Text="Insert" OnClick="Button2_Click" CssClass="btn" />
                    <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" CssClass="btn cancel" />
                
                    <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" CssClass="btn cancel" />
            </div>
            <asp:Label ID="lblOutput" runat="server"  ></asp:Label>
     
            </div>

    

        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="HolidayID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="HolidayID" HeaderText="Holiday ID" InsertVisible="False" ReadOnly="True" SortExpression="HolidayID" />
                <asp:BoundField DataField="HolidayType" HeaderText="Holiday Type" SortExpression="HolidayType" />
                <asp:BoundField DataField="FromDate" HeaderText="From Date" SortExpression="FromDate" DataFormatString="{0:dd-MM-yyyy}" HtmlEncode="False" />
                <asp:BoundField DataField="UptoDate" HeaderText="Upto Date" SortExpression="UptoDate" DataFormatString="{0:dd-MM-yyyy}" HtmlEncode="False" />
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />
        </asp:GridView>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [Holidays]"></asp:SqlDataSource>

    </div>
    <br />
    <br />

</asp:Content>

<%-- </form>
</body>
</html>--%>
