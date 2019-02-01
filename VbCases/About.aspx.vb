Imports System.IO

Public Class About
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        'Response.Clear()
        'Response.BinaryWrite(File.ReadAllBytes(Server.MapPath("/rep.pdf")))
        'Response.End()
        'Response.Flush()
        'Response.ContentType = "application/pdf"

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Dim file As HttpPostedFile = FileUpload1.PostedFile

    End Sub

End Class