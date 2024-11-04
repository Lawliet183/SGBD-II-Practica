Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormUsuarios
    Dim conexion As MySqlConnection

    Private Sub FormUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT * from Usuarios"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Si se selecciono una fila valida, popular las cajas de texto con los datos de la tabla seleccionada
        If e.RowIndex >= 0 Then
            Dim usuario As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Orden SQL para conseguir el usuario que se ha seleccionado
            Dim SQL As String = "SELECT * FROM Usuarios " &
                "WHERE id_usuario = '" & usuario & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idUsuario.Text = lectura("id_usuario").ToString()
                    Me.ct_username.Text = lectura("username").ToString()
                    Me.ct_password.Text = lectura("password").ToString()
                    Me.ct_rol.Text = lectura("rol").ToString()
                End If

                lectura.Close()
            Catch ex As Exception
                MessageBox.Show("Error al leer los datos: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        LimpiarTexto()
    End Sub

    Private Sub LimpiarTexto()
        Me.ct_idUsuario.Text = ""
        Me.ct_username.Text = ""
        Me.ct_password.Text = ""
        Me.ct_rol.Text = ""

        Me.ct_username.Focus()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        ' Revisar que todos los campos contengan algo antes de continuar
        If ct_username.Text = "" Then
            MessageBox.Show("Digite el nombre del usuario")
            ct_username.Focus()
            Exit Sub
        End If

        If ct_password.Text = "" Then
            MessageBox.Show("Digite la contraseña")
            ct_password.Focus()
            Exit Sub
        End If

        If ct_rol.Text = "" Then
            MessageBox.Show("Digite el rol")
            ct_rol.Focus()
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


        ' Orden SQL para conseguir los usuarios que coincidan con el ID de usuario en la caja de texto (si lo hubiera)
        Dim SQL As String = "select id_usuario " &
            "from Usuarios " &
            "WHERE id_usuario = '" & ct_idUsuario.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim tipoModificacion As String

        ' Si la orden SQL retorno algo, se actualiza el registro (UPDATE); 
        ' De lo contrario, se inserta el nuevo registro (INSERT)
        If lectura.HasRows Then
            tipoModificacion = "Actualizado"
            SQL = "UPDATE Usuarios " &
                "set username='" & ct_username.Text & "'," &
                "password='" & ct_password.Text & "'," &
                "rol='" & ct_rol.Text & "'," &
                "where id_usuario='" & ct_idUsuario.Text & "'"
        Else
            tipoModificacion = "Guardado"
            SQL = "INSERT INTO Usuarios values" &
                "(null," &
                "'" & ct_username.Text & "'," &
                "md5('" & ct_password.Text & "')," &
                "'" & ct_rol.Text & "')"
        End If

        lectura.Close()

        ' Si se trata de realizar una operacion invalida, indicarla al usuario
        cmd.CommandText = SQL
        Try
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

        MessageBox.Show("Registro " & tipoModificacion)

        LimpiarTexto()

        ' Cargar nuevamente la tabla con los datos actualizados
        SQL = "SELECT * from Usuarios order by username"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        ' Comprobar que se ha seleccionado un registro de la tabla
        If ct_idUsuario.Text = "" Then
            MessageBox.Show("Seleccione un usuario")
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

        ' Orden SQL para borrar el usuario que se ha seleccionado
        Dim SQL As String = "delete from Usuarios " &
            "WHERE id_usuario = '" & ct_idUsuario.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()

        MessageBox.Show("Registro borrado")

        LimpiarTexto()

        ' Cargar de nuevo la tabla con lo datos actualizados
        SQL = "SELECT * from Usuarios order by username"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class