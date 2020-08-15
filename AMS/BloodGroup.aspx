<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BloodGroup.aspx.cs" Inherits="WebApplication1.BloodGroup" MasterPageFile="~/AMS/Site1.Master" %>

<%--<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">--%>
<asp:Content ID="content1" ContentPlaceHolderID="Content" runat="server">
        <div>
            <asp:Panel ID="panel1" runat="server">
                <div class="filter-box">
                    <div class="form-group">
                        <asp:Label ID="label2" Text=" Blood Group ID" runat="server"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="label1" Text="Enter Blood group" runat="server"></asp:Label>
                        <asp:TextBox ID="txtBG" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group btn-box">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="insert" cssClass="btn"/>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" cssClass="btn cancel"/>
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" cssClass="btn cancel" />
                        </div>
                </div>
           <%-- <table style="border-style: solid; background-color: #33CCFF; table-layout: fixed">
                <tr>
                    <td class="auto-style5">
                    
            </td>
                    <td class="auto-style6">
                        
                    </td>
                    </tr>
                <tr>
                    <td class="auto-style4">
                        <br />
                    &nbsp &nbsp &nbsp &nbsp &nbsp
           </td>
                    <td>
                        
                    </td>
                    </tr>
                <tr>
                    <td class="auto-style4">--%>
                    <%--<asp:Button ID="btnReturn" Text="Return" runat="server" OnClick="btnReturn_Click" />--%>
                       <%-- <br />
                    
                    </td>
                    <td>
                        <br />
                        
                    </td>
                    <td>
                        <br />
                        
               </td>
                        </tr>
                
                </table>--%>
                </asp:Panel>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
              


                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="BloodGroup_ID" CellPadding="4" GridLines="None"   ForeColor="#333333" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  AllowPaging="True" DataSourceID="SqlDataSource1" CssClass="table">
                       <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="BloodGroup_ID" HeaderText="BloodGroup_ID" InsertVisible="False" ReadOnly="True" SortExpression="BloodGroup_ID" />
                            <asp:BoundField DataField="BloodGroup_Type" HeaderText="BloodGroup_Type" SortExpression="BloodGroup_Type" />
                        </Columns>
                        <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
                        <%--<HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />--%>
                        <PagerStyle ForeColor="#333333" HorizontalAlign="Center" BackColor="#FFCC66" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" DeleteCommand="DELETE FROM [BloodGroup] WHERE [BloodGroup_ID] = @BloodGroup_ID" 
                      InsertCommand="INSERT INTO [BloodGroup] ([BloodGroup_Type]) VALUES (@BloodGroup_Type)" SelectCommand="SELECT * FROM [BloodGroup]" 
                      UpdateCommand="UPDATE [BloodGroup] SET [BloodGroup_Type] = @BloodGroup_Type WHERE [BloodGroup_ID] = @BloodGroup_ID">
                      <DeleteParameters>
                          <asp:Parameter Name="BloodGroup_ID" Type="Int32" />
                      </DeleteParameters>
                      <InsertParameters>
                          <asp:Parameter Name="BloodGroup_Type" Type="String" />
                      </InsertParameters>
                      <UpdateParameters>
                          <asp:Parameter Name="BloodGroup_Type" Type="String" />
                          <asp:Parameter Name="BloodGroup_ID" Type="Int32" />
                      </UpdateParameters>
            </asp:SqlDataSource>
                  <br />


                    <br />
                    <br />
                    <br />
                    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" DeleteCommand="DELETE FROM [BloodGroup] WHERE [BloodGroup_ID] = @BloodGroup_ID"
                        InsertCommand="INSERT INTO [BloodGroup] ([BloodGroup_Type]) VALUES (@BloodGroup_Type)"
                        SelectCommand="SELECT [BloodGroup_ID], [BloodGroup_Type] FROM [BloodGroup]"
                        ></asp:SqlDataSource>
  --%>              
            <br />


        </div>
        <label id="lblOutput" text="label" runat="server"></label>
       
    </asp:Content>


    <%--</form>
</body>
</html>--%>

