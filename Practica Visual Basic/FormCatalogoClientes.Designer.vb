<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCatalogoClientes
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        btExportar = New Button()
        btResetear = New Button()
        btSalir = New Button()
        comboBoxCliente = New ComboBox()
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
        DataGridView1.Size = New Size(639, 188)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(174, 223)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 20)
        Label1.TabIndex = 3
        Label1.Text = "Cliente:"
        ' 
        ' btExportar
        ' 
        btExportar.Location = New Point(238, 281)
        btExportar.Name = "btExportar"
        btExportar.Size = New Size(125, 29)
        btExportar.TabIndex = 4
        btExportar.Text = "Exportar a Excel"
        btExportar.UseVisualStyleBackColor = True
        ' 
        ' btResetear
        ' 
        btResetear.Location = New Point(383, 219)
        btResetear.Name = "btResetear"
        btResetear.Size = New Size(94, 29)
        btResetear.TabIndex = 5
        btResetear.Text = "Resetear"
        btResetear.UseVisualStyleBackColor = True
        ' 
        ' btSalir
        ' 
        btSalir.Location = New Point(383, 281)
        btSalir.Name = "btSalir"
        btSalir.Size = New Size(94, 29)
        btSalir.TabIndex = 6
        btSalir.Text = "Salir"
        btSalir.UseVisualStyleBackColor = True
        ' 
        ' comboBoxCliente
        ' 
        comboBoxCliente.FormattingEnabled = True
        comboBoxCliente.Location = New Point(238, 220)
        comboBoxCliente.Name = "comboBoxCliente"
        comboBoxCliente.Size = New Size(125, 28)
        comboBoxCliente.TabIndex = 7
        ' 
        ' FormCatalogoClientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(639, 355)
        Controls.Add(comboBoxCliente)
        Controls.Add(btSalir)
        Controls.Add(btResetear)
        Controls.Add(btExportar)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "FormCatalogoClientes"
        Text = "Catalogo de Clientes"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btExportar As Button
    Friend WithEvents btResetear As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents comboBoxCliente As ComboBox
End Class
