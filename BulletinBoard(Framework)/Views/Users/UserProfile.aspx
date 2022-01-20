<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Users.UserProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resources/css/common/common.css" rel="stylesheet" type="text/css"/>
    <style type="text/css">
        .auto-style1 {
            width: 60%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="post">
            <h3>User Profile</h3>
            <div>

                <table class="auto-style1">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Image ID="Image1" runat="server" Height="90px" Width="90px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Email Address"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text="Type"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblType" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text="Phone"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblPhone" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text="Date of birth"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblDob" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblAddress" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                </table>

            </div>
        </div>
    </form>
</body>
</html>
