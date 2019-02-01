<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SelectIndexEventToChangebkcolorOfGridViewRow.aspx.vb" Inherits="VbCases.SelectIndexEventToChangebkcolorOfGridViewRow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="kgrid" runat="server" OnDataBound="kgrid_DataBound" AutoGenerateColumns="false" >
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox11" runat="server" Text="<%# GetDataItem().ToString() %>"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text="the second column"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>


        <asp:DropDownList ID="ponumtxt" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>OPEN</asp:ListItem>
            <asp:ListItem>PENDING</asp:ListItem>
            <asp:ListItem>CLOSED</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
