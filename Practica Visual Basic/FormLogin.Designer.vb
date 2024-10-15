<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        ct_userID = New TextBox()
        ct_password = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btLogin = New Button()
        SuspendLayout()
        ' 
        ' ct_userID
        ' 
        ct_userID.Location = New Point(116, 59)
        ct_userID.Name = "ct_userID"
        ct_userID.Size = New Size(125, 27)
        ct_userID.TabIndex = 0
        ' 
        ' ct_password
        ' 
        ct_password.Location = New Point(116, 92)
        ct_password.Name = "ct_password"
        ct_password.Size = New Size(125, 27)
        ct_password.TabIndex = 1
        ct_password.UseSystemPasswordChar = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(85, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 20)
        Label1.TabIndex = 2
        Label1.Text = "Inicio de sesión"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 3
        Label2.Text = "Usuario:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 4
        Label3.Text = "Contraseña:"
        ' 
        ' btLogin
        ' 
        btLogin.Location = New Point(85, 141)
        btLogin.Name = "btLogin"
        btLogin.Size = New Size(94, 29)
        btLogin.TabIndex = 5
        btLogin.Text = "Login"
        btLogin.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(279, 209)
        Controls.Add(btLogin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ct_password)
        Controls.Add(ct_userID)
        Name = "FormLogin"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ct_userID As TextBox
    Friend WithEvents ct_password As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btLogin As Button
End Class
