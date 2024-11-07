Imports MySql.Data.MySqlClient

Public Class FormReporteComprasPorFecha
    Dim conexion As MySqlConnection

    Private Sub FormReporteComprasPorFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
    End Sub

    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click
        Dim SQL As String = "SELECT " &
            "id_compra as 'ID de compra', " &
            "Prov.nombre as 'Nombre de proveedor', " &
            "fecha_compra as 'Fecha de compra', " &
            "id_detalle_compra as 'ID de detalle de compra', " &
            "Prod.nombre as 'Nombre de producto', " &
            "cantidad as 'Cantidad', " &
            "D.precio_compra as 'Precio de compra', " &
            "total as 'Total' " &
            "FROM Compras as C " &
            "NATURAL JOIN Detalle_compras as D " &
            "NATURAL JOIN Proveedores as Prov " &
            "INNER JOIN Productos as Prod on D.id_producto = Prod.id_producto " &
            "WHERE fecha_compra BETWEEN '" & dtp_fechaInicio.Text & "' AND '" & dtp_fechaFin.Text & "' " &
            "ORDER BY fecha_compra asc"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btExportar_Click(sender As Object, e As EventArgs) Handles btExportar.Click
        ConvertirGridAExcel(DataGridView1)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class