Imports System.Configuration
Imports System.Data.SqlClient

Public MustInherit Class Conexion
    Private ReadOnly connectionstring As String
    Public Sub New()
        connectionstring = ConfigurationManager.ConnectionStrings("constring").ToString()
    End Sub
    Protected Function GetCon() As SqlConnection
        Return New SqlConnection(connectionstring)
    End Function
End Class
