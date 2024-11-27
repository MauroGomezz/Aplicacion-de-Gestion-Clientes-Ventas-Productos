Imports System.Data.SqlClient
Imports AccesoDatos
Public Class ItemsModelo
    Private _ID As Integer
    Private _IDVenta As Integer
    Private _IDProducto As Integer
    Private _PrecioUnitario As Double
    Private _Cantidad As Integer
    Private _PrecioTotal As Double
    Private _Estado As EstadoEntidad
    Private Repositorio As IVentaItem
    Private ItemListViewModel As List(Of ItemsModelo)
    Public clase = "items"

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property IDVenta As Integer
        Get
            Return _IDVenta
        End Get
        Set(value As Integer)
            _IDVenta = value
        End Set
    End Property

    Public Property IDProducto As Integer
        Get
            Return _IDProducto
        End Get
        Set(value As Integer)
            _IDProducto = value
        End Set
    End Property

    Public Property PrecioUnitario As Double
        Get
            Return _PrecioUnitario
        End Get
        Set(value As Double)
            _PrecioUnitario = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _Cantidad
        End Get
        Set(value As Integer)
            _Cantidad = value
        End Set
    End Property

    Public Property PrecioTotal As Double
        Get
            Return _PrecioTotal
        End Get
        Set(value As Double)
            _PrecioTotal = value
        End Set
    End Property

    Public Property Estado As EstadoEntidad
        Private Get
            Return _Estado
        End Get
        Set(value As EstadoEntidad)
            _Estado = value
        End Set
    End Property

    Public Sub New()
        Repositorio = New ItemsRepo()
    End Sub

    Public Function saveChanges() As String
        Dim message As String = Nothing

        Try
            Dim ItemDataModel As New VentaItem()
            ItemDataModel.ID = ID
            ItemDataModel.IDVenta = IDVenta
            ItemDataModel.IDProducto = IDProducto
            ItemDataModel.PrecioUnitario = PrecioUnitario
            ItemDataModel.Cantidad = Cantidad
            ItemDataModel.PrecioTotal = PrecioTotal

            Select Case Estado
                Case EstadoEntidad.Added
                    Repositorio.Add(ItemDataModel)
                    message = "Agregado correctamente"
                Case EstadoEntidad.Modified
                    Repositorio.Edit(ItemDataModel)
                    message = "Modificado correctamente"
                Case EstadoEntidad.Deleted
                    Repositorio.Remove(ID)
                    message = "Eliminado correctamente"
            End Select
        Catch ex As Exception
            Dim sqlEx As SqlException = TryCast(ex, SqlException)
            If sqlEx IsNot Nothing AndAlso sqlEx.Number = 2627 Then
                message = "Error de dupicacion"
            Else
                message = ex.ToString()
            End If
        End Try

        Return message
    End Function

    Public Function GetItems() As List(Of ItemsModelo)
        Dim ItemDataList = Repositorio.GetAll()
        ItemListViewModel = New List(Of ItemsModelo)

        For Each item As VentaItem In ItemDataList
            ItemListViewModel.Add(New ItemsModelo With {
                .ID = item.ID,
                .IDVenta = item.IDVenta,
                .IDProducto = item.IDProducto,
                .PrecioUnitario = item.PrecioUnitario,
                .Cantidad = item.Cantidad,
                .PrecioTotal = item.PrecioTotal
            })
        Next

        Return ItemListViewModel
    End Function
End Class
