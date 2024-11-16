Imports Dominio
Public Class Editar
    Public Sub actualizar(modelo)
        If Examen.DataGridView1.SelectedRows.Count > 0 Then
            modelo.ID = Examen.DataGridView1.CurrentRow.Cells(0).Value
            modelo.Estado = EstadoEntidad.Modified
            Edit_Crear.TextBox1.Text = Examen.DataGridView1.CurrentRow.Cells(0).Value
            Edit_Crear.TextBox2.Text = Examen.DataGridView1.CurrentRow.Cells(1).Value
            Edit_Crear.TextBox3.Text = Examen.DataGridView1.CurrentRow.Cells(2).Value
            Edit_Crear.TextBox4.Text = Examen.DataGridView1.CurrentRow.Cells(3).Value
        Else
            MessageBox.Show("Seleccione una fila")
        End If
    End Sub
End Class
