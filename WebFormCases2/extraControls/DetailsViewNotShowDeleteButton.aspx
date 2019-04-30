<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsViewNotShowDeleteButton.aspx.cs" Inherits="WebFormCases2.extraControls.DetailsViewNotShowDeleteButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
       <asp:View ID="viewDetails" runat="server">
            <asp:DetailsView DefaultMode="Edit" BorderColor="#CCCCCC" OnItemCommand="DetailsView1_ItemCommand"
                BorderWidth="1px" Font-Names="Verdana" Font-Size="8pt"
                ID="DetailsView1" runat="server" AutoGenerateRows="False"
                DataKeyNames="id" DataSourceID="dsFueltype"
                Height="50px" Width="325px">
                <Fields>
                    <asp:TemplateField HeaderText="ID">
                        <EditItemTemplate>
                            <asp:Label ID="lblDistrictHeatSupplyID" Text='<%# Bind("shape") %>' runat="server"></asp:Label>
                        </EditItemTemplate>
                        <InsertItemTemplate>
                            <asp:TextBox CssClass="ekpro_txt" ID="txtDistrictHeatingSupplyID" Text='<%# Bind("image_id") %>' runat="server"></asp:TextBox>
                        </InsertItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="coords" HeaderText="Navn" SortExpression="Name" ControlStyle-CssClass="ekpro_txt" ControlStyle-Width="300" />
                    

                    <asp:CommandField ButtonType="Button" 
                        ShowDeleteButton="true" DeleteText="Delete"
                        ShowCancelButton="true" CancelText="Cancel" 
                        ShowInsertButton="true" InsertText="Gem"
                        ShowEditButton="true"   UpdateText="Update" />
                </Fields>

                <AlternatingRowStyle CssClass="tblrowalt" />
                <RowStyle CssClass="tblrow" />
            </asp:DetailsView>
            <asp:Button ID="btnAddVAT" runat="server" Text="Tillæg moms" />
            <asp:SqlDataSource ID="dsFueltype" runat="server"
                ConnectionString="<%$ ConnectionStrings:EntityDb %>"
                SelectCommand="SELECT [id], [shape], [coords], [image_id] FROM [areas]" DeleteCommand="DELETE FROM [areas] WHERE [id] = @id" InsertCommand="INSERT INTO [areas] ([shape], [coords], [image_id]) VALUES (@shape, @coords, @image_id)" UpdateCommand="UPDATE [areas] SET [shape] = @shape, [coords] = @coords, [image_id] = @image_id WHERE [id] = @id">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="shape" Type="String" />
                    <asp:Parameter Name="coords" Type="String" />
                    <asp:Parameter Name="image_id" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="shape" Type="String" />
                    <asp:Parameter Name="coords" Type="String" />
                    <asp:Parameter Name="image_id" Type="Int32" />
                    <asp:Parameter Name="id" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

          
        </asp:View>
            </asp:MultiView>
    </form>
</body>
</html>
