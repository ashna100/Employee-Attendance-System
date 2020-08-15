<%@ Page Title="" Language="C#" MasterPageFile="~/AMS/MasterEmployee.Master" AutoEventWireup="true" CodeBehind="MyAttendance.aspx.cs" Inherits="WebApplication1.AMS.MyAttendance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentEmployee" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

             <div class="filter-box">
                <div align="center" colspan="2">
            
            <h1 style="align-content:center; font-size:X-large">Attendance Sheet</h1><hr />
            
          
        </div>
                   

        <asp:GridView ID="GridView1" Width="100%" runat="server" CssClass="table" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:BoundField DataField="AutoID" HeaderText="Days" />
                <asp:BoundField DataField="DaysNames" HeaderText="Days Names" />
                <asp:BoundField DataField="Date" HeaderText="Date" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" placeholder="Remarks"></asp:TextBox>  

                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="chkbox" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <br />

        <div  class ="form-group btn-box">
            <asp:Button  ID="Button1"  runat="server" Text="Mark Attendance" CssClass="btn" Font-Size="X-Large" OnClick="Button1_Click" Width="987px" Height="52px"/><br />
            <asp:Label ID="label1" runat="server" ForeColor="Red" Font-Size="Larger"></asp:Label>
        </div>
    </div>


        </ContentTemplate>
    </asp:UpdatePanel>
   </asp:Content>
