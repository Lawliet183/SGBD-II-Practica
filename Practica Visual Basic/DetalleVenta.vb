Public Class DetalleVenta
    Friend idDetalleVenta As Integer
    Friend idVenta As Integer
    Friend Producto As String
    Friend cantidad As Integer
    Friend precioUnitario As Decimal

    Public Sub New(ByVal idDetalleVenta As Integer, ByVal idVenta As Integer, ByVal Producto As String, ByVal cantidad As Integer, ByVal precioUnitario As Decimal)
        Me.idDetalleVenta = idDetalleVenta
        Me.idVenta = idVenta
        Me.Producto = Producto
        Me.cantidad = cantidad
        Me.precioUnitario = precioUnitario
    End Sub
End Class
