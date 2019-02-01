Public Class RemoveDropdownitem
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim table As DataTable = New DataTable()
        table.Columns.Add(New DataColumn("items", GetType(String)))
        table.Columns.Add(New DataColumn("quantity", GetType(Int32)))


        table.Rows.Add("laptop", 90)
        table.Rows.Add("keyboard", 100)
        table.Rows.Add("mouse", 0)
        table.Rows.Add("pc", 25)


        table = table.AsEnumerable().Where(Function(row) Convert.ToInt32(row("quantity")) <> 0).CopyToDataTable()
        Dim newTable As DataTable = New DataTable()
        newTable.Columns.Add(New DataColumn("items", GetType(String)))
        newTable.Columns.Add(New DataColumn("quantity", GetType(Int32)))

        For Each row As DataRow In table.Rows
            If Convert.ToInt32(row("quantity")) <> 0 Then
                newTable.Rows.Add(row("items"), row("quantity"))
            End If
        Next


        DropDownList1.DataValueField = "quantity"
        DropDownList1.DataTextField = "items"
        DropDownList1.DataSource = newTable
        DropDownList1.DataBind()
    End Sub

End Class