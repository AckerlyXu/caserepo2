Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim client = New Calculator.CalculatorClient()
        Response.Write(client.Add(1, 3))

    End Sub
End Class