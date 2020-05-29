<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="Mukicik_backend.View.Insert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td> <asp:Label Text="Product Name" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productName" runat="server" /> </td>
            <td> <asp:RequiredFieldValidator ErrorMessage="Must be filled!" ControlToValidate="input_productName" runat="server" /></td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Price" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productPrice" runat="server" /> </td>
            <td> <asp:RequiredFieldValidator ErrorMessage="Must be filled!" ControlToValidate="input_productPrice" runat="server" /></td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Image" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productImage" runat="server" /> </td>
            <td> <asp:RequiredFieldValidator ErrorMessage="Must be filled!" ControlToValidate="input_productImage" runat="server" /></td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Rating" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productRating" runat="server" /> </td>
            <td> <asp:RequiredFieldValidator ErrorMessage="Must be filled!" ControlToValidate="input_productRating" runat="server" /></td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Stock" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productStock" runat="server" /> </td>
            <td> <asp:RequiredFieldValidator ErrorMessage="Must be filled!" ControlToValidate="input_productStock" runat="server" /></td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Category" runat="server" /> </td>
            <td> 
                <asp:DropDownList ID="ddl_category" runat="server">
                </asp:DropDownList>
            </td>
            <td> <asp:RequiredFieldValidator ErrorMessage="Must be filled!" ControlToValidate="ddl_category" runat="server" /></td>
        </tr>
        <tr>
            <td></td>
            <td> <asp:Button ID="button_insertProduct" Text="Insert" runat="server" OnClick="button_insertProduct_Click"/></td>
            <td> <asp:Label ID="label_errorLabel" Text="" runat="server" /> </td>
        </tr>
    </table>
</asp:Content>
