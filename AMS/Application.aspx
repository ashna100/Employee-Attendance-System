<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/MasterEmployee.Master" AutoEventWireup="true" CodeBehind="Application.aspx.cs" Inherits="WebApplication1.AMS.Application" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentEmployee" runat="server">
    <center>
    <div class="filter-box">
        <asp:ScriptManager ID="scriptmanager1" runat="server"></asp:ScriptManager>
        <div class="form-group">
            <asp:Label id="lbl1" runat="server" Text="Select Leave Type"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"  AutoPostBack="true">
                
            </asp:DropDownList>
            
        </div>
        <div class="form-group">
            Select From Date:
            <asp:TextBox ID="txtfrom" runat="server" TextMode="Date" placeholder="From Date" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtfrom" runat="server" Text="Select Date" ForeColor="Red"></asp:RequiredFieldValidator>
            
        </div>

        <div class="form-group">
            select Upto Date:
            <asp:TextBox ID="txtUpto" runat="server" TextMode="Date" placeholder="Upto Date" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="txtUpto" runat="server" Text="Select Date" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtfrom"  Operator="GreaterThanEqual" ControlToValidate="txtUpto"
                ErrorMessage="From Date Must be Smaller or equals to Upto Date" ForeColor="Red"></asp:CompareValidator>
            
        </div>

        <div class="form-group">
            <asp:Radiobutton ID="RadioButton1" runat="server" Text="Full Day" GroupName="grp1"  Font-Bold="true" Checked="True" />

            <asp:RadioButton ID="RadioButton2" runat="server" Text="Half Day" GroupName="grp1" Font-Bold="true" />
        </div>
        <div>
            Leave Purpose
            <asp:TextBox ID="txtPurpose" runat="server"  TextMode="MultiLine" placeholder="Leave Purpose" Height="61px" Width="234px"></asp:TextBox>
        </div>
    
        <div class="form-group btn-box">
            <asp:Button ID="btn1" runat="server" Font-Size="X-Large" Text="Submit" CssClass="btn" OnClick="btn1_Click" Height="51px" Width="306px" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblshow" runat="server" Font-Bold="true" Font-Size="X-Large"></asp:Label>

        </div>

            
        </div>
        </center>
</asp:Content>
