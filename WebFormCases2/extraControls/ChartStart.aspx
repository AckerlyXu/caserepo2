<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChartStart.aspx.cs" Inherits="WebFormCases2.extraControls.ChartStart" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Chart ID="Chart1" runat="server" >
            <Series >
                <asp:Series Name="Series1"></asp:Series>
            </Series>
              <%-- <Series>
                <asp:Series Name="Series2"></asp:Series>
            </Series>--%>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1" >
                   
                </asp:ChartArea>
            </ChartAreas>
            
        </asp:Chart>
    </form>
</body>
</html>
