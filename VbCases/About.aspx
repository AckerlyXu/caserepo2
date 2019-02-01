<%@ Page Title="About" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.vb" Inherits="VbCases.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <p>Your app description page.</p>
    <p>Use this area to provide additional information.</p>
  
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:FileUpload ID="FileUpload1" runat="server" />
</asp:Content>
