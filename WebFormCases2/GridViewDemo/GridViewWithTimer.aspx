<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewWithTimer.aspx.cs" Inherits="WebFormCases2.GridViewDemo.GridViewWithTimer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                 <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" PageSize="2" AllowPaging="true"></asp:GridView>
                  <asp:Timer ID="Timer1" runat="server"  Interval="10000"  OnTick="Timer1_Tick"></asp:Timer>
               
            </ContentTemplate>

        </asp:UpdatePanel>
       <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EntityDb %>" SelectCommand="SELECT * FROM [customer]"></asp:SqlDataSource>
       
    </form>
</body>
</html>
