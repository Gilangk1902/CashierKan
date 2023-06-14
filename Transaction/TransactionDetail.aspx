<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="TransactionDetail.aspx.cs" Inherits="PSDProject.Views.TransactionDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:2% 10%">
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Item ID</th>
                    <th scope="col">Item Type</th>
                    <th scope="col">Item Name</th>
                    <th scope="col">Item Price</th>
                    <th scope="col">Item Quantity</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="TableRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td scope="row"><%# Eval("Item.Id") %></td>
                            <td scope="row"><%# Eval("Item.ItemType.ItemTypeName") %></td>
                            <td scope="row"><%# Eval("Item.ItemName") %></td>
                            <td scope="row"><%# Eval("Item.ItemPrice") %></td>
                            <td scope="row"><%# Eval("Quantity") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
