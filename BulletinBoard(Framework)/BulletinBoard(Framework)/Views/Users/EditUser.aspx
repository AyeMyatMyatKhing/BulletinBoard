<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditUser.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Users.EditUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style7 {
            width: 450px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:350px;margin-top:50px">
            <div class="auto-style7">
                <h2 style="color:#4800ff">Edit User</h2>
                <%-- <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Large" Text="Edit User"></asp:Label>
                 <asp:Image ID="profile" runat="server" Height="100px" Width="100px" style="float:right" ImageUrl ='"image.ashx?id="+id'/>--%>
             <%--   <img  alt="profile" src="image. ?id=<%#Eval("id") %>" style="float:right;width:100px;height:100px"/>--%>
            </div>
           
            <br />
            <br />
            
             <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label runat="server" Text="Name" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtname" runat="server" Height="30px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="Email" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtemail" runat="server" Height="30px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Phone" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtphone" runat="server" Height="30px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="Address" ForeColor="#003399"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtaddr" runat="server" Height="30px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="btnconfirm" runat="server" OnClick="btnconfirm_Click" Text="Confirm" BackColor="#3333FF" BorderColor="#3333FF" Height="35px" />
&nbsp;
                        <asp:Button ID="btncancel" runat="server" Text="Cancel" BackColor="#3333FF" BorderColor="#3333FF" Height="35px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
