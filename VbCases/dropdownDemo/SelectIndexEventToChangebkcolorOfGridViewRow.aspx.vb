Public Class SelectIndexEventToChangebkcolorOfGridViewRow
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            kgrid.DataSource = New String() {"ABC", "EFG", "IJK", "LMN"}
            kgrid.DataBind()
        End If
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs)

        For Each item As GridViewRow In kgrid.Rows
            If item.RowType = DataControlRowType.DataRow Then

                Dim box As TextBox = CType(item.FindControl("TextBox11"), TextBox)

                'if is open start
                If ponumtxt.Text = "OPEN" Then
                    If box.Text = "ABC" Then


                        item.BackColor = System.Drawing.Color.Red
                        box.BackColor = System.Drawing.Color.White

                    ElseIf box.Text = "EFG" Then
                        item.BackColor = System.Drawing.Color.SkyBlue

                        box.BackColor = System.Drawing.Color.SkyBlue
                    ElseIf box.Text = "IJK" Then
                        item.BackColor = System.Drawing.Color.Yellow

                        box.BackColor = System.Drawing.Color.Yellow
                    End If
                End If

                ' 'if is open end




                ' if is PENDING start 
                If ponumtxt.Text = "PENDING" Then
                    If box.Text = "ABC" Then
                        ' If Val(potext.Text) = 31 Then
                        item.BackColor = System.Drawing.Color.Red
                        box.BackColor = System.Drawing.Color.Red
                    ElseIf box.Text = "EFG" Then
                        item.BackColor = System.Drawing.Color.SkyBlue
                        box.BackColor = System.Drawing.Color.SkyBlue
                    ElseIf box.Text = "IJK" Then
                        item.BackColor = System.Drawing.Color.Yellow
                        box.BackColor = System.Drawing.Color.Yellow
                    End If
                End If
                ' if is PENDING end




                'if is CLOSED start
                If ponumtxt.Text = "CLOSED" Then
                    If box.Text = "ABC" Then
                        item.BackColor = System.Drawing.Color.Red

                        box.BackColor = System.Drawing.Color.Red
                    ElseIf box.Text = "EFG" Then
                        item.BackColor = System.Drawing.Color.SkyBlue
                        box.BackColor = System.Drawing.Color.SkyBlue
                    ElseIf box.Text = "IJK" Then
                        item.BackColor = System.Drawing.Color.BlueViolet

                        box.BackColor = System.Drawing.Color.BlueViolet
                    End If
                End If
                ' if is CLOSED end


            End If



        Next

    End Sub

    Protected Sub kgrid_DataBound(sender As Object, e As EventArgs)


        For Each item As GridViewRow In kgrid.Rows
            If item.RowType = DataControlRowType.DataRow Then

                Dim box As TextBox = CType(item.FindControl("TextBox11"), TextBox)

                'if is open start
                If ponumtxt.Text = "OPEN" Then
                    If box.Text = "ABC" Then


                        item.BackColor = System.Drawing.Color.Red


                    ElseIf box.Text = "EFG" Then
                        item.BackColor = System.Drawing.Color.SkyBlue

                        box.BackColor = System.Drawing.Color.SkyBlue
                    ElseIf box.Text = "IJK" Then
                        item.BackColor = System.Drawing.Color.Yellow

                        box.BackColor = System.Drawing.Color.Yellow
                    End If
                End If

                ' 'if is open end




                ' if is PENDING start 
                If ponumtxt.Text = "PENDING" Then
                    If box.Text = "ABC" Then
                        ' If Val(potext.Text) = 31 Then
                        item.BackColor = System.Drawing.Color.Red
                        box.BackColor = System.Drawing.Color.Red
                    ElseIf box.Text = "EFG" Then
                        item.BackColor = System.Drawing.Color.SkyBlue
                        box.BackColor = System.Drawing.Color.SkyBlue
                    ElseIf box.Text = "IJK" Then
                        item.BackColor = System.Drawing.Color.Yellow
                        box.BackColor = System.Drawing.Color.Yellow
                    End If
                End If
                ' if is PENDING end




                'if is CLOSED start
                If ponumtxt.Text = "CLOSED" Then
                    If box.Text = "ABC" Then
                        item.BackColor = System.Drawing.Color.Red

                        box.BackColor = System.Drawing.Color.Red
                    ElseIf box.Text = "EFG" Then
                        item.BackColor = System.Drawing.Color.SkyBlue
                        box.BackColor = System.Drawing.Color.SkyBlue
                    ElseIf box.Text = "IJK" Then
                        item.BackColor = System.Drawing.Color.BlueViolet

                        box.BackColor = System.Drawing.Color.BlueViolet
                    End If
                End If
                ' if is CLOSED end


            End If



        Next

    End Sub
End Class