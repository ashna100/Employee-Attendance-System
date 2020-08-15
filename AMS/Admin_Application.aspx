<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/Site1.Master" AutoEventWireup="true" CodeBehind="Admin_Application.aspx.cs" Inherits="WebApplication1.AMS.Admin_Application" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="filter-box">
        
    
    <asp:GridView ID="grdview1" runat="server" CssClass="table" DataFormatString="{0:dd-MM-yyyy}" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="Approval">
                <ItemTemplate>
                    <asp:CheckBox ID="CheckBox1" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="ApplicationID" HeaderText="Applicant ID" />
            <asp:BoundField DataField="FirstName" HeaderText="Employee Name" />
            <asp:BoundField DataField="Purpose" HeaderText="Purpose" />
            <asp:BoundField DataField="FromDate" HeaderText="From Date" />
            <asp:BoundField DataField="UptoDate" HeaderText="Upto Date" />
            <asp:BoundField DataField="LeaveType" HeaderText="Leave Type" />
        </Columns>
    </asp:GridView>
    
    <div class="form-group btn-box" style="text-align: center">
        <asp:Button ID="btn1" runat="server" CssClass="btn" Text="Submit" Width="174px" OnClick="btn1_Click" />
    </div>
   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>"
        SelectCommand="select ApplicationID, FirstName, Purpose, FromDate, UptoDate, LeaveType  from Application_Details where Approval='N'"></asp:SqlDataSource>
    
            <asp:Label ID="lbl1" ForeColor="SlateBlue" Font-Bold="true" Font-Size="X-Large" runat="server"></asp:Label>
    </div>
</asp:Content>
