Imports System
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCompras
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
        ct_idCompra = New TextBox()
        ct_idProveedor = New TextBox()
        ct_total = New TextBox()
        btNuevo = New Button()
        btGuardar = New Button()
        btBorrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        dtp_fecha = New DateTimePicker()
        ct_idProducto = New TextBox()
        ct_precio = New TextBox()
        ct_cantidad = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ct_idDetalleCompra = New TextBox()
        btMas = New Button()
        btMenos = New Button()
        btSalir = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(875, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' ct_idCompra
        ' 
        ct_idCompra.Location = New Point(253, 206)
        ct_idCompra.Name = "ct_idCompra"
        ct_idCompra.Size = New Size(165, 27)
        ct_idCompra.TabIndex = 1
        ct_idCompra.Visible = False
        ' 
        ' ct_idProveedor
        ' 
        ct_idProveedor.Location = New Point(201, 239)
        ct_idProveedor.Name = "ct_idProveedor"
        ct_idProveedor.Size = New Size(165, 27)
        ct_idProveedor.TabIndex = 2
        ' 
        ' ct_total
        ' 
        ct_total.Location = New Point(133, 349)
        ct_total.Name = "ct_total"
        ct_total.Size = New Size(165, 27)
        ct_total.TabIndex = 4
        ' 
        ' btNuevo
        ' 
        btNuevo.Location = New Point(239, 415)
        btNuevo.Name = "btNuevo"
        btNuevo.Size = New Size(94, 29)
        btNuevo.TabIndex = 5
        btNuevo.Text = "Nuevo"
        btNuevo.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(339, 415)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(94, 29)
        btGuardar.TabIndex = 6
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(439, 415)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(94, 29)
        btBorrar.TabIndex = 7
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 242)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 20)
        Label1.TabIndex = 8
        Label1.Text = "ID de proveedor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(439, 242)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 20)
        Label2.TabIndex = 9
        Label2.Text = "Fecha de compra:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(82, 352)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 10
        Label3.Text = "Total:"
        ' 
        ' dtp_fecha
        ' 
        dtp_fecha.CustomFormat = "yyyy-MM-dd"
        dtp_fecha.Format = DateTimePickerFormat.Custom
        dtp_fecha.Location = New Point(571, 239)
        dtp_fecha.Name = "dtp_fecha"
        dtp_fecha.Size = New Size(250, 27)
        dtp_fecha.TabIndex = 11
        ' 
        ' ct_idProducto
        ' 
        ct_idProducto.Location = New Point(201, 293)
        ct_idProducto.Name = "ct_idProducto"
        ct_idProducto.Size = New Size(125, 27)
        ct_idProducto.TabIndex = 12
        ' 
        ' ct_precio
        ' 
        ct_precio.Location = New Point(623, 293)
        ct_precio.Name = "ct_precio"
        ct_precio.Size = New Size(125, 27)
        ct_precio.TabIndex = 13
        ' 
        ' ct_cantidad
        ' 
        ct_cantidad.Location = New Point(421, 293)
        ct_cantidad.Name = "ct_cantidad"
        ct_cantidad.Size = New Size(125, 27)
        ct_cantidad.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(82, 296)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 15
        Label4.Text = "ID de producto:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(564, 296)
        Label5.Name = "Label5"
        Label5.Size = New Size(53, 20)
        Label5.TabIndex = 16
        Label5.Text = "Precio:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(343, 296)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 20)
        Label6.TabIndex = 17
        Label6.Text = "Cantidad:"
        ' 
        ' ct_idDetalleCompra
        ' 
        ct_idDetalleCompra.Location = New Point(82, 206)
        ct_idDetalleCompra.Name = "ct_idDetalleCompra"
        ct_idDetalleCompra.Size = New Size(165, 27)
        ct_idDetalleCompra.TabIndex = 18
        ct_idDetalleCompra.Visible = False
        ' 
        ' btMas
        ' 
        btMas.Location = New Point(787, 292)
        btMas.Name = "btMas"
        btMas.Size = New Size(54, 29)
        btMas.TabIndex = 19
        btMas.Text = "+"
        btMas.UseVisualStyleBackColor = True
        ' 
        ' btMenos
        ' 
        btMenos.Location = New Point(787, 327)
        btMenos.Name = "btMenos"
        btMenos.Size = New Size(54, 29)
        btMenos.TabIndex = 20
        btMenos.Text = "-"
        btMenos.UseVisualStyleBackColor = True
        ' 
        ' btSalir
        ' 
        btSalir.Location = New Point(539, 415)
        btSalir.Name = "btSalir"
        btSalir.Size = New Size(94, 29)
        btSalir.TabIndex = 21
        btSalir.Text = "Salir"
        btSalir.UseVisualStyleBackColor = True
        ' 
        ' FormCompras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(899, 502)
        Controls.Add(btSalir)
        Controls.Add(btMenos)
        Controls.Add(btMas)
        Controls.Add(ct_idDetalleCompra)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(ct_cantidad)
        Controls.Add(ct_precio)
        Controls.Add(ct_idProducto)
        Controls.Add(dtp_fecha)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btBorrar)
        Controls.Add(btGuardar)
        Controls.Add(btNuevo)
        Controls.Add(ct_total)
        Controls.Add(ct_idProveedor)
        Controls.Add(ct_idCompra)
        Controls.Add(DataGridView1)
        Name = "FormCompras"
        Text = "Compras"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_idCompra As TextBox
    Friend WithEvents ct_idProveedor As TextBox
    Friend WithEvents ct_total As TextBox
    Friend WithEvents btNuevo As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents ct_idProducto As TextBox
    Friend WithEvents ct_precio As TextBox
    Friend WithEvents ct_cantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ct_idDetalleCompra As TextBox
    Friend WithEvents btMas As Button
    Friend WithEvents btMenos As Button
    Friend WithEvents btSalir As Button
End Class
