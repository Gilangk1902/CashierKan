<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="UpdateItem.aspx.cs" Inherits="CashierKan.Views.ItemsView.UpdateItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="name_Label" Text="Name" runat="server" />
    <asp:TextBox ID="name_TextBox" runat="server" />
    <asp:Label ID="types_Label" Text="Type" runat="server" />
    <asp:DropDownList ID="types_DropDownList" runat="server">
        <asp:ListItem Text="food" />
        <asp:ListItem Text="electronic" />
    </asp:DropDownList>
    <asp:Label ID="price_Label" Text="Price" runat="server"/>
    <asp:TextBox ID ="price_TextBox" runat="server" />
    <asp:Button ID="update_Button" Text="Add" runat="server" Onclick="update_Button_Click"/>
</asp:Content>
