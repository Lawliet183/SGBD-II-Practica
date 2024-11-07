Imports MySql.Data.MySqlClient

Public Class FormReporteGanancias
    Dim conexion As New MySqlConnection

    Private Sub FormReporteGanancias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
    End Sub

    Private Sub btFiltrar_Click(sender As Object, e As EventArgs) Handles btFiltrar.Click
        Dim SQL As String = "SELECT DISTINCT " &
            "(SELECT SUM(total) FROM Ventas) AS 'Total de Ventas', " &
            "(SELECT SUM(total) FROM Compras) AS 'Total de Compras', " &
            "(SELECT SUM(total) FROM Ventas) - (SELECT SUM(total) FROM Compras) AS Ganancias " &
            "FROM Ventas, Compras " &
            "WHERE fecha_compra BETWEEN '" & dtp_fechaInicio.Text & "' AND '" & dtp_fechaFin.Text & "' " &
            "AND fecha_venta BETWEEN '" & dtp_fechaInicio.Text & "' AND '" & dtp_fechaFin.Text & "' " &
            "ORDER BY Ganancias DESC;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btExportar_Click(sender As Object, e As EventArgs) Handles btExportar.Click
        ConvertirGridAExcel(DataGridView1)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class