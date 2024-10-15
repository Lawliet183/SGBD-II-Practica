<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVentas
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
        ct_idVenta = New TextBox()
        ct_fechaVenta = New TextBox()
        ct_total = New TextBox()
        ct_idCliente = New TextBox()
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
        ' ct_idVenta
        ' 
        ct_idVenta.Location = New Point(311, 237)
        ct_idVenta.Name = "ct_idVenta"
        ct_idVenta.Size = New Size(173, 27)
        ct_idVenta.TabIndex = 1
        ct_idVenta.Visible = False
        ' 
        ' ct_fechaVenta
        ' 
        ct_fechaVenta.Location = New Point(311, 270)
        ct_fechaVenta.Name = "ct_fechaVenta"
        ct_fechaVenta.Size = New Size(173, 27)
        ct_fechaVenta.TabIndex = 2
        ' 
        ' ct_total
        ' 
        ct_total.Location = New Point(311, 336)
        ct_total.Name = "ct_total"
        ct_total.Size = New Size(173, 27)
        ct_total.TabIndex = 3
        ' 
        ' ct_idCliente
        ' 
        ct_idCliente.Location = New Point(311, 303)
        ct_idCliente.Name = "ct_idCliente"
        ct_idCliente.Size = New Size(173, 27)
        ct_idCliente.TabIndex = 4
        ' 
        ' btNuevo
        ' 
        btNuevo.Location = New Point(563, 250)
        btNuevo.Name = "btNuevo"
        btNuevo.Size = New Size(94, 29)
        btNuevo.TabIndex = 5
        btNuevo.Text = "Nuevo"
        btNuevo.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(563, 285)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(94, 29)
        btGuardar.TabIndex = 6
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(563, 320)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(94, 29)
        btBorrar.TabIndex = 7
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(194, 273)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 20)
        Label1.TabIndex = 8
        Label1.Text = "Fecha de venta:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(209, 306)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 20)
        Label2.TabIndex = 9
        Label2.Text = "ID de cliente:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(260, 339)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 20)
        Label3.TabIndex = 10
        Label3.Text = "Total:"
        ' 
        ' FormVentas
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
        Controls.Add(ct_idCliente)
        Controls.Add(ct_total)
        Controls.Add(ct_fechaVenta)
        Controls.Add(ct_idVenta)
        Controls.Add(DataGridView1)
        Name = "FormVentas"
        Text = "Ventas"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_idVenta As TextBox
    Friend WithEvents ct_fechaVenta As TextBox
    Friend WithEvents ct_total As TextBox
    Friend WithEvents ct_idCliente As TextBox
    Friend WithEvents btNuevo As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
