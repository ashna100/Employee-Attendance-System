<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="City.aspx.cs" Inherits="WebApplication1.City" MasterPageFile="~/AMS/Site1.Master" %>


<asp:Content ID="content1" ContentPlaceHolderID="Content" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
      <div class="filter-box">
             <div class="form-group">
                 <asp:Label ID="label1" runat="server" Text="Select State" ></asp:Label>
               <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="StateName" DataValueField="StateId" AppendDataBoundItems="True">
                    <asp:ListItem Value="0">Select</asp:ListItem>
                </asp:DropDownList>
           
          </div>
          <div class="form-group">
            <asp:Label ID="lblCity0" runat="server" Text="City ID" ></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
              </div>

          <div class="form-group">
           <asp:Label ID="lblCity" runat="server" Text="City Name" ></asp:Label>
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
          </div>

          <div class="form-group btn-box">
             <asp:Button ID="btnAdd" runat="server" Text="Add City" OnClick="BtnAdd_Click"  CssClass="btn" />
             <asp:Button ID="btnDelete" runat="server" Text="Delete City" OnClick="BtnDelete_Click" CssClass="btn cancel"/>
             <asp:Button ID="btnUpdate" runat="server" Text="Update City" OnClick="btnUpdate_Click" CssClass="btn cancel" />
        </div>
          </div>
   <asp:Label ID="lbloutput" runat="server" Text=""></asp:Label>

        <%--<asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>--%>
   


    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>"
        SelectCommand="SELECT [CItyId], [CityName], [StateName] FROM [City]" DeleteCommand="DELETE FROM [City] WHERE [CItyId] = @CItyId" InsertCommand="INSERT INTO [City] ([CityName], [StateName]) VALUES (@CityName, @StateName)" UpdateCommand="UPDATE [City] SET [CityName] = @CityName, [StateName] = @StateName WHERE [CItyId] = @CItyId" >
        <DeleteParameters>
            <asp:Parameter Name="CItyId" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="CityName" Type="String" />
            <asp:Parameter Name="StateName" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="CityName" Type="String" />
            <asp:Parameter Name="StateName" Type="String" />
            <asp:Parameter Name="CItyId" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>"
        SelectCommand="SELECT [StateId], [StateName] FROM [State]"></asp:SqlDataSource>



    <br />



    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="CItyId" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table">
        <Columns>
            <asp:CommandField ShowSelectButton="True" />
            <asp:BoundField DataField="CItyId" HeaderText="CItyId" InsertVisible="False" ReadOnly="True" SortExpression="CItyId" />
            <asp:BoundField DataField="CityName" HeaderText="CityName" SortExpression="CityName" />
            <asp:BoundField DataField="StateName" HeaderText="StateName" SortExpression="StateName" />
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
</asp:Content>


<%--</form>
</body>
</html>--%>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="head">
    </asp:Content>

