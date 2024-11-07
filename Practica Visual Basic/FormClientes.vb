Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormClientes
    Dim conexion As MySqlConnection

    Private Sub FormClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT * from Clientes order by id_cliente"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Si se selecciono una fila valida, popular las cajas de texto con los datos de la tabla seleccionada
        If e.RowIndex >= 0 Then
            Dim cliente As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Orden SQL para conseguir el cliente que se ha seleccionado
            Dim SQL As String = "SELECT * FROM Clientes " &
                "WHERE id_cliente = '" & cliente & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idCliente.Text = lectura("id_cliente").ToString()
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

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        LimpiarTexto()
    End Sub

    Private Sub LimpiarTexto()
        Me.ct_idCliente.Text = ""
        Me.ct_nombre.Text = ""
        Me.ct_direccion.Text = ""
        Me.ct_telefono.Text = ""
        Me.ct_correo.Text = ""

        Me.ct_nombre.Focus()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        ' Revisar que todos los campos contengan algo antes de continuar
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del cliente")
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


        ' Orden SQL para conseguir los clientes que coincidan con el ID de cliente en la caja de texto (si lo hubiera)
        Dim SQL As String = "select id_cliente " &
            "from Clientes " &
            "WHERE id_cliente = '" & ct_idCliente.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim tipoModificacion As String

        ' Si la orden SQL retorno algo, se actualiza el registro (UPDATE); 
        ' De lo contrario, se inserta el nuevo registro (INSERT)
        If lectura.HasRows Then
            tipoModificacion = "Actualizado"
            SQL = "UPDATE Clientes " &
                "set nombre='" & ct_nombre.Text & "'," &
                "direccion='" & ct_direccion.Text & "'," &
                "telefono='" & ct_telefono.Text & "'," &
                "email='" & ct_correo.Text & "'" &
                "where id_cliente='" & ct_idCliente.Text & "'"
        Else
            tipoModificacion = "Guardado"
            SQL = "INSERT INTO Clientes values" &
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

        LimpiarTexto()

        ' Cargar nuevamente la tabla con los datos actualizados
        SQL = "SELECT * from Clientes order by id_cliente"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        ' Comprobar que se ha seleccionado un registro de la tabla
        If ct_idCliente.Text = "" Then
            MessageBox.Show("Seleccione un cliente")
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

        ' Orden SQL para borrar el cliente que se ha seleccionado
        Dim SQL As String = "delete from Clientes " &
            "WHERE id_cliente = '" & ct_idCliente.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()

        MessageBox.Show("Registro borrado")

        LimpiarTexto()

        ' Cargar de nuevo la tabla con lo datos actualizados
        SQL = "SELECT * from Clientes order by id_cliente"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class