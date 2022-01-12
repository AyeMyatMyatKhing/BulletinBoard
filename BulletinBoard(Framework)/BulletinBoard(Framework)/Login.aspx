<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BulletinBoard_Framework_.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div style="margin-left:400px;color:#4800ff">

           <h2>Login Form</h2>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
             <table class="auto-style1" border="0" dir="auto" style="text-align: left">
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtemail" runat="server" Height="30px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtpwd" runat="server" Height="30px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style2">
                    <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="LogIn" BackColor="#3333FF" BorderColor="#3333FF" ForeColor="Black" Height="35px" Width="75px" />
&nbsp;
                    <asp:Button ID="btncancel" runat="server" Text="Cancel" BackColor="#3333FF" BorderColor="#3333FF" Height="35px" Width="75px" OnClick="btncancel_Click" />
                </td>
            </tr>
        </table>
        </div>
       
    </form>
</body>
</html>
