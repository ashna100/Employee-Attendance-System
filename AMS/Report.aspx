<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="WebApplication1.AMS.Report" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridview1"  runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="EMP ID"></asp:TemplateField>
                    <asp:TemplateField HeaderText="EMP Name"></asp:TemplateField>
                    <asp:TemplateField HeaderText="EMP Designation"></asp:TemplateField>
                    <asp:TemplateField HeaderText="EMP Department"></asp:TemplateField>
                    <asp:TemplateField HeaderText="Date"></asp:TemplateField>
                    <asp:TemplateField HeaderText="InTime"></asp:TemplateField>
                    <asp:TemplateField HeaderText="OutTime"></asp:TemplateField>
                    <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="Delete" ShowHeader="True" Text="Delete" />
                     <asp:ButtonField ButtonType="Button" CommandName="Edit" HeaderText="Edit" ShowHeader="True" Text="Edit" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
