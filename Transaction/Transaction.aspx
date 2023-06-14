<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="PSDProject.Views.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:2% 10%">
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Transaction ID</th>
                    <th scope="col">Transaction Date</th>
                    <th scope="col"></th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="TableRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td scope="row"><%# Eval("Id") %></td>
                            <td scope="row"><%# Eval("TransactionDate") %></td>
                            <td scope="row">
                                <asp:LinkButton ID="OpenDetail" runat="server" class="btn btn-outline-success" CommandArgument='<%#Eval("Id") %>'
                                    OnClick="OpenDetail_Click">Open Detail</asp:LinkButton>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
