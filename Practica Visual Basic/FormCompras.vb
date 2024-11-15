Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormCompras
    Dim conexion As MySqlConnection
    Dim listaDetalleCompras As New List(Of DetalleCompra)

    Private Sub FormCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "select " &
            "id_compra as 'ID de compra', " &
            "Prov.nombre as 'Proveedor', " &
            "fecha_compra as 'Fecha de compra', " &
            "id_detalle_compra as 'ID de detalle de compra', " &
            "Prod.nombre as 'Producto', " &
            "cantidad as 'Cantidad', " &
            "D.precio_compra as 'Precio de compra', " &
            "total as 'Total' " &
            "from Compras as C " &
            "natural join Detalle_compras as D " &
            "natural join Proveedores as Prov " &
            "inner join Productos as Prod on " &
            "D.id_producto = Prod.id_producto " &
            "order by id_compra, id_detalle_compra;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)

        InicializarProveedores()
        InicializarProductos()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Si se selecciono una fila valida, popular las cajas de texto con los datos de la tabla seleccionada
        If e.RowIndex >= 0 Then
            Dim compra As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Orden SQL para conseguir la compra que se ha seleccionado
            Dim SQL As String = "select " &
                "id_compra as 'ID de compra', " &
                "Prov.nombre as 'Proveedor', " &
                "fecha_compra as 'Fecha de compra', " &
                "id_detalle_compra as 'ID de detalle de compra', " &
                "Prod.nombre as 'Producto', " &
                "cantidad as 'Cantidad', " &
                "D.precio_compra as 'Precio de compra', " &
                "total as 'Total' " &
                "from Compras as C " &
                "natural join Detalle_compras as D " &
                "natural join Proveedores as Prov " &
                "inner join Productos as Prod on " &
                "D.id_producto = Prod.id_producto " &
                "where C.id_compra = '" & compra & "' " &
                "order by id_compra, id_detalle_compra;"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idCompra.Text = lectura("ID de compra").ToString()
                    Me.ct_idDetalleCompra.Text = lectura("ID de detalle de compra").ToString()
                    Me.comboBoxProveedor.Text = lectura("Proveedor").ToString()
                    Me.comboBoxProducto.Text = lectura("Producto").ToString()
                    Me.ct_cantidad.Text = lectura("Cantidad").ToString()
                    Me.ct_precio.Text = lectura("Precio de compra").ToString()
                    Me.ct_total.Text = lectura("Total").ToString()
                    Me.dtp_fecha.Text = lectura("Fecha de compra").ToString()
                End If

                lectura.Close()
            Catch ex As Exception
                MessageBox.Show("Error al leer los datos: " & ex.Message)
            End Try

            listaDetalleCompras = New List(Of DetalleCompra)
            AgregarDetalleCompras()
        End If
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        LimpiarTextoCompleto()
        listaDetalleCompras = New List(Of DetalleCompra)
    End Sub

    Private Sub LimpiarTextoCompleto()
        Me.ct_idCompra.Text = ""
        Me.ct_idDetalleCompra.Text = ""
        Me.comboBoxProveedor.Text = ""
        Me.comboBoxProducto.Text = ""
        Me.ct_cantidad.Text = ""
        Me.ct_precio.Text = ""
        Me.ct_total.Text = ""
        Me.dtp_fecha.Text = ""

        Me.comboBoxProducto.Focus()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        ' Revisar que todos los campos contengan algo antes de continuar
        If comboBoxProveedor.Text = "" Then
            MessageBox.Show("Digite el ID del proveedor")
            comboBoxProveedor.Focus()
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


        ' Conseguir el ID del proveedor para guardar/actualizar despues
        Dim SQL As String = "select id_proveedor " &
            "from proveedores " &
            "where nombre = '" & comboBoxProveedor.Text & "';"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim IDProveedor As String = ""
        If lectura.Read() Then
            IDProveedor = lectura.GetInt32(0).ToString()
        End If

        lectura.Close()

        ' Orden SQL para conseguir las compras que coincidan con el ID de compra en la caja de texto (si lo hubiera)
        SQL = "select id_compra " &
            "from Compras " &
            "WHERE id_compra = '" & ct_idCompra.Text & "'"

        cmd.CommandText = SQL

        lectura = cmd.ExecuteReader()
        Dim tipoModificacion As String

        ' Si se encuentra alguna coincidencia de compras, actualizar el registro; de otra forma, insertarlo
        If lectura.HasRows Then
            tipoModificacion = "Actualizado"

            SQL = "UPDATE Compras " &
                "set id_proveedor = '" & IDProveedor & "', " &
                "fecha_compra = '" & dtp_fecha.Text & "', " &
                "total = '" & ct_total.Text & "' " &
                "where id_compra = '" & ct_idCompra.Text & "'"
        Else
            tipoModificacion = "Guardado"

            SQL = "INSERT INTO Compras values" &
                "(null," &
                "'" & IDProveedor & "', " &
                "'" & dtp_fecha.Text & "', " &
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


        ' Si se inserto una nueva compra, actualizar la caja de texto con la respectiva ID
        If tipoModificacion = "Guardado" Then
            ' Seleccionar el ultimo ID insertado (generado por un AUTO INCREMENT)
            SQL = "select last_insert_id()"

            cmd.CommandText = SQL
            lectura = cmd.ExecuteReader()

            lectura.Read()
            Me.ct_idCompra.Text = lectura("last_insert_id()").ToString()

            lectura.Close()
        End If

        AgregarDetalleCompras()


        ' Actualizar (o insertar) los registros de detalle de compras
        For Each detalleCompra As DetalleCompra In listaDetalleCompras
            ' Orden SQL para iterar por cada detalle de compra
            SQL = "select id_detalle_compra " &
                "from Detalle_compras " &
                "where id_detalle_compra = '" & detalleCompra.idDetalleCompra & "'"

            cmd.CommandText = SQL
            lectura = cmd.ExecuteReader()

            ' Si el detalle de compra no tiene ID de compra, usar el ultimo generado por AUTO INCREMENT;
            ' De otra forma, usar el ID que ya tiene
            Dim idCompra As Integer
            If detalleCompra.idCompra = 0 Then
                Integer.TryParse(ct_idCompra.Text, idCompra)
            Else
                idCompra = detalleCompra.idCompra
            End If

            ' Si el detalle de compra ya existe, actualizarlo; De otra forma, insertarlo
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

                SQL = "UPDATE Detalle_compras " &
                    "set id_producto = '" & IDProducto & "', " &
                    "cantidad = '" & ct_cantidad.Text & "', " &
                    "precio_compra = '" & ct_precio.Text & "' " &
                    "where id_detalle_compra = '" & ct_idDetalleCompra.Text & "'"
            Else
                lectura.Close()

                SQL = "select id_producto " &
                    "from productos " &
                    "where nombre = '" & detalleCompra.Producto & "';"

                cmd.CommandText = SQL

                lectura = cmd.ExecuteReader()
                Dim IDProducto As String = ""
                If lectura.Read() Then
                    IDProducto = lectura.GetInt32(0).ToString()
                End If

                SQL = "INSERT INTO Detalle_compras values " &
                    "(null, " &
                    "'" & idCompra & "', " &
                    "'" & IDProducto & "', " &
                    "'" & detalleCompra.cantidad & "', " &
                    "'" & detalleCompra.precioCompra & "')"
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
        listaDetalleCompras = New List(Of DetalleCompra)

        ' Cargar nuevamente la tabla con los datos actualizados
        SQL = "select " &
            "id_compra as 'ID de compra', " &
            "Prov.nombre as 'Proveedor', " &
            "fecha_compra as 'Fecha de compra', " &
            "id_detalle_compra as 'ID de detalle de compra', " &
            "Prod.nombre as 'Producto', " &
            "cantidad as 'Cantidad', " &
            "D.precio_compra as 'Precio de compra', " &
            "total as 'Total' " &
            "from Compras as C " &
            "natural join Detalle_compras as D " &
            "natural join Proveedores as Prov " &
            "inner join Productos as Prod on " &
            "D.id_producto = Prod.id_producto " &
            "order by id_compra, id_detalle_compra;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub


    Private Function AgregarDetalleCompras() As Boolean
        Dim idDetalleCompra As Integer
        Integer.TryParse(ct_idDetalleCompra.Text, idDetalleCompra)

        Dim idCompra As Integer
        Integer.TryParse(ct_idCompra.Text, idCompra)

        Dim Producto As String = comboBoxProducto.Text

        Dim cantidad As Integer
        If Not Integer.TryParse(ct_cantidad.Text, cantidad) Then
            MessageBox.Show("La cantidad debe ser un numero entero")
            Return False
        End If

        Dim subtotal As Decimal
        If Not Decimal.TryParse(ct_precio.Text, subTotal) Then
            MessageBox.Show("El precio debe ser un numero")
            Return False
        End If

        Dim precioCompra = subtotal / cantidad

        Dim detalleCompra As New DetalleCompra(idDetalleCompra, idCompra, Producto, cantidad, precioCompra)
        listaDetalleCompras.Add(detalleCompra)

        Return True
    End Function

    Private Sub LimpiarTextoDetalleCompras()
        Me.ct_idDetalleCompra.Text = ""
        Me.comboBoxProducto.Text = ""
        Me.ct_cantidad.Text = ""
        Me.ct_precio.Text = ""
    End Sub

    Private Sub btMas_Click(sender As Object, e As EventArgs) Handles btMas.Click
        AgregarDetalleCompras()
        LimpiarTextoDetalleCompras()
    End Sub

    Private Sub btMenos_Click(sender As Object, e As EventArgs) Handles btMenos.Click
        Dim idDetalleCompra As Integer
        If Not Integer.TryParse(ct_idDetalleCompra.Text, idDetalleCompra) Then
            MessageBox.Show("El ID debe ser un numero entero")
            LimpiarTextoDetalleCompras()
            Exit Sub
        End If

        Dim index As Integer = BuscarDetalleCompra(idDetalleCompra)

        If index < 0 Then
            MessageBox.Show("No se ha encontrado")
        Else
            listaDetalleCompras.RemoveAt(index)
            LimpiarTextoDetalleCompras()
        End If
    End Sub

    Private Function BuscarDetalleCompra(ByVal idDetalleCompra As Integer) As Integer
        For i As Integer = 0 To listaDetalleCompras.Count
            If idDetalleCompra = listaDetalleCompras(i).idDetalleCompra Then
                Return i
            End If
        Next

        Return -1
    End Function

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        ' Comprobar que se ha seleccionado un registro de la tabla
        If ct_idCompra.Text = "" Then
            MessageBox.Show("Seleccione una compra")
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
            "Desea eliminar la compra completa?",
            "Sistema de Inventario",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        Dim SQL As String
        If respuesta = DialogResult.Yes Then
            ' Orden SQL para borrar la compra que se ha seleccionado
            SQL = "delete from Compras " &
                "WHERE id_compra = '" & ct_idCompra.Text & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
        Else
            ' Orden SQL para borrar el detalle de compra que se ha seleccionado
            SQL = "delete from Detalle_compras " &
                "WHERE id_detalle_compra = '" & ct_idDetalleCompra.Text & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
        End If

        MessageBox.Show("Registro borrado")

        LimpiarTextoCompleto()

        ' Cargar de nuevo la tabla con lo datos actualizados
        SQL = "select " &
            "id_compra as 'ID de compra', " &
            "Prov.nombre as 'Proveedor', " &
            "fecha_compra as 'Fecha de compra', " &
            "id_detalle_compra as 'ID de detalle de compra', " &
            "Prod.nombre as 'Producto', " &
            "cantidad as 'Cantidad', " &
            "D.precio_compra as 'Precio de compra', " &
            "total as 'Total' " &
            "from Compras as C " &
            "natural join Detalle_compras as D " &
            "natural join Proveedores as Prov " &
            "inner join Productos as Prod on " &
            "D.id_producto = Prod.id_producto " &
            "order by id_compra, id_detalle_compra;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
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

    Private Sub comboBoxProducto_TextChanged(sender As Object, e As EventArgs) Handles comboBoxProducto.TextChanged
        If comboBoxProducto.Text = "" Then
            ct_precio.Text = "0"
        Else
            ActualizarPrecio()
        End If
    End Sub

    Private Sub ActualizarPrecio()
        Dim SQL As String = "select precio_compra " &
            "from productos " &
            "where nombre = '" & comboBoxProducto.Text & "';"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim precioCompra As Single = 0
        If lectura.Read() Then
            precioCompra = lectura.GetFloat(0)
        End If

        lectura.Close()

        Dim cantidad As Integer
        Integer.TryParse(ct_cantidad.Text, cantidad)

        Dim subTotal = precioCompra * cantidad

        ct_precio.Text = subTotal.ToString()
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
        For Each detalleCompra As DetalleCompra In listaDetalleCompras
            subtotal = detalleCompra.precioCompra * detalleCompra.cantidad
            total += subtotal
        Next

        ct_total.Text = total.ToString()
    End Sub
End Class