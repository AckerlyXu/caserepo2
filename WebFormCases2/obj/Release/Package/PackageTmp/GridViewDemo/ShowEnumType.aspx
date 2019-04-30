<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEnumType.aspx.cs" Inherits="WebFormCases2.GridViewDemo.ShowEnumType" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateEditButton="true"  AutoGenerateColumns="false" SelectMethod="GridView1_GetData" ItemType="WebFormCases2.Models.school.ServiceConfiguration" UpdateMethod="GridView1_UpdateItem">
            <Columns>
                <asp:BoundField  DataField="SeviceName" HeaderText="ServiceName"/>
                  <asp:BoundField  DataField="DisplayName"  HeaderText="DisplayName"/>
                  <asp:BoundField  DataField="MachineName"  HeaderText="MachineName"/>
                  <asp:BoundField DataField="Parameter" HeaderText="Parameter" />
                
                <asp:DynamicField DataField="Type" HeaderText="Type" />
            </Columns>
        </asp:GridView>
    </form>
   
</body>
</html>
