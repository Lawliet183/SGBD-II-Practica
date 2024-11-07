Imports MySql.Data.MySqlClient

Public Class FormReporteVentasPorFecha
    Dim conexion As MySqlConnection

    Private Sub FormReporteVentasPorFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
    End Sub

    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click
        Dim SQL As String = "SELECT " &
            "id_venta as 'ID de venta', " &
            "C.nombre as 'Nombre de cliente', " &
            "fecha_venta as 'Fecha de venta', " &
            "id_detalle as 'ID de detalle de venta', " &
            "P.nombre as 'Nombre de producto', " &
            "cantidad as 'Cantidad', " &
            "precio_unitario as 'Precio unitario', " &
            "total as 'Total' " &
            "FROM Ventas as V " &
            "NATURAL JOIN Detalle_ventas as D " &
            "NATURAL JOIN Clientes as C " &
            "INNER JOIN Productos as P on D.id_producto = P.id_producto " &
            "WHERE fecha_venta BETWEEN '" & dtp_fechaInicio.Text & "' AND '" & dtp_fechaFin.Text & "' " &
            "ORDER BY fecha_venta asc"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btExportar_Click(sender As Object, e As EventArgs) Handles btExportar.Click
        ConvertirGridAExcel(DataGridView1)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class