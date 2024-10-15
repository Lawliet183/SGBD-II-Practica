<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        ct_fechaCompra = New TextBox()
        ct_total = New TextBox()
        btNuevo = New Button()
        btGuardar = New Button()
        btBorrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
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
        ' ct_idCompra
        ' 
        ct_idCompra.Location = New Point(319, 238)
        ct_idCompra.Name = "ct_idCompra"
        ct_idCompra.Size = New Size(165, 27)
        ct_idCompra.TabIndex = 1
        ct_idCompra.Visible = False
        ' 
        ' ct_idProveedor
        ' 
        ct_idProveedor.Location = New Point(319, 271)
        ct_idProveedor.Name = "ct_idProveedor"
        ct_idProveedor.Size = New Size(165, 27)
        ct_idProveedor.TabIndex = 2
        ' 
        ' ct_fechaCompra
        ' 
        ct_fechaCompra.Location = New Point(319, 304)
        ct_fechaCompra.Name = "ct_fechaCompra"
        ct_fechaCompra.Size = New Size(165, 27)
        ct_fechaCompra.TabIndex = 3
        ' 
        ' ct_total
        ' 
        ct_total.Location = New Point(319, 337)
        ct_total.Name = "ct_total"
        ct_total.Size = New Size(165, 27)
        ct_total.TabIndex = 4
        ' 
        ' btNuevo
        ' 
        btNuevo.Location = New Point(563, 249)
        btNuevo.Name = "btNuevo"
        btNuevo.Size = New Size(94, 29)
        btNuevo.TabIndex = 5
        btNuevo.Text = "Nuevo"
        btNuevo.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(563, 284)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(94, 29)
        btGuardar.TabIndex = 6
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(563, 319)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(94, 29)
        btBorrar.TabIndex = 7
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 274)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 20)
        Label1.TabIndex = 8
        Label1.Text = "ID de proveedor:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(187, 307)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 20)
        Label2.TabIndex = 9
        Label2.Text = "Fecha de compra:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(268, 340)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 10
        Label3.Text = "Total:"
        ' 
        ' FormCompras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btBorrar)
        Controls.Add(btGuardar)
        Controls.Add(btNuevo)
        Controls.Add(ct_total)
        Controls.Add(ct_fechaCompra)
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
    Friend WithEvents ct_fechaCompra As TextBox
    Friend WithEvents ct_total As TextBox
    Friend WithEvents btNuevo As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
