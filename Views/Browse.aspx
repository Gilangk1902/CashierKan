<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Views.aspx.cs" Inherits="PSDProject.Views.Views" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Browse All Items</h1>

    <!-- Search Form -->
    <asp:TextBox ID="SearchTextBox" runat="server"></asp:TextBox>
    <asp:Button ID="SearchButton" runat="server" Text="Search" OnClick="SearchButton_Click" />
    <asp:Button ID="Button1" runat="server" Text="Search" CssClass="blue-button" OnClick="SearchButton_Click" />
    <style>
    .blue-button {
        background-color: blue;
        color: white;
        padding: 5px 10px;
        border: none;
        cursor: pointer;
    }
</style>

    <!-- Item List -->
    <asp:GridView ID="ItemGridView" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="ItemName" HeaderText="Item Name" />
            <asp:BoundField DataField="Price" HeaderText="Price" />
            <!-- Add other columns as needed -->
        </Columns>
    </asp:GridView>

    <!-- Item Detail -->
    <div>
        <h2>Item Detail</h2>
        <p><strong>Item Name:</strong> <asp:Label ID="ItemNameLabel" runat="server"></asp:Label></p>
        <p><strong>Price:</strong> <asp:Label ID="PriceLabel" runat="server"></asp:Label></p>
        <!-- Add other details as needed -->
    </div>
</asp:Content>
