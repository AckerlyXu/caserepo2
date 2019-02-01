Public Class Contact
    Inherits Page

    Public Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Response.Write(DateTime.Now.ToString("yyyy/MM/dd"))

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Dim file As HttpPostedFile = FileUpload1.PostedFile
        If Not String.IsNullOrEmpty(file.FileName) Then
            Dim a = 1
        Else
            Dim b = 1
        End If


        Dim m As DateTime = DateTime.Now
        Dim n As DateTime = DateTime.Now
        Dim d As TimeSpan = n - m

    End Sub
End Class