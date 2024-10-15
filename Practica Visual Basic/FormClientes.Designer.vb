<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClientes
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
        ct_idCliente = New TextBox()
        ct_correo = New TextBox()
        ct_telefono = New TextBox()
        ct_direccion = New TextBox()
        ct_nombre = New TextBox()
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
        ' ct_idCliente
        ' 
        ct_idCliente.Location = New Point(326, 227)
        ct_idCliente.Name = "ct_idCliente"
        ct_idCliente.Size = New Size(185, 27)
        ct_idCliente.TabIndex = 1
        ct_idCliente.Visible = False
        ' 
        ' ct_correo
        ' 
        ct_correo.Location = New Point(326, 359)
        ct_correo.Name = "ct_correo"
        ct_correo.Size = New Size(185, 27)
        ct_correo.TabIndex = 2
        ' 
        ' ct_telefono
        ' 
        ct_telefono.Location = New Point(326, 326)
        ct_telefono.Name = "ct_telefono"
        ct_telefono.Size = New Size(185, 27)
        ct_telefono.TabIndex = 3
        ' 
        ' ct_direccion
        ' 
        ct_direccion.Location = New Point(326, 293)
        ct_direccion.Name = "ct_direccion"
        ct_direccion.Size = New Size(185, 27)
        ct_direccion.TabIndex = 4
        ' 
        ' ct_nombre
        ' 
        ct_nombre.Location = New Point(326, 260)
        ct_nombre.Name = "ct_nombre"
        ct_nombre.Size = New Size(185, 27)
        ct_nombre.TabIndex = 5
        ' 
        ' btNuevo
        ' 
        btNuevo.Location = New Point(593, 238)
        btNuevo.Name = "btNuevo"
        btNuevo.Size = New Size(94, 29)
        btNuevo.TabIndex = 6
        btNuevo.Text = "Nuevo"
        btNuevo.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(593, 273)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(94, 29)
        btGuardar.TabIndex = 7
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(593, 308)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(94, 29)
        btBorrar.TabIndex = 8
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(253, 263)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 9
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(245, 296)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 10
        Label2.Text = "Direccion:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(250, 329)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 11
        Label3.Text = "Telefono:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(263, 362)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 12
        Label4.Text = "Correo:"
        ' 
        ' FormClientes
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
        Controls.Add(ct_nombre)
        Controls.Add(ct_direccion)
        Controls.Add(ct_telefono)
        Controls.Add(ct_correo)
        Controls.Add(ct_idCliente)
        Controls.Add(DataGridView1)
        Name = "FormClientes"
        Text = "Clientes"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_idCliente As TextBox
    Friend WithEvents ct_correo As TextBox
    Friend WithEvents ct_telefono As TextBox
    Friend WithEvents ct_direccion As TextBox
    Friend WithEvents ct_nombre As TextBox
    Friend WithEvents btNuevo As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
