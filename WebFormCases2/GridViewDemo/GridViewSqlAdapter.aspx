<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewSqlAdapter.aspx.cs" Inherits="WebFormCases2.GridViewDemo.GridViewSqlAdapter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .hide{
            display:none
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" DataKeyNames="InfoId" runat="server" OnRowDataBound="GridView1_RowDataBound" AutoGenerateSelectButton="true"  OnRowEditing ="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnPageIndexChanging="GridView1_PageIndexChanging" OnPageIndexChanged="GridView1_PageIndexChanged">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:DropDownList ID="DropDownList1" runat="server" Visible="false"></asp:DropDownList>
                        
                    </ItemTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField   HeaderStyle-CssClass="hide">
                    <ItemStyle  CssClass="hide" />
                    <ItemTemplate>
                        <asp:HiddenField ID="HiddenField2" runat="server" Value="abc" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
       <%-- <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>--%>
        <asp:Button ID="Button1" runat="server" Text="Button"  OnClick="Button1_Click"/>
       
    </form>
</body>
</html>
