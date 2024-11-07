Imports System
Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormUsuarios
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
        ct_idUsuario = New TextBox()
        ct_username = New TextBox()
        ct_password = New TextBox()
        btNuevo = New Button()
        btGuardar = New Button()
        btBorrar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btSalir = New Button()
        comboBox_Rol = New ComboBox()
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
        ' ct_idUsuario
        ' 
        ct_idUsuario.Location = New Point(317, 230)
        ct_idUsuario.Name = "ct_idUsuario"
        ct_idUsuario.Size = New Size(173, 27)
        ct_idUsuario.TabIndex = 1
        ct_idUsuario.Visible = False
        ' 
        ' ct_username
        ' 
        ct_username.Location = New Point(317, 263)
        ct_username.Name = "ct_username"
        ct_username.Size = New Size(173, 27)
        ct_username.TabIndex = 2
        ' 
        ' ct_password
        ' 
        ct_password.Location = New Point(317, 296)
        ct_password.Name = "ct_password"
        ct_password.Size = New Size(173, 27)
        ct_password.TabIndex = 3
        ct_password.UseSystemPasswordChar = True
        ' 
        ' btNuevo
        ' 
        btNuevo.Location = New Point(563, 243)
        btNuevo.Name = "btNuevo"
        btNuevo.Size = New Size(94, 29)
        btNuevo.TabIndex = 5
        btNuevo.Text = "Nuevo"
        btNuevo.UseVisualStyleBackColor = True
        ' 
        ' btGuardar
        ' 
        btGuardar.Location = New Point(563, 278)
        btGuardar.Name = "btGuardar"
        btGuardar.Size = New Size(94, 29)
        btGuardar.TabIndex = 6
        btGuardar.Text = "Guardar"
        btGuardar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.Location = New Point(563, 313)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(94, 29)
        btBorrar.TabIndex = 7
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(171, 266)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 20)
        Label1.TabIndex = 8
        Label1.Text = "Nombre de usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(225, 299)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 9
        Label2.Text = "Contraseña:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(277, 332)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 20)
        Label3.TabIndex = 10
        Label3.Text = "Rol:"
        ' 
        ' btSalir
        ' 
        btSalir.Location = New Point(563, 348)
        btSalir.Name = "btSalir"
        btSalir.Size = New Size(94, 29)
        btSalir.TabIndex = 11
        btSalir.Text = "Salir"
        btSalir.UseVisualStyleBackColor = True
        ' 
        ' comboBox_Rol
        ' 
        comboBox_Rol.FormattingEnabled = True
        comboBox_Rol.Location = New Point(317, 329)
        comboBox_Rol.Name = "comboBox_Rol"
        comboBox_Rol.Size = New Size(173, 28)
        comboBox_Rol.TabIndex = 12
        ' 
        ' FormUsuarios
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 408)
        Controls.Add(comboBox_Rol)
        Controls.Add(btSalir)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btBorrar)
        Controls.Add(btGuardar)
        Controls.Add(btNuevo)
        Controls.Add(ct_password)
        Controls.Add(ct_username)
        Controls.Add(ct_idUsuario)
        Controls.Add(DataGridView1)
        Name = "FormUsuarios"
        Text = "Usuarios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ct_idUsuario As TextBox
    Friend WithEvents ct_username As TextBox
    Friend WithEvents ct_password As TextBox
    Friend WithEvents btNuevo As Button
    Friend WithEvents btGuardar As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btSalir As Button
    Friend WithEvents comboBox_Rol As ComboBox
End Class
