<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="transactionPage.aspx.cs" Inherits="Mukicik_backend.View.transactionPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:PlaceHolder ID="placeholder_user" runat="server" Visible="false">
        <table>
            <tr>
                <td>Transaction List</td>
                <td></td>
            </tr>
            <tr>
                <td><asp:GridView ID="gvTransactionList" runat="server"> </asp:GridView></td>
                <td></td>
            </tr>
            <tr>
                <td>Transaction Detail</td>
                <td></td>
            </tr>
            <tr>
                <td><asp:GridView ID="gvTransactionDetail" runat="server"> </asp:GridView></td>
                <td></td>
            </tr>
        </table>
    </asp:PlaceHolder>
    
</asp:Content>
