<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="Mukicik_backend.View.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <br />
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
            <td> Selected Item</td>
            <td> <asp:TextBox ID="input_productName" ReadOnly="true" runat="server" /> </td>
        </tr>
        <tr>
            <td> Item price</td>
            <td> <asp:TextBox ID="input_productPrice" ReadOnly="true" runat="server" /> </td>
        </tr>
        <tr>
            <td> Quantity </td>
            <td> <asp:TextBox ID="input_productQuantity" runat="server" /></td>
            <td> <asp:RequiredFieldValidator ErrorMessage="Required" ForeColor="red" ControlToValidate="input_productQuantity" runat="server" /></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button ID="button_addToCart" Text="Add to cart" runat="server" OnClick="button_addToCart_Click" /></td>
            <td><asp:Label ID="label_error" Text="" runat="server" ForeColor="red" /></td>
        </tr>
    </table>
    
</asp:Content>
