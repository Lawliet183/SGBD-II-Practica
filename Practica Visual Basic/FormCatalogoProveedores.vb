Imports MySql.Data.MySqlClient

Public Class FormCatalogoProveedores
    Dim conexion As MySqlConnection

    Private Sub FormCatalogoProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de proveedor', " &
            "direccion as 'Direccion', " &
            "telefono as 'Telefono', " &
            "email as 'Correo electronico' " &
            "FROM Proveedores"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Buscar()
    End Sub

    Private Sub btResetear_Click(sender As Object, e As EventArgs) Handles btResetear.Click
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de proveedor', " &
            "direccion as 'Direccion', " &
            "telefono as 'Telefono', " &
            "email as 'Correo electronico' " &
            "FROM Proveedores"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
        ct_nombre.Text = ""
    End Sub

    Private Sub btExportar_Click(sender As Object, e As EventArgs) Handles btExportar.Click
        ConvertirGridAExcel(DataGridView1)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub ct_nombre_KeyDown(sender As Object, e As KeyEventArgs) Handles ct_nombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Buscar()
        End If
    End Sub

    Private Sub Buscar()
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de proveedor', " &
            "direccion as 'Direccion', " &
            "telefono as 'Telefono', " &
            "email as 'Correo electronico' " &
            "FROM Proveedores " &
            "WHERE nombre like '" & ct_nombre.Text & "%'"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub
End Class