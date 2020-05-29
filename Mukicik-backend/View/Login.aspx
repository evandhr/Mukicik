<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Mukicik_backend.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:auto; margin-top:1%;">
        <tr>
            <td><asp:Label Text="Username" runat="server" /></td>
            <td><asp:TextBox ID="userInput_userName" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ErrorMessage="Please Enter your Username" ForeColor="Red" ControlToValidate="userInput_userName" runat="server" />
            </td>
        </tr>
        <tr>
            <td><asp:Label Text="Password" runat="server" /></td>
            <td><asp:TextBox ID="userInput_userPassword" TextMode="Password" runat="server" /></td>
            <td>
                <asp:RequiredFieldValidator ID="input_userPassword" ErrorMessage="Please Enter your Password" forecolor="Red" ControlToValidate="userInput_userPassword" runat="server" />
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button Text="Login" runat="server" OnClick="userClick_loginButton" />
                <asp:Label ID="userLabel_login" Text="" ForeColor="Red" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
