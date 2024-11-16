Imports System.Data
Imports System.Data.SqlClient
Public Class ClientesRepo
    Inherits MasterRepo
    Implements ICliente

    Private selectAll
    Private insert
    Private update
    Private delete

    Public Sub New()
        selectAll = "select * from clientes"
        insert = "insert into clientes values(@Cliente,@Telefono,@Correo)"
        update = "update clientes set Cliente=@Cliente,Telefono=@Telefono,Correo=@Correo where ID=@ID"
        delete = "delete from clientes where ID=@ID"
    End Sub

    Public Function GetAll() As IEnumerable(Of Cliente) Implements IGeneric(Of Cliente).GetAll
        Dim resultTable = ExecuteReader(selectAll)
        Dim clientList = New List(Of Cliente)

        For Each item As DataRow In resultTable.Rows
            clientList.Add(New Cliente With {
                .ID = item(0),
                .Cliente = item(1),
                .Telefono = item(2),
                .Correo = item(3)
            })
        Next
        Return clientList
    End Function

    Public Function Add(entity As Cliente) As Integer Implements IGeneric(Of Cliente).Add
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@Cliente", entity.Cliente),
            New SqlParameter("@Telefono", entity.Telefono),
            New SqlParameter("@Correo", entity.Correo)
        }
        Return ExecuteNonQuery(insert)
    End Function

    Public Function Edit(entity As Cliente) As Integer Implements IGeneric(Of Cliente).Edit
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@ID", entity.ID),
            New SqlParameter("@Cliente", entity.Cliente),
            New SqlParameter("@Telefono", entity.Telefono),
            New SqlParameter("@Correo", entity.Correo)
        }
        Return ExecuteNonQuery(update)
    End Function

    Public Function Remove(id As Integer) As Integer Implements IGeneric(Of Cliente).Remove
        parameters = New List(Of SqlParameter) From {
            New SqlParameter("@ID", id)
        }
        Return ExecuteNonQuery(delete)
    End Function
End Class
