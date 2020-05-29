<%@ Page Title="" Language="C#" MasterPageFile="~/View/Main.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Mukicik_backend.View.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:auto; margin-top:1%;">
        <tr>
            <td><asp:Label Text="Username" runat="server" /></td>
            <td><asp:TextBox ID="input_userName" Text="" runat="server" /></td>
            <td><asp:RequiredFieldValidator ErrorMessage="Must be filled!" forecolor="red" ControlToValidate="input_userName" runat="server" /></td>
        </tr>
        <tr>
            <td><asp:Label Text="Email Address" runat="server" /></td>
            <td><asp:TextBox ID="input_userEmailAddress" text="" textmode="Email" runat="server" /></td>
            <td><asp:RequiredFieldValidator ErrorMessage="Must be filled!" forecolor="red" ControlToValidate="input_userEmailAddress" runat="server" /></td>
        </tr>
        <tr>
            <td><asp:Label Text="Gender" runat="server" /> </td>
            <td>
                <asp:RadioButton Text="Male" runat="server" ID="Chk_Male" GroupName="gender"/>
            </td>
            <td>
                <asp:RadioButton Text="Female" runat="server" ID="Chk_Female" GroupName="gender"/>
            </td>
        </tr>
        <tr>
            <td><asp:Label ID="label_userDOB" Text="Date of Birth : " runat="server" /></td>
            <td>
                <asp:ScriptManager ID="scriptmanager_Calendar1" runat="server" />
                <asp:UpdatePanel ID="updatePanel_Calendar1" UpdateMode="Conditional" ChildrenAsTriggers="true" runat="server">
                    <ContentTemplate>
                        <asp:Calendar ID="Calendar1" OnSelectionChanged="Calendar1_SelectionChanged" runat="server"></asp:Calendar>
                        <asp:TextBox ID="input_userDOB" runat="server" />
                    </ContentTemplate>
                </asp:UpdatePanel>
                <asp:RequiredFieldValidator ID="validator_Calendar1" ForeColor="red" ErrorMessage="Select your Date of Birth!" ControlToValidate="input_userDOB" runat="server" />
            </td>
        </tr>
        <tr>
            <td><asp:Label Text="Profile Picture Link" runat="server" /></td>
            <td><asp:TextBox ID="input_userPP" runat="server"/></td>
        </tr>
        <tr>
            <td><asp:Label Text="Password" runat="server" /></td>
            <td><asp:TextBox ID="input_userPassword" textMode="Password" runat="server" /></td>
            <td><asp:RequiredFieldValidator ErrorMessage="Must be filled!" forecolor="red" ControlToValidate="input_userPassword" runat="server" /></td>
        </tr>
        <tr>
            <td><asp:Label Text="Repeat Password" runat="server" /></td>
            <td><asp:TextBox id="input_repeatUserPassword" textMode="Password" runat="server" /></td>
            <td><asp:RequiredFieldValidator ErrorMessage="Must be filled!" forecolor="red" ControlToValidate="input_repeatUserPassword" runat="server" /></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button id="registerButton" Text="Register" runat="server" onclick="userClick_registerButton"/>
                <asp:Label ID="labelError" Text="" ForeColor="red" visible="false" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>