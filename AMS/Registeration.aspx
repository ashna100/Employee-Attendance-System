<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="WebApplication1.validations" EnableViewState="true" MasterPageFile="~/AMS/Site1.Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>




<asp:Content ID="Content11" ContentPlaceHolderID="Content" runat="server">
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

    <%--   <asp:Label ID="lbl1" runat="server" ForeColor="Violet"></asp:Label><br /><br />
<asp:Label ID="lbl2" runat="server" ForeColor="Tomato"></asp:Label><br /><br />
<asp:Label ID="lbl3" runat="server" ForeColor="HotPink"></asp:Label><br /><br />
        <asp:Label ID="lbl4" runat="server" ForeColor="HotPink"></asp:Label>--%>


    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <%--<asp:UpdatePanel  runat="server">--%>
        
        <asp:Panel ID="Panel1" runat="server">

            <%--<div>
            <select id="Select1">
                <option value="" selected disabled>-Select--</option>
            </select> 
        </div>--%>

            <div class="login-box register-box">
                <%--<asp:HiddenField ID="hfUserID" runat="server" />--%>

                <h2>
                    <label style="text-align: center">Registration Form</label></h2>
                <asp:Label ID="lblOutput" runat="server" CssClass="div-msg"></asp:Label>

                <asp:Label ID="Label2" runat="server" CssClass="div-msg"></asp:Label>

                <div class="form-group">
                    <label>UserID</label>
                    <asp:TextBox ID="TextBox12" runat="server" CssClass="form-control"></asp:TextBox>

                </div>


                <div class="form-group">
                    <label>First Name</label>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>--%>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red"  ControlToValidate="TextBox1" 
            ErrorMessage="Enter name"></asp:RequiredFieldValidator>--%>
                </div>

                <div class="form-group">
                    <label>Last Name</label>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>--%>
                    <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="red" ControlToValidate="TextBox2" ErrorMessage="Enter last name">
                    </asp:RequiredFieldValidator>
                    --%>
                </div>


                <div class="form-group">
                    <label>DOB</label>
                    <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender1" runat="server" TargetControlID="txtDob" Format="dd-MM-yyyy" />
                    <%--<asp:Button ID="button5" runat="server" Text="select Date" OnClick="button5_Click" />--%>
                    <%--<asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>--%>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDob"  ForeColor="Red"
                   ErrorMessage="select your Date of birth"></asp:RequiredFieldValidator>--%>
                </div>




                <div class="form-group">
                    <label>Mother's Name</label>
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" TextMode="MultiLine" ForeColor="Red"
                 ErrorMessage="enter Mother's Name" ControlToValidate ="TextBox10"></asp:RequiredFieldValidator>
                    --%>
                </div>
                <div class="form-group">
                    <label>Father's Name</label>
                    <asp:TextBox ID="TextBox11" runat="server" CssClass="form-control"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator23" runat="server" TextMode="MultiLine" ForeColor="Red"
                 ErrorMessage="enter Father's Name" ControlToValidate ="TextBox11"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Marital Status </label>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="MaritalStatus" DataValueField="MId">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  ForeColor="Red"  ControlToValidate ="DropDownList1"
                     ErrorMessage="Choose your status"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Select gender</label>

                    <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="GenderName" DataValueField="GenderId">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList2"
                     ErrorMessage="select gender"></asp:RequiredFieldValidator>--%>
                </div>

                <div class="form-group">
                    <label>Select Reporting Manager</label>
                    <asp:DropDownList ID="DropDownList10" runat="server" DataSourceID="SqlDataSource11" DataTextField="ManagerName" DataValueField="ManagerID">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList2"
                     ErrorMessage="select gender"></asp:RequiredFieldValidator>--%>
                </div>

                <div class="form-group">
                    <label>select country</label>
                    <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="CountryName" DataValueField="CountryId" AutoPostBack="True">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList3"
                     ErrorMessage="select Country"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>select State</label>
                    <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource4" DataTextField="StateName" DataValueField="StateId" AutoPostBack="True">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList4"
                     ErrorMessage="select State"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>select city</label>
                    <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource5" DataTextField="CityName" DataValueField="CItyId" AutoPostBack="True">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList5"
                     ErrorMessage="select City"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Pincode </label>
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ForeColor="Red" ErrorMessage="RequiredFieldValidator" 
                    ControlToValidate="TextBox9"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Address </label>
                    <asp:TextBox ID="TextBox8" runat="server" CssClass="form-control"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" TextMode="MultiLine" ForeColor="Red"
                         ErrorMessage="Fill your address" ControlToValidate ="TextBox8"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Contact 1 </label>
                    <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ForeColor="Red"  ControlToValidate="TextBox6"
                    ErrorMessage="Please enter your Contact Number"></asp:RequiredFieldValidator>--%>
                </div>

                <div class="form-group">
                    <label>Contact2 </label>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ForeColor="Red" ErrorMessage="RequiredFieldValidator" 
                    ControlToValidate="TextBox3"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Personal Email ID </label>
                    <asp:TextBox ID="TextBox7" runat="server" CssClass="form-control"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ForeColor="Red" ControlToValidate ="TextBox7"
                    ErrorMessage="Please fill Email id"></asp:RequiredFieldValidator>
                    --%>
                </div>

                <div class="form-group">
                    <label>Official Email ID </label>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ForeColor="Red" ErrorMessage="Enter email id" 
                    ControlToValidate="TextBox5"></asp:RequiredFieldValidator>--%>
                </div>

               <%-- <div class="form-group">
                    <label>Password </label>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ForeColor="Red" ErrorMessage="Enter email id" 
                    ControlToValidate="TextBox5"></asp:RequiredFieldValidator>
                </div>--%>

                <div class="form-group">
                    <label>Select Department</label>
                    <asp:DropDownList ID="DropDownList6" runat="server" DataSourceID="SqlDataSource6" DataTextField="Name" DataValueField="DeptId">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--   <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList6"
                     ErrorMessage="select Department"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Select Designation</label>
                    <asp:DropDownList ID="DropDownList7" runat="server" DataSourceID="SqlDataSource7" DataTextField="DesName" DataValueField="DesId">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList7"
                     ErrorMessage="select Designation"></asp:RequiredFieldValidator>--%>
                </div>

                <div class="form-group">
                    <label>Select Grade</label>
                    <asp:DropDownList ID="DropDownList8" runat="server" DataSourceID="SqlDataSource8" DataTextField="GradeName" DataValueField="GradeID">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList8"
                     ErrorMessage="select Grade"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Select Blood Group</label>
                    <asp:DropDownList ID="DropDownList9" runat="server" DataSourceID="SqlDataSource9" DataTextField="BloodGroup_Type" DataValueField="BloodGroup_ID">
                        <asp:ListItem>Select</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ForeColor="Red"  ControlToValidate ="DropDownList9"
                     ErrorMessage="select Blood Group"></asp:RequiredFieldValidator>
                    --%>
                </div>
                <div class="form-group">
                    <label>Select DOJ</label>
                    <asp:TextBox ID="txtDoj" runat="server"></asp:TextBox>
                    <ajaxToolkit:CalendarExtender ID="CalendarExtender2" runat="server" TargetControlID="txtDoj" Format="dd-MM-yyyy" />
                    <%--<asp:Button ID="button6" runat="server" Text="select Date" OnClick="button6_Click" />--%>
                    <%--<asp:Label Text="*" runat="server" ForeColor="Red"></asp:Label>--%>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="txtDoj"  ForeColor="Red"
                   ErrorMessage="select your Date of joining"></asp:RequiredFieldValidator>--%>
                </div>
                <div class="form-group">
                    <label>Card Number</label>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
                    <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" TextMode="MultiLine" ForeColor="Red"
                 ErrorMessage="enter card number" ControlToValidate ="TextBox4"></asp:RequiredFieldValidator>--%>
                </div>

                <div class="form-group">
                    <%-- <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                   <asp:Label ID="Label2" runat="server" ForeColor="Green" Text="Label2"></asp:Label>--%>
                </div>
                <div class="form-group btn-box full">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" CssClass="btn" />
                    &nbsp&nbsp
                  <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" CssClass="btn" />

                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" CssClass="btn" />&nbsp&nbsp
                  <%--<asp:Button ID="Home" runat="server" Text="Home Page" OnClick="Home_Click" CssClass="btn"/>--%>
                </div>
            </div>




        <%--<asp:TextBox ID="txtSearch" runat="server" Placeholder="Enter userId"></asp:TextBox>--%>
                  
                &nbsp;<br />
        <br />
        <%--<asp:LinkButton ID="LinkButton1" runat="server" BackColor="#33CCCC" BorderColor="White" BorderStyle="Double" BorderWidth="3px" ForeColor="White" Height="30px" OnClick="LinkButton1_Click">Click here for new Registration</asp:LinkButton>--%>

        <%-- <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1"   runat="server" PopupControlID="Panel1"  CancelControlID="Button3"  TargetControlID="LinkButton1">
    </ajaxToolkit:ModalPopupExtender>
        --%>
        <div style="overflow-x: auto;">
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" DataKeyNames="UserID" DataSourceID="SqlDataSource10" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="UserID" HeaderText="UserID" InsertVisible="False" ReadOnly="True" SortExpression="UserID" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                    <asp:BoundField DataField="MaritalStatus" HeaderText="MaritalStatus" SortExpression="MaritalStatus" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
                    <asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="Pincode" HeaderText="Pincode" SortExpression="Pincode" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="PersonalEmail" HeaderText="PersonalEmail" SortExpression="PersonalEmail" />
                    <asp:BoundField DataField="officialEmail" HeaderText="officialEmail" SortExpression="officialEmail" />
                    <asp:BoundField DataField="Contact1" HeaderText="Contact1" SortExpression="Contact1" />
                    <asp:BoundField DataField="Contact2" HeaderText="Contact2" SortExpression="Contact2" />
                    <asp:BoundField DataField="DOJ" HeaderText="DOJ" SortExpression="DOJ" />
                    <asp:BoundField DataField="MotherName" HeaderText="MotherName" SortExpression="MotherName" />
                    <asp:BoundField DataField="FatherName" HeaderText="FatherName" SortExpression="FatherName" />
                    <asp:BoundField DataField="BloodGroup" HeaderText="BloodGroup" SortExpression="BloodGroup" />
                    <asp:BoundField DataField="Department" HeaderText="Department" SortExpression="Department" />
                    <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
                    <asp:BoundField DataField="Grade" HeaderText="Grade" SortExpression="Grade" />
                    <asp:BoundField DataField="CardNumber" HeaderText="CardNumber" SortExpression="CardNumber" />
                    <asp:BoundField DataField="ReportingManager" HeaderText="ReportingManager" SortExpression="ReportingManager" />
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
            </div>

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [MaritalStatus]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [Gender]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [country1]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [State] WHERE ([CountryID] = @CountryID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList3" Name="CountryID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [City] WHERE ([StateID] = @StateID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList4" Name="StateID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource6" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [Department]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource7" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [Designation]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource8" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [Grade]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource9" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [BloodGroup]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource11" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" SelectCommand="SELECT * FROM [ReportingManager]"></asp:SqlDataSource>

            <asp:SqlDataSource ID="SqlDataSource10" runat="server" ConnectionString="<%$ ConnectionStrings:infoConnectionString %>" DeleteCommand="DELETE FROM [Registration] WHERE [UserID] = @UserID"
                InsertCommand="INSERT INTO [Registration] ([FirstName], [LastName], [DOB], [MaritalStatus], [Gender], [Country], [State], [City], [Pincode], [Address], [PersonalEmail], [officialEmail], [Contact1], [Contact2], [DOJ], [MotherName], [FatherName], [BloodGroup], [Department], [Designation], [Grade], [CardNumber]) VALUES (@FirstName, @LastName, @DOB, @MaritalStatus, @Gender, @Country, @State, @City, @Pincode, @Address, @PersonalEmail, @officialEmail, @Contact1, @Contact2, @DOJ, @MotherName, @FatherName, @BloodGroup, @Department, @Designation, @Grade, @CardNumber)"
                SelectCommand="SELECT * FROM [Registration]" UpdateCommand="UPDATE [Registration] SET [FirstName] = @FirstName, [LastName] = @LastName, [DOB] = @DOB, [MaritalStatus] = @MaritalStatus, [Gender] = @Gender, [Country] = @Country, [State] = @State, [City] = @City, [Pincode] = @Pincode, [Address] = @Address, [PersonalEmail] = @PersonalEmail, [officialEmail] = @officialEmail, [Contact1] = @Contact1, [Contact2] = @Contact2, [DOJ] = @DOJ, [MotherName] = @MotherName, [FatherName] = @FatherName, [BloodGroup] = @BloodGroup, [Department] = @Department, [Designation] = @Designation, [Grade] = @Grade, [CardNumber] = @CardNumber WHERE [UserID] = @UserID">
                <DeleteParameters>
                    <asp:Parameter Name="UserID" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter DbType="Date" Name="DOB" />
                    <asp:Parameter Name="MaritalStatus" Type="String" />
                    <asp:Parameter Name="Gender" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="State" Type="String" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="Pincode" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="PersonalEmail" Type="String" />
                    <asp:Parameter Name="officialEmail" Type="String" />
                    <asp:Parameter Name="Contact1" Type="String" />
                    <asp:Parameter Name="Contact2" Type="String" />
                    <asp:Parameter DbType="Date" Name="DOJ" />
                    <asp:Parameter Name="MotherName" Type="String" />
                    <asp:Parameter Name="FatherName" Type="String" />
                    <asp:Parameter Name="BloodGroup" Type="String" />
                    <asp:Parameter Name="Department" Type="String" />
                    <asp:Parameter Name="Designation" Type="String" />
                    <asp:Parameter Name="Grade" Type="String" />
                    <asp:Parameter Name="CardNumber" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="FirstName" Type="String" />
                    <asp:Parameter Name="LastName" Type="String" />
                    <asp:Parameter DbType="Date" Name="DOB" />
                    <asp:Parameter Name="MaritalStatus" Type="String" />
                    <asp:Parameter Name="Gender" Type="String" />
                    <asp:Parameter Name="Country" Type="String" />
                    <asp:Parameter Name="State" Type="String" />
                    <asp:Parameter Name="City" Type="String" />
                    <asp:Parameter Name="Pincode" Type="String" />
                    <asp:Parameter Name="Address" Type="String" />
                    <asp:Parameter Name="PersonalEmail" Type="String" />
                    <asp:Parameter Name="officialEmail" Type="String" />
                    <asp:Parameter Name="Contact1" Type="String" />
                    <asp:Parameter Name="Contact2" Type="String" />
                    <asp:Parameter DbType="Date" Name="DOJ" />
                    <asp:Parameter Name="MotherName" Type="String" />
                    <asp:Parameter Name="FatherName" Type="String" />
                    <asp:Parameter Name="BloodGroup" Type="String" />
                    <asp:Parameter Name="Department" Type="String" />
                    <asp:Parameter Name="Designation" Type="String" />
                    <asp:Parameter Name="Grade" Type="String" />
                    <asp:Parameter Name="CardNumber" Type="String" />
                    <asp:Parameter Name="UserID" Type="Int32" />
                </UpdateParameters>

            </asp:SqlDataSource>

            <br />
            </asp:Panel>
    <%--</asp:UpdatePanel>--%>



</asp:Content>

<%--   </form>
</body>
</html>--%>
