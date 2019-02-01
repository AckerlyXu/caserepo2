<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowUsersUsingUserManager.aspx.cs" Inherits="WebFormCases2.IdentityExe.ShowUsersUsingUserManager" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="Id" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"  OnRowDataBound="GridView1_RowDataBound" AutoGenerateEditButton="true" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="UserName"  HeaderText="username"/>
                <asp:BoundField DataField="PasswordHash" HeaderText="PasswordHash" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:TemplateField HeaderText="Role">
                    <ItemTemplate>
                        <%# Eval("Role") %>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
