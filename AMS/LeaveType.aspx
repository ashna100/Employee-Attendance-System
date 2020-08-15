<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LeaveType.aspx.cs" Inherits="WebApplication1.AMS.LeaveType"  MasterPageFile="~/AMS/Site1.Master"%>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="Content14" ContentPlaceHolderID="Content" runat="server">
    <div>

        <div class="filter-box">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div class="form-group">
                <asp:Label ID="lblLeaveName" Text="Leave Type Name" runat="server"></asp:Label>
            <asp:TextBox ID="txtleave" runat="server"></asp:TextBox>    
            </div>
            <div class="form-group">
                <asp:Label ID="lblLimit" Text="Yearly Limit" runat="server"></asp:Label>
                <asp:TextBox ID="txtLimit" runat="server"></asp:TextBox>
                </div>
            <div class="form-group btn-box">
                <asp:Button ID="btnInsert" Text="Insert" runat="server" CssClass="btn"></asp:button>
                <asp:Button ID="btnUpdate" Text="Update" runat="server" CssClass="btn cancel" ></asp:Button>
               
                </div>
            
            </div>
        <asp:Label id="lblOutput" runat="server"></asp:Label>
        <asp:HiddenField ID="hfLeaveID" runat="server" />
         
       
        </div>
 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" BackColor="#99FF33" CssClass="table">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="LeaveName" HeaderText="LeaveName" SortExpression="LeaveName" />
            <asp:BoundField DataField="YearlyLimit" HeaderText="YearlyLimit" SortExpression="YearlyLimit" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False"  OnClick="delete_click"  Text="Delete"></asp:LinkButton>
                    <br />
                     <asp:Panel ID="Panel1" runat="server" BackColor="Yellow" Height="102px" >
                            <div class="auto-style4" style="background-color: #FFFF66; font-weight: bold">
                                &nbsp;&nbsp;&nbsp; Do you want to delete record?<br />
                                <br />
                                &nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Button1" runat="server" Text="Yes" Width="94px"  />
                                &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="No" Width="94px" />
                            </div>
                        </asp:Panel>
                        <ajaxToolkit:ConfirmButtonExtender ID="ConfirmButtonExtender2" runat="server" TargetControlID="LinkButton1"  DisplayModalPopupID="ModalPopupExtender1" />
                        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server"  TargetControlID="LinkButton1" PopupControlID="Panel1" OkControlID="Button1" CancelControlID="Button2"></ajaxToolkit:ModalPopupExtender>
  
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                     <ItemTemplate>
                        <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="true" Font-Size="Large" CommandArgument='<%# Eval("LeaveID")%>' OnClick="GridView1_SelectedIndexChanged">View</asp:LinkButton>
                       
                    </ItemTemplate>

                </asp:TemplateField>
               
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    </asp:Content>