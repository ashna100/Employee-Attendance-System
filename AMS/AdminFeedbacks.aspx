<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/Site1.Master" AutoEventWireup="true" CodeBehind="AdminFeedbacks.aspx.cs" Inherits="WebApplication1.AMS.AdminFeedbacks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <%-- <asp:DataList ID="dlFeedback" runat="server" RepeatColumns="3" Font-Strikeout="false" Font-Underline="false">
        <ItemTemplate>
            <div allign="left">
               <table runat="server" cellspacing="1" style="border:1px ridge #9900FF;  width: 185px; text-align: center;">
                   <tr>
                           <td style="border-bottom-style: ridge; border-width: 1px; border-color: #000000">
                           <asp:Label ID="lblName" runat="server" Text='<%# Eval("Name") %>' Style="font-weight: 700px"></asp:Label>
                                                                    
                          </td>
                                                           
                   </tr>

                    <tr>
                           <td style="border-bottom-style: ridge; border-width: 1px; border-color: #000000">
                           <asp:Label ID="lblContact" runat="server" Text='<%# Eval("Contact") %>' Style="font-weight: 700px"></asp:Label>
                                                                    
                          </td>
                                                           
                   </tr>
                    <tr>
                           <td style="border-bottom-style: ridge; border-width: 1px; border-color: #000000">
                           <asp:Label ID="lblFeedback" runat="server" Text='<%# Eval("Feedback") %>' Style="font-weight: 700px"></asp:Label>
                                                                    
                          </td>
                                                           
                   </tr>
               </table>
            </div>

        </ItemTemplate>
    </asp:DataList>--%> 
    <asp:GridView ID="gridview1" runat="server" CssClass="table" AutoGenerateColumns="False" Width="100%">
        <Columns>
            <asp:BoundField DataField="Name"  HeaderText="Employee Name">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Contact" HeaderText="Contact">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="Feedback" HeaderText="Feedback">
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>
