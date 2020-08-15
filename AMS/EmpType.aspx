<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpType.aspx.cs" Inherits="WebApplication1.EmpType" MasterPageFile="~/AMS/Site1.Master" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>

<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
       
        <div class="filter-box">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div class="form-group">
                 <asp:Label ID="label3" runat="server" Text="Enter employee id" ></asp:Label>
                  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
<asp:Label ID="label1" runat="server" Text="Enter employee type" ></asp:Label>
                 <asp:TextBox ID="txtEmpType" runat="server"></asp:TextBox>   
            </div>
            <div class="form-group btn-box">
 <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Insert" CssClass="btn"/>
              <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Update" CssClass="btn cancel"/>    
                <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Delete" CssClass="btn cancel" />
            </div>
        </div>   

                   <%--<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Return" />--%>
                 
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" 
       SelectCommand="SELECT * FROM [EmpType]" >
        </asp:SqlDataSource>
        
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="EmpId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="EmpId" HeaderText="EmpId" InsertVisible="False" ReadOnly="True" SortExpression="EmpId" />
                <asp:BoundField DataField="EmployeeType" HeaderText="EmployeeType" SortExpression="EmployeeType" />
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

        
             <br />
        <br />
    
    
        <asp:Label ID="lblOutput" runat="server" ></asp:Label>

             
           </asp:Content> 
    <%--         </form>
    
        </body>
</html>--%>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style4 {
            width: 503px;
            height: 201px;
        }
    </style>
</asp:Content>

