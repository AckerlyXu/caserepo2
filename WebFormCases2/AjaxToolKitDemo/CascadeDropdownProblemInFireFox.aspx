<%@ Page Language="C#" AutoEventWireup="true"   CodeBehind="CascadeDropdownProblemInFireFox.aspx.cs" Inherits="WebFormCases2.AjaxToolKitDemo.CascadeDropdownProblemInFireFox" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <title></title>
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
    </style>
   
</head>
<body>
    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
             
               <%-- <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>--%>
    <table>
        <tr>
            <td style="width: 80px">
                Country:
            </td>
            <td>
                <asp:DropDownList ID="ddlCountries" runat="server" Width="150">
                </asp:DropDownList>
                <cc1:CascadingDropDown ID="cdlCountries" TargetControlID="ddlCountries" PromptText="Select Country"
                    PromptValue="" ServicePath="ServiceCS.asmx" ServiceMethod="GetCountries" runat="server"
                    Category="CountryId" LoadingText="Loading..." EnableAtLoading="false" />
          
                         <asp:Button ID ="btn1" runat="server" OnClick="btn1_Click" Text="Submit" />
                
            </td>
        </tr>
        <tr>
            <td>
                State:
            </td>
            <td>
                <asp:DropDownList ID="ddlStates" runat="server" Width="150">
                </asp:DropDownList>
                <cc1:CascadingDropDown ID="cdlStates" TargetControlID="ddlStates" PromptText="Select State"
                    PromptValue="" ServicePath="ServiceCS.asmx" ServiceMethod="GetStates" runat="server"
                    Category="StateId" ParentControlID="ddlCountries" LoadingText="Loading..." EnableAtLoading="false"/>
            </td>
        </tr>
        <tr>
            <td>
                City:
            </td>
            <td>
                <asp:DropDownList ID="ddlCities" runat="server" Width="150">
                </asp:DropDownList>
                <cc1:CascadingDropDown ID="cdlCities" TargetControlID="ddlCities" PromptText="Select City"
                    ServicePath="ServiceCS.asmx" ServiceMethod="GetCity" runat="server"
                    Category="CityId" ParentControlID="ddlStates" />
            </td>
        </tr>
          <%--  </ContentTemplate>
                </asp:UpdatePanel>--%>
    </table>
    </form>
     <script type="text/javascript">
         function abc() {
          
              $("#<%=ddlCountries.ClientID%> ").val("2");
            
             
             }
         $(document).ready(function () {
          
             //console.log($("#<%=ddlCities.ClientID%>").val());
         
                 $("#<%=ddlCities.ClientID%>").change(function () {
              alert($("#<%=ddlCities.ClientID%>").val())
             });
           
            
//
            // console.log("abc");
        });

    </script>
</body>
</html>