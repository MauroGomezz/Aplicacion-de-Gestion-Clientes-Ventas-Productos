Public Class ClientesLista
    Private Sub ClientesLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Examen.clienteModelo.GetClients()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditVentas.TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value
        Close()
    End Sub
End Class