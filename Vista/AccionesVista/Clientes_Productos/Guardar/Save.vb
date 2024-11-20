Public Class Save
    Dim guardarVentas As New GuardarVentas
    Public Sub save(Modelo)
        Dim result
        Select Case Modelo.clase
            Case "clientes"
                Modelo.Cliente = Edit_Crear.TextBox2.Text
                Modelo.Telefono = Edit_Crear.TextBox3.Text
                Modelo.Correo = Edit_Crear.TextBox4.Text
                result = Modelo.saveChanges()
                MessageBox.Show(result)
                Examen.DataGridView1.DataSource = Modelo.GetClients()
            Case "productos"
                Modelo.Nombre = Edit_Crear.TextBox2.Text
                Modelo.Precio = Edit_Crear.TextBox3.Text
                Modelo.Categoria = Edit_Crear.TextBox4.Text
                result = Modelo.saveChanges()
                MessageBox.Show(result)
                Examen.DataGridView1.DataSource = Modelo.GetProducts()
            Case "Ventas"
                guardarVentas.saveVentas(Modelo)
        End Select
    End Sub
End Class
