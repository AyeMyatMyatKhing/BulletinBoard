<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Users.CreateUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resources/css/common/common.css" Type="text/css" rel="stylesheet"/>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
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
        .auto-style5 {
            width: 121px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="post">
            <table  class="auto-style1">
                <tr>
                    <td colspan="2"><h2>Registration form</h2></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtName" runat="server" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredName" ErrorMessage="*" Display="Dynamic" runat="server" ControlToValidate="txtName" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server" ID="validate" ControlToValidate="txtName" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Email Address"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ErrorMessage="*" Display="Dynamic" runat="server" ControlToValidate="txtEmail" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator1" ControlToValidate="txtEmail" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Password" ></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" class="textbox" MaxLength="30"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ErrorMessage="*" runat="server" Display="Dynamic" ControlToValidate="txtPassword" ForeColor="Red"></asp:RequiredFieldValidator>
                         <asp:RegularExpressionValidator runat="server" ID="RegularExpressionValidator2" ControlToValidate="txtPassword" ValidationExpression="[\s\S]{0,50}" ErrorMessage="Only 50 characters are allowed" ForeColor="red" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label10" runat="server" Text="Confirm Password" ></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtRePassword" runat="server" TextMode="Password" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredConfirmPassword" ErrorMessage="*" runat="server" ControlToValidate="txtRePassword" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
                         <asp:CompareValidator ID="ComparePassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtRePassword" Display="Dynamic" ErrorMessage="Password do not match." ForeColor="Red"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label5" runat="server" Text="Type"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="DropDownList1" runat="server" Height="22px">
                            <asp:ListItem Selected="True">Choose type</asp:ListItem>
                            <asp:ListItem>Admin</asp:ListItem>
                            <asp:ListItem>User</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredType" InitialValue="Choose type" ErrorMessage="*" Display="Dynamic" runat="server" ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text="Phone" ></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtPhone" runat="server" class="textbox" TextMode="Phone"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredPhone" ErrorMessage="*" Display="Dynamic" runat="server" ControlToValidate="txtPhone" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtPhone" ErrorMessage="Invalid number." ForeColor="Red" ValidationExpression="^[0-9]*$" Display="Dynamic"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label7" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtAddress" runat="server" class="textbox" TextMode="MultiLine"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredAddress" ErrorMessage="*" Display="Dynamic" runat="server" ControlToValidate="txtAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Text="Date of birth" ></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDob" runat="server" TextMode="Date" class="textbox"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredDob" ErrorMessage="*" Display="Dynamic" runat="server" ControlToValidate="txtDob" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="ValidateDob" runat="server" ControlToValidate="txtDob" Display="Dynamic" MinimumValue="12/31/1950" MaximumValue="12/31/2020" Type="Date" Text="Invalid date" ForeColor="Red"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label9" runat="server" Text="Profile" ></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:FileUpload ID="uploadProfile" runat="server" class="textbox" />
                        <asp:RequiredFieldValidator ID="RequiredProfile" ErrorMessage="*" Display="Dynamic" runat="server" ControlToValidate="uploadProfile" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Button ID="btnConfirm" runat="server" OnClick="btnConfirm_Click" Text="Confirm" class="button" />
&nbsp;&nbsp;
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" class="button" causesvalidation="false"/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                         <h4>If already have an account, please <asp:LinkButton ID="login" runat="server" causesvalidation="false" OnClick="login_Click1">Login</asp:LinkButton>.</h4>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
