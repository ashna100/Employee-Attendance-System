<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OutdoorAttendance.aspx.cs" Inherits="WebApplication1.AMS.OutdoorAttendance" MasterPageFile="~/AMS/Site1.Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>


<asp:Content ID="Content12" ContentPlaceHolderID="Content" runat="server">
      <h2> <asp:Label ID="lblOutput" runat="server"></asp:Label></h2>
    <div>
        <div class="filter-box">
            <asp:HiddenField ID="hfUserID" runat="server" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

            <div class="form-group">
                <asp:Label ID="lblFromdate" Text="FromDate" runat="server"></asp:Label>
                <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtFrom" Format="dd-MM-yyyy" />
                <asp:CompareValidator runat="server" ID="CompareValidator2"
                    ErrorMessage="The From date must be less than upto Date"
                    ControlToValidate="txtFrom" ControlToCompare="txtUpto" Type="Date" Operator="LessThanEqual" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblUptoDate" Text="UptoDate" runat="server"></asp:Label>
                <asp:TextBox ID="txtUpto" runat="server"></asp:TextBox>
                <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtUpto" Format="dd-MM-yyyy" />
                <asp:CompareValidator runat="server" ID="cmp1"
                    ErrorMessage="The Upto date must be greater than From Date"
                    ControlToValidate="txtUpto" ControlToCompare="txtFrom" Type="Date" Operator="GreaterThanEqual" />
            </div>

            <div class="form-group">
                <asp:Label ID="lblIntime" Text="In-Time" runat="server"></asp:Label>
                <asp:TextBox ID="inTime" runat="server" TextMode="Time"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblOutTime" Text="Out-Time" runat="server"></asp:Label>
                <asp:TextBox ID="outTime" runat="server" TextMode="Time"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblRemarks" Text="Remarks" runat="server"></asp:Label>
                <asp:TextBox ID="TxtRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>

            <div class="form-group btn-box">
                <asp:Button ID="btnInsert" Text="Insert" runat="server" OnClick="btnInsert_Click" CssClass="btn"></asp:Button>
                <asp:Button ID="btnUpdate" Text="Update" runat="server" OnClick="btnUpdate_Click" CssClass="btn cancel"></asp:Button>

            </div>
                   </div>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" CssClass="table">
                <Columns>
                    <%--<asp:BoundField DataField="UserID" HeaderText="UserID" SortExpression="UserID" InsertVisible="False" ReadOnly="True" />--%>
                    <asp:BoundField DataField="FromDate" HeaderText="FromDate" SortExpression="FromDate" DataFormatString="{0:dd-MMM-yyyy}" HtmlEncode="False" />
                    <asp:BoundField DataField="UptoDate" HeaderText="UptoDate" SortExpression="UptoDate" DataFormatString="{0:dd-MMM-yyyy}" HtmlEncode="False" />
                    <asp:BoundField DataField="InTime" HeaderText="InTime" SortExpression="InTime" />
                    <asp:BoundField DataField="OutTime" HeaderText="OutTime" SortExpression="OutTime" />
                    <asp:BoundField DataField="Remarks" HeaderText="Remarks" SortExpression="Remarks" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="true" Font-Size="Large" OnClick="btnDelete_Click">Delete</asp:LinkButton>
                            <br />
                            <br />
                            <asp:Panel ID="Panel1" runat="server" BackColor="Yellow">
                                <div class="auto-style4" style="background-color: #FFFF66; font-weight: bold">
                                    Do you want to delete record?<br />
                                    <br />
                                    <asp:Button ID="Button1" runat="server" Text="Yes" Height="33px" Width="99px" />
                                    &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="No" Height="32px" Width="110px" />
                                </div>
                            </asp:Panel>
                            <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender1" runat="server" TargetControlID="LinkButton1" DisplayModalPopupID="ModalPopupExtender1" />
                            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" TargetControlID="LinkButton1" PopupControlID="Panel1" OkControlID="Button1" CancelControlID="Button2"></ajaxToolkit:ModalPopupExtender>

                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="true" Font-Size="Large" CommandArgument='<%# Eval("UserID")%>' OnClick="View_Click">View</asp:LinkButton>

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
            <br />
            <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" 
            SelectCommand="SELECT * FROM [OutDoorAttendance]" DeleteCommand="DELETE FROM [OutDoorAttendance] WHERE [UserID] = @UserID" 
            InsertCommand="INSERT INTO [OutDoorAttendance] ([FromDate], [UptoDate], [InTime], [OutTime], [Remarks]) VALUES (@FromDate, @UptoDate, @InTime, @OutTime, @Remarks)" 
            UpdateCommand="UPDATE [OutDoorAttendance] SET [FromDate] = @FromDate, [UptoDate] = @UptoDate, [InTime] = @InTime, [OutTime] = @OutTime, [Remarks] = @Remarks WHERE [UserID] = @UserID">
            <DeleteParameters>
                <asp:Parameter Name="UserID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter DbType="Date" Name="FromDate" />
                <asp:Parameter DbType="Date" Name="UptoDate" />
                <asp:Parameter DbType="Time" Name="InTime" />
                <asp:Parameter DbType="Time" Name="OutTime" />
                <asp:Parameter Name="Remarks" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter DbType="Date" Name="FromDate" />
                <asp:Parameter DbType="Date" Name="UptoDate" />
                <asp:Parameter DbType="Time" Name="InTime" />
                <asp:Parameter DbType="Time" Name="OutTime" />
                <asp:Parameter Name="Remarks" Type="String" />
                <asp:Parameter Name="UserID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>--%>
        </div>
</asp:Content>












<asp:Content ID="Content13" runat="server" ContentPlaceHolderID="head">
    <style type="text/css">
        .auto-style4 {
            text-align: center;
            height: 206px;
            width: 280px;
            margin-left: 0px;
        }
    </style>
</asp:Content>













