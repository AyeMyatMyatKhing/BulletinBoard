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
        .auto-style7 {
            width: 450px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="post">
            <div class="auto-style7">
                <%-- <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Large" Text="Edit User"></asp:Label>
                 <asp:Image ID="profile" runat="server" Height="100px" Width="100px" style="float:right" ImageUrl ='"image.ashx?id="+id'/>--%>
             <%--   <img  alt="profile" src="image. ?id=<%#Eval("id") %>" style="float:right;width:100px;height:100px"/>--%>
            </div>
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
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="txtemail" runat="server" class="textbox" TextMode="Email"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Display="Dynamic" Text="Please provide a valid email address" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$" ControlToValidate="txtemail" ForeColor="Red"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Phone" ></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtphone" runat="server" class="textbox" TextMode="Phone"></asp:TextBox>
                        <%--<asp:RegularExpressionValidator ID="ValidatePhone" runat="server" Display="Dynamic" Text="RegularExpressionError" ControlToValidate="txtPhone" ValidationExpression="[0-9]{10}" ForeColor="red"></asp:RegularExpressionValidator>--%>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtaddr" runat="server" class="textbox" TextMode="MultiLine"></asp:TextBox>
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
