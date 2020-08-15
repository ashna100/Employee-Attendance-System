<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/MasterEmployee.Master" AutoEventWireup="true" CodeBehind="EmployeeHolidays.aspx.cs" Inherits="WebApplication1.AMS.EmployeeHolidays" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentEmployee" runat="server">
    <center>
       <div>
           <asp:GridView width="80%" ID="GridView1" runat="server" CssClass="table"></asp:GridView>
       </div>
   </center>
</asp:Content>
