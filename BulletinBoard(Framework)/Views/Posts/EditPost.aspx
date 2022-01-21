<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPost.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Posts.EditPost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resources/css/common/common.css" type="text/css" rel="stylesheet"/>
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
        <div class="post">
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <h2>Edit Post</h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Title" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtTitle" runat="server" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="requiredTitle" runat="server" ControlToValidate="txtTitle" ErrorMessage="*" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server" ID="validate" ControlToValidate="txtTitle" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Description" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Requireddescription" runat="server" ControlToValidate="txtDescription" ErrorMessage="*" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style4">
                        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" class="button"/>
&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" causesvalidation="false" OnClick="btnCancel_Click" class="button"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
