<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormCases2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <script>
        $(function () {
            console.log($("#<%=Button1.ClientID%>"));
        })
    </script>
</asp:Content>
