<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CommonHeader.aspx.cs" Inherits="BulletinBoard_Framework_.Views.Main.CommonHeader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../Resources/css/common/common.css" type="text/css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <h1>SCM Bulletin Board</h1>
            <ul>
                <li>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" class="link">Users</asp:LinkButton>
                </li>
                <li>
                    <asp:LinkButton ID="LinkButton2" runat="server" class="link" style="text-decoration:underline">Posts</asp:LinkButton>
                </li>
            </ul>
            <div class="RightNavbar" style="margin-left:56%">
                <ul >
                    <li>
                       <asp:LinkButton ID="UserName" runat="server" class="link"></asp:LinkButton>
                    </li>
                    <li>
                      <asp:LinkButton ID="LinkButton3" runat="server" class="link" OnClick="LinkButton3_Click">Logout</asp:LinkButton>
                   </li>
               </ul>
            </div>
           
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Create Post" OnClick="Button1_Click" class="button CreateButton"/>

        </div>
        <div class="dataList">
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" AutoGenerateColumns="False" Width="60%" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="id">
                <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                <RowStyle BackColor="White" ForeColor="#003399" />
                <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                <SortedAscendingCellStyle BackColor="#EDF6F6" />
                <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                <SortedDescendingCellStyle BackColor="#D6DFDF" />
                <SortedDescendingHeaderStyle BackColor="#002876" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID"/>
                    <asp:BoundField DataField="title" HeaderText="Post Title"/>
                    <asp:BoundField DataField="description" HeaderText="Post Description"/>
                    <asp:BoundField DataField="name" HeaderText="Posted User"/>
                    <asp:BoundField DataField="PostedDate" HeaderText="Posted Date"/>
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
