Imports System.Data.SqlClient
Imports AccesoDatos
Public Class VentaModelo
    Private _ID As Integer
    Private _IDCliente As Integer
    Private _Fecha As Date
    Private _Total As Double
    Private _Estado As EstadoEntidad
    Private Repositorio As IVenta
    Private VentaListViewModel As List(Of VentaModelo)
    Public clase = "ventas"

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property IDCliente As String
        Get
            Return _IDCliente
        End Get
        Set(value As String)
            _IDCliente = value
        End Set
    End Property

    Public Property Fecha As String
        Get
            Return _Fecha
        End Get
        Set(value As String)
            _Fecha = value
        End Set
    End Property

    Public Property Total As String
        Get
            Return _Total
        End Get
        Set(value As String)
            _Total = value
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
        Repositorio = New VentasRepo()
    End Sub

    Public Function saveChanges() As String
        Dim message As String = Nothing

        Try
            Dim VentaDataModel As New Venta()
            VentaDataModel.ID = ID
            VentaDataModel.IDCliente = IDCliente
            VentaDataModel.Fecha = Fecha
            VentaDataModel.Total = Total

            Select Case Estado
                Case EstadoEntidad.Added
                    Repositorio.Add(VentaDataModel)
                    message = "Agregado correctamente"
                Case EstadoEntidad.Modified
                    Repositorio.Edit(VentaDataModel)
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

    Public Function GetVentas() As List(Of VentaModelo)
        Dim VentaDataList = Repositorio.GetAll()
        VentaListViewModel = New List(Of VentaModelo)

        For Each item As Venta In VentaDataList
            VentaListViewModel.Add(New VentaModelo With {
                .ID = item.ID,
                .IDCliente = item.IDCliente,
                .Fecha = item.Fecha,
                .Total = item.Total
            })
        Next

        Return VentaListViewModel
    End Function
End Class
