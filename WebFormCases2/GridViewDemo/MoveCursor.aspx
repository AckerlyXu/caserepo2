<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MoveCursor.aspx.cs" Inherits="WebFormCases2.GridViewDemo.MoveCursor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width:100px;overflow:scroll;height:200px">
        <asp:GridView ID="GridView1" runat="server">

            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" AutoPostBack="true"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
                      
                 
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </div>
          
        
    </form>
</body>
</html>
