Public Class DetalleCompra
    Friend idDetalleCompra As Integer
    Friend idCompra As Integer
    Friend Producto As String
    Friend cantidad As Integer
    Friend precioCompra As Decimal

    Public Sub New(ByVal idDetalleCompra As Integer, ByVal idCompra As Integer, ByVal Producto As String, ByVal cantidad As Integer, ByVal precioCompra As Decimal)
        Me.idDetalleCompra = idDetalleCompra
        Me.idCompra = idCompra
        Me.Producto = Producto
        Me.cantidad = cantidad
        Me.precioCompra = precioCompra
    End Sub
End Class
