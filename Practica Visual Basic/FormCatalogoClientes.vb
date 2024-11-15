Imports MySql.Data.MySqlClient

Public Class FormCatalogoClientes
    Dim conexion As MySqlConnection

    Private Sub FormCatalogoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de cliente', " &
            "direccion as 'Direccion', " &
            "telefono as 'Telefono', " &
            "email as 'Correo electronico' " &
            "FROM Clientes"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)

        InicializarClientes()
    End Sub

    Private Sub btResetear_Click(sender As Object, e As EventArgs) Handles btResetear.Click
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de cliente', " &
            "direccion as 'Direccion', " &
            "telefono as 'Telefono', " &
            "email as 'Correo electronico' " &
            "FROM Clientes"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
        comboBoxCliente.Text = ""
    End Sub

    Private Sub btExportar_Click(sender As Object, e As EventArgs) Handles btExportar.Click
        ConvertirGridAExcel(DataGridView1)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub Buscar()
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de cliente', " &
            "direccion as 'Direccion', " &
            "telefono as 'Telefono', " &
            "email as 'Correo electronico' " &
            "FROM Clientes " &
            "WHERE nombre like '" & comboBoxCliente.Text & "%'"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub comboBoxCliente_TextChanged(sender As Object, e As EventArgs) Handles comboBoxCliente.TextChanged
        Buscar()
    End Sub

    Private Sub InicializarClientes()
        Dim orden As String = "select nombre from clientes"
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
            comboBoxCliente.Items.Add(dataReader.GetString(campo))
        End While

        dataReader.Close()
    End Sub
End Class