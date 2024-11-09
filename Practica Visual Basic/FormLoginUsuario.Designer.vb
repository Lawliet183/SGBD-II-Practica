Imports System.Windows.Forms
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLoginUsuario
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
        ct_usuario = New TextBox()
        ct_clave = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        bt_enviar = New Button()
        SuspendLayout()
        ' 
        ' ct_usuario
        ' 
        ct_usuario.Location = New Point(131, 63)
        ct_usuario.Name = "ct_usuario"
        ct_usuario.Size = New Size(125, 27)
        ct_usuario.TabIndex = 0
        ' 
        ' ct_clave
        ' 
        ct_clave.Location = New Point(131, 96)
        ct_clave.Name = "ct_clave"
        ct_clave.Size = New Size(125, 27)
        ct_clave.TabIndex = 1
        ct_clave.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 2
        Label1.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(39, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 3
        Label2.Text = "Contraseña:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(63, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(184, 20)
        Label3.TabIndex = 4
        Label3.Text = "Inicio de sesión de usuario"
        ' 
        ' bt_enviar
        ' 
        bt_enviar.Location = New Point(107, 148)
        bt_enviar.Name = "bt_enviar"
        bt_enviar.Size = New Size(94, 29)
        bt_enviar.TabIndex = 5
        bt_enviar.Text = "Login"
        bt_enviar.UseVisualStyleBackColor = True
        ' 
        ' FormLoginUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(326, 214)
        ControlBox = False
        Controls.Add(bt_enviar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ct_clave)
        Controls.Add(ct_usuario)
        Name = "FormLoginUsuario"
        Text = "Login de Usuario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ct_usuario As TextBox
    Friend WithEvents ct_clave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents bt_enviar As Button
End Class
