Imports System.Data.SqlClient
Imports AccesoDatos
Public Class ClienteModelo
    Private _ID As Integer
    Private _Cliente As String
    Private _Telefono As String
    Private _Correo As String
    Private _Estado As EstadoEntidad
    Private Repositorio As ICliente
    Private ClientListViewModel As List(Of ClienteModelo)
    Public clase = "clientes"

    Public Property ID As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _Cliente
        End Get
        Set(value As String)
            _Cliente = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
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
        Repositorio = New ClientesRepo()
    End Sub

    Public Function saveChanges() As String
        Dim message As String = Nothing

        Try
            Dim clientDataModel As New Cliente()
            clientDataModel.ID = ID
            clientDataModel.Cliente = Cliente
            clientDataModel.Telefono = Telefono
            clientDataModel.Correo = Correo

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

    Public Function GetClients() As List(Of ClienteModelo)
        Dim ClientListDataModel = Repositorio.GetAll()
        ClientListViewModel = New List(Of ClienteModelo)

        For Each item As Cliente In ClientListDataModel
            ClientListViewModel.Add(New ClienteModelo With {
                .ID = item.ID,
                .Cliente = item.Cliente,
                .Correo = item.Correo,
                .Telefono = item.Telefono
            })
        Next

        Return ClientListViewModel
    End Function

    Public Function FindById(filter As String) As IEnumerable(Of ClienteModelo)
        Return ClientListViewModel.FindAll(Function(cli) cli.Cliente.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0 OrElse cli.Correo.Contains(filter))
    End Function
End Class
