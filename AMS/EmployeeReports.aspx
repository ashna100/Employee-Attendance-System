<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/MasterEmployee.Master" AutoEventWireup="true" CodeBehind="EmployeeReports.aspx.cs" Inherits="WebApplication1.AMS.EmployeeReports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentEmployee" runat="server">
    <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>
    <%--<asp:UpdatePanel ID="UpdatePanel" runat="server">--%>

        
             <div class="filter-box">
        
            <table align="center" runat="server">
                <tr>
                    <td align="center">
                        Select:&nbsp
                        <asp:dropdownlist id="drpmonth" runat="server" >
                                <asp:ListItem>Select</asp:ListItem>
                                <asp:ListItem Value="1">January</asp:ListItem>
                                <asp:ListItem Value="2">February</asp:ListItem>
                                <asp:ListItem Value="3">March</asp:ListItem>
                                <asp:ListItem Value="4">April</asp:ListItem>
                                <asp:ListItem Value="5">May</asp:ListItem>
                                <asp:ListItem Value="6">June</asp:ListItem>
                                <asp:ListItem Value="7">July</asp:ListItem>
                                <asp:ListItem Value="8">August</asp:ListItem>
                                <asp:ListItem Value="9">September</asp:ListItem>
                                <asp:ListItem Value="10">October</asp:ListItem>
                                <asp:ListItem Value="11">November</asp:ListItem>
                                <asp:ListItem Value="12">December</asp:ListItem>
                            </asp:dropdownlist>
                    </td>

                    <td align="center">
                        Year:<asp:textbox id="txtDate" runat="server" placeholder="Enter Year"></asp:textbox>
                    </td>
                

                    <td align="center" colspan="2">
                        <asp:button id="btnreport" runat="server" cssclass="btn-box"
                            text="Report" onclick="btnreport_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:label id="lblShow" runat="server" ForeColor="Red" Font-Bold="true"></asp:label>
                        <asp:label id="lblDays" runat="server"></asp:label>
                    </td>
                </tr>
                </table>
                </div>

             <div align="center">
                       <asp:gridview id="Gridview1" runat="server"  cssclass="table" width="100%" emptydatatext="No Record Found">
                        </asp:gridview>
             </div>
    
    
<%--</asp:UpdatePanel>--%>

</asp:Content>
