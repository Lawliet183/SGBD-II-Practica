Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormCompras
    Dim conexion As MySqlConnection
    Dim listaDetalleCompras As New List(Of DetalleCompra)

    Private Sub FormCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT * from Compras " &
            "natural join Detalle_compras;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Si se selecciono una fila valida, popular las cajas de texto con los datos de la tabla seleccionada
        If e.RowIndex >= 0 Then
            Dim compra As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Orden SQL para conseguir la compra que se ha seleccionado
            Dim SQL As String = "SELECT * FROM Compras " &
                "natural join Detalle_compras " &
                "WHERE id_compra = '" & compra & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idCompra.Text = lectura("id_compra").ToString()
                    Me.ct_idDetalleCompra.Text = lectura("id_detalle_compra").ToString()
                    Me.ct_idProveedor.Text = lectura("id_proveedor").ToString()
                    Me.ct_idProducto.Text = lectura("id_producto").ToString()
                    Me.ct_cantidad.Text = lectura("cantidad").ToString()
                    Me.ct_precio.Text = lectura("precio_compra").ToString()
                    Me.ct_total.Text = lectura("total").ToString()
                    Me.dtp_fecha.Text = lectura("fecha_compra").ToString()
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
        Me.ct_idProveedor.Text = ""
        Me.ct_idProducto.Text = ""
        Me.ct_cantidad.Text = ""
        Me.ct_precio.Text = ""
        Me.ct_total.Text = ""
        Me.dtp_fecha.Text = ""

        Me.ct_idProducto.Focus()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        ' Revisar que todos los campos contengan algo antes de continuar
        If ct_idProveedor.Text = "" Then
            MessageBox.Show("Digite el ID del proveedor")
            ct_idProveedor.Focus()
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


        ' Orden SQL para conseguir las compras que coincidan con el ID de compra en la caja de texto (si lo hubiera)
        Dim SQL As String = "select id_compra " &
            "from Compras " &
            "WHERE id_compra = '" & ct_idCompra.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
        Dim tipoModificacion As String

        ' Si se encuentra alguna coincidencia de compras, actualizar el registro; de otra forma, insertarlo
        If lectura.HasRows Then
            tipoModificacion = "Actualizado"

            SQL = "UPDATE Compras " &
                "set id_proveedor = '" & ct_idProveedor.Text & "', " &
                "fecha_compra = '" & dtp_fecha.Text & "', " &
                "total = '" & ct_total.Text & "' " &
                "where id_compra = '" & ct_idCompra.Text & "'"
        Else
            tipoModificacion = "Guardado"

            SQL = "INSERT INTO Compras values" &
                "(null," &
                "'" & ct_idProveedor.Text & "', " &
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

        ' Actualizar la caja de texto con la respectiva ID
        SQL = "select * from Ventas " &
            "where id_proveedor = '" & ct_idProveedor.Text & "' " &
            "and fecha_compra = '" & dtp_fecha.Text & "' " &
            "and total = '" & ct_total.Text & "'"

        cmd.CommandText = SQL
        lectura = cmd.ExecuteReader()

        If lectura.Read() = True Then
            Me.ct_idCompra.Text = lectura("id_compra").ToString()
        End If

        lectura.Close()

        AgregarDetalleCompras()


        ' Actualizar (o insertar) los registros de detalle de compras
        For Each detalleCompra As DetalleCompra In listaDetalleCompras
            ' Orden SQL para iterar por cada detalle de compra
            SQL = "select id_detalle_compra " &
                "from Detalle_compras " &
                "where id_detalle_compra = '" & detalleCompra.idDetalleCompra & "'"

            cmd.CommandText = SQL
            lectura = cmd.ExecuteReader()

            If lectura.HasRows Then
                SQL = "UPDATE Detalle_compras " &
                    "set id_producto = '" & ct_idProducto.Text & "', " &
                    "cantidad = '" & ct_cantidad.Text & "', " &
                    "precio_compra = '" & ct_precio.Text & "' " &
                    "where id_detalle_compra = '" & ct_idDetalleCompra.Text & "'"
            Else
                SQL = "INSERT INTO Detalle_compras values " &
                    "(null, " &
                    "'" & detalleCompra.idCompra & "', " &
                    "'" & detalleCompra.idProducto & "', " &
                    "'" & detalleCompra.cantidad & "', " &
                    "'" & detalleCompra.precioCompra & "')"
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
        listaDetalleCompras = New List(Of DetalleCompra)

        ' Cargar nuevamente la tabla con los datos actualizados
        SQL = "SELECT * from Compras natural join Detalle_compras order by id_compra, id_detalle_compra"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub


    Private Function AgregarDetalleCompras() As Boolean
        Dim idDetalleCompra As Integer
        Integer.TryParse(ct_idDetalleCompra.Text, idDetalleCompra)

        Dim idCompra As Integer
        If Not Integer.TryParse(ct_idCompra.Text, idCompra) Then
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

        Dim precioCompra As Decimal
        If Not Decimal.TryParse(ct_precio.Text, precioCompra) Then
            MessageBox.Show("El precio debe ser un numero")
            Return False
        End If

        Dim detalleCompra As New DetalleCompra(idDetalleCompra, idCompra, idProducto, cantidad, precioCompra)
        listaDetalleCompras.Add(detalleCompra)

        Return True
    End Function

    Private Sub LimpiarTextoDetalleCompras()
        Me.ct_idDetalleCompra.Text = ""
        Me.ct_idProducto.Text = ""
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
        SQL = "SELECT * from Compras natural join Detalle_compras order by id_compra, id_detalle_compra"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class