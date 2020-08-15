<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportingManager.aspx.cs" Inherits="WebApplication1.AMS.ReportingManager" MasterPageFile="~/AMS/Site1.Master" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    --%>   
<asp:Content ID="Content12" ContentPlaceHolderID="Content" runat="server">
    <div>

        <div class="filter-box">
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                   <div class="form-group">
            <asp:Label ID="label2" Text=" Reporting Manager ID" runat="server"></asp:Label>&nbsp &nbsp &nbsp &nbsp
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
                       </div>

                   <div class="form-group">
            <asp:Label ID="label1" Text="Enter Reporting Manager Name" runat="server"></asp:Label>&nbsp &nbsp &nbsp &nbsp &nbsp
           <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            
                       </div>
            <div class="form-group btn-box">
             <%--<asp:Button ID="btnReturn" Text="Return" runat="server" OnClick="btnReturn_Click" />&nbsp &nbsp &nbsp &nbsp--%>
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="insert" CssClass="btn" />
             <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" CssClass="btn cancel"/>
             <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" CssClass="btn cancel"/>
               
                </div>

            </div>
                           <label id="lblOutput" Text="label" runat="server"> </label>
             <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  CellPadding="4" GridLines="None" AllowPaging="True" DataSourceID="SqlDataSource1" ForeColor="#333333" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table">  
                 <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="ManagerID" HeaderText="ManagerID" SortExpression="ManagerID" />
                    <asp:BoundField DataField="ManagerName" HeaderText="ManagerName" SortExpression="ManagerName" />
                </Columns>
                <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#333333" HorizontalAlign="Center" BackColor="#FFCC66" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
            <br />
            <br />
            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" 
                SelectCommand="SELECT * FROM [ReportingManager]">
               
            </asp:SqlDataSource>
            <br />
        </div>

    

        </div>
    </asp:Content>
    <%--</form>
</body>
</html>--%>
