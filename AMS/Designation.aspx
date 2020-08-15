<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Designation.aspx.cs" Inherits="WebApplication1.Designation"  MasterPageFile="~/AMS/Site1.Master"%>

<%--<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">--%>
<asp:Content ID="content1" ContentPlaceHolderID="Content" runat="server">
           <div>
               <div class="filter-box">
                   <div class="form-group">
                       <asp:Label ID="Label1" runat="server" Text="Designation ID"></asp:Label>
                       <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                   <div class="form-group">
                       <asp:Label ID="Label2" runat="server" Text="Designation Name"></asp:Label>
                       <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                    </div>
                   <div class="form-group btn-box">
                       <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" CssClass="btn" />         
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" CssClass="btn cancel" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" CssClass="btn cancel" />
                    </div>
                   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                </div>
                


                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [Designation]"></asp:SqlDataSource>
                
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="DesId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="DesId" HeaderText="DesId" InsertVisible="False" ReadOnly="True" SortExpression="DesId" />
                        <asp:BoundField DataField="DesName" HeaderText="DesName" SortExpression="DesName" />
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
                


                <asp:Label ID="lbloutput" runat="server" Text=""></asp:Label>

            </div>
                </asp:Content>
    <%--    </div>
    </form>
</body>
</html>--%>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style4 {
            width: 287px;
        }
    </style>
</asp:Content>

