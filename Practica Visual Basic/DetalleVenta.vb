Public Class DetalleVenta
    Friend idDetalleVenta As Integer
    Friend idVenta As Integer
    Friend idProducto As Integer
    Friend cantidad As Integer
    Friend precioUnitario As Decimal

    Public Sub New(ByVal idDetalleVenta As Integer, ByVal idVenta As Integer, ByVal idProducto As Integer, ByVal cantidad As Integer, ByVal precioUnitario As Decimal)
        Me.idDetalleVenta = idDetalleVenta
        Me.idVenta = idVenta
        Me.idProducto = idProducto
        Me.cantidad = cantidad
        Me.precioUnitario = precioUnitario
    End Sub
End Class
