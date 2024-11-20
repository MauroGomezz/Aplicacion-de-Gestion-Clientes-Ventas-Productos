Imports Dominio
Public Class Examen
    Public clienteModelo As New ClienteModelo
    Public productoModelo As New ProductoModelo
    Public ventaModelo As New VentaModelo
    Public modelo = clienteModelo
    Public accion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = clienteModelo.GetClients()
        ClientesToolStripMenuItem.BackColor = Color.DarkGray
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        DataGridView1.DataSource = clienteModelo.FindById(TextBox1.Text)
    End Sub

    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles Agregar.Click
        accion = "agregar"
        If VentasToolStripMenuItem.BackColor = Color.DarkGray Then
            EditVentas.Show()
        Else
            Edit_Crear.Show()
        End If
    End Sub

    Private Sub Actualizar_Click(sender As Object, e As EventArgs) Handles Actualizar.Click
        accion = "editar"
        If VentasToolStripMenuItem.BackColor = Color.DarkGray Then
            EditVentas.Show()
        Else
            Edit_Crear.Show()
        End If
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            modelo.ID = DataGridView1.CurrentRow.Cells(0).Value
            modelo.Estado = EstadoEntidad.Deleted
            Dim result = modelo.saveChanges()
            MessageBox.Show(result)
            If ProductosToolStripMenuItem.BackColor = Color.DarkGray Then
                DataGridView1.DataSource = productoModelo.GetProducts()
            ElseIf ClientesToolStripMenuItem.BackColor = Color.DarkGray Then
                DataGridView1.DataSource = clienteModelo.GetClients()
            ElseIf VentasToolStripMenuItem.BackColor = Color.DarkGray Then
                DataGridView1.DataSource = ventaModelo.GetVentas()
            End If
        Else
            MessageBox.Show("Seleccione una fila")
        End If
    End Sub

    Public Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        modelo = productoModelo
        DataGridView1.DataSource = productoModelo.GetProducts()
        ProductosToolStripMenuItem.BackColor = Color.DarkGray
        ClientesToolStripMenuItem.BackColor = Color.White
        VentasToolStripMenuItem.BackColor = Color.White
    End Sub

    Public Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        modelo = clienteModelo
        DataGridView1.DataSource = clienteModelo.GetClients()
        ClientesToolStripMenuItem.BackColor = Color.DarkGray
        ProductosToolStripMenuItem.BackColor = Color.White
        VentasToolStripMenuItem.BackColor = Color.White
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        modelo = ventaModelo
        DataGridView1.DataSource = ventaModelo.GetVentas()
        VentasToolStripMenuItem.BackColor = Color.DarkGray
        ClientesToolStripMenuItem.BackColor = Color.White
        ProductosToolStripMenuItem.BackColor = Color.White
    End Sub

End Class
