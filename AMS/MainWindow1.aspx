<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainWindow1.aspx.cs" Inherits="WebApplication1.MainWindow" MasterPageFile="~/AMS/Site1.Master" %>


<asp:Content ID="content1" ContentPlaceHolderID="Content" runat="server">
        <%--<div>--%>
        <%-- <p class="auto-style3"> --%> 
        <%--<img alt="AMS" class="auto-style2" src="../Images/AMS%20logo.png" /></p>--%>

            <%--<asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem NavigateUrl="HomePage.aspx" Text="Master" Value="Master"></asp:MenuItem>
                    <asp:MenuItem NavigateUrl="Registeration.aspx" Text="User Management" Value="User Management"></asp:MenuItem>
                </Items>
                <StaticHoverStyle BackColor="#99FF66" ForeColor="#990033" />
                <StaticMenuItemStyle BackColor="#0033CC" ForeColor="#FFFF99" HorizontalPadding="70px" VerticalPadding="10px" />
            </asp:Menu>--%>

            <%--<table>
                <tr>
                    <td>--%>
                          <%--<asp:Button ID="master" Text="Master" runat="server" OnClick="master_Click" />--%>
                    <%--</td>
                    <td>--%>
                       <%-- &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;--%>
                        <%--<asp:Button ID="User" Text="User Management" runat="server" OnClick="User_Click" />--%>
                    <%--</td>
                </tr>
            </table>--%>
          
        <%--</div>--%>
    </asp:Content>
    <%--</form>
    </body>
</html>--%>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2 {
            height: 68px;
            width: 656px;
        }
        .auto-style3 {
            height: 367px;
        }
       body {
        background: url(../images/bg1.jpg) no-repeat;
        background-size: cover;
    }
    .footer {
    position: fixed;
    background: rgba(0, 0, 0, .4) !important;
    width: 100%;
    text-align: center;
    padding: 12px;
    bottom: 0px;
    color: #fff;
}
    .welcome-msg {
    display:block !important;
}
    </style>
</asp:Content>

