Imports Entidades

Public Class Edit
    Dim editar As New Editar
    Dim Guardar As New Save
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case Examen.accion
            Case "editar"
                editar.actualizar(Examen.modelo)
            Case "agregar"
                Examen.modelo.Estado = EstadoEntidad.Added
        End Select
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Guardar.save(Examen.modelo)
        Hide()
    End Sub
End Class