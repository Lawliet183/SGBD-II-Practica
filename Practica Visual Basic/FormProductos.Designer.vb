Imports System
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProductos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        ct_idProducto = New TextBox()
        ct_precioVenta = New TextBox()
        ct_descripcion = New TextBox()
        ct_nombre = New TextBox()
        ct_stock = New TextBox()
        ct_precioCompra = New TextBox()
        ct_stockMinimo = New TextBox()
        ct_porcentajeGanancia = New TextBox()
        btNuevo = New Button()
        btGuardar = New Button()
        btBorrar = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        btSalir = New Button()
        comboBoxProveedor = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Dock = DockStyle.Top
        DataGridView1.Location = New Point(0, 0)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(800, 205)
        DataGridView1.TabIndex = 0
        ' 
        ' ct_idProducto
        ' 
        ct_idProducto.Location = New Point(313, 236)
        ct_idProducto.Name = "ct_idProducto"
        ct_idProducto.Size = New Size(194, 27)
        ct_idProducto.TabIndex = 1
        ct_idProducto.Visible = False
        ' 
        ' ct_precioVenta
        ' 
        ct_precioVenta.Location = New Point(313, 401)
        ct_precioVenta.Name = "ct_precioVenta"
        ct_precioVenta.Size = New Size(194, 27)
        ct_precioVenta.TabIndex = 2
        ' 
        ' ct_descripcion
        ' 
        ct_descripcion.Location = New Point(313, 302)
        ct_descripcion.Name = "ct_descripcion"
        ct_descripcion.Size = New Size(194, 27)
        ct_descripcion.TabIndex = 3
        ' 
        ' ct_nombre
        ' 
        ct_nombre.Location = New Point(313, 269)
        ct_nombre.Name = "ct_nombre"
        ct_nombre.Size = New Size(194, 27)
        ct_nombre.TabIndex = 4
        ' 
        ' ct_stock
        ' 
        ct_stock.Location = New Point(313, 434)
        ct_stock.Name = "ct_stock"
        ct_stock.Size = New Size(194, 27)
        ct_stock.TabIndex = 6
        ' 
        ' ct_precioCompra
        ' 
        ct_precioCompra.Location = New Point(313, 335)
        ct_precioCompra.Name = "ct_precioCompra"
        ct_precioCompra.Size = New Size(194, 27)
        ct_precioCompra.TabIndex = 7
        ' 
        ' ct_stockMinimo
        ' 
        ct_stockMinimo.Location = New Point(313, 467)
        ct_stockMinimo.Name = "ct_stockMinimo"
        ct_stockMinimo.Size = New Size(194, 27)
        ct_stockMinimo.TabIndex = 8
        ' 
        ' ct_porcentajeGanancia
        ' 
        ct_porcentajeGanancia.Location = New Point(313, 368)
        ct_porcentajeGanancia.Name = "ct_porcentajeGanancia"
        ct_porcentajeGanancia.ReadOnly = True
        ct_porcentajeGanancia.Size = New Size(194, 27)
        ct_porcentajeGanancia.TabIndex = 9
        ' 
        ' btNuevo
        ' 
        btNuevo.Location = New Point(586, 257)
        btNuevo.Name = "btNuevo"
        btNuevo.Size = New Size(94, 29)
        btNuevo.TabIndex = 10
        btNuevo.Text = "Nuevo"
        btNuevo.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(586, 292)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(94, 29)
        btGuardar.TabIndex = 11
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(586, 327)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(94, 29)
        btBorrar.TabIndex = 12
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(240, 272)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 14
        Label2.Text = "Nombre:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(217, 305)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 15
        Label3.Text = "Descripcion:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(178, 338)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 20)
        Label4.TabIndex = 16
        Label4.Text = "Precio de compra:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(141, 371)
        Label5.Name = "Label5"
        Label5.Size = New Size(166, 20)
        Label5.TabIndex = 17
        Label5.Text = "Porcentaje de ganancia:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(193, 404)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 20)
        Label6.TabIndex = 18
        Label6.Text = "Precio de venta:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(259, 437)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 20)
        Label7.TabIndex = 19
        Label7.Text = "Stock:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(204, 470)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 20)
        Label8.TabIndex = 20
        Label8.Text = "Stock minimo:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(227, 503)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 20)
        Label9.TabIndex = 21
        Label9.Text = "Proveedor:"
        ' 
        ' btSalir
        ' 
        btSalir.Location = New Point(586, 362)
        btSalir.Name = "btSalir"
        btSalir.Size = New Size(94, 29)
        btSalir.TabIndex = 22
        btSalir.Text = "Salir"
        btSalir.UseVisualStyleBackColor = True
        ' 
        ' comboBoxProveedor
        ' 
        comboBoxProveedor.FormattingEnabled = True
        comboBoxProveedor.Location = New Point(313, 500)
        comboBoxProveedor.Name = "comboBoxProveedor"
        comboBoxProveedor.Size = New Size(194, 28)
        comboBoxProveedor.TabIndex = 23
        ' 
        ' FormProductos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 558)
        Controls.Add(comboBoxProveedor)
        Controls.Add(btSalir)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btBorrar)
        Controls.Add(btGuardar)
        Controls.Add(btNuevo)
        Controls.Add(ct_porcentajeGanancia)
        Controls.Add(ct_stockMinimo)
        Controls.Add(ct_precioCompra)
        Controls.Add(ct_stock)
        Controls.Add(ct_nombre)
        Controls.Add(ct_descripcion)
        Controls.Add(ct_precioVenta)
        Controls.Add(ct_idProducto)
        Controls.Add(DataGridView1)
        Name = "FormProductos"
        Text = "Productos"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_idProducto As TextBox
    Friend WithEvents ct_precioVenta As TextBox
    Friend WithEvents ct_descripcion As TextBox
    Friend WithEvents ct_nombre As TextBox
    Friend WithEvents ct_stock As TextBox
    Friend WithEvents ct_precioCompra As TextBox
    Friend WithEvents ct_stockMinimo As TextBox
    Friend WithEvents ct_porcentajeGanancia As TextBox
    Friend WithEvents btNuevo As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btSalir As Button
    Friend WithEvents comboBoxProveedor As ComboBox
End Class
