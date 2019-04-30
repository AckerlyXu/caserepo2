Public Class DatatableWithLinq
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then


            Dim dt As DataTable = New DataTable()
            dt.Columns.Add(New DataColumn("id", GetType(Int32)))
            dt.Columns.Add(New DataColumn("SUB1_TH", GetType(Int32)))
            dt.Columns.Add(New DataColumn("SUB1_PR", GetType(Int32)))
            dt.Columns.Add(New DataColumn("SUB1_TTL", GetType(Int32)))
            dt.Columns.Add(New DataColumn("SUB1_PER", GetType(Double)))
            dt.Columns.Add(New DataColumn("SUB2_TH", GetType(Int32)))
            dt.Columns.Add(New DataColumn("SUB2_PR", GetType(Int32)))
            dt.Columns.Add(New DataColumn("SUB2_TTL", GetType(Int32)))
            dt.Columns.Add(New DataColumn("SUB2_PER", GetType(Double)))
            dt.Rows.Add(1, 10, 20, 0, 0, 30, 40, 0, 0)
            dt.Rows.Add(2, 20, 30, 0, 0, 40, 50, 0, 0)
            dt.Rows.Add(3, 60, 70, 0, 0, 80, 90, 0, 0)
            Dim count = (dt.Columns.Count - 1) / 4   'get how many times you should cauculator, SUB_TH	SUB_PR	SUB_TTL	SUB_PER is one group exculde id , so divided by 4
            dt = dt.AsEnumerable().Select( ' the select method could get every row of the datatable and receive the mapped row finally the result will be collection of mapped row
             Function(row)
                 'here in the function you get every row, and set row columns you want 
                 For index = 1 To count   ' here total group is two , so loop for two times
                     ' set total 
                     row("SUB" & index & "_TTL") = DirectCast(row("SUB" & index & "_TH"), Int32) + DirectCast(row("SUB" & index & "_PR"), Int32)
                     'set percentage
                     row("SUB" & index & "_PER") = DirectCast(row("SUB" & index & "_PR"), Int32) * 1.0 / DirectCast(row("SUB" & index & "_TTL"), Int32)

                 Next
                 Return row
             End Function
             ).CopyToDataTable() 'the CopyToDataTable method convert the result to datatable

            GridView1.DataSource = dt
            GridView1.DataBind()


        End If
    End Sub

End Class