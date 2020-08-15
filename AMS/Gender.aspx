<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gender.aspx.cs" Inherits="WebApplication1.Gender" MasterPageFIle="~/AMS/Site1.Master" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="content7" ContentPlaceHolderID="Content" runat="server"> 
        <div>
            <div class="filter-box">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="form-group">
                    <asp:Label ID="label1" runat="server" Text="Gender ID"></asp:Label>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    </div>
                <div class="form-group">
                    <asp:Label ID="label2" runat="server" Text="Enter Gender"></asp:Label>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                    </div>
                <div class="form-group btn-box">
                    <asp:Button ID="BtnAdd" Text="Add" runat="server" OnClick="BtnAdd_Click" CssClass="btn"/>
                    <asp:Button ID="BtnUpdate" Text="Update" runat="server" OnClick="BtnUpdate_Click" CssClass="btn cancel"/>
                    <asp:Button ID="BtnDelete" Text="Delete" runat="server" OnClick="BtnDelete_Click" CssClass="btn cancel"/>
                    </div>
                </div>
           <%-- <table style="border-style: solid; background-color: #33CCFF; table-layout: fixed">
                
                <tr>
                    <td>
                        
                    </td>
                    <td>
                        
                    </td>
                </tr>
               <tr>
                    <td>
                        <br />
                        
                    </td>
                    <%--<td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                         <asp:ListItem Value="-1">--Select--</asp:ListItem>
                         <asp:ListItem>Male</asp:ListItem>
                         <asp:ListItem>Female</asp:ListItem>
                         <asp:ListItem>Transgender</asp:ListItem>
                         </asp:DropDownList>  
                    </td>--%>
                     <%--<td>
                        
                     </td>
                </tr>
         
                
                <tr>--%>
                    <%-- <td>
                        <asp:Button ID="btn1" Text="Show All" runat="server" OnClick="btn1_Click" />
                    </td>&nbsp &nbsp &nbsp &nbsp--%>
                   <%-- <td>
                        <br />
                        
                        <br />
                        <br />
                    </td>&nbsp &nbsp &nbsp &nbsp
                      <td>
                        &nbsp;
                    </td>&nbsp &nbsp &nbsp &nbsp
                    <td>
                        
                    </td>&nbsp &nbsp &nbsp &nbsp
                    <td>
                        <br />
                        <br />--%>
                        <%--<asp:Button ID="btnReturn" Text="Return" runat="server" OnClick="btnReturn_Click" />--%>
                        <%--<br />
                        <br />
                    </td>
                </tr>
                
                      </table>    
                 <br />
            <br />--%>

                 <asp:GridView ID="grdView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="GenderId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GrdView1_SelectedIndexChanged" CssClass="table">         
                     <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="GenderId" HeaderText="GenderId" InsertVisible="False" ReadOnly="True" SortExpression="GenderId" />
                <asp:BoundField DataField="GenderName" HeaderText="GenderName" SortExpression="GenderName" />
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
                    
                
                
            
            <label id="lblOutput" runat="server"></label>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>"      SelectCommand="SELECT * FROM [Gender]">
            </asp:SqlDataSource>
       </asp:Content>
<%--    </form>
</body>
</html>--%>
