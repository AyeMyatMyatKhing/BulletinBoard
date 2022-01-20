<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserList.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Users.UserList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resources/css/common/common.css" Type="text/css" rel="stylesheet"/>
    </head>
<body>
    <form id="form1" runat="server">
        <div class="showList">
            <h2>User List&nbsp;
                <asp:Button ID="btnBack" runat="server" Text="Back" class="button" OnClick="btnBack_Click"/>
            </h2>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AutoGenerateColumns="False" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="id" OnRowCommand="GridView1_RowCommand" Width="800px" AllowPaging="true" PageIndex="10" OnPageIndexChanging="GridView1_PageIndexChanging">
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle ForeColor="#003399" HorizontalAlign="Left" BackColor="#99CCCC" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
            <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID"/>
                    <asp:BoundField  DataField="name" HeaderText="Name"/>
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField  DataField="phone" HeaderText="Phone"/>
                    <asp:BoundField DataField="address" HeaderText="Address" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button  ID="btnEdit" runat="server" Text="Edit" CommandName="EditButton" CommandArgument="<%#((GridViewRow)Container).RowIndex %>"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowDeleteButton="true" ButtonType="Button"/>
            </Columns>
        </asp:GridView>
        </div>
        
    </form>
</body>
</html>
