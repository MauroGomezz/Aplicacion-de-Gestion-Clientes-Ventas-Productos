Imports System.Data
Imports System.Data.SqlClient
Public Class ProductosRepo
    Inherits MasterRepo
    Implements IProducto

    Private selectAll
    Private insert
    Private update
    Private delete

    Public Sub New()
        selectAll = "select * from productos"
        insert = "insert into productos values(@Nombre,@Precio,@Categoria)"
        update = "update productos set Nombre=@Nombre,Precio=@Precio,Categoria=@Categoria where ID=@ID"
        delete = "delete from productos where ID=@ID"
    End Sub

    Public Function GetAll() As IEnumerable(Of Producto) Implements IGeneric(Of Producto).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim clientList = New List(Of Producto)

        For Each item As DataRow In resultTable.Rows
            clientList.Add(New Producto With {
                .ID = item(0),
                .Nombre = item(1),
                .Precio = item(2),
                .Categoria = item(3)
            })
        Next
        Return clientList
    End Function

    Public Function Add(entity As Producto) As Integer Implements IGeneric(Of Producto).Add
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@Nombre", entity.Nombre),
            New SqlParameter("@Precio", entity.Precio),
            New SqlParameter("@Categoria", entity.Categoria)
        }
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Producto) As Integer Implements IGeneric(Of Producto).Edit
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@ID", entity.ID),
            New SqlParameter("@Nombre", entity.Nombre),
            New SqlParameter("@Precio", entity.Precio),
            New SqlParameter("@Categoria", entity.Categoria)
        }
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGeneric(Of Producto).Remove
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@ID", id)
        }
        Return ExecuteNonQuery(delete)
    End Function
End Class
