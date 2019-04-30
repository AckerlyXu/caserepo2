<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeatreOnDataBoundDemo.aspx.cs" Inherits="WebFormCases2.extraControls.RepeatreOnDataBoundDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Repeater ID="Repeater1" runat="server" OnItemDataBound="Repeater1_ItemDataBound">
           <HeaderTemplate>
               <table border="1">
                   <tr> <td>name</td><td>image</td></tr>
           </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("name") %>' ></asp:Label></td>
                  <td>
                      <asp:Image ID="Image1" runat="server"   />
                  </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
           </table>
                </FooterTemplate>
        </asp:Repeater>
    </form>
</body>
</html>
