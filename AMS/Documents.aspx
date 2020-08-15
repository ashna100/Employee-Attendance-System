<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/Site1.Master" AutoEventWireup="true" CodeBehind="Documents.aspx.cs" Inherits="WebApplication1.AMS.Documents" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="filter-box">
        <div class="form-group">
            <b>Employee Name:</b>
            <asp:DropDownList ID="drpdown1" runat="server" AutoPostBack="true"></asp:DropDownList>
        </div>
        <div class="form-group">
           <b>Document Type</b>
            <asp:TextBox ID="txtDoc"  runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:fileupload ID="fileupload1" runat="server"></asp:fileupload>
        </div>
        <div class="form-group btn-box">
            <asp:Button  ID="btn1" runat="server" Text="Submit" cssClass="btn" OnClick="btn1_Click" />
        </div>
        <asp:Label ID="lblAlert" runat="server" ForeColor="Red"></asp:Label>
          <asp:Label ID="Label1" runat="server" ForeColor="green" Font-Bold="true"></asp:Label>
    </div>
</asp:Content>
