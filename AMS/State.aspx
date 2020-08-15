<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="State.aspx.cs" Inherits="WebApplication1.State" MasterPageFile="~/AMS/Site1.Master"%>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="Content13" ContentPlaceHolderID="Content" runat="server">
        <div>
            <div class="filter-box">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="form-group">
                    <asp:label ID="label1" runat="server" Text="Select Country"></asp:label>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CountryName" DataValueField="CountryId">
                        </asp:DropDownList>
                    </div>
                <div class="form-group">
                    <asp:Label ID="lblState0" runat="server" Text="State ID"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </div>
                <div class="form-group">
                    <asp:Label ID="lblState" runat="server" Text="State Name"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                <div class="form-group btn-box">
                    <asp:Button ID="btnAdd" runat="server" Text="Add State" OnClick="btnAdd_Click" CssClass="btn" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Update State" OnClick="btnUpdate_Click" CssClass="btn cancel" />
                        <asp:Button ID="btnDelete" runat="server" Text="Delete State" OnClick="btnDelete_Click" CssClass="btn cancel" />
                    </div>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [country1]"></asp:SqlDataSource>
             

                <asp:Label ID="lbloutput" runat="server" Text=""></asp:Label>
                </div>
              
                
              <asp:GridView ID="grdloadproperties" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" 
                  BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="StateId" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="grdloadproperties_SelectedIndexChanged" CssClass="table">
                  <Columns>
                      <asp:CommandField ShowSelectButton="True" />
                      <asp:BoundField DataField="StateId" HeaderText="StateId" InsertVisible="False" ReadOnly="True" SortExpression="StateId" />
                      <asp:BoundField DataField="StateName" HeaderText="StateName" SortExpression="StateName" />
                      <asp:BoundField DataField="CountryName" HeaderText="CountryName" SortExpression="CountryName" />
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
                
              <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>"
              SelectCommand="SELECT [StateId], [StateName], [CountryName] FROM [State]"></asp:SqlDataSource>
                
         </div>
    </asp:Content>
    <%--</form>
</body>
</html>--%>
<asp:Content ID="Content14" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style4 {
            height: 37px;
        }
    </style>
</asp:Content>

