Imports System.Data.SqlClient

Public Class MasterRepo
    Inherits Conexion

    Protected parameters As List(Of SqlParameter)
    Protected Function ExecuteNonQuery(transacsql As String) As Integer
        Using connection = GetCon()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = transacsql
                command.CommandType = CommandType.Text
                For Each item As SqlParameter In parameters
                    command.Parameters.Add(item)
                Next
                Dim result = command.ExecuteNonQuery()
                parameters.Clear()
                Return result
            End Using
        End Using
    End Function

    Protected Function ExecuteReader(transacsql As String) As DataTable
        Using connection = GetCon()
            connection.Open()
            Using command = New SqlCommand()
                command.Connection = connection
                command.CommandText = transacsql
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                Using table = New DataTable
                    table.Load(reader)
                    reader.Dispose()
                    Return table
                End Using
            End Using
        End Using
    End Function
End Class
