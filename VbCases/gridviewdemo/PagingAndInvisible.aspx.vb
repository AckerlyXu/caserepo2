Public Class PagingAndInvisible
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Dim table As DataTable = New DataTable()
            table.Columns.Add(New DataColumn("NT_GROUP", GetType(String)))
            table.Columns.Add(New DataColumn("Rep_Code", GetType(String)))
            table.Columns.Add(New DataColumn("Rep_Name", GetType(String)))
            table.Rows.Add("group1", "1", "rep1")
            table.Rows.Add("group1", "2", "rep2")
            table.Rows.Add("group1", "3", "rep3")
            table.Rows.Add("group1", "4", "rep1")
            table.Rows.Add("group2", "5", "rep2")
            table.Rows.Add("group2", "6", "rep3")
            table.Rows.Add("group2", "7", "rep1")
            table.Rows.Add("group2", "8", "rep2")
            table.Rows.Add("group3", "9", "rep3")
            table.Rows.Add("group3", "10", "rep1")
            table.Rows.Add("group3", "11", "rep2")
            table.Rows.Add("group3", "12", "rep3")
            table = table.AsEnumerable().Where(Function(r) r("NT_GROUP").ToString() <> "group1").CopyToDataTable()
            GridView1.DataSource = table
            GridView1.DataBind()

        End If
    End Sub

    Protected Sub GridView1_RowDataBound(sender As Object, e As GridViewRowEventArgs)



    End Sub

    Protected Sub GridView1_PageIndexChanging(sender As Object, e As GridViewPageEventArgs)
        GridView1.PageIndex = e.NewPageIndex
        Dim table As DataTable = New DataTable()
        table.Columns.Add(New DataColumn("NT_GROUP", GetType(String)))
        table.Columns.Add(New DataColumn("Rep_Code", GetType(String)))
        table.Columns.Add(New DataColumn("Rep_Name", GetType(String)))
        table.Rows.Add("group1", "1", "rep1")
        table.Rows.Add("group1", "2", "rep2")
        table.Rows.Add("group1", "3", "rep3")
        table.Rows.Add("group1", "4", "rep1")
        table.Rows.Add("group2", "5", "rep2")
        table.Rows.Add("group2", "6", "rep3")
        table.Rows.Add("group2", "7", "rep1")
        table.Rows.Add("group2", "8", "rep2")
        table.Rows.Add("group3", "9", "rep3")
        table.Rows.Add("group3", "10", "rep1")
        table.Rows.Add("group3", "11", "rep2")
        table.Rows.Add("group3", "12", "rep3")
        table = table.AsEnumerable().Where(Function(r) r("NT_GROUP").ToString() <> "group1").CopyToDataTable()
        GridView1.DataSource = table
        GridView1.DataBind()
    End Sub
End Class