<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostCreate.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Posts.PostCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resources/css/common/common.css" type="text/css" rel="stylesheet"/>
    <style type="text/css">
        .auto-style1 {
            width: 53%;
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
        <div class="post">
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                         <h2>Create Post</h2>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Title" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtTitle" runat="server" class="textbox"></asp:TextBox> 
                        <asp:RegularExpressionValidator runat="server" ID="validate" ControlToValidate="txtTitle" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="TitleValidator" ErrorMessage="*" ControlToValidate="txtTitle" runat="server" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Description" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" class="textbox"></asp:TextBox>
                        <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="txtDescription" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="DescriptionValidator" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtDescription" runat="server" ForeColor="red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style3">
                        <asp:Button ID="btnCreate" runat="server" Text="Create" OnClick="btnCreate_Click" class="button"/>
&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="button" OnClick="btnCancel_Click" CausesValidation="false"/>
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
