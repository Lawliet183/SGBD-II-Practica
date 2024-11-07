Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormProductos
    Dim conexion As MySqlConnection

    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT * from Productos order by id_producto asc"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Si se selecciono una fila valida, popular las cajas de texto con los datos de la tabla seleccionada
        If e.RowIndex >= 0 Then
            Dim producto As String = Convert.ToString(DataGridView1.Rows(e.RowIndex).Cells(0).Value)

            ' Orden SQL para conseguir el producto que se ha seleccionado
            Dim SQL As String = "SELECT * FROM Productos " &
                "WHERE id_producto = '" & producto & "'"

            Dim cmd As New MySqlCommand(SQL, conexion)
            cmd.CommandType = CommandType.Text

            Try
                Dim lectura As MySqlDataReader = cmd.ExecuteReader()
                If lectura.Read = True Then
                    Me.ct_idProducto.Text = lectura("id_producto").ToString()
                    Me.ct_nombre.Text = lectura("nombre").ToString()
                    Me.ct_descripcion.Text = lectura("descripcion").ToString()
                    Me.ct_precioCompra.Text = lectura("precio_compra").ToString()
                    Me.ct_porcentajeGanancia.Text = lectura("porcentaje_ganancia").ToString()
                    Me.ct_precioVenta.Text = lectura("precio_venta").ToString()
                    Me.ct_stock.Text = lectura("stock").ToString()
                    Me.ct_stockMinimo.Text = lectura("stock_minimo").ToString()
                    Me.ct_idProveedor.Text = lectura("id_proveedor").ToString()
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
        Me.ct_idProveedor.Text = ""

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

        If ct_idProveedor.Text = "" Then
            MessageBox.Show("Digite el ID de proveedor")
            ct_idProveedor.Focus()
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


        ' Orden SQL para conseguir los productos que coincidan con el ID de producto en la caja de texto (si lo hubiera)
        Dim SQL As String = "select id_producto " &
            "from Productos " &
            "WHERE id_producto = '" & ct_idProducto.Text & "'"

        Dim cmd As New MySqlCommand(SQL, conexion)
        cmd.CommandType = CommandType.Text

        Dim lectura As MySqlDataReader = cmd.ExecuteReader()
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
                "id_proveedor='" & ct_idProveedor.Text & "'" &
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
                "'" & ct_idProveedor.Text & "')"
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
        SQL = "SELECT * from Productos order by id_producto"
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
        SQL = "SELECT * from Productos order by id_producto"
        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub
End Class