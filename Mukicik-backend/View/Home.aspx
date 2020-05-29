<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Mukicik_backend.View.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Welcome</h1>
    <p></p>
    <table>
        <tr>
            <td>
                <asp:PlaceHolder ID="placeholder_userSession" Visible="false" runat="server" > 
                    <asp:Label ID="label_userSession" Text="" runat="server" /> <br />
                    <asp:Button Text="Logout" runat="server" onclick="userClick_logoutButton"/>
                </asp:PlaceHolder>
            </td>
        </tr>
        <tr>
            <td>
                <asp:PlaceHolder ID="placeholder_userCart" visible="false" runat="server" > 
                    <asp:Label ID="label_userCart" text="" runat="server" />
                </asp:PlaceHolder>
            </td>
        </tr>
    </table>


</asp:Content>
