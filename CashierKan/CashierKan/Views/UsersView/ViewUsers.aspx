<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="ViewUsers.aspx.cs" Inherits="CashierKan.Views.UsersView.ViewUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
         <asp:GridView ID="usersGridView" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="usersGridView_SelectedIndexChanged" OnRowDeleting="userGridView_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Email" HeaderText="Price" SortExpression="Price" />
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="Role.Name" HeaderText="Role" SortExpression="Role.Name" />
                    <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="False" ShowHeader="True" />
                </Columns>
            </asp:GridView>
    </div>
</asp:Content>
