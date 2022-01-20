<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForgotPassword.aspx.cs" Inherits="BulletinBoard_Framework_.ForgotPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Resources/css/common/common.css" rel="stylesheet" type="text/css"/>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            height:30%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="post">
            <table>
                <tr>
                    <td colspan="2">
                         <h2>Please enter your Email address</h2>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" class="textbox"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSend" runat="server" Text="Send" class="button" OnClick="btnSend_Click"/>
&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="button"/>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
