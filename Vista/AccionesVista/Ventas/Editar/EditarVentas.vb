Imports Dominio
Public Class EditarVentas
    Public Sub actualizarVentas(modelo)
        If Examen.DataGridView1.SelectedRows.Count > 0 Then
            modelo.ID = Examen.DataGridView1.CurrentRow.Cells(0).Value
            modelo.Estado = EstadoEntidad.Modified
            EditVentas.TextBox1.Text = Examen.DataGridView1.CurrentRow.Cells(0).Value
            EditVentas.TextBox2.Text = Examen.DataGridView1.CurrentRow.Cells(1).Value
            EditVentas.TextBox3.Text = Examen.DataGridView1.CurrentRow.Cells(2).Value
            EditVentas.TextBox4.Text = Examen.DataGridView1.CurrentRow.Cells(3).Value
        Else
            MessageBox.Show("Seleccione una fila")
        End If
    End Sub
End Class
