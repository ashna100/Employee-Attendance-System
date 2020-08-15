<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/MasterEmployee.Master" AutoEventWireup="true" CodeBehind="EmployeeDocument.aspx.cs" Inherits="WebApplication1.AMS.EmployeeDocument" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentEmployee" runat="server">
    <asp:GridView ID="grdview1" runat="server"  EmptyDataText="No files Found"  CssClass="table" CellPadding="2" Height="231px" Width="1047px" AutoGenerateColumns="False" OnRowCommand="grdview1_RowCommand" >
        <Columns>
            <asp:TemplateField HeaderText="Document">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("UploadedFiles") %>' CommandName="Download" Text='<%# Eval("UploadedFiles") %>'></asp:LinkButton>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:BoundField HeaderText="Document Type" DataField="DocumentType">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
       
        
    </asp:GridView>
    </asp:Content>
