Imports Dominio
Public Class Edit_Crear
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
        Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class