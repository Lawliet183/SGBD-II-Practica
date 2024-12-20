﻿Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormVentas
    Dim conexion As MySqlConnection
    Dim listaDetalleVentas As New List(Of DetalleVenta)

    Private Sub FormVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "select " &
            "id_venta as 'ID de venta', " &
            "C.nombre as 'Cliente', " &
            "fecha_venta as 'Fecha de venta', " &
            "id_detalle as 'ID de detalle de venta', " &
            "P.nombre as 'Producto', " &
            "cantidad as 'Cantidad', " &
            "precio_unitario as 'Precio unitario', " &
            "total as 'Total' " &
            "from Ventas as V " &
            "natural join Detalle_ventas as D " &
            "natural join Clientes as C " &
            "inner join Productos as P on " &
            "D.id_producto = P.id_producto " &
            "order by id_venta, id_detalle;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)

        InicializarClientes()
        InicializarProductos()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Si se selecciono una fila valida, popular las cajas de texto con los datos de la tabla seleccionada
        If e.RowIndex >= 0 Then
            Dim venta As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Orden SQL para conseguir la venta que se ha seleccionado
            Dim SQL As String = "select " &
                "id_venta as 'ID de venta', " &
                "C.nombre as 'Cliente', " &
                "fecha_venta as 'Fecha de venta', " &
                "id_detalle as 'ID de detalle de venta', " &
                "P.nombre as 'Producto', " &
                "cantidad as 'Cantidad', " &
                "precio_unitario as 'Precio unitario', " &
                "total as 'Total' " &
                "from Ventas as V " &
                "natural join Detalle_ventas as D " &
                "natural join Clientes as C " &
                "inner join Productos as P on " &
                "D.id_producto = P.id_producto " &
                "where id_venta = '" & venta & "' " &
                "order by id_venta, id_detalle;"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idVenta.Text = lectura("ID de venta").ToString()
                    Me.ct_idDetalleVenta.Text = lectura("ID de detalle").ToString()
                    Me.comboBoxCliente.Text = lectura("Cliente").ToString()
                    Me.comboBoxProducto.Text = lectura("Producto").ToString()
                    Me.ct_cantidad.Text = lectura("Cantidad").ToString()
                    Me.ct_precio.Text = lectura("Precio unitario").ToString()
                    Me.ct_total.Text = lectura("Total").ToString()
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
        If comboBoxCliente.Text = "" Then
            MessageBox.Show("Digite el ID del cliente")
            comboBoxCliente.Focus()
            Exit Sub
        End If

        If comboBoxProducto.Text = "" Then
            MessageBox.Show("Digite el ID del producto")
            comboBoxProducto.Focus()
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


        ' Conseguir el ID del cliente para guardar/actualizar despues
        Dim SQL As String = "select id_cliente " &
            "from clientes " &
            "where nombre = '" & comboBoxCliente.Text & "';"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim IDCliente As String = ""
        If lectura.Read() Then
            IDCliente = lectura.GetInt32(0).ToString()
        End If

        lectura.Close()

        ' Orden SQL para conseguir las ventas que coincidan con el ID de venta en la caja de texto (si lo hubiera)
        SQL = "select id_venta " &
            "from Ventas " &
            "WHERE id_venta = '" & ct_idVenta.Text & "'"

        cmd.CommandText = SQL

        lectura = cmd.ExecuteReader()
        Dim tipoModificacion As String

        ' Si se encuentra alguna coincidencia de ventas, actualizar el registro; de otra forma, insertarlo
        If lectura.HasRows Then
            tipoModificacion = "Actualizado"

            SQL = "UPDATE Ventas " &
                "set id_cliente = '" & IDCliente & "', " &
                "fecha_venta = '" & dtp_fecha.Text & "', " &
                "total = '" & ct_total.Text & "' " &
                "where id_venta = '" & ct_idVenta.Text & "'"
        Else
            tipoModificacion = "Guardado"

            SQL = "INSERT INTO Ventas values" &
                "(null," &
                "'" & dtp_fecha.Text & "', " &
                "'" & IDCliente & "', " &
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


        ' Si se inserto una nueva venta, actualizar la caja de texto con la respectiva ID
        If tipoModificacion = "Guardado" Then
            ' Seleccionar el ultimo ID insertado (generado por un AUTO INCREMENT)
            SQL = "select last_insert_id()"

            cmd.CommandText = SQL
            lectura = cmd.ExecuteReader()

            lectura.Read()
            Me.ct_idVenta.Text = lectura("last_insert_id()").ToString()

            lectura.Close()
        End If

        AgregarDetalleVentas()


        ' Actualizar (o insertar) los registros de detalle de ventas
        For Each detalleVenta As DetalleVenta In listaDetalleVentas
            ' Orden SQL para iterar por cada detalle de venta
            SQL = "select id_detalle " &
                "from Detalle_ventas " &
                "where id_detalle = '" & detalleVenta.idDetalleVenta & "'"

            cmd.CommandText = SQL
            lectura = cmd.ExecuteReader()

            ' Si el detalle de venta no tiene ID de venta, usar el ultimo generado por AUTO INCREMENT;
            ' De otra forma, usar el ID que ya tiene
            Dim idVenta As Integer
            If detalleVenta.idVenta = 0 Then
                Integer.TryParse(ct_idVenta.Text, idVenta)
            Else
                idVenta = detalleVenta.idVenta
            End If

            ' Si el detalle de venta ya existe, actualizarlo; De otra forma, insertarlo
            If lectura.HasRows Then
                lectura.Close()

                SQL = "select id_producto " &
                    "from productos " &
                    "where nombre = '" & comboBoxProducto.Text & "';"

                cmd.CommandText = SQL

                lectura = cmd.ExecuteReader()
                Dim IDProducto As String = ""
                If lectura.Read() Then
                    IDProducto = lectura.GetInt32(0).ToString()
                End If

                SQL = "UPDATE Detalle_ventas " &
                    "set id_producto = '" & IDProducto & "', " &
                    "cantidad = '" & ct_cantidad.Text & "', " &
                    "precio_unitario = '" & ct_precio.Text & "' " &
                    "where id_detalle = '" & ct_idDetalleVenta.Text & "'"
            Else
                lectura.Close()

                SQL = "select id_producto " &
                    "from productos " &
                    "where nombre = '" & detalleVenta.Producto & "';"

                cmd.CommandText = SQL

                lectura = cmd.ExecuteReader()
                Dim IDProducto As String = ""
                If lectura.Read() Then
                    IDProducto = lectura.GetInt32(0).ToString()
                End If

                SQL = "INSERT INTO Detalle_ventas values " &
                    "(null, " &
                    "'" & idVenta & "', " &
                    "'" & IDProducto & "', " &
                    "'" & detalleVenta.cantidad & "', " &
                    "'" & detalleVenta.precioUnitario & "')"
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
        Next

        MessageBox.Show("Registro " & tipoModificacion)

        LimpiarTextoCompleto()
        listaDetalleVentas = New List(Of DetalleVenta)

        ' Cargar nuevamente la tabla con los datos actualizados
        SQL = "select " &
            "id_venta as 'ID de venta', " &
            "C.nombre as 'Cliente', " &
            "fecha_venta as 'Fecha de venta', " &
            "id_detalle as 'ID de detalle de venta', " &
            "P.nombre as 'Producto', " &
            "cantidad as 'Cantidad', " &
            "precio_unitario as 'Precio unitario', " &
            "total as 'Total' " &
            "from Ventas as V " &
            "natural join Detalle_ventas as D " &
            "natural join Clientes as C " &
            "inner join Productos as P on " &
            "D.id_producto = P.id_producto " &
            "order by id_venta, id_detalle;"

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
        SQL = "select " &
            "id_venta as 'ID de venta', " &
            "C.nombre as 'Cliente', " &
            "fecha_venta as 'Fecha de venta', " &
            "id_detalle as 'ID de detalle de venta', " &
            "P.nombre as 'Producto', " &
            "cantidad as 'Cantidad', " &
            "precio_unitario as 'Precio unitario', " &
            "total as 'Total' " &
            "from Ventas as V " &
            "natural join Detalle_ventas as D " &
            "natural join Clientes as C " &
            "inner join Productos as P on " &
            "D.id_producto = P.id_producto " &
            "order by id_venta, id_detalle;"

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
            LimpiarTextoDetalleVentas()
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
        Me.comboBoxCliente.Text = ""
        Me.comboBoxProducto.Text = ""
        Me.ct_cantidad.Text = ""
        Me.ct_precio.Text = ""
        Me.ct_total.Text = ""
        Me.dtp_fecha.Text = ""

        Me.comboBoxProducto.Focus()
    End Sub

    Private Function AgregarDetalleVentas() As Boolean
        Dim idDetalleVenta As Integer
        Integer.TryParse(ct_idDetalleVenta.Text, idDetalleVenta)

        Dim idVenta As Integer
        Integer.TryParse(ct_idVenta.Text, idVenta)

        Dim Producto As String = comboBoxProducto.Text

        Dim cantidad As Integer
        If Not Integer.TryParse(ct_cantidad.Text, cantidad) Then
            MessageBox.Show("La cantidad debe ser un numero entero")
            Return False
        End If

        Dim subtotal As Decimal
        If Not Decimal.TryParse(ct_precio.Text, subtotal) Then
            MessageBox.Show("El precio debe ser un numero")
            Return False
        End If

        Dim precioUnitario = subtotal / cantidad

        Dim detalleVenta As New DetalleVenta(idDetalleVenta, idVenta, Producto, cantidad, precioUnitario)
        listaDetalleVentas.Add(detalleVenta)

        Return True
    End Function

    Private Sub LimpiarTextoDetalleVentas()
        Me.ct_idDetalleVenta.Text = ""
        Me.comboBoxProducto.Text = ""
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

    Private Sub InicializarProductos()
        Dim orden As String = "select nombre from productos"
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
            comboBoxProducto.Items.Add(dataReader.GetString(campo))
        End While

        dataReader.Close()
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

    Private Sub comboBoxProducto_TextChanged(sender As Object, e As EventArgs) Handles comboBoxProducto.TextChanged
        If comboBoxProducto.Text = "" Then
            ct_precio.Text = "0"
        Else
            ActualizarPrecio()
        End If
    End Sub

    Private Sub ActualizarPrecio()
        Dim SQL As String = "select precio_venta " &
            "from productos " &
            "where nombre = '" & comboBoxProducto.Text & "';"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim precioVenta As Single = 0
        If lectura.Read() Then
            precioVenta = lectura.GetFloat(0)
        End If

        lectura.Close()

        Dim cantidad As Integer
        Integer.TryParse(ct_cantidad.Text, cantidad)

        Dim subtotal = precioVenta * cantidad

        ct_precio.Text = subtotal.ToString()
    End Sub

    Private Sub ct_cantidad_TextChanged(sender As Object, e As EventArgs) Handles ct_cantidad.TextChanged
        If ct_cantidad.Text = "" Then
            ct_precio.Text = "0"
        Else
            ActualizarPrecio()
        End If
    End Sub

    Private Sub ct_precio_TextChanged(sender As Object, e As EventArgs) Handles ct_precio.TextChanged
        ActualizarTotal()
    End Sub

    Private Sub ActualizarTotal()
        Dim total As Single
        Single.TryParse(ct_precio.Text, total)

        Dim subtotal As Single
        For Each detalleVenta As DetalleVenta In listaDetalleVentas
            subtotal = detalleVenta.precioUnitario * detalleVenta.cantidad
            total += subtotal
        Next

        ct_total.Text = total.ToString()
    End Sub
End Class