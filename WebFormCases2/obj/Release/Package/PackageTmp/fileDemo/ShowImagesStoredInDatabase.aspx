<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowImagesStoredInDatabase.aspx.cs" Inherits="WebFormCases2.fileDemo.ShowImagesStoredInDatabase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CategoryID" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:BoundField DataField="CategoryID" HeaderText="CategoryID" InsertVisible="False" ReadOnly="True" SortExpression="CategoryID"  />
                <asp:BoundField DataField="CategoryName" HeaderText="CategoryName" SortExpression="CategoryName" />
                <asp:TemplateField HeaderText=" show images using ashx">
                    <ItemTemplate>
                        <img  src ='/Services/WriteImages.ashx?id=<%# Eval("CategoryID")  %>' />
                    </ItemTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText=" show images using base64">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server"  />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            </Columns>
        </asp:GridView>

        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT [CategoryID], [CategoryName], [Description],[image] FROM [Categories]"></asp:SqlDataSource>
    </form>
</body>
</html>
