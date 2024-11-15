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

        InicializarProveedores()
    End Sub

    Private Sub btResetear_Click(sender As Object, e As EventArgs) Handles btResetear.Click
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de proveedor', " &
            "direccion as 'Direccion', " &
            "telefono as 'Telefono', " &
            "email as 'Correo electronico' " &
            "FROM Proveedores"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
        comboBoxProveedor.Text = ""
    End Sub

    Private Sub btExportar_Click(sender As Object, e As EventArgs) Handles btExportar.Click
        ConvertirGridAExcel(DataGridView1)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub Buscar()
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de proveedor', " &
            "direccion as 'Direccion', " &
            "telefono as 'Telefono', " &
            "email as 'Correo electronico' " &
            "FROM Proveedores " &
            "WHERE nombre like '" & comboBoxProveedor.Text & "%'"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub comboBoxProveedor_TextChanged(sender As Object, e As EventArgs) Handles comboBoxProveedor.TextChanged
        Buscar()
    End Sub

    Private Sub InicializarProveedores()
        Dim orden As String = "select nombre from proveedores"
        Dim campo As String = "nombre"

        Dim dataReader As MySqlDataReader = Nothing
        Try
            Dim comando As New MySqlCommand(orden, conexion)
            dataReader = comando.ExecuteReader()
        Catch ex As Exception
            If dataReader IsNot Nothing And Not dataReader.IsClosed Then
                dataReader.Close()
            End If

            Exit Sub
        End Try

        While dataReader.Read()
            comboBoxProveedor.Items.Add(dataReader.GetString(campo))
        End While

        dataReader.Close()
    End Sub
End Class