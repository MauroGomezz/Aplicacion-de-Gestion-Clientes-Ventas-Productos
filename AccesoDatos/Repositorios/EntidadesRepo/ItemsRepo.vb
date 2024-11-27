Imports System.Data
Imports System.Data.SqlClient
Public Class ItemsRepo
    Inherits MasterRepo
    Implements IVentaItem

    Private selectAll
    Private insert
    Private update
    Private delete

    Public Sub New()
        selectAll = "select * from ventasitems"
        insert = "insert into ventasitems values(@IDVenta,@IDProducto,@PrecioUnitario,@Cantidad,@PrecioTotal)"
        update = "update ventasitems set IDProducto=@IDProducto,PrecioUnitario=@PrecioUnitario,Cantidad=@Cantidad where ID=@ID"
        delete = "delete from ventasitems where ID=@ID"
    End Sub
    Public Function GetTotal(precio As Integer, cantidad As Integer) As Integer Implements IVentaItem.GetTotal
        Dim total = precio * cantidad
        Return total
    End Function

    Public Function GetAll() As IEnumerable(Of VentaItem) Implements IGeneric(Of VentaItem).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim itemList = New List(Of VentaItem)

        For Each item As DataRow In resultTable.Rows
            itemList.Add(New VentaItem With {
                .ID = item(0),
                .IDVenta = item(1),
                .IDProducto = item(2),
                .PrecioUnitario = item(3),
                .Cantidad = item(4),
                .PrecioTotal = item(5)
            })
        Next
        Return itemList
    End Function

    Public Function Add(entity As VentaItem) As Integer Implements IGeneric(Of VentaItem).Add
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@IDVenta", entity.IDVenta),
            New SqlParameter("@IDProducto", entity.IDProducto),
            New SqlParameter("@PrecioUnitario", entity.PrecioUnitario),
            New SqlParameter("@Cantidad", entity.Cantidad),
            New SqlParameter("@PrecioTotal", GetTotal(entity.PrecioUnitario, entity.Cantidad))
            }
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As VentaItem) As Integer Implements IGeneric(Of VentaItem).Edit
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@ID", entity.ID),
            New SqlParameter("@IDVenta", entity.IDVenta),
            New SqlParameter("@IDProducto", entity.IDProducto),
            New SqlParameter("@PrecioUnitario", entity.PrecioUnitario),
            New SqlParameter("@Cantidad", entity.Cantidad),
            New SqlParameter("@PrecioTotal", GetTotal(entity.PrecioUnitario, entity.Cantidad))
        }
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGeneric(Of VentaItem).Remove
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@ID", id)
        }
        Return ExecuteNonQuery(delete)
    End Function

End Class
