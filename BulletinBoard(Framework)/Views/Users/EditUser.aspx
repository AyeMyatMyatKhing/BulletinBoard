<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Users.EditUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resources/css/common/common.css" Type="text/css" rel="stylesheet"/>
<style type="text/css">
        .auto-style1 {
            width: 65%;
        }
        .auto-style3 {
            width: 194px;
            height: 50px;
        }
        .auto-style4 {
            height: 50px;
        }
        .auto-style5 {
            width: 194px;
            height: 51px;
        }
        .auto-style6 {
            height: 51px;
        }
        .auto-style8 {
        height: 45px;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="post">
             <table class="auto-style1">
                 <tr>
                     <td colspan="2">
                           <h2>Edit User</h2>
                     </td>
                 </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label runat="server" Text="Name" ></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtname" runat="server" class="textbox"></asp:TextBox>
                        <asp:RegularExpressionValidator runat="server" ID="validate" ControlToValidate="txtname" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtemail" runat="server" class="textbox" TextMode="Email"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" Text="Please provide a valid email address" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" ControlToValidate="txtemail" ForeColor="Red"></asp:RegularExpressionValidator>
                        <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator2" ControlToValidate="txtemail" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Label ID="Label3" runat="server" Text="Type"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>admin</asp:ListItem>
                            <asp:ListItem>user</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Phone" ></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtphone" runat="server" class="textbox" TextMode="Phone"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                     <td class="auto-style6">
                         <asp:Label ID="Label1" runat="server" Text="Date of birth"></asp:Label>
                     </td>
                     <td class="auto-style6">
                         <asp:TextBox ID="txtDob" runat="server" class="textbox"></asp:TextBox>
                     </td>
                 </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtaddr" runat="server" class="textbox" TextMode="MultiLine"></asp:TextBox>
                        <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator3" ControlToValidate="txtaddr" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                 <tr>
                     <td class="auto-style4">
                         <asp:Label ID="Label5" runat="server" Text="Profile"></asp:Label>
                     </td>
                     <td class="auto-style4">
                         <asp:FileUpload ID="profileUpload" runat="server" class="textbox"/>
                     </td>
                 </tr>
                 <tr>
                     <td></td>
                     <td>
                          <asp:Image ID="profile" runat="server" Height="90px" Width="90px"/>
                     </td>
                 </tr>
                 <tr>
                     <td colspan="2" class="auto-style8">
                         <asp:LinkButton ID="changePwd" runat="server" OnClick="changePwd_Click">Change Password</asp:LinkButton>
                     </td>
                 </tr>
                 <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="btnconfirm" runat="server" OnClick="btnconfirm_Click" Text="Confirm"  class="button"/>
&nbsp;
                        <asp:Button ID="btncancel" runat="server" Text="Cancel" class="button" OnClick="btncancel_Click" />
                    </td>
                 </tr>
            </table>
        </div>
    </form>
</body>
</html>
