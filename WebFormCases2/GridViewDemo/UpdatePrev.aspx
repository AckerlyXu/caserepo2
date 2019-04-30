<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePrev.aspx.cs" Inherits="WebFormCases2.GridViewDemo.UpdatePrev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="gvchild" CssClass="gvv" DataKeyNames="AccountID"
            OnRowDeleting="gvchild_RowDeleting" runat="server"
            AutoGenerateColumns="false" class="table table-striped"
            
            Width="100%">
            <Columns>
                <asp:BoundField DataField="AccountID" ReadOnly="true"
                    HeaderText="Account ID" />
                <asp:TemplateField HeaderText="Account Name">
                    <ItemTemplate>
                        <asp:TextBox ID="txtaccountname" runat="server" data-index='<%# Container.DataItemIndex %>'
                            Text='<%#Eval("AccountName")%>' Width="475px"  />

                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sub Account">
                    <ItemTemplate>
                        <asp:TextBox ID="txtsubaccount" runat="server" data-index='<%# Container.DataItemIndex %>'
                            Text='<%#Eval("SubAccount")%>' Width="475px" />
                        <asp:DropDownList ID="DropDownList1" runat="server" data-index='<%# Container.DataItemIndex %>'>
                            <asp:ListItem>a</asp:ListItem>
                             <asp:ListItem>b</asp:ListItem>
                             <asp:ListItem>c</asp:ListItem>
                        </asp:DropDownList>
                    </ItemTemplate>
                </asp:TemplateField>
          
                <asp:CommandField ButtonType="Button" ShowDeleteButton="true"
                    HeaderText="Delete" />

            </Columns>
           
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click"  style="display:none"/>
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <script>
            var index;
            $("#gvchild input,#gvchild select").change(function () {// record preous row's index
             
                index = $(this).data("index");
            })
            //$("#gvchild input[type=text]").focus(function () { // wnen edit the next row

            //    if (index !== undefined  && $(this).data("index") !=index) {
            //                  // confirm 
                    
            //        if (confirm("are you going to update the record, whose row index is  " + (index + 1))) {
            //            // if return true,  pass data to server 
            //            $("#HiddenField1").val(index);
            //            $("[value=Update]").click(); 
                       
            //        }
            //            index = undefined;
                    
                  
                    
            //    }
            //})
    
             $("#gvchild  tr").click(function () { // wnen edit the next row

                if (index !== undefined  && $(this).find("input[type=text]").data("index") !=index) {
                              // confirm 
                    
                    if (confirm("are you going to update the record, whose row index is  " + (index + 1))) {
                        // if return true,  pass data to server 
                        $("#HiddenField1").val(index);
                        $("[value=Update]").click(); 
                       
                    }
                        index = undefined;
                    
                  
                    
                }
            })
           
        </script>
    </form>
</body>
</html>
