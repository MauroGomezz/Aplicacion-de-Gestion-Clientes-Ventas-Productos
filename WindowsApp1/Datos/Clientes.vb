Imports System.Configuration
Imports System.Data.SqlClient

Public Class Clientes
    Dim con_string As New SqlConnection(ConfigurationManager.ConnectionStrings("constring").ConnectionString)
    Public Sub Cargar(datagrid As DataGridView)
        Try
            con_string.Open()
            datagrid.Rows.Clear()
            Dim cmd As New SqlCommand("SELECT * FROM clientes", con_string)
            Dim dr = cmd.ExecuteReader
            While dr.Read
                datagrid.Rows.Add(dr.Item("ID"), dr.Item("CLIENTE"), dr.Item("TELEFONO"), dr.Item("CORREO"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_string.Close()
        End Try
    End Sub
    Public Sub Buscar(datagrid As DataGridView, val As String)
        Try
            con_string.Open()
            Dim cmd As New SqlCommand("SELECT * FROM clientes WHERE cliente='" & val & "'", con_string)
            Dim dr = cmd.ExecuteReader
            datagrid.Rows.Clear()
            While dr.Read
                datagrid.Rows.Add(dr.Item("ID"), dr.Item("CLIENTE"), dr.Item("TELEFONO"), dr.Item("CORREO"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_string.Close()
        End Try
    End Sub
    Public Sub Crear(client As String, tel As String, mail As String)
        Try
            con_string.Open()
            Dim cmd As New SqlCommand("INSERT INTO clientes (Cliente,Telefono,Correo) VALUES ('" & client & "','" & tel & "','" & mail & "')", con_string)
            Dim i = cmd.ExecuteNonQuery
            If i <= 0 Then
                MessageBox.Show("No funciono")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_string.Close()
        End Try
    End Sub
    Public Sub Eliminar(id As String)
        Try
            con_string.Open()
            Dim cmd As New SqlCommand("DELETE FROM clientes WHERE ID =" & id & "", con_string)
            Dim i = cmd.ExecuteNonQuery
            If i <= 0 Then
                MessageBox.Show("No funciono")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_string.Close()
        End Try
    End Sub
    Public Sub Editar(id As String, client As String, tel As String, mail As String)
        Try
            con_string.Open()
            Dim cmd As New SqlCommand("UPDATE clientes SET Cliente='" & client & "', Telefono='" & tel & "', Correo='" & mail & "' WHERE ID='" & id & "'", con_string)
            Dim i = cmd.ExecuteNonQuery
            If i <= 0 Then
                MessageBox.Show("No funciono")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_string.Close()
        End Try
    End Sub
End Class
