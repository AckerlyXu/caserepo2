<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccordionTwo.aspx.cs" Inherits="WebFormCases2.AjaxTookKitDemo.AccordionTwo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <ajaxToolkit:Accordion ID="Accordion1" runat="server">
            <ContentTemplate> <%# Eval("content") %></ContentTemplate>
            <HeaderTemplate> <%# Eval("header") %></HeaderTemplate>
            
        </ajaxToolkit:Accordion>
        <ajaxToolkit:Accordion ID="Accordion2" runat="server">
            <ContentTemplate> <%# Eval("content") %></ContentTemplate>
            <HeaderTemplate><%# Eval("header") %></HeaderTemplate>
            
        </ajaxToolkit:Accordion>
    </form>
</body>
</html>
