<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Country.aspx.cs" Inherits="WebApplication1.Country" MasterPageFile="~/AMS/Site1.Master" %>


<asp:Content ID="Content1" ContentPlaceHolderID="Content" runat="server">
        <div class="filter-box">
             <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
               <div class="form-group">
                <asp:Label ID="lblCountry0" runat="server" Text="Country ID" ></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                   </div>
            <div class="form-group">
                 <asp:Label ID="lblCountry" runat="server" Text="Country Name" ></asp:Label>
                  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                   <div class="form-group btn-box">
                        <asp:Button ID="btnAdd" runat="server" Text="Add Country" OnClick="btnAdd_Click" CssClass="btn"/>
                        <asp:Button ID="btnUpdate" runat="server" Text="Update Country" OnClick="btnUpdate_Click" CssClass="btn cancel"/>
                       <asp:Button ID="btnDelete" runat="server" Text="Delete Country" OnClick="btnDelete_Click" CssClass="btn cancel"/>
                        <%--<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Return" />--%>
                    </div>
            </div>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [country1]"></asp:SqlDataSource>
                
              
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="CountryId" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="CountryId" HeaderText="CountryId" InsertVisible="False" ReadOnly="True" SortExpression="CountryId" />
                        <asp:BoundField DataField="CountryName" HeaderText="CountryName" SortExpression="CountryName" />
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
                
               

               <h3> <asp:Label ID="lbloutput" runat="server" Text=""></asp:Label></h3>

                <%--<asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>--%>
                
        </div>
    </asp:Content>
    <%--</form>
</body>
</html>--%>
