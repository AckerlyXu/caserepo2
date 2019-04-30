<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployWithDepart.aspx.cs" Inherits="WebFormCases2.GridViewDemo.OneToMany.EmployWithDepart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnRowDataBound="GridView1_RowDataBound">
            <Columns>
                <asp:BoundField DataField="name" HeaderText="name" />
                <asp:BoundField DataField="salary" HeaderText="salary" />
               <asp:TemplateField HeaderText="department">

                   <ItemTemplate>
                      
                   </ItemTemplate>


               </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
