Imports MySql.Data.MySqlClient

Public Class FormProveedores

    Dim conexion As New MySqlConnection

    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conexion = Conectar()
        Dim SQL As String = "SELECT * from Proveedores"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles btnuevo.Click
        Me.ct_idproveedor.Text = ""
        Me.ct_nombre.Text = ""
        Me.ct_direccion.Text = ""
        Me.ct_telefono.Text = ""
        Me.ct_correo.Text = ""

        Me.ct_nombre.Focus()
    End Sub

    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del proveedor")
            ct_nombre.Focus()
            Exit Sub
        End If

        If ct_direccion.Text = "" Then
            MessageBox.Show("Digite la dirección")
            ct_direccion.Focus()
            Exit Sub
        End If

        If ct_telefono.Text = "" Then
            MessageBox.Show("Digite el teléfono")
            ct_telefono.Focus()
            Exit Sub
        End If

        If ct_correo.Text = "" Then
            MessageBox.Show("Digite el correo")
            ct_correo.Focus()
            Exit Sub
        End If


        Dim respuesta As DialogResult = MessageBox.Show(
            "Desea guardar el registro?",
            "Sistema de Inventario",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
            )

        If respuesta = DialogResult.No Then
            Exit Sub
        End If


        Dim SQL As String = "select id_proveedor " &
            "from Proveedores " &
            "WHERE id_proveedor = '" & ct_idproveedor.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim tipoModificacion As String
        If lectura.HasRows Then
            tipoModificacion = "Actualizado"
            SQL = "UPDATE Proveedores " &
                "set nombre='" & ct_nombre.Text & "'," &
                "direccion='" & ct_direccion.Text & "'," &
                "telefono='" & ct_telefono.Text & "'," &
                "email='" & ct_correo.Text & "'" &
                "where id_proveedor='" & ct_idproveedor.Text & "'"
        Else
            tipoModificacion = "Guardado"
            SQL = "INSERT INTO Proveedores values" &
                "(null," &
                "'" & ct_nombre.Text & "'," &
                "'" & ct_direccion.Text & "'," &
                "'" & ct_telefono.Text & "'," &
                "'" & ct_correo.Text & "')"
        End If

        lectura.Close()

        cmd.CommandText = SQL
        cmd.ExecuteNonQuery()
        MessageBox.Show("Registro " & tipoModificacion)

        bt_nuevo_Click(Nothing, Nothing)

        SQL = "SELECT * from Proveedores order by nombre"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub bt_borrar_Click(sender As Object, e As EventArgs) Handles btborrar.Click
        If ct_idproveedor.Text = "" Then
            MessageBox.Show("Seleccione un proveedor")
            Exit Sub
        End If

        Dim respuesta = MessageBox.Show(
            "Desea eliminar el registro?",
            "Sistema de Inventario",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1
            )

        If respuesta = DialogResult.No Then
            Exit Sub
        End If

        Dim SQL As String = "delete from Proveedores " &
            "WHERE id_proveedor = '" & ct_idproveedor.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()

        MessageBox.Show("Registro borrado")

        bt_nuevo_Click(Nothing, Nothing)

        SQL = "SELECT * from Proveedores order by nombre"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub bt_salir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim proveedor As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            Dim SQL As String = "SELECT * FROM Proveedores " &
                "WHERE id_proveedor = '" & proveedor & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idproveedor.Text = lectura("id_proveedor").ToString()
                    Me.ct_nombre.Text = lectura("nombre").ToString()
                    Me.ct_direccion.Text = lectura("direccion").ToString()
                    Me.ct_telefono.Text = lectura("telefono").ToString()
                    Me.ct_correo.Text = lectura("email").ToString()
                End If

                lectura.Close()
            Catch ex As Exception
                MessageBox.Show("Error al leer los datos: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub ct_nombre_TextChanged(sender As Object, e As EventArgs) Handles ct_nombre.TextChanged

    End Sub
End Class
