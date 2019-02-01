Public Class IfElse
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim data As List(Of Int32) = New List(Of Integer)
            data.Add(1)
            data.Add(2)
            data.Add(3)
            data.Add(4)
            data.Add(5)
            GridView1.DataSource = data
            GridView1.DataBind()
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Dim flag As Boolean = False
        For Each row As GridViewRow In GridView1.Rows
            If row.RowType = DataControlRowType.DataRow Then
                Dim data As Int32 = Convert.ToInt32(row.Cells(0).Text)

                If data = 3 Or data = 5 Then

                    flag = True

                End If
                If flag = True Then
                    Response.Write(data)
                End If
            End If
        Next

    End Sub
End Class