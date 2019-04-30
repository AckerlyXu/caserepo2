<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="PagingAndInvisible.aspx.vb" Inherits="VbCases.PagingAndInvisible" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  ShowHeader="False" DataKeyNames="Rep_Code" HorizontalAlign="Center" BorderStyle="None" AllowPaging="True" PageSize="2"
              OnRowDataBound ="GridView1_RowDataBound"  OnPageIndexChanging="GridView1_PageIndexChanging" 
             >
            <Columns>
                <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="NT_GROUP" SortExpression="NT_GROUP" >
                    <ItemTemplate>
                        <asp:Label ID="lblGroup" runat="server" Text='<%# Eval("NT_GROUP") %>' Visible="True"></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="Rep_Code" SortExpression="Rep_Code" >
                    <ItemTemplate>
                        <asp:Label ID="lblCode" runat="server" Text='<%# Eval("Rep_Code") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
               
                <asp:BoundField DataField="Rep_Name" HeaderText="Report" SortExpression="Rep_Name" >
                <ItemStyle Font-Names="Verdana" Font-Size="small" ForeColor="Black" Wrap="False" />
                </asp:BoundField>
            </Columns>
            <PagerSettings FirstPageText="First&amp;nbsp;" LastPageText="&amp;nbsp;Last" Mode="NextPreviousFirstLast" NextPageText="Next" PreviousPageText="Previous" />
            <PagerStyle ForeColor="Navy" HorizontalAlign="Center" Wrap="False" />
        </asp:GridView>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>
    </form>
</body>
</html>
