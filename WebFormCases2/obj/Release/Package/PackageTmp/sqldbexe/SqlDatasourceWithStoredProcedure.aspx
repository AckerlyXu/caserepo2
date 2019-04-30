<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SqlDatasourceWithStoredProcedure.aspx.cs" Inherits="WebFormCases2.sqldbexe.SqlDatasourceWithStoredProcedure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EntityDb %>" SelectCommand="mysp" SelectCommandType="StoredProcedure">
        <SelectParameters>
            <asp:Parameter DefaultValue="12" Name="id" Type="Int32" />
           <%--  <asp:Parameter DefaultValue="w" Name="address" Type="string" />
              <asp:Parameter DefaultValue="1" Name="apprYears" Type="string" />--%>
         
        </SelectParameters>
    </asp:SqlDataSource>
</body>
</html>
