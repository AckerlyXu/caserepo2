<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowEnumUsingDynamicControl.aspx.cs" Inherits="WebFormCases2.GridViewDemo.ShowEnumUsingDynamicControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
         <asp:GridView ID="GridView1" runat="server" AutoGenerateEditButton="true"  OnRowEditing="GridView1_RowEditing" AutoGenerateColumns="false" OnRowDataBound="GridView1_RowDataBound" >
            <Columns>
                <asp:BoundField  DataField="SeviceName" HeaderText="ServiceName"/>
                  <asp:BoundField  DataField="DisplayName"  HeaderText="DisplayName"/>
                  <asp:BoundField  DataField="MachineName"  HeaderText="MachineName"/>
                  <asp:BoundField DataField="Parameter" HeaderText="Parameter" />
                
               <asp:TemplateField HeaderText="Type">
                   <ItemTemplate>
                       <%# Eval("Type") %>
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
