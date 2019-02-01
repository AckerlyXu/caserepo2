Imports System.Data.SqlClient

Public Class BindDataAccordingToCheckBox
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Response.Write(String.Format("C:\inetpub\wwwroot\ABC\ABC\Reports\ADV\ADVReport{0}.pdf", Convert.ToString(123)))
    End Sub
    Private constr As String = ConfigurationManager.ConnectionStrings("WingtipToysConnectionString").ConnectionString
    Protected Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        Dim check As CheckBox = CType(sender, CheckBox) 'get the current checkbox
        If Not check.Checked Then
            Return   'check whether it is checked
        End If
        Using adapter As SqlDataAdapter = New SqlDataAdapter("select * from products where CategoryiD =@ID", constr)
            adapter.SelectCommand.Parameters.AddWithValue("ID", check.Attributes("param")) ' get the id stored in the checkbox
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)


            GridView1.DataSource = table
            GridView1.DataBind()
        End Using
    End Sub
End Class