Public Class Save
    Public Sub save(Modelo)
        Dim result
        Select Case Modelo.clase
            Case "clientes"
                Modelo.Cliente = Edit.TextBox2.Text
                Modelo.Telefono = Edit.TextBox3.Text
                Modelo.Correo = Edit.TextBox4.Text
                result = Modelo.saveChanges()
                MessageBox.Show(result)
                Examen.DataGridView1.DataSource = Modelo.GetClients()
            Case "productos"
                Modelo.Nombre = Edit.TextBox2.Text
                Modelo.Precio = Edit.TextBox3.Text
                Modelo.Categoria = Edit.TextBox4.Text
                result = Modelo.saveChanges()
                MessageBox.Show(result)
                Examen.DataGridView1.DataSource = Modelo.GetProducts()
        End Select
    End Sub
End Class
