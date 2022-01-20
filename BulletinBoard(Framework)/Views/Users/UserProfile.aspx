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
        .auto-style2 {
            height: 50px;
        }
        .auto-style4 {
            height: 51px;
        }
        .auto-style5 {
            height: 50px;
            width: 128px;
        }
        .auto-style7 {
            height: 51px;
            width: 128px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="post">
            <div>
                <table class="auto-style1">
                    <tr>
                        <td colspan="2">
                             <h2>User Profile</h2>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Image ID="profile" runat="server" Height="90px" Width="90px"/>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label1" runat="server" Text="Name:" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="lblName" runat="server" Font-Italic="True"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label2" runat="server" Text="Email Address:" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="lblEmail" runat="server" Font-Italic="True" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label3" runat="server" Text="Type:" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="lblType" runat="server" Font-Italic="True" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            <asp:Label ID="Label4" runat="server" Text="Phone:" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="auto-style4">
                            <asp:Label ID="lblPhone" runat="server" Font-Italic="True" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label5" runat="server" Text="Date of birth:" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="lblDob" runat="server" Font-Italic="True" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">
                            <asp:Label ID="Label6" runat="server" Text="Address:" Font-Bold="True"></asp:Label>
                        </td>
                        <td class="auto-style2">
                            <asp:Label ID="lblAddress" runat="server" Font-Italic="True" ></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            <asp:Button ID="Back" runat="server" Text="Back" class="button" OnClick="Back_Click" Width="80px"/>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
