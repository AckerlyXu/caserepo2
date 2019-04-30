<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jquerytabcrud.aspx.cs" Inherits="WebFormCases2.JqueryPlugins.jquerytabcrud" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.5.2/jquery.min.js" type="text/javascript" charset="utf-8"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.12/jquery-ui.min.js" type="text/javascript" charset="utf-8"></script>

    <script src="../Scripts/tag-it.js"></script>
    <link rel="stylesheet" type="text/css" href="http://ajax.googleapis.com/ajax/libs/jqueryui/1/themes/flick/jquery-ui.css" />

    <link href="../Content/jquery.tagit.css" rel="stylesheet" />
    <style>
        .happy{
            color:green
        }
        .sad {
            color:red
        }
        .left {
            color:blue
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
 <table>
        <tr>
            <td>     <asp:Label ID="Label2" runat="server" Text="yes"></asp:Label></td>
            <td>     <asp:Label ID="Label3" runat="server" Text="no"></asp:Label></td>
            <td>     <asp:Label ID="Label4" runat="server" Text="yes/no"></asp:Label></td>
        </tr>
        <tr>
            <td>     <asp:Label ID="Label5" runat="server" Text="no"></asp:Label></td>
            <td>     <asp:Label ID="Label6" runat="server" Text="yes"></asp:Label></td>
            <td>     <asp:Label ID="Label7" runat="server" Text="yes/no"></asp:Label></td>
        </tr>
        <tr>
            <td>     <asp:Label ID="Label8" runat="server" Text="yes"></asp:Label></td>
            <td>     <asp:Label ID="Label9" runat="server" Text="yes/no"></asp:Label></td>
            <td>     <asp:Label ID="Label10" runat="server" Text="no"></asp:Label></td>
        </tr>

    </table>
      <%--  <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<ul id="myTags">
    <!-- Existing list items will be pre-added to the tags -->
    <li>Tag1</li>
    <li>Tag2</li>
</ul>--%>
        <asp:HiddenField ID="HiddenField1" runat="server" />

         <script type="text/javascript">
    $(document).ready(function() {
        //$("#myTags").tagit();
    
        //var tagArr = [];
        //$.each($("input[name=tags]"), function (index, ele) {
        //    tagArr.push(ele.value);
        //})
      <%--  $("#<%= HiddenField1.ClientID%>").val(tagArr.join(","))--%>
        $("td span").css("cursor", "pointer");
        $("td span").click(function () {
            $(this).parents("tr").find("span").removeClass("happy sad left");
            if ($(this).html().trim() == "yes") {
                $(this).addClass("happy")
            } else if ($(this).html().trim() == "no") {
                $(this).addClass("sad")
            } else {
                $(this).addClass("left");
            }
        })
    });
</script>
    </form>
</body>
</html>
