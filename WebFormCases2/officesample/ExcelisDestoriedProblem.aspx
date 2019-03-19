<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExcelisDestoriedProblem.aspx.cs" Inherits="WebFormCases2.officesample.ExcelisDestoriedProblem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     
        <asp:Button ID="Button1" runat="server" Text="download" OnClick="Button1_Click" />

             <%
            
             Response.Clear();
            Response.ContentType = "application/vnd.ms-excel";

            Response.AddHeader("Content-Disposition", "inline; filename=output.xls");
            Response.WriteFile(Server.MapPath("/officesample/My.xls"));
            Response.End();
            
            %>
      
    </form>
</body>
</html>
