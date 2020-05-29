<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="Mukicik_backend.View.testpurpose" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:Label Text="Upload Profile Picture" runat="server" /> <br />
            </td>
            <td>
                <asp:FileUpload ID="fileUpload1" runat="server"/> <br />
                <asp:Button ID="button_uploadProfilePicture" Text="Upload" runat="server" OnClick="UploadFile" /> <br />
            </td>
            <td>
                <asp:Image ID="image1" height="100" Width="100" runat="server" /> <br />
            </td>
        </tr>

        <tr>
            <td><asp:Calendar runat="server" ID="calendarTest"></asp:Calendar></td>
            <td><asp:Button Text="refresh" runat="server" onclick="Page_Load"/></td>
            <td><asp:Label ID="outputLabel" Text="" runat="server" /></td>
            <td><asp:Label ID="outputLabel2" Text="" runat="server" /></td>
        </tr>
        <tr>
            <td>
                <asp:RadioButton Text="Male" ID="button_male" runat="server" />
                <asp:RadioButton Text="Female" ID="button_female" runat="server" />
                <asp:Button Text="test" ID="button_gender" runat="server" onclick="button_gender_Click"/>
            </td>
            <td>
                <asp:Label ID="label_gender" Text="" runat="server" />
            </td>
        </tr>
        <tr>
            <td><asp:Label Text="Add category" runat="server" /></td>
            <td><asp:TextBox ID="input_addCategory" runat="server" /></td>
            <td><asp:Button OnClick="addCategory_click" Text="Add" runat="server" /></td>
        </tr>
        <tr>
            <td> <asp:GridView ID="gv_category" runat="server"> </asp:GridView></td>
        </tr>
    </table>
</asp:Content>
