<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResetPassword.aspx.cs" Inherits="WebApplication1.AMS.ResetPassword" MasterPageFile="~/AMS/Site1.Master" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 26%;
            height: 196px;
            margin-left: 178px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">--%>
      <asp:Content ID="Content18" ContentPlaceHolderID="Content" runat="server">
          <div class="login-box">
          <div class="auto-style1">
            <h2>RESET PASSWORD</h2></div>
        
       <asp:Panel ID="Panel1" runat="server" Visible="false">
           &nbsp;&nbsp;<img src="../Images/download.jpg" class="auto-style2"/></asp:Panel>

        <asp:Panel ID="Panel_reset_pwd" runat="server" Visible="false">
            <table class="style1">
                <tr>
                    <td class="style2">
                        Enter Your New Password:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txt_pwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                            ControlToValidate="txt_pwd" ErrorMessage="Reqiired"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        Retype Password</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txt_retype_pwd" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                            ControlToValidate="txt_retype_pwd" ErrorMessage="Required"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server"
                            ControlToCompare="txt_pwd" ControlToValidate="txt_retype_pwd"
                            ErrorMessage="Enter Same Password"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="btn_change_pwd" runat="server" 
                            Text="Change Password"  OnClick="btn_change_pwd_Click"/>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="RedirectLogin" runat="server" Text="Login" OnClick="RedirectLogin_Click" Visible="false" />
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                       </td>
                    <td class="auto-style1">
                        <asp:Label ID="lbl_msg" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
       
        </asp:Panel>
              </div>
    
    
            <%--<table class="auto-style2" style="background-color: #99FF66">
                <tr>
                    <td class="auto-style3">New Password</td>
                    <td>
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Confirm Password</td>
                    <td>
                        <asp:TextBox ID="txtConfirmPass" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" ForeColor="#FF5050" Text="New password and confirm password does not match"></asp:Label>
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Reset Password" />
                    </td>
                </tr>
            </table>--%>
            

</asp:Content>
 <%--</form>
</body>      
</html>--%>










<asp:Content ID="Content19" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 234px;
        }
    </style>
</asp:Content>











