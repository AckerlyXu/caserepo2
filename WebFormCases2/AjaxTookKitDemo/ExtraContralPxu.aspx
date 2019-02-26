<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExtraContralPxu.aspx.cs" Inherits="WebFormCases2.AjaxTookKitDemo.ExtraContralPxu" %>

<%@ Register Assembly="PIUControlsX" Namespace="PIUControlsX" TagPrefix="PIUControlsX" %>

<%@ Register Assembly="PIUControls" Namespace="PIUControls" TagPrefix="PIUControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


 


<asp:label id="lblInitialRisk" runat="server"> Initial Risk Assessment</asp:label>

 

<asp:HyperLink id="link1" runat="server" Text="NSW Health Risk Matrix" NavigateUrl="~/NSW_Health_Risk_Matrix_with_LHN_delegation.pdf" Target="_blank" /> 

<asp:RequiredFieldValidator ID="vldInitialRisk" ValidationGroup="Risk" runat="server"

ErrorMessage="Current Risk Rating must be entered" ControlToValidate="tbxInitialRisk" Font-Bold="True" Display="Dynamic" EnableClientScript="False">Current Risk Rating must be entered</asp:RequiredFieldValidator>

<PIUControlsX:RiskPicker ID="rpInitialRisk" runat="server" OnClick="tbxInitialRisk" EnableViewState="false" />

<asp:TextBox ID="tbxInitialRisk" CssClass ="hidden" runat="server"

 />

<asp:label id="lblPriority" runat="server" >NSW Health Matrix Classification: </asp:label>

<asp:label id="lblPriorityRating" runat="server" CssClass="readOnlyValue" Width="75px"></asp:label>

<asp:TextBox ID="tbxCurrentRisk" CssClass="hidden" runat="server"></asp:TextBox>

<asp:label id="lblPriorityRating_R" runat="server" CssClass="readOnlyValue" Width="75px" Visible="false"></asp:label>

<asp:label id="lblInitialDate" runat="server">Date Risk Created</asp:label>

 

<asp:RequiredFieldValidator ID="vldInitialDate" runat="server" ControlToValidate="tbxInitialDate" ValidationGroup="Risk"

ErrorMessage="Current Risk Rating Date must be entered" Display="Dynamic" Font-Bold="True">

Current risk rating date must be entered</asp:RequiredFieldValidator>

<PIUControls:datepicker id="dpInitialDate" runat="server" DateType="d mmm yyyy" EnableViewState="false"></PIUControls:datepicker>

<asp:TextBox ID="tbxInitialDate" runat="server" Width="72px" CssClass="hidden" ></asp:TextBox>






</form>
    <script>
        var theForm = document.forms["form1"];
        window.onload = function () {
           // DPOnLoad();
           init()  //function for datepicker
            initRP();//function for RiskPicker
            popUpRiskPicker(document.all.rpInitialRisk_PIUTextBoxRP, document.all.rpInitialRisk_PIUTextBoxRP);
            popUpCalendar(document.all.dpInitialDate_PIUTextBox, document.all.dpInitialDate_PIUTextBox, 'd mmm yyyy');
        }
    </script>
</body>
</html>
