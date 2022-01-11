<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Posts.EditPost" %>

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
            height: 54px;
        }
        .auto-style4 {
            height: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:400px">
            <h2 style="color:#3333FF">Edit Post</h2>
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
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Description" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style4">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" Height="33px" OnClick="btnUpdate_Click" BackColor="#3333FF" BorderColor="#3333FF" />
&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Height="33px" BackColor="#3333FF" BorderColor="#3333FF" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
