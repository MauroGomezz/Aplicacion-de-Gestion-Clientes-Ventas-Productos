Public Interface IVentaItem
    Inherits IGeneric(Of VentaItem)
    Function GetTotal(precio As Integer, cantidad As Integer) As Integer
End Interface
