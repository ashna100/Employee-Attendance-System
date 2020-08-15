<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgetPasswordLink.aspx.cs" Inherits="WebApplication1.AMS.ForgetPasswordLink"  MasterPageFile="~/AMS/Site1.Master"%>
<%--<head runat="server">
    <title>Forget Password</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .auto-style1 {
            width: 57%;
            height: 263px;
            margin-left: 267px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">--%>


<asp:Content ID="ForgetPasswordLink1" ContentPlaceHolderID="Content" runat="server">
    <div>
    <div class="login-box">
              <h3>Forgot Password?</h3>
        <div class="form-group">
                <asp:Label ID="lbl_msg" runat="server"></asp:Label>
            </div>

              <div class="form-group">
                  <label>Enter email id</label>
                  <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
        <%--<asp:regularexpressionvalidator id="regularexpressionvalidator1" runat="server"
            controltovalidate="txt_email" errormessage="enter valid email address"
            validationexpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:regularexpressionvalidator>--%>
                  </div>
         <div class="form-group text-center">
            <h1>Or</h1>
         </div>
       
        <div class="form-group">
                  <label>Enter username</label>
            <asp:TextBox ID="txt_uname" runat="server"></asp:TextBox>
            </div>

        <div class="form-group btn-box">
            <asp:Button ID="btn_send" runat="server" onclick="btn_send_Click" Text="Send" CssClass="btn full" />
       <%--<h2> <asp:Label ID="lblmsg" runat="server"></asp:Label></h2>--%>
            </div>
       
    </div>
        </div>


    <style>
    
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
    <%--</form>
</body>--%>



