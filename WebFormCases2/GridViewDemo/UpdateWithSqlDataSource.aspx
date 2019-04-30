<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateWithSqlDataSource.aspx.cs" Inherits="WebFormCases2.GridViewDemo.UpdateWithSqlDataSource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateEditButton="true" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1"  OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
               <asp:TemplateField HeaderText="name">
                   <ItemTemplate>
                       <asp:Label ID="Label1" runat="server" Text='<%# Eval("name") %>'></asp:Label>
                   </ItemTemplate>
                   <EditItemTemplate>
                       <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%#Bind("name") %>'>
                           <asp:ListItem Value="tili" Text="tili"></asp:ListItem>
                             <asp:ListItem Value="miqi" Text="miqi"></asp:ListItem>
                             <asp:ListItem Value="kiti" Text="kiti"></asp:ListItem>
                             <asp:ListItem Value="nancy" Text="nancy"></asp:ListItem>
                            <asp:ListItem Value="customize" Text="customize"></asp:ListItem>
                       </asp:DropDownList>
                   </EditItemTemplate>
               </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EntityDb %>" SelectCommand="SELECT [id], [name] FROM [Entity1]" DeleteCommand="DELETE FROM [Entity1] WHERE [id] = @id" InsertCommand="INSERT INTO [Entity1] ([name]) VALUES (@name)" UpdateCommand="UPDATE [Entity1] SET [name] = @name WHERE [id] = @id">
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="id" Type="Int32" />

            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
