<%@ Page Title="" Language="C#" MasterPageFile="~/bootstrapexe/Site2.Master" AutoEventWireup="true" CodeBehind="ShowSideBar.aspx.cs" Inherits="WebFormCases2.bootstrapexe.ShowSideBar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-sm-3 sidenav hidden-lg">
      <h2>&nbsp;</h2>
      <ul class="nav nav-pills nav-stacked">
        <li class="active"><a href="#section1">Active Page</a></li>
        <li><a href="/Page1.aspx?">Page1</a></li>
        <li><a href="/Page2.aspx?">Page2</a></li>      
        <li><a href="/Page3.aspx?">Page3 </a></li>
        <li><a href="/Page4.aspx?">Page4</a></li>
      </ul><br>
    </div>
</asp:Content>
