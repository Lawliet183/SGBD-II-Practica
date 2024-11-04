Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop

Public Class FormCatalogoProductos
    Dim conexion As MySqlConnection

    Private Sub FormCatalogoProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de producto', " &
            "descripcion as 'Descripcion', " &
            "precio_venta as 'Precio', " &
            "stock as 'Stock' " &
            "FROM Productos"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de producto', " &
            "descripcion as 'Descripcion', " &
            "precio_venta as 'Precio', " &
            "stock as 'Stock' " &
            "FROM Productos " &
            "WHERE nombre like '" & ct_nombre.Text & "%'"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btResetear_Click(sender As Object, e As EventArgs) Handles btResetear.Click
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de producto', " &
            "descripcion as 'Descripcion', " &
            "precio_venta as 'Precio', " &
            "stock as 'Stock' " &
            "FROM Productos"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btExportar_Click(sender As Object, e As EventArgs) Handles btExportar.Click
        'ConvertirGridAExcel(DataGridView1)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class