Imports System.Configuration
Imports System.Data.SqlClient

Public Class Productos
    Dim con_string As New SqlConnection(ConfigurationManager.ConnectionStrings("constring").ConnectionString)
    Public Sub Cargar(datagrid As DataGridView)
        Try
            con_string.Open()
            datagrid.Rows.Clear()
            Dim cmd As New SqlCommand("SELECT * FROM productos", con_string)
            Dim dr = cmd.ExecuteReader
            While dr.Read
                datagrid.Rows.Add(dr.Item("ID"), dr.Item("NOMBRE"), dr.Item("PRECIO"), dr.Item("CATEGORIA"))
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
            Dim cmd As New SqlCommand("SELECT * FROM productos WHERE Nombre='" & val & "'", con_string)
            Dim dr = cmd.ExecuteReader
            datagrid.Rows.Clear()
            While dr.Read
                datagrid.Rows.Add(dr.Item("ID"), dr.Item("NOMBRE"), dr.Item("PRECIO"), dr.Item("CATEGORIA"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con_string.Close()
        End Try
    End Sub
    Public Sub Crear(name As String, tel As String, mail As String)
        Try
            con_string.Open()
            Dim cmd As New SqlCommand("INSERT INTO productos (Nombre,Precio,Categoria) VALUES ('" & name & "','" & tel & "','" & mail & "')", con_string)
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
            Dim cmd As New SqlCommand("DELETE FROM productos WHERE ID =" & id & "", con_string)
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
    Public Sub Editar(id As String, name As String, tel As String, mail As String)
        Try
            con_string.Open()
            Dim cmd As New SqlCommand("UPDATE productos SET Nombre='" & name & "', Precio='" & tel & "', Categoria='" & mail & "' WHERE ID='" & id & "'", con_string)
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
