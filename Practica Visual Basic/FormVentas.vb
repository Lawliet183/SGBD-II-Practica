Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormVentas
    Dim conexion As MySqlConnection
    Dim listaDetalleVentas As New List(Of DetalleVenta)

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT * from Ventas " &
            "natural join Detalle_ventas;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Si se selecciono una fila valida, popular las cajas de texto con los datos de la tabla seleccionada
        If e.RowIndex >= 0 Then
            Dim venta As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Orden SQL para conseguir la venta que se ha seleccionado
            Dim SQL As String = "SELECT * FROM Ventas " &
                "natural join Detalle_ventas " &
                "WHERE id_venta = '" & venta & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idVenta.Text = lectura("id_venta").ToString()
                    Me.ct_idDetalleVenta.Text = lectura("id_detalle").ToString()
                    Me.ct_idCliente.Text = lectura("id_cliente").ToString()
                    Me.ct_idProducto.Text = lectura("id_producto").ToString()
                    Me.ct_cantidad.Text = lectura("cantidad").ToString()
                    Me.ct_precio.Text = lectura("precio_unitario").ToString()
                    Me.ct_total.Text = lectura("total").ToString()
                    Me.dtp_fecha.Text = lectura("fecha_venta").ToString()
                End If

                lectura.Close()
            Catch ex As Exception
                MessageBox.Show("Error al leer los datos: " & ex.Message)
            End Try

            listaDetalleVentas = New List(Of DetalleVenta)
            AgregarDetalleVentas()
        End If
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        LimpiarTextoCompleto()
        listaDetalleVentas = New List(Of DetalleVenta)
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        ' Revisar que todos los campos contengan algo antes de continuar
        If ct_idCliente.Text = "" Then
            MessageBox.Show("Digite el ID del cliente")
            ct_idCliente.Focus()
            Exit Sub
        End If

        If ct_idProducto.Text = "" Then
            MessageBox.Show("Digite el ID del producto")
            ct_idProducto.Focus()
            Exit Sub
        End If

        If ct_cantidad.Text = "" Then
            MessageBox.Show("Digite la cantidad")
            ct_cantidad.Focus()
            Exit Sub
        End If

        If ct_precio.Text = "" Then
            MessageBox.Show("Digite el precio")
            ct_precio.Focus()
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


        ' Orden SQL para conseguir las ventas que coincidan con el ID de venta en la caja de texto (si lo hubiera)
        Dim SQL As String = "select id_venta " &
            "from Ventas " &
            "WHERE id_venta = '" & ct_idVenta.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim tipoModificacion As String

        ' Si se encuentra alguna coincidencia de ventas, actualizar el registro; de otra forma, insertarlo
        If lectura.HasRows Then
            tipoModificacion = "Actualizado"

            SQL = "UPDATE Ventas " &
                "set id_cliente = '" & ct_idCliente.Text & "', " &
                "fecha_venta = '" & dtp_fecha.Text & "', " &
                "total = '" & ct_total.Text & "' " &
                "where id_venta = '" & ct_idVenta.Text & "'"
        Else
            tipoModificacion = "Guardado"

            SQL = "INSERT INTO Ventas values" &
                "(null," &
                "'" & dtp_fecha.Text & "', " &
                "'" & ct_idCliente.Text & "', " &
                "'" & ct_total.Text & "')"
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

        ' Actualizar la caja de texto con la respectiva ID
        SQL = "select * from Ventas " &
            "where fecha_venta = '" & dtp_fecha.Text & "' " &
            "and id_cliente = '" & ct_idCliente.Text & "' " &
            "and total = '" & ct_total.Text & "'"

        cmd.CommandText = SQL
        lectura = cmd.ExecuteReader()

        If lectura.Read() = True Then
            Me.ct_idVenta.Text = lectura("id_venta").ToString()
        End If

        lectura.Close()

        AgregarDetalleVentas()


        ' Actualizar (o insertar) los registros de detalle de ventas
        For Each detalleVenta As DetalleVenta In listaDetalleVentas
            ' Orden SQL para iterar por cada detalle de venta
            SQL = "select id_detalle " &
                "from Detalle_ventas " &
                "where id_detalle = '" & detalleVenta.idDetalleVenta & "'"

            cmd.CommandText = SQL
            lectura = cmd.ExecuteReader()

            If lectura.HasRows Then
                SQL = "UPDATE Detalle_ventas " &
                    "set id_producto = '" & ct_idProducto.Text & "', " &
                    "cantidad = '" & ct_cantidad.Text & "', " &
                    "precio_unitario = '" & ct_precio.Text & "' " &
                    "where id_detalle = '" & ct_idDetalleVenta.Text & "'"
            Else
                SQL = "INSERT INTO Detalle_ventas values " &
                    "(null, " &
                    "'" & detalleVenta.idVenta & "', " &
                    "'" & detalleVenta.idProducto & "', " &
                    "'" & detalleVenta.cantidad & "', " &
                    "'" & detalleVenta.precioUnitario & "')"
            End If

            lectura.Close()
        Next

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

        LimpiarTextoCompleto()
        listaDetalleVentas = New List(Of DetalleVenta)

        ' Cargar nuevamente la tabla con los datos actualizados
        SQL = "SELECT * from Ventas natural join Detalle_ventas order by id_venta, id_detalle"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        ' Comprobar que se ha seleccionado un registro de la tabla
        If ct_idVenta.Text = "" Then
            MessageBox.Show("Seleccione una venta")
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

        respuesta = MessageBox.Show(
            "Desea eliminar la venta completa?",
            "Sistema de Inventario",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        Dim SQL As String
        If respuesta = DialogResult.Yes Then
            ' Orden SQL para borrar la venta que se ha seleccionado
            SQL = "delete from Ventas " &
                "WHERE id_venta = '" & ct_idVenta.Text & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
        Else
            ' Orden SQL para borrar el detalle de venta que se ha seleccionado
            SQL = "delete from Detalle_ventas " &
                "WHERE id_detalle = '" & ct_idDetalleVenta.Text & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
        End If

        MessageBox.Show("Registro borrado")

        LimpiarTextoCompleto()

        ' Cargar de nuevo la tabla con lo datos actualizados
        SQL = "SELECT * from Ventas natural join Detalle_ventas order by id_venta, id_detalle"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub btMas_Click(sender As Object, e As EventArgs) Handles btMas.Click
        AgregarDetalleVentas()
        LimpiarTextoDetalleVentas()
    End Sub

    Private Sub btMenos_Click(sender As Object, e As EventArgs) Handles btMenos.Click
        Dim idDetalleVenta As Integer
        If Not Integer.TryParse(ct_idDetalleVenta.Text, idDetalleVenta) Then
            MessageBox.Show("El ID debe ser un numero entero")
            Exit Sub
        End If

        Dim index As Integer = BuscarDetalleVenta(idDetalleVenta)

        If index < 0 Then
            MessageBox.Show("No se ha encontrado")
        Else
            listaDetalleVentas.RemoveAt(index)
            LimpiarTextoDetalleVentas()
        End If
    End Sub

    Private Sub LimpiarTextoCompleto()
        Me.ct_idVenta.Text = ""
        Me.ct_idDetalleVenta.Text = ""
        Me.ct_idCliente.Text = ""
        Me.ct_idProducto.Text = ""
        Me.ct_cantidad.Text = ""
        Me.ct_precio.Text = ""
        Me.ct_total.Text = ""
        Me.dtp_fecha.Text = ""

        Me.ct_idProducto.Focus()
    End Sub

    Private Function AgregarDetalleVentas() As Boolean
        Dim idDetalleVenta As Integer
        Integer.TryParse(ct_idDetalleVenta.Text, idDetalleVenta)

        Dim idVenta As Integer
        If Not Integer.TryParse(ct_idVenta.Text, idVenta) Then
            MessageBox.Show("El ID debe ser un numero entero")
            Return False
        End If

        Dim idProducto As Integer
        If Not Integer.TryParse(ct_idProducto.Text, idProducto) Then
            MessageBox.Show("El ID debe ser un numero entero")
            Return False
        End If

        Dim cantidad As Integer
        If Not Integer.TryParse(ct_cantidad.Text, cantidad) Then
            MessageBox.Show("La cantidad debe ser un numero entero")
            Return False
        End If

        Dim precioUnitario As Decimal
        If Not Decimal.TryParse(ct_precio.Text, precioUnitario) Then
            MessageBox.Show("El precio debe ser un numero")
            Return False
        End If

        Dim detalleVenta As New DetalleVenta(idDetalleVenta, idVenta, idProducto, cantidad, precioUnitario)
        listaDetalleVentas.Add(detalleVenta)

        Return True
    End Function

    Private Sub LimpiarTextoDetalleVentas()
        Me.ct_idDetalleVenta.Text = ""
        Me.ct_idProducto.Text = ""
        Me.ct_cantidad.Text = ""
        Me.ct_precio.Text = ""
    End Sub

    Private Function BuscarDetalleVenta(ByVal idDetalleVenta As Integer) As Integer
        For i As Integer = 0 To listaDetalleVentas.Count
            If idDetalleVenta = listaDetalleVentas(i).idDetalleVenta Then
                Return i
            End If
        Next

        Return -1
    End Function
End Class