Imports Dominio

Public Class EditVentas
    Dim edit As New EditarVentas
    Dim save As New GuardarVentas
    Private Sub EditVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Examen.accion
            Case "editar"
                edit.actualizarVentas(Examen.modelo)
            Case "agregar"
                TextBox3.Text = DateTimePicker1.Value
                Examen.modelo.Estado = EstadoEntidad.Added
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        save.saveVentas(Examen.modelo)
        Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TextBox3.Text = DateTimePicker1.Value
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ClientesLista.Show()
    End Sub
End Class