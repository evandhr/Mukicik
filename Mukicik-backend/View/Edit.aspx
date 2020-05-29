<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Mukicik_backend.View.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <br>
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView 
                    ID="gvProducts" 
                    runat="server" 
                    AutoGenerateSelectButton="true"
                    OnSelectedIndexChanged="gvProducts_SelectedIndexChanged"/>

            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td> <asp:Label Text="Selected ID" runat="server" /> </td>
            <td> <asp:TextBox ReadOnly="true" ID="input_productID" runat="server" /> </td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Name" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productName" runat="server" /> </td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Price" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productPrice" runat="server" /> </td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Image" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productImage" runat="server" /> </td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Rating" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productRating" runat="server" /> </td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Stock" runat="server" /> </td>
            <td> <asp:TextBox ID="input_productStock" runat="server" /> </td>
        </tr>
        <tr>
            <td> <asp:Label Text="Product Category" runat="server" /> </td>
            <td> 
                <asp:DropDownList ID="ddl_category" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td></td>
            <td> 
                <asp:Button ID="button_editProduct" Text="Edit" runat="server" OnClick="button_edit_Click"/>
                <asp:Button ID="button_removeProduct" Text="Deelte" runat="server" OnClick="button_remove_Click"/>
            </td>
            <td> <asp:Label ID="label_errorLabel" Text="" runat="server" /> </td>
        </tr>
    </table>
</asp:Content>
