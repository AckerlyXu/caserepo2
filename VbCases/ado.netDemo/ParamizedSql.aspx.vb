Imports System.Data.SqlClient

Public Class ParamizedSql
    Inherits System.Web.UI.Page
    Private constr As String = ConfigurationManager.ConnectionStrings("EntityExeConnectionString").ConnectionString
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Using adapter As SqlDataAdapter = New SqlDataAdapter("select info,amount from first where id>@myid", constr)

                adapter.SelectCommand.Parameters.AddWithValue("@myid", 3) 'the value of the parameter @myid is 3
                Dim table As DataTable = New DataTable()
                adapter.Fill(table)
                DropDownList1.DataSource = table
                DropDownList1.DataValueField = "amount"
                DropDownList1.DataTextField = "info"
                DropDownList1.DataBind()
            End Using
        End If

    End Sub

End Class