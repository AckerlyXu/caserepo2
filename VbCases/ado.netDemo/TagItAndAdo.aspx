<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TagItAndAdo.aspx.vb" Inherits="VbCases.TagItAndAdo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.2/jquery.min.js" type="text/javascript" charset="utf-8"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.12/jquery-ui.min.js" type="text/javascript" charset="utf-8"></script>

    <script src="../Scripts/tag-it.js"></script>
    <link rel="stylesheet" type="text/css" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1/themes/flick/jquery-ui.css" />

    <link href="../Content/jquery.tagit.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1"  CancelControlID="Button3" TargetControlID="Button2"></ajaxToolkit:ModalPopupExtender>
       

          
           <asp:Button ID="Button2" runat="server" Text="open pop up" />
        <asp:Panel ID="Panel1" runat="server" CssClass="modalPopup" align="center">
             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
   <ul id="myTags">
    <!-- Existing list items will be pre-added to the tags -->
    <% For Each tag In tags
                %>
    <li> <%=tag %></li>
    <%   Next
        %>

</ul>

        <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
        <asp:HiddenField ID="HiddenField1" runat="server" />


            <asp:Button ID="Button3" runat="server" Text="Close" />
             </ContentTemplate>

        </asp:UpdatePanel>
   
</asp:Panel>
 
      <%--  <input  type="button" onclick="showValues()" value="click"/>--%>

         <script type="text/javascript">
       //      function showValues() {
       //          var values = [];
       //$.each($("input[name=tags]"), function (index, ele) {
       //    values.push(ele.value);
         
       //          })
       //            alert(values);
       //      }
    $(document).ready(function() {
        $("#myTags").tagit();
    
        var tagArr = [];
        $.each($("input[name=tags]"), function (index, ele) {
            tagArr.push(ele.value);
        })
        $("#<%= HiddenField1.ClientID%>").val(tagArr.join(","))
    });
</script>
    </form>
</body>
</html>

