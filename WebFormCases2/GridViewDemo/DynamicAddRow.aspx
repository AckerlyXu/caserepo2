<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicAddRow.aspx.cs" Inherits="WebFormCases2.GridViewDemo.DynamicAddRow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand" OnPageIndexChanging="GridView1_PageIndexChanging" AllowPaging="true" PageSize="1" OnSorting="GridView1_Sorting" AllowSorting="true">
            <Columns>
               <asp:TemplateField>
                   <ItemTemplate>
                       <asp:Button ID="Button2" runat="server" Text="Button" CommandName="Insert" />
                   </ItemTemplate>
               </asp:TemplateField>
            </Columns>
        </asp:GridView>
          <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
  
</body>
</html>
