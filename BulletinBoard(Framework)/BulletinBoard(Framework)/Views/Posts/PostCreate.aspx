<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostCreate.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Posts.PostCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
        .auto-style2 {
            height: 50px;
        }
        .auto-style3 {
            height: 52px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:400px">
            <h2 style="color:#4800ff">Create Post</h2>
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Title" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Description" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style3">
                        <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" BackColor="#3333FF" BorderColor="#3333FF" Height="33px" />
&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" BackColor="#3333FF" BorderColor="#3333FF" Height="33px" />
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
