<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlDataSourceProgramAddParameter.aspx.cs" Inherits="WebFormCases2.sqldbexe.SqlDataSourceProgramAddParameter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         
         <asp:GridView ID="GridView1" runat="server"  ></asp:GridView>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:testConnectionString %>" ProviderName="<%$ ConnectionStrings:testConnectionString.ProviderName %>" SelectCommand="SELECT [name] FROM [customer] "  >
        
      
        </asp:SqlDataSource>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
