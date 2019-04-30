<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HideModelPopupInUpdatePanel.aspx.cs" Inherits="WebFormCases2.extraControls.HideModelPopupInUpdatePanel" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script src="../Scripts/jquery-3.3.1.js"></script>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel runat="server" Width="300px" Height="200px" BackColor="YellowGreen" ID="panel">

                    <asp:Button ID="Button1" runat="server" Text="in update panel" OnClick="Button1_Click" />
                    <asp:Button ID="Button3" runat="server" Text="Button" style="display:none"/>
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </asp:Panel>

                <asp:Button ID="Button2" runat="server" Text="show panel" />
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" OkControlID="Button3" TargetControlID="Button2" PopupControlID="panel" ></ajaxToolkit:ModalPopupExtender>
            </ContentTemplate>
            
        </asp:UpdatePanel>

        <asp:Label ID="Label1" runat="server" Text="other things"></asp:Label>
        <script>
            $(function () {
                $("#Button1").click(function () {
                    $("#Button3").click();
                })
            })
        </script>
    </form>
</body>
</html>
