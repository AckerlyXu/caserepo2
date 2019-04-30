<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HoverToShowPopup.aspx.cs" Inherits="WebFormCases2.extraControls.HoverToShowPopup" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../Scripts/jquery-1.9.1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">

            <ContentTemplate>
                 <asp:Panel ID="Panel1" runat="server">
            content of model pop up
            <img src="../images/WingtipToysBak/busdouble.png" />
        </asp:Panel>
                <asp:Button ID="Button1" runat="server" Text="show pop up"  />
                   <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1" TargetControlID="Button1" CancelControlID="Button2"></ajaxToolkit:ModalPopupExtender>
            </ContentTemplate>
        </asp:UpdatePanel> 
       
        
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <img src="../images/icons/ok.png" id="ok" width="40px" height="40px"/>
     
       
    </form>


     <script>
            $(function () {
                //  $("#Button1").click(function () {
                //    return false;
                //})
                //  $("#Label1").click();
                $("#Button1")[0].onclick();
                //$("#ok").mouseleave(function () {
                //    $("#Button2").click();
                //})
                //$("#ok").mouseover(
                //    function (e) {
                //        e.preventDefault();
                //  //  $("#Button1").click();
                //    }
                //)
            })
        </script>
</body>
</html>
