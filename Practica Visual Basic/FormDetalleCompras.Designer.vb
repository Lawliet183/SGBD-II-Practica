<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalleCompras
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
        ct_idDetalleCompra = New TextBox()
        ct_idCompra = New TextBox()
        ct_idProducto = New TextBox()
        ct_cantidad = New TextBox()
        ct_precioCompra = New TextBox()
        btNuevo = New Button()
        btGuardar = New Button()
        btBorrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(776, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' ct_idDetalleCompra
        ' 
        ct_idDetalleCompra.Location = New Point(333, 224)
        ct_idDetalleCompra.Name = "ct_idDetalleCompra"
        ct_idDetalleCompra.Size = New Size(168, 27)
        ct_idDetalleCompra.TabIndex = 1
        ct_idDetalleCompra.Visible = False
        ' 
        ' ct_idCompra
        ' 
        ct_idCompra.Location = New Point(333, 257)
        ct_idCompra.Name = "ct_idCompra"
        ct_idCompra.Size = New Size(168, 27)
        ct_idCompra.TabIndex = 2
        ' 
        ' ct_idProducto
        ' 
        ct_idProducto.Location = New Point(333, 290)
        ct_idProducto.Name = "ct_idProducto"
        ct_idProducto.Size = New Size(168, 27)
        ct_idProducto.TabIndex = 3
        ' 
        ' ct_cantidad
        ' 
        ct_cantidad.Location = New Point(333, 323)
        ct_cantidad.Name = "ct_cantidad"
        ct_cantidad.Size = New Size(168, 27)
        ct_cantidad.TabIndex = 4
        ' 
        ' ct_precioCompra
        ' 
        ct_precioCompra.Location = New Point(333, 356)
        ct_precioCompra.Name = "ct_precioCompra"
        ct_precioCompra.Size = New Size(168, 27)
        ct_precioCompra.TabIndex = 5
        ' 
        ' btNuevo
        ' 
        btNuevo.Location = New Point(573, 243)
        btNuevo.Name = "btNuevo"
        btNuevo.Size = New Size(94, 29)
        btNuevo.TabIndex = 6
        btNuevo.Text = "Nuevo"
        btNuevo.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(573, 278)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(94, 29)
        btGuardar.TabIndex = 7
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(573, 313)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(94, 29)
        btBorrar.TabIndex = 8
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(224, 260)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 20)
        Label1.TabIndex = 9
        Label1.Text = "ID de compra:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(214, 293)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 10
        Label2.Text = "ID de producto:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(255, 326)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 11
        Label3.Text = "Cantidad:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(198, 359)
        Label4.Name = "Label4"
        Label4.Size = New Size(129, 20)
        Label4.TabIndex = 12
        Label4.Text = "Precio de compra:"
        ' 
        ' FormDetalleCompras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btBorrar)
        Controls.Add(btGuardar)
        Controls.Add(btNuevo)
        Controls.Add(ct_precioCompra)
        Controls.Add(ct_cantidad)
        Controls.Add(ct_idProducto)
        Controls.Add(ct_idCompra)
        Controls.Add(ct_idDetalleCompra)
        Controls.Add(DataGridView1)
        Name = "FormDetalleCompras"
        Text = "DetalleCompras"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_idDetalleCompra As TextBox
    Friend WithEvents ct_idCompra As TextBox
    Friend WithEvents ct_idProducto As TextBox
    Friend WithEvents ct_cantidad As TextBox
    Friend WithEvents ct_precioCompra As TextBox
    Friend WithEvents btNuevo As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
