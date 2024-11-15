Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormProductos
    Dim conexion As MySqlConnection

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "select " &
            "Prod.id_producto as 'ID de producto', " &
            "Prod.nombre as 'Producto', " &
            "Prod.descripcion as 'Descripcion', " &
            "Prod.precio_compra as 'Precio de compra', " &
            "Prod.porcentaje_ganancia as 'Porcentaje de ganancia', " &
            "Prod.precio_venta as 'Precio de venta', " &
            "Prod.stock as 'Stock', " &
            "Prod.stock_minimo as 'Stock minimo', " &
            "Prov.nombre as 'Proveedor' " &
            "from Productos as Prod " &
            "inner join Proveedores as Prov on " &
            "Prod.id_proveedor = Prov.id_proveedor;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)

        InicializarProveedores()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Si se selecciono una fila valida, popular las cajas de texto con los datos de la tabla seleccionada
        If e.RowIndex >= 0 Then
            Dim producto As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Orden SQL para conseguir el producto que se ha seleccionado
            Dim SQL As String = "select " &
                "Prod.id_producto as 'ID de producto', " &
                "Prod.nombre as 'Producto', " &
                "Prod.descripcion as 'Descripcion', " &
                "Prod.precio_compra as 'Precio de compra', " &
                "Prod.porcentaje_ganancia as 'Porcentaje de ganancia', " &
                "Prod.precio_venta as 'Precio de venta', " &
                "Prod.stock as 'Stock', " &
                "Prod.stock_minimo as 'Stock minimo', " &
                "Prov.nombre as 'Proveedor' " &
                "from Productos as Prod " &
                "inner join Proveedores as Prov on " &
                "Prod.id_proveedor = Prov.id_proveedor " &
                "where Prod.id_producto = '" & producto & "';"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idProducto.Text = lectura("ID de producto").ToString()
                    Me.ct_nombre.Text = lectura("Producto").ToString()
                    Me.ct_descripcion.Text = lectura("Descripcion").ToString()
                    Me.ct_precioCompra.Text = lectura("Precio de compra").ToString()
                    Me.ct_porcentajeGanancia.Text = lectura("Porcentaje de ganancia").ToString()
                    Me.ct_precioVenta.Text = lectura("Precio de venta").ToString()
                    Me.ct_stock.Text = lectura("Stock").ToString()
                    Me.ct_stockMinimo.Text = lectura("Stock minimo").ToString()
                    Me.comboBoxProveedor.Text = lectura("Proveedor").ToString()
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
        Me.ct_idProducto.Text = ""
        Me.ct_nombre.Text = ""
        Me.ct_descripcion.Text = ""
        Me.ct_precioCompra.Text = ""
        Me.ct_porcentajeGanancia.Text = ""
        Me.ct_precioVenta.Text = ""
        Me.ct_stock.Text = ""
        Me.ct_stockMinimo.Text = ""
        Me.comboBoxProveedor.Text = ""

        Me.ct_nombre.Focus()
    End Sub

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        ' Revisar que todos los campos contengan algo antes de continuar
        If ct_nombre.Text = "" Then
            MessageBox.Show("Digite el nombre del producto")
            ct_nombre.Focus()
            Exit Sub
        End If

        If ct_descripcion.Text = "" Then
            MessageBox.Show("Digite la descripción")
            ct_descripcion.Focus()
            Exit Sub
        End If

        If ct_precioCompra.Text = "" Then
            MessageBox.Show("Digite el precio de compra")
            ct_precioCompra.Focus()
            Exit Sub
        End If

        If ct_porcentajeGanancia.Text = "" Then
            MessageBox.Show("Digite el porcentaje de ganancia")
            ct_porcentajeGanancia.Focus()
            Exit Sub
        End If

        If ct_precioVenta.Text = "" Then
            MessageBox.Show("Digite el precio de venta")
            ct_precioVenta.Focus()
            Exit Sub
        End If

        If ct_stock.Text = "" Then
            MessageBox.Show("Digite la cantidad de stock")
            ct_stock.Focus()
            Exit Sub
        End If

        If ct_stockMinimo.Text = "" Then
            MessageBox.Show("Digite la cantidad de stock minimo")
            ct_stockMinimo.Focus()
            Exit Sub
        End If

        If comboBoxProveedor.Text = "" Then
            MessageBox.Show("Seleccione el proveedor")
            comboBoxProveedor.Focus()
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

        ' Orden SQL para conseguir los productos que coincidan con el ID de producto en la caja de texto (si lo hubiera)
        SQL = "select id_producto " &
            "from Productos " &
            "WHERE id_producto = '" & ct_idProducto.Text & "'"

        cmd.CommandText = SQL

        lectura = cmd.ExecuteReader()
        Dim tipoModificacion As String

        ' Si la orden SQL retorno algo, se actualiza el registro (UPDATE); 
        ' De lo contrario, se inserta el nuevo registro (INSERT)
        If lectura.HasRows Then
            tipoModificacion = "Actualizado"
            SQL = "UPDATE Productos " &
                "set nombre='" & ct_nombre.Text & "'," &
                "descripcion='" & ct_descripcion.Text & "'," &
                "precio_compra='" & ct_precioCompra.Text & "'," &
                "porcentaje_ganancia='" & ct_porcentajeGanancia.Text & "'," &
                "precio_venta='" & ct_precioVenta.Text & "'," &
                "stock='" & ct_stock.Text & "'," &
                "stock_minimo='" & ct_stockMinimo.Text & "'," &
                "id_proveedor='" & IDProveedor & "'" &
                "where id_producto='" & ct_idProducto.Text & "'"
        Else
            tipoModificacion = "Guardado"
            SQL = "INSERT INTO Productos values" &
                "(null," &
                "'" & ct_nombre.Text & "'," &
                "'" & ct_descripcion.Text & "'," &
                "'" & ct_precioCompra.Text & "'," &
                "'" & ct_porcentajeGanancia.Text & "'," &
                "'" & ct_precioVenta.Text & "'," &
                "'" & ct_stock.Text & "'," &
                "'" & ct_stockMinimo.Text & "'," &
                "'" & IDProveedor & "')"
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
        SQL = "select " &
            "Prod.id_producto as 'ID de producto', " &
            "Prod.nombre as 'Producto', " &
            "Prod.descripcion as 'Descripcion', " &
            "Prod.precio_compra as 'Precio de compra', " &
            "Prod.porcentaje_ganancia as 'Porcentaje de ganancia', " &
            "Prod.precio_venta as 'Precio de venta', " &
            "Prod.stock as 'Stock', " &
            "Prod.stock_minimo as 'Stock minimo', " &
            "Prov.nombre as 'Proveedor' " &
            "from Productos as Prod " &
            "inner join Proveedores as Prov on " &
            "Prod.id_proveedor = Prov.id_proveedor;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        ' Comprobar que se ha seleccionado un registro de la tabla
        If ct_idProducto.Text = "" Then
            MessageBox.Show("Seleccione un producto")
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

        ' Orden SQL para borrar el producto que se ha seleccionado
        Dim SQL As String = "delete from Productos " &
            "WHERE id_producto = '" & ct_idProducto.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text
        cmd.ExecuteNonQuery()

        MessageBox.Show("Registro borrado")

        LimpiarTexto()

        ' Cargar de nuevo la tabla con lo datos actualizados
        SQL = "select " &
            "Prod.id_producto as 'ID de producto', " &
            "Prod.nombre as 'Producto', " &
            "Prod.descripcion as 'Descripcion', " &
            "Prod.precio_compra as 'Precio de compra', " &
            "Prod.porcentaje_ganancia as 'Porcentaje de ganancia', " &
            "Prod.precio_venta as 'Precio de venta', " &
            "Prod.stock as 'Stock', " &
            "Prod.stock_minimo as 'Stock minimo', " &
            "Prov.nombre as 'Proveedor' " &
            "from Productos as Prod " &
            "inner join Proveedores as Prov on " &
            "Prod.id_proveedor = Prov.id_proveedor;"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub ct_precioCompra_TextChanged(sender As Object, e As EventArgs) Handles ct_precioCompra.TextChanged
        If ct_precioVenta.Text = "" Then
            ct_porcentajeGanancia.Text = "0"
        Else
            ActualizarPorcentajeDeGanancia()
        End If
    End Sub

    Private Sub ct_precioVenta_TextChanged(sender As Object, e As EventArgs) Handles ct_precioVenta.TextChanged
        If ct_precioCompra.Text = "" Then
            ct_porcentajeGanancia.Text = "0"
        Else
            ActualizarPorcentajeDeGanancia()
        End If
    End Sub

    Private Sub ActualizarPorcentajeDeGanancia()
        Dim precioCompra As Single
        Single.TryParse(ct_precioCompra.Text, precioCompra)

        Dim precioVenta As Single
        Single.TryParse(ct_precioVenta.Text, precioVenta)

        Dim porcentajeGanancia As Single = ((precioVenta * 100) / (precioCompra)) - 100

        ct_porcentajeGanancia.Text = porcentajeGanancia.ToString()
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