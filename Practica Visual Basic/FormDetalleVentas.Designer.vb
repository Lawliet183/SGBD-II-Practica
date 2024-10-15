<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetalleVentas
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
        ct_idDetalle = New TextBox()
        ct_idVenta = New TextBox()
        ct_idProducto = New TextBox()
        ct_precioUnitario = New TextBox()
        ct_cantidad = New TextBox()
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
        ' ct_idDetalle
        ' 
        ct_idDetalle.Location = New Point(329, 233)
        ct_idDetalle.Name = "ct_idDetalle"
        ct_idDetalle.Size = New Size(181, 27)
        ct_idDetalle.TabIndex = 1
        ct_idDetalle.Visible = False
        ' 
        ' ct_idVenta
        ' 
        ct_idVenta.Location = New Point(329, 266)
        ct_idVenta.Name = "ct_idVenta"
        ct_idVenta.Size = New Size(181, 27)
        ct_idVenta.TabIndex = 2
        ' 
        ' ct_idProducto
        ' 
        ct_idProducto.Location = New Point(329, 299)
        ct_idProducto.Name = "ct_idProducto"
        ct_idProducto.Size = New Size(181, 27)
        ct_idProducto.TabIndex = 3
        ' 
        ' ct_precioUnitario
        ' 
        ct_precioUnitario.Location = New Point(329, 365)
        ct_precioUnitario.Name = "ct_precioUnitario"
        ct_precioUnitario.Size = New Size(181, 27)
        ct_precioUnitario.TabIndex = 4
        ' 
        ' ct_cantidad
        ' 
        ct_cantidad.Location = New Point(329, 332)
        ct_cantidad.Name = "ct_cantidad"
        ct_cantidad.Size = New Size(181, 27)
        ct_cantidad.TabIndex = 5
        ' 
        ' btNuevo
        ' 
        btNuevo.Location = New Point(587, 248)
        btNuevo.Name = "btNuevo"
        btNuevo.Size = New Size(94, 29)
        btNuevo.TabIndex = 6
        btNuevo.Text = "Nuevo"
        btNuevo.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(587, 283)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(94, 29)
        btGuardar.TabIndex = 7
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(587, 318)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(94, 29)
        btBorrar.TabIndex = 8
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(235, 269)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 9
        Label1.Text = "ID de venta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(210, 302)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 20)
        Label2.TabIndex = 10
        Label2.Text = "ID de producto:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(251, 335)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 11
        Label3.Text = "Cantidad:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(215, 368)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 20)
        Label4.TabIndex = 12
        Label4.Text = "Precio unitario:"
        ' 
        ' FormDetalleVentas
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
        Controls.Add(ct_cantidad)
        Controls.Add(ct_precioUnitario)
        Controls.Add(ct_idProducto)
        Controls.Add(ct_idVenta)
        Controls.Add(ct_idDetalle)
        Controls.Add(DataGridView1)
        Name = "FormDetalleVentas"
        Text = "DetalleVentas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_idDetalle As TextBox
    Friend WithEvents ct_idVenta As TextBox
    Friend WithEvents ct_idProducto As TextBox
    Friend WithEvents ct_precioUnitario As TextBox
    Friend WithEvents ct_cantidad As TextBox
    Friend WithEvents btNuevo As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
