<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SortStringUsingRownum.aspx.cs" Inherits="WebFormCases2.csharpDemp.SortStringUsingRownum" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <ajaxToolkit:Accordion ID="EntreeAc" runat="server"  RequireOpenedPane="False">
            <HeaderTemplate> <%#Eval("header") %></HeaderTemplate>
            <ContentTemplate>
              
                     <%#Eval("content") %>
                             
            </ContentTemplate>
        </ajaxToolkit:Accordion>
      
        <ajaxToolkit:Accordion ID="SidesAc" runat="server" RequireOpenedPane="False">
            <HeaderTemplate> <%#Eval("header") %></HeaderTemplate>

                         <ContentTemplate>
              
                     <%#Eval("content") %>
                             
            </ContentTemplate>        
                             
            
        </ajaxToolkit:Accordion>
    </form>
</body>
</html>
