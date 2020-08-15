<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WeekOff.aspx.cs" Inherits="WebApplication1.AMS.WeekOff" MasterPageFile="~/AMS/Site1.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="Content14" ContentPlaceHolderID="Content" runat="server">

    <div class="filter-box">
        <asp:HiddenField ID="hfDateID" runat="server" />
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         <div class="form-group">
             <asp:Label ID="lblWeekOff" Text="WeekOFF" runat="server"></asp:Label>
             <asp:TextBox ID="txtweekoff" runat="server"></asp:TextBox>
                    <ajaxtoolkit:calendarextender id="CalendarExtender1" targetcontrolid="txtweekoff" runat="server" format="dd-MM-yyyy" />
             </div>
        <div class="form-group btn-box">
            <asp:Button ID="btnInsert" Text="Insert" runat="server" CssClass="btn"></asp:button>
            <asp:Button ID="btnUpdate" Text="Update" runat="server" CssClass="btn cancel"></asp:Button>
             </div>
        <label id="lblOutput" runat="server" style="background-color: #FFFFFF; border-color: #FF00FF"></label>
        </div>
        <%--<table style="border-style: solid; background-color: #33CCFF; table-layout: fixed" class="auto-style4">
            
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
           <td>
                <br />
                
            </td>
            
        </tr>
            
            
        </table>
                  <br />--%>


                  <asp:GridView ID="GridView1" runat="server"   AutoGenerateColumns="False"   CellPadding="4"  ForeColor="#333333" GridLines="None" CssClass="table" >
             <AlternatingRowStyle BackColor="White" />
             <Columns>
                 <%--<asp:CommandField ShowSelectButton="True" />--%>
                 <%--<asp:CommandField HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" ShowSelectButton="True"  />--%>
                 <%--<asp:CommandField ShowSelectButton="True" />--%>
                
                 <asp:TemplateField>
                     <ItemTemplate>
                         <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="true" CommandArgument='<%# Eval("DateID")%>' OnClick="GridView1_SelectedIndexChanged">View</asp:LinkButton>
                     </ItemTemplate>
                 </asp:TemplateField>
                
                 <asp:TemplateField>
                     <ItemTemplate>
                         <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="true"   OnClick="btnDelete_Click">Delete</asp:LinkButton>
                         <asp:Panel ID="Panel1" runat="server" Height="81px" BackColor="Yellow">
                             Do you want to delete?<br />
                             <br />
                             <asp:Button ID="Button1" runat="server" Text="Yes" />
                             &nbsp;&nbsp;&nbsp;&nbsp;
                             <asp:Button ID="Button2" runat="server" Text="No" />
                         </asp:Panel>
                          <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" TargetControlID="LinkButton1"  DisplayModalPopupID="ModalPopupExtender1" />
                        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  TargetControlID="LinkButton1" PopupControlID="Panel1" OkControlID="Button1" CancelControlID="Button2"></ajaxToolkit:ModalPopupExtender>

                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:BoundField DataField="WeekOffDate" HeaderText="WeekOff Date" SortExpression="WeekOffDate" DataFormatString="{0:dd-MMM-yyyy}" HtmlEncode="False"/>
             </Columns>
             <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
             <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
             <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
             <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
             <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
             <SortedAscendingCellStyle BackColor="#FDF5AC" />
             <SortedAscendingHeaderStyle BackColor="#4D0000" />
             <SortedDescendingCellStyle BackColor="#FCF6C0" />
             <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
         

    </div>
</asp:Content>
<%--</form>
</body>
</html>--%>
