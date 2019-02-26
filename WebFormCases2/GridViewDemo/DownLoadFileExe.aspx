<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DownLoadFileExe.aspx.cs" Inherits="WebFormCases2.GridViewDemo.DownLoadFileExe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-3.3.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="false">
            <Columns>
              <asp:TemplateField>
                  <ItemTemplate>
                      <asp:LinkButton ID="LinkButton1" runat="server" Text='<%#Eval("fileName") %>' OnClick="LinkButton1_Click"></asp:LinkButton>
                  </ItemTemplate>
              </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <div id="content">
            
        </div>
       
        <script>

           
        </script>
    </form>
</body>
</html>
