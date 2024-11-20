Public Class GuardarVentas

    Public Sub saveVentas(Modelo)
        Dim result
        Modelo.IDCliente = EditVentas.TextBox2.Text
        Modelo.Fecha = EditVentas.TextBox3.Text
        Modelo.Total = EditVentas.TextBox4.Text
        result = Modelo.saveChanges()
        MessageBox.Show(result)
        Examen.DataGridView1.DataSource = Modelo.GetVentas()
    End Sub
End Class
