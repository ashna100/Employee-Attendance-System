<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MaritalStatus.aspx.cs" Inherits="WebApplication1.MaritalStatus" MasterPageFile="~/AMS/Site1.Master" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>

<asp:Content ID="Content10" ContentPlaceHolderID="Content" runat="server">
    <div>
        <div class="filter-box">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
           
            <div class="form-group">
                <asp:Label ID="label2" Text="Marital Status ID " runat="server"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <asp:Label ID="label1" Text="Marital Status " runat="server"></asp:Label>
                <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
            </div>

            <%--<tr>
                    <td>
                        <asp:Label ID="label1" runat="server" Text="Marital status"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server">
                         <asp:ListItem Value="-1">--Select--</asp:ListItem>
                         <asp:ListItem>married</asp:ListItem>
                         <asp:ListItem>unmarried</asp:ListItem>
                         <asp:ListItem>Single Parent</asp:ListItem>
                         <asp:ListItem>Divorce</asp:ListItem>
                         </asp:DropDownList>  
                    </td>
                </tr>--%>
            <div class="form-group btn-box">
                <asp:Button ID="BtnAdd" Text="Insert" runat="server" OnClick="BtnAdd_Click" CssClass="btn" />
                <asp:Button ID="BtnUpdate" Text="Update Status" runat="server" OnClick="btnupdate_click" CssClass="btn cancel" />
                <asp:Button ID="BtnDelete" Text="Delete Status" runat="server" OnClick="BtnDelete_Click" CssClass="btn cancel" />
            </div>
            </div>

            <label id="lblOutput" runat="server"></label>

            <asp:GridView ID="grdView1" runat="server"
                BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="MId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="grdView1_SelectedIndexChanged" CssClass="table">



                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="MId" HeaderText="MId" InsertVisible="False" ReadOnly="True" SortExpression="MId" />
                    <asp:BoundField DataField="MaritalStatus" HeaderText="MaritalStatus" SortExpression="MaritalStatus" />
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

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>"
                SelectCommand="SELECT * FROM [MaritalStatus]"
                DeleteCommand="DELETE FROM [MaritalStatus] WHERE [MId] = @MId"
                InsertCommand="INSERT INTO [MaritalStatus] (MaritalStatus) VALUES (@MaritalStatus)"
                UpdateCommand="UPDATE [MaritalStatus] SET [MaritalStatus] = @MaritalStatus WHERE [MId] = @MId"></asp:SqlDataSource>
            <%--<FooterTemplate>
<asp:TextBox ID="txtpname" runat="server" />
</FooterTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText = "Marital Status">
<ItemTemplate>
<Drop ID="lblPrice" runat="server" Text='<%# Eval("price")%>'></Drop>--%>
        </div>
</asp:Content>
<%--    </form>
</body>
</html>--%>
