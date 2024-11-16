Imports System.Data.SqlClient
Imports AccesoDatos
Public Class ProductoModelo
    Private _ID As Integer
    Private _Nombre As String
    Private _Precio As Decimal
    Private _Categoria As String
    Private _Estado As EstadoEntidad
    Private Repositorio As IProducto
    Private ProductListViewModel As List(Of ProductoModelo)
    Public clase = "productos"

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _Precio
        End Get
        Set(value As Decimal)
            _Precio = value
        End Set
    End Property

    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(value As String)
            _Categoria = value
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
        Repositorio = New ProductosRepo()
    End Sub

    Public Function saveChanges() As String
        Dim message As String = Nothing

        Try
            Dim clientDataModel As New Producto()
            clientDataModel.ID = ID
            clientDataModel.Nombre = Nombre
            clientDataModel.Precio = Precio
            clientDataModel.Categoria = Categoria

            Select Case Estado
                Case EstadoEntidad.Added
                    Repositorio.Add(clientDataModel)
                    message = "Agregado correctamente"
                Case EstadoEntidad.Modified
                    Repositorio.Edit(clientDataModel)
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

    Public Function GetProducts() As List(Of ProductoModelo)
        Dim ProductDataList = Repositorio.GetAll()
        ProductListViewModel = New List(Of ProductoModelo)

        For Each item As Producto In ProductDataList
            ProductListViewModel.Add(New ProductoModelo With {
                .ID = item.ID,
                .Nombre = item.Nombre,
                .Precio = item.Precio,
                .Categoria = item.Categoria
            })
        Next

        Return ProductListViewModel
    End Function
End Class
