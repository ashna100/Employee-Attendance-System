<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="WebApplication1.AMS.LoginPage"  MasterPageFile="~/AMS/Site1.Master"%>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">--%>
      <asp:Content ID="Content18" ContentPlaceHolderID="Content" runat="server">  
          <div class="login-box">
              <h3>Login Here!!</h3>
              <div class="form-group">
                  <label>Username</label>
                  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              </div>
              <div class="form-group">
                  <label>Password</label>
                  <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
              </div>
              <div class="form-group btn-box">
                  <asp:Button ID="Button1" runat="server"  Text="Admin Login" OnClick="Button1_Click" CssClass="btn" />
                  <asp:Button ID="Button2" runat="server"  Text="Cancel" OnClick="Button2_Click" CssClass="btn cancel"/><br />
                  <asp:Button ID="Button3" runat="server"  Text="Employee Login"  CssClass="btn" OnClick="Button3_Click" />
                  
              </div>
              <div class="form-group text-center">
                  <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#0066FF" NavigateUrl="~/AMS/ForgetPasswordLink.aspx">Forgot Password?</asp:HyperLink>
                  <%--<asp:Label ID="Label2" runat="server" Text="Forgot Password Label" OnLoad="LabelForget"></asp:Label>--%>
                 <br /> <h2><asp:Label ID="Label1" runat="server"></asp:Label></h2>
              </div>
               
                                    
          </div>
          <%--<div class="auto-style4">
            <table class="auto-style5">
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7" style="background-color: #FFFF99">
                        <table class="auto-style9" style="border-style: 1; background-color: #99FF66;">
                            <tr>
                                
                                <td class="auto-style14"></td>
                                <td class="auto-style15">
                                    
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12"> Password</td>
                                <td class="auto-style13">
                                    
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">
                                    
                                    </td>
                                <td>
                                    &nbsp;<br />
                                   
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>--%>
          </asp:Content>
   <%-- </form>
</body>
</html>--%>
<asp:Content ID="Content19" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style4 {
            height: 381px;
            margin-top: 0px;
        }
        .auto-style5 {
            width: 163%;
            height: 302px;
        }
        .auto-style7 {
            width: 595px;
        }
        .auto-style8 {
            width: 235px;
        }
        .auto-style9 {
            width: 100%;
            height: 201px;
        }
        .auto-style10 {
            margin-left: 0px;
        }
        .auto-style11 {
            width: 275px;
        }
    .auto-style12 {
        width: 275px;
        height: 100px;
    }
    .auto-style13 {
        height: 100px;
    }
    .auto-style14 {
        width: 275px;
        height: 69px;
    }
    .auto-style15 {
        height: 69px;
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
    </style>
</asp:Content>

