<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grade.aspx.cs" Inherits="WebApplication1.Grade" MasterPageFile="~/AMS/Site1.Master"%>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="content8" ContentPlaceHolderID="Content" runat="server"> 
        
            <div class="filter-box">
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Grade ID"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label2" runat="server" Text="Grade Name"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                </div>
                <div class="form-group btn-box">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Grade" OnClick="btnAdd_Click" CssClass="btn" />
                    <asp:Button ID="btnUpdate" runat="server" Text="Update Grade" OnClick="BtnUpdate_Click"  CssClass="btn cancel" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete Grade" OnClick="btnDelete_Click" CssClass="btn cancel" />
                </div>
                <asp:Label ID="lbloutput" runat="server" Text=""></asp:Label>
            </div>
            <%--<table style="border-style: solid; background-color: #33CCFF; table-layout: fixed">--%>
                
                <%--<tr>
                    <td>
                      
                        </td>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <td>
                      
                    </td>
                 </tr>
                <tr>
                     <td>
                         <br />
                       
                     </td>
                     <td>
                       
                     </td>
                 </tr><br /><br /><br />
                <tr>--%>
                    <%--<td>
                        <asp:Button ID="btnShow" runat="server" Text="ShowAll" OnClick="btnShow_Click" />
                    </td>--%>
                   <%-- <td>
                        <br />
                        
                    </td>
                    <td>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        <br />
                        &nbsp;&nbsp;&nbsp;--%>
                        <%--<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Return" />--%>
                       <%-- &nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                </tr>
                
               
                

            
         </table>--%>
        
     <%--<br />--%>
     <asp:GridView ID="grdloadproperties" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="GradeID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="grdloadproperties_SelectedIndexChanged" CssClass="table">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="GradeID" HeaderText="GradeID" InsertVisible="False" ReadOnly="True" SortExpression="GradeID" />
                        <asp:BoundField DataField="GradeName" HeaderText="GradeName" SortExpression="GradeName" />
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [Grade]"></asp:SqlDataSource>
   </asp:Content>
    <%--</form>
     <br />

</body>
</html>--%>
