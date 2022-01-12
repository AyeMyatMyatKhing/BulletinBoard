<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Users.CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 65%;
        }
        .auto-style2 {
            height: 51px;
        }
        .auto-style3 {
            height: 50px;
        }
        .auto-style4 {
            height: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:400px">
           <h2 style="color:#4800ff">Create User</h2>
            <br />
            <br />
            <table  class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Name" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtName" runat="server" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Email Address" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Password" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label10" runat="server" Text="Confirm Password" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtRePassword" runat="server" TextMode="Password" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Type" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="22px">
                            <asp:ListItem>Admin</asp:ListItem>
                            <asp:ListItem>User</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="Phone" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPhone" runat="server" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label7" runat="server" Text="Address" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtAddress" runat="server" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Text="Date of birth" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDob" runat="server" TextMode="Date" Height="22px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label9" runat="server" Text="Profile" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:FileUpload ID="uploadProfile" runat="server" Height="22px" />
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" BackColor="#3333FF" BorderColor="#3333FF" Height="35px" />
&nbsp;&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" BackColor="#3333FF" BorderColor="#3333FF" Height="35px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
