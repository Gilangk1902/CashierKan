<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CashierKan.Views.LoginRegister.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%;">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                Register
            </h2>
        </div>
        <div class="d-flex justify-content-center" style="margin-top: 2.5%;">
            <div class="card row d-flex" style="width: 30rem;">
                <div class="card-body">
                   <div>

                <p class="card-text">Role</p>
                <div class="mb-3">
                    <asp:DropDownList ID="RoleList" runat="server" OnSelectedIndexChanged="RoleList_SelectedIndexChanged"></asp:DropDownList>
                    <asp:Label ID="Label3" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p class="card-text">Name</p>
                <div class="mb-3">
                    <asp:TextBox ID="UsernameTxt" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="UsernameLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p class="card-text">Address</p>
                <div class="mb-3">
                    <asp:TextBox ID="AddressTxt" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="AddressLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p class="card-text">Date of Birth</p>
                <div class="mb-3">
                    <asp:TextBox ID="DobTxt" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="DobLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p class="card-text">Email</p>
                <div class="mb-3">
                    <asp:TextBox ID="EmailTxt" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="EmailLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p class="card-text">Password</p>
                <div class="mb-3">
                    <asp:TextBox ID="PasswordTxt" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="PasswordLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>
                    <asp:Button ID="registerBtn" runat="server" Text="Register" class="btn btn-success" style="width: 100%;" OnClick="registerBtn_Click"/>
                </p>
                <p>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Views/Login.aspx"><input type="button" value="Login" style="width:100%" class="btn btn-outline-success"/></asp:HyperLink>
                </p>
            </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
