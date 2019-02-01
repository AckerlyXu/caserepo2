Imports System.Data.SqlClient

Module SqlHelper
    Private constr As String = ConfigurationManager.ConnectionStrings("supplyModel").ConnectionString

    Function ExcuteNunQuery(ByVal sql As String, ParamArray sqlParameters As SqlParameter()) As Integer
        Using con As SqlConnection = New SqlConnection(constr)

            Using com As SqlCommand = New SqlCommand(sql, con)
                com.Parameters.AddRange(sqlParameters)
                con.Open()
                Return com.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Function ExcuteNunQueryPro(ByVal sql As String, ParamArray sqlParameters As SqlParameter()) As Integer
        Using con As SqlConnection = New SqlConnection(constr)

            Using com As SqlCommand = New SqlCommand(sql, con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddRange(sqlParameters)
                con.Open()
                Return com.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Function getDataTable(ByVal sql As String, ParamArray sqlParameters As SqlParameter()) As DataTable
        Using adapter As SqlDataAdapter = New SqlDataAdapter(sql, constr)
            adapter.SelectCommand.Parameters.AddRange(sqlParameters)
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)

        End Using
#Disable Warning BC42105 ' Function doesn't return a value on all code paths
    End Function
#Enable Warning BC42105 ' Function doesn't return a value on all code paths

    Function getDataTablePro(ByVal sql As String, ParamArray sqlParameters As SqlParameter()) As DataTable
        Using adapter As SqlDataAdapter = New SqlDataAdapter(sql, constr)
            adapter.SelectCommand.Parameters.AddRange(sqlParameters)
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim table As DataTable = New DataTable()
            adapter.Fill(table)
            Return table
        End Using
    End Function

    Function ExcuteScalar(ByVal sql As String, ParamArray sqlParameters As SqlParameter()) As Object
        Using con As SqlConnection = New SqlConnection(constr)

            Using com As SqlCommand = New SqlCommand(sql, con)
                com.Parameters.AddRange(sqlParameters)
                con.Open()
                Return com.ExecuteScalar()
            End Using
        End Using
    End Function

    Function ExcuteScalarPro(ByVal sql As String, ParamArray sqlParameters As SqlParameter()) As Object
        Using con As SqlConnection = New SqlConnection(constr)

            Using com As SqlCommand = New SqlCommand(sql, con)
                com.CommandType = CommandType.StoredProcedure
                com.Parameters.AddRange(sqlParameters)
                con.Open()
                Return com.ExecuteScalar()
            End Using
        End Using
    End Function

    Function GetSqlDataReader(ByVal sql As String, ParamArray sqlParameters As SqlParameter()) As SqlDataReader
        Dim con As SqlConnection = New SqlConnection(constr)

        Using com As SqlCommand = New SqlCommand(sql, con)

            Try
                con.Open()
                Return com.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Catch __unusedException1__ As Exception
                con.Close()
                con.Dispose()
                Throw
            End Try
        End Using
    End Function

    Function GetSqlDataReaderPro(ByVal sql As String, ParamArray sqlParameters As SqlParameter()) As SqlDataReader
        Dim con As SqlConnection = New SqlConnection(constr)

        Using com As SqlCommand = New SqlCommand(sql, con)

            Try
                com.CommandType = CommandType.StoredProcedure
                con.Open()
                com.Parameters.AddRange(sqlParameters)
                Return com.ExecuteReader(System.Data.CommandBehavior.CloseConnection)
            Catch __unusedException1__ As Exception
                con.Close()
                con.Dispose()
                Throw
            End Try
        End Using
    End Function
End Module

