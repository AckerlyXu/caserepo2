<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="withAjaxtoolkitCalendar.aspx.cs" Inherits="WebFormCases2.bootstrapexe.withAjaxtoolkitCalendar" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link rel="Stylesheet" href="~/Content/bootstrap.min.css" style="" />  
    <link rel="Stylesheet" href="~/Content/bootstrap.css" />  
    <style>  
.hdrow {  
    text-align:center;  
    color:White;  
    background-color:midnightblue;  
    height:30px;  
}  

.gridview  
{  
    width:50%;  
    background-color:white;  
    margin:0px auto;  
}  

.mydatagrid
{
   width: 80%;
   border: solid 2px black;
   min-width: 80%;
}

.header
{
    background-color: #646464;
    font-family: Arial;
    color: White;
    border: none 0px transparent;
    height: 25px;
    text-align: center;
    font-size: 16px;
}

.rows
{
    background-color: #fff;
    font-family: Arial;
    font-size: 14px;
    color: #000;
    min-height: 25px;
    text-align: left;
    border: none 0px transparent;
}

.rows:hover
{
    background-color: #ff8000;
    font-family: Arial;
    color: #fff;
    text-align: left;
}

.selectedrow
{
    background-color: #ff8000;
    font-family: Arial;
    color: #fff;
    font-weight: bold;
    text-align: left;
}

.mydatagrid a 
{
    background-color: Transparent;
    padding: 5px 5px 5px 5px;
    color: #fff;
    text-decoration: none;
    font-weight: bold;
} 

.mydatagrid a:hover /** FOR THE PAGING ICONS  HOVER STYLES**/
{
    background-color: #000;
    color: #fff;
}

.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
{
    background-color: #c9c9c9;
    color: #000;
    padding: 5px 5px 5px 5px;
}

.pager
{
    background-color: #646464;
    font-family: Arial;
    color: White;
    height: 30px;
    text-align: left;
}

.mydatagrid td
{
    padding: 5px;
}

.mydatagrid th
{
    padding: 5px;
}

</style>  
</head>
<body>
    <form id="form1" runat="server" style="margin-left:10px;">
          <div>           
           <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:Label ID="HSPolDocsLabel" runat="server" Text="Policy Documents" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <asp:TextBox ID="txtClientID" runat="server" Visible="false" ReadOnly="true"></asp:TextBox>
        <br />
        <br />

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
            
    <div class="container">
    <button type="button" class="icon fa-files-o" data-toggle="modal" data-target="#myModal" style="left: 0px; top: 0px; width: 270px; height: 70px; background-color: #DF554C; font-weight: bold; font-size: medium;"> Upload New Document</button>

    <div class="modal fade" id="myModal" role="dialog">
    <div class="modal-dialog">
    
      <div class="modal-content">
        <div class="modal-header">

          <button type="button" class="icon fa-close" style="background-color: #DF554C; font-weight: bold; font-size: x-small;" data-dismiss="modal"></button>
          <h4>Upload a New Policy Document</h4>
        </div>
        <div class="modal-body">

            <asp:TextBox ID="ClientIdtxt" runat="server"></asp:TextBox>
            <asp:TextBox ID="SiteIdtxt" runat="server"></asp:TextBox>
            <asp:TextBox ID="ServiceIdtxt" runat="server"></asp:TextBox>
            <asp:TextBox ID="DocIdtxt" runat="server"></asp:TextBox>
            <asp:TextBox ID="Uploadedbytxt" runat="server"></asp:TextBox>


            <asp:Label ID="DocrefnoLbl" runat="server" Text="Doc Ref No"></asp:Label>
            <asp:TextBox ID="Docrefnotxt" runat="server"></asp:TextBox>
        <br />

            <asp:Label ID="Docnamelbl" runat="server" Text="Doc Name"></asp:Label>
            <asp:TextBox ID="Docnametxt" runat="server"></asp:TextBox>
        <br />
            
            <asp:Label ID="Docdatelbl" runat="server" Text="Doc Date"></asp:Label>
            <ajaxToolkit:CalendarExtender ID="DocdateExt" runat="server" PopupButtonID="Docdatetxt" TargetControlID="Docdatetxt" format="dd/MM/yyyy" FirstDayOfWeek="Monday" ClearTime="True" TodaysDateFormat="dd/MM/yyyy" ValidateRequestMode="Inherit"  />

            <asp:TextBox ID="Docdatetxt" runat="server" autocomplete="off"></asp:TextBox>

        <br />

            <asp:Label ID="DoxexpiryLbl" runat="server" Text="Doc Expiry"></asp:Label>
            <asp:TextBox ID="Docexpirytxt" runat="server"></asp:TextBox>
        <br />

            <asp:Label ID="DeptLbl" runat="server" Text="Department"></asp:Label>
            <asp:TextBox ID="Depttxt" runat="server"></asp:TextBox>
        <br />

            <asp:FileUpload ID="FileUpload1" runat="server" />  
            <asp:Button ID="btnUpload" runat="server" Text="Upload" CssClass="btn-primary" />  
                </div>
            </div>

            <div class="modal-footer">
          <button type="button" class="btn btn-default" style="background-color: #DF554C; font-weight: bold; font-size: small;" data-dismiss="modal">Closes="modal">Close</button>
        </div>
    </div>
</div>
</div>
</div>
        <br />
        <br />
            <asp:Label ID="SelectDeptlbl" runat="server" Text="Please Select a Department"></asp:Label>
            <asp:DropDownList ID="SelectDeptddl" runat="server" Height="29px" Width="429px" CssClass="auto-style9"  Font-Names="Arial" Font-Size="Medium">
            </asp:DropDownList>
        <br />
            <asp:GridView ID="HSPolicyDocsDG" runat="server" CssClass="mydatagrid" PagerStyle-CssClass="pager" HeaderStyle-CssClass="header" RowStyle-CssClass="rows" AllowPaging="True" OnItemDataBound="Item_Bound"  >
              <Columns>  
                <asp:BoundField DataField="DocName" HeaderText="Document Name" />  
                <asp:TemplateField ItemStyle-HorizontalAlign="Center">  
                    <ItemTemplate>  
                        <asp:LinkButton ID="lnkDownload" runat="server" Text="Download" 
                            CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>  
                    </ItemTemplate>  
                </asp:TemplateField>  
            </Columns>  
            </asp:GridView>

    </form>
</body>
</html>
