<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/MasterEmployee.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="WebApplication1.AMS.Feedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentEmployee" runat="server">
    <div class="filter-box">
        <h1>Feedback Form</h1>
        <div class="form-group" style="height: 245px">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblName" runat="server" Text="Enter Your Name" ></asp:Label>
                    </td>
                    <td></td><td></td>
                    <td>
                      <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                       <asp:Label ID="lblContact" runat="server" Text="Contact"></asp:Label>
                    </td>
                    <td></td><td></td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblFeedback" runat="server" Text="Feedback"></asp:Label>
                    </td>
                    <td></td><td></td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
            </table>
            
             <div class="form-group btn-box">       
            <asp:Button ID="btn1"  type="Submit" runat ="server" Text="Submit" CssClass="btn" OnClick="btn1_Click" Width="250px" />
             
            
            <asp:Label ID="lbl1"  runat="server" ForeColor="green"  Font-Size="Large" Font-Bold="true" ></asp:Label>
            
            </div>
             
            
        </div>
        
        
    </div>
</asp:Content>
