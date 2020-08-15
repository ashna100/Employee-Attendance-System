<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="WebApplication1.Department" MasterPageFile="~/AMS/Site1.Master" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="Content1" ContentPlaceHolderID="Content"  runat="server">
     <div class="filter-box">
         <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Department ID"></asp:Label>
                <asp:TextBox ID="lblDept" runat="server"></asp:TextBox>
            </div>
         <div class="form-group">
             <asp:Label ID="Label2" runat="server" Text="name"></asp:Label>
             <asp:TextBox ID="lblName" runat="server"></asp:TextBox>
            </div>
         <div class="form-group btn-box">
             <asp:Button ID="btnAdd" runat="server" OnClick="btnNew_Click" Text="Add" CssClass="btn"/>
             <asp:Button ID="btnUpdate" runat="server" OnClick="Button2_Click" Text="Update" CssClass="btn cancel"/>
             <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" CssClass="btn cancel"/>
            </div>
    </div>
    
       <%-- <table style="border-style: solid; background-color: #33CCFF; table-layout: fixed">
            
            <tr>
                <td>
                    
                </td>
                &nbsp;
             <td>
                 
             </td>
            </tr>
            <br />
            <br />

            <tr>
                <td>
                    <br />
                    
                </td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
               <td>
                   
               </td>
            </tr>
            
            <tr>
                <td>
                    <br />
                    <br />
                    <br />
                    
                </td>
                &nbsp;&nbsp;&nbsp;
             <td>
                 <br />
                 <br />
                 <br />
                 
             </td>
                &nbsp;&nbsp;&nbsp;
             <td>
                 <br />
                 <br />
                 <br />
                 
             </td>
                &nbsp;&nbsp;&nbsp;
               
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <%--<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Return" />--%>
                  
               <%-- </td>
                </tr>
                &nbsp;&nbsp;&nbsp;
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
            </tr>
            </table>



                <br />--%>



                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="DeptId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowPaging="True" CssClass="table">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="DeptId" HeaderText="DeptId" InsertVisible="False" ReadOnly="True" SortExpression="DeptId" />
                        <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
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



                <asp:Label ID="lbloutput" runat="server" Text=""></asp:Label><br /><br />
             
           
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [Department]">

        </asp:SqlDataSource>
   </asp:Content>
    <%--    </form>
       
</body>
</html>--%>
