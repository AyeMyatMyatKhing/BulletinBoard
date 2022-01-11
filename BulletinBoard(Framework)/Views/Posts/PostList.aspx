<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostList.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Posts.PostList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left:300px">
            <h2 style="color:#4800ff">Post Lists</h2>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="id">
                <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
                <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
                <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#594B9C" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#33276A" />
                <Columns>
                    <asp:BoundField  HeaderText="Id" DataField="id"/>
                    <asp:BoundField HeaderText="Post Title" DataField="title"/>
                    <asp:BoundField HeaderText="Post Description" DataField="description"/>
                    <asp:BoundField HeaderText="Posted User" DataField="create_user_id"/>
                    <asp:BoundField HeaderText="Posted Date" DataField="created_at"/>
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
