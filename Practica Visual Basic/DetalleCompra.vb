Public Class DetalleCompra
    Friend idDetalleCompra As Integer
    Friend idCompra As Integer
    Friend idProducto As Integer
    Friend cantidad As Integer
    Friend precioCompra As Decimal

    Public Sub New(ByVal idDetalleCompra As Integer, ByVal idCompra As Integer, ByVal idProducto As Integer, ByVal cantidad As Integer, ByVal precioCompra As Decimal)
        Me.idDetalleCompra = idDetalleCompra
        Me.idCompra = idCompra
        Me.idProducto = idProducto
        Me.cantidad = cantidad
        Me.precioCompra = precioCompra
    End Sub
End Class
