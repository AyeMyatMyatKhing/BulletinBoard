<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Users.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resources/css/common/common.css" rel="stylesheet" type="text/css"/>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
        }
        .auto-style2 {
            height: 50px;
        }
        .auto-style3 {
            height: 47px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="post">
            <table class="auto-style1">
                <tr>
                    <td colspan="2"><h2>Change Password</h2></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Old Password"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtOldpass" runat="server" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="OldPassValidator" ErrorMessage="*" runat="server" Display="Dynamic" ControlToValidate="txtOldpass" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator2" ControlToValidate="txtOldpass" ValidationExpression="^[a-zA-Z0-9'@&#.\s]{7,}$" ErrorMessage="Password must be at least 7 characters long" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtNewpass" runat="server" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="*" runat="server" Display="Dynamic" ControlToValidate="txtNewpass" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="txtNewpass" ValidationExpression="^[a-zA-Z0-9'@&#.\s]{7,}$" ErrorMessage="Password must be at least 7 characters long" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Confirm new password"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtConfirmNewpass" runat="server" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredConfirmPassword" ErrorMessage="*" runat="server" ControlToValidate="txtConfirmNewpass" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                         <asp:CompareValidator ID="ComparePassword" runat="server" ControlToCompare="txtNewpass" ControlToValidate="txtConfirmNewpass" Display="Dynamic" ErrorMessage="Password do not match." ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style3">
                        <asp:Button ID="btnChange" runat="server" Text="Change" class="button" OnClick="btnChange_Click"/>
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="button" OnClick="btnClear_Click" CausesValidation="false"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
