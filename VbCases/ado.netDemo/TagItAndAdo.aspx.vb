Imports System.Data.SqlClient

Public Class TagItAndAdo
    Inherits System.Web.UI.Page
    Private constr As String = ConfigurationManager.ConnectionStrings("EntityDb").ConnectionString

    Public tags As List(Of String) = New List(Of String)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Using con As SqlConnection = New SqlConnection(constr)


                Using com As SqlCommand = New SqlCommand("select keytag from postingsTags where Refno=@no ", con)
                    con.Open()
                    com.Parameters.AddWithValue("no", "id1")
                    Using reader As SqlDataReader = com.ExecuteReader()
                        If reader.HasRows Then
                            While reader.Read()
                                tags.Add(reader.GetString(0))
                            End While

                        End If
                    End Using

                End Using

            End Using


        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs)
        Dim newTags = Request.Form("tags").Split(","c)
        Dim oldTags = HiddenField1.Value.Split(","c)
        Dim valuesToDelete = oldTags.Except(newTags).Distinct().ToList()
        Dim valuesToInsert = newTags.Except(oldTags).Distinct().ToList()

        If valuesToDelete.Count > 0 Then
            Dim deleteSql = "delete from postingstags where keyTag in ("

            Using con As SqlConnection = New SqlConnection(constr)

                Using com As SqlCommand = New SqlCommand("", con)
                    For index = 0 To valuesToDelete.Count - 1
                        If index = 0 Then
                            deleteSql += "@parameter" & index

                        Else
                            deleteSql += ",@parameter" & index
                        End If
                        com.Parameters.AddWithValue("parameter" & index, valuesToDelete(index))

                    Next
                    deleteSql += ")"
                    com.CommandText = deleteSql
                    con.Open()
                    Response.Write("you have deleted " & com.ExecuteNonQuery().ToString() & " record")
                End Using
            End Using
        End If



        If valuesToInsert.Count > 0 Then
            Dim insertSql = "insert into  postingstags (RefNo,KeyTag) values "

            Using con As SqlConnection = New SqlConnection(constr)

                Using com As SqlCommand = New SqlCommand("", con)
                    For index = 0 To valuesToInsert.Count - 1
                        If index = 0 Then
                            insertSql += "(@RefNo,@parameter" & index.ToString() & ")"

                        Else
                            insertSql += ",(@RefNo,@parameter" & index.ToString() & ")"
                        End If
                        com.Parameters.AddWithValue("parameter" & index, valuesToInsert(index))

                    Next
                    com.Parameters.AddWithValue("RefNo", "id1")
                    com.CommandText = insertSql
                    con.Open()
                    Response.Write("<br/>you have inserted  " & com.ExecuteNonQuery().ToString() & " record")
                End Using
            End Using
        End If





        Using con As SqlConnection = New SqlConnection(constr)


            Using com As SqlCommand = New SqlCommand("select keytag from postingsTags where Refno=@no ", con)
                con.Open()
                com.Parameters.AddWithValue("no", "id1")
                Using reader As SqlDataReader = com.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            tags.Add(reader.GetString(0))
                        End While

                    End If
                End Using

            End Using

        End Using
    End Sub
End Class