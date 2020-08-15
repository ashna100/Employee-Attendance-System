<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveAssign.aspx.cs" Inherits="WebApplication1.AMS.LeaveAssign" MasterPageFile="~/AMS/Site1.Master" %>


<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="Content14" ContentPlaceHolderID="Content" runat="server">

    <h2>
        <asp:Label ID="lblOutput" runat="server" BackColor="White" BorderColor="#CC0066" BorderStyle="Ridge"></asp:Label></h2>
    <div>
        <div class="filter-box">
            <asp:HiddenField ID="hfUserID" runat="server" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <div class="form-group">
                <asp:Label ID="lblFromdate" Text="FromDate" runat="server"></asp:Label>
                <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFrom" Format="dd-MM-yyyy" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblUptoDate" Text="UptoDate" runat="server"></asp:Label>
                <asp:TextBox ID="txtUpto" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtUpto" Format="dd-MM-yyyy" />
                <asp:CompareValidator runat="server" ID="cmp1"
                    ErrorMessage="The Upto date must be greater than From Date"
                    ControlToValidate="txtUpto" ControlToCompare="txtFrom" Type="Date" Operator="GreaterThan" />
            </div>
            <div class="form-group">
                <asp:Label ID="lblLeaveName" Text="Leave Type" runat="server"></asp:Label>
                <asp:TextBox ID="txtleave" runat="server"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblRemarks" Text="Remarks" TextMode="multiline" runat="server"></asp:Label>
                <asp:TextBox ID="txtRemarks" runat="server"></asp:TextBox>
            </div>

            <div class="form-group btn-box">
                <asp:Button ID="btnInsert" Text="Insert" runat="server" OnClick="btnInsert_Click" CssClass="btn"></asp:Button>
                <asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="btnUpdate_Click" CssClass="btn cancel"></asp:Button>
            </div>
        </div>



        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="3" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellSpacing="2" CssClass="table">
            <Columns>
                <asp:BoundField DataField="FromDate" HeaderText="FromDate" SortExpression="FromDate" DataFormatString="{0:dd-MM-yyyy}" />
                <asp:BoundField DataField="UptoDate" HeaderText="UptoDate" SortExpression="UptoDate" DataFormatString="{0:dd-MM-yyyy}" />
                <asp:BoundField DataField="LeaveType" HeaderText="LeaveType" SortExpression="LeaveType" />
                <asp:BoundField DataField="Remarks" HeaderText="Remarks" SortExpression="Remarks" />
                <asp:TemplateField ShowHeader="False">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="btndelete_click" Text="Delete"></asp:LinkButton>
                        <asp:Panel ID="Panel1" runat="server" BackColor="#99FF33" Height="89px" Width="311px">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Do you want to delete?<br />
                            <br />
                            &nbsp;
                                <asp:Button ID="Button1" runat="server" Text="yes" Height="36px" Width="133px" OnClick="btndelete_click" />
                            &nbsp;&nbsp;
                                <asp:Button ID="Button2" runat="server" Text="No" Height="36px" Width="121px" />
                        </asp:Panel>
                        <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" TargetControlID="LinkButton1" DisplayModalPopupID="ModalPopupExtender1" />
                        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="LinkButton1" PopupControlID="Panel1" OkControlID="Button1" CancelControlID="Button2"></ajaxToolkit:ModalPopupExtender>

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ShowHeader="False">

                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="true" Font-Size="Large" CommandArgument='<%# Eval("UserID")%>' OnClick="GridView1_SelectedIndexChanged">View</asp:LinkButton>

                    </ItemTemplate>
                </asp:TemplateField>

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

    </div>
</asp:Content>
<%--</form>
</body>
</html>--%>
<asp:Content ID="Content15" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .auto-style4 {
            margin-top: 44px;
        }
    </style>
</asp:Content>

