Imports System.Data
Imports System.Data.SqlClient
Public Class VentasRepo
    Inherits MasterRepo
    Implements IVenta

    Private selectAll
    Private insert
    Private update
    Private delete

    Public Sub New()
        selectAll = "select * from ventas"
        insert = "insert into ventas values(@IDCliente,@Fecha,@Total)"
        update = "update Ventas set IDCliente=@IDCliente,Fecha=@Fecha,Total=@Total where ID=@ID"
        delete = "delete from ventas where ID=@ID"
    End Sub

    Public Function GetAll() As IEnumerable(Of Venta) Implements IGeneric(Of Venta).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim ventaList = New List(Of Venta)

        For Each item As DataRow In resultTable.Rows
            ventaList.Add(New Venta With {
                .ID = item(0),
                .IDCliente = item(1),
                .Fecha = item(2),
                .Total = item(3)
            })
        Next
        Return ventaList
    End Function

    Public Function Add(entity As Venta) As Integer Implements IGeneric(Of Venta).Add
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@IDCliente", entity.IDCliente),
            New SqlParameter("@Fecha", entity.Fecha()),
            New SqlParameter("@Total", entity.Total)
        }
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Venta) As Integer Implements IGeneric(Of Venta).Edit
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@ID", entity.ID),
            New SqlParameter("@IDCliente", entity.IDCliente),
            New SqlParameter("@Fecha", entity.Fecha()),
            New SqlParameter("@Total", entity.Total)
        }
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGeneric(Of Venta).Remove
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@ID", id)
        }
        Return ExecuteNonQuery(delete)
    End Function
End Class
