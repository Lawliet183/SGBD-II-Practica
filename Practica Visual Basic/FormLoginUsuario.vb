Imports MySql.Data.MySqlClient

Public Class FormLoginUsuario
    Private Sub bt_enviar_Click(sender As Object, e As EventArgs) Handles bt_enviar.Click
        ' Revisar si el nombre de usuario esta vacio
        If ct_usuario.Text = "" Then
            MsgBox("Digite el usuario")
            ct_usuario.Focus()
            Exit Sub
        End If

        ' Revisar si la contraseña esta vacia
        If ct_clave.Text = "" Then
            MsgBox("Digite la contraseña")
            ct_clave.Focus()
            Exit Sub
        End If

        ' Orden SQL para encontrar el usuario con el nombre y contraseña especificado
        Dim SQL As String = "select * from usuarios " &
            "WHERE username = '" & ct_usuario.Text & "' " &
            "and password = md5('" & ct_clave.Text & "');"

        Dim conexion As MySqlConnection = FormMenuPrincipal.ConseguirConexion()
        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text
        Dim lectura As MySqlDataReader = cmd.ExecuteReader()

        ' Si hay coincidencias, cerrar el formulario de login; de lo contrario, indicar que el usuario o clave es invalido
        If lectura.HasRows Then
            'FormMenuPrincipal.Show()
            Me.Close()
        Else
            MsgBox("Usuario o clave invalido")
            ct_usuario.Text = ""
            ct_clave.Text = ""
            ct_usuario.Focus()
        End If

        lectura.Close()
    End Sub
End Class