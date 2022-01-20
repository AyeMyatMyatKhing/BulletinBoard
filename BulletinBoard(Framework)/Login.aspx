<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BulletinBoard_Framework_.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Resources/css/common/common.css" type="text/css" rel="stylesheet"/>
    <style type="text/css">
        .auto-style1 {
            height: 36px;
        }
        .auto-style3 {
            height: 50px;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
        <div class="post">
           <table class="auto-style1">
               <tr>
                   <td colspan="2">
                         <h2>Login Form</h2>
                   </td>
               </tr>
             <tr>
                 <td colspan="2">
                     <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
                 </td>
             </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtemail" runat="server" class="textbox"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style3">
                    <asp:TextBox ID="txtpwd" runat="server" class="textbox"></asp:TextBox>
                </td>
            </tr>
               <tr>
                   <td></td>
                   <td>
                       <asp:LinkButton ID="forgotPassword" runat="server" OnClick="forgotPassword_Click">forgot password?</asp:LinkButton>
                   </td>
               </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="LogIn" class="button" />
&nbsp;
                    <asp:Button ID="btncancel" runat="server" Text="Cancel" class="button" OnClick="btncancel_Click" />
                </td>
            </tr>
        </table>
        </div>
       
    </form>
</body>
</html>
