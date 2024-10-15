<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProveedores
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        ct_idproveedor = New TextBox()
        ct_nombre = New TextBox()
        ct_direccion = New TextBox()
        ct_telefono = New TextBox()
        ct_correo = New TextBox()
        btnuevo = New Button()
        btguardar = New Button()
        btborrar = New Button()
        btsalir = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(11, 11)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(618, 178)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 229)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nombre:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 258)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 2
        Label2.Text = "Direccion:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 288)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 3
        Label3.Text = "Telefono:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 320)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 4
        Label4.Text = "Correo:"
        ' 
        ' ct_idproveedor
        ' 
        ct_idproveedor.Location = New Point(101, 194)
        ct_idproveedor.Margin = New Padding(2)
        ct_idproveedor.Name = "ct_idproveedor"
        ct_idproveedor.Size = New Size(226, 27)
        ct_idproveedor.TabIndex = 5
        ct_idproveedor.Visible = False
        ' 
        ' ct_nombre
        ' 
        ct_nombre.Location = New Point(101, 226)
        ct_nombre.Margin = New Padding(2)
        ct_nombre.Name = "ct_nombre"
        ct_nombre.Size = New Size(226, 27)
        ct_nombre.TabIndex = 6
        ' 
        ' ct_direccion
        ' 
        ct_direccion.Location = New Point(101, 255)
        ct_direccion.Margin = New Padding(2)
        ct_direccion.Name = "ct_direccion"
        ct_direccion.Size = New Size(226, 27)
        ct_direccion.TabIndex = 7
        ' 
        ' ct_telefono
        ' 
        ct_telefono.Location = New Point(101, 285)
        ct_telefono.Margin = New Padding(2)
        ct_telefono.Name = "ct_telefono"
        ct_telefono.Size = New Size(226, 27)
        ct_telefono.TabIndex = 8
        ' 
        ' ct_correo
        ' 
        ct_correo.Location = New Point(101, 317)
        ct_correo.Margin = New Padding(2)
        ct_correo.Name = "ct_correo"
        ct_correo.Size = New Size(226, 27)
        ct_correo.TabIndex = 9
        ' 
        ' btnuevo
        ' 
        btnuevo.Location = New Point(442, 207)
        btnuevo.Margin = New Padding(2)
        btnuevo.Name = "btnuevo"
        btnuevo.Size = New Size(90, 27)
        btnuevo.TabIndex = 10
        btnuevo.Text = "Nuevo"
        btnuevo.UseVisualStyleBackColor = True
        ' 
        ' btguardar
        ' 
        btguardar.Location = New Point(442, 239)
        btguardar.Margin = New Padding(2)
        btguardar.Name = "btguardar"
        btguardar.Size = New Size(90, 27)
        btguardar.TabIndex = 11
        btguardar.Text = "Guardar"
        btguardar.UseVisualStyleBackColor = True
        ' 
        ' btborrar
        ' 
        btborrar.Location = New Point(442, 271)
        btborrar.Margin = New Padding(2)
        btborrar.Name = "btborrar"
        btborrar.Size = New Size(90, 27)
        btborrar.TabIndex = 12
        btborrar.Text = "Borrar"
        btborrar.UseVisualStyleBackColor = True
        ' 
        ' btsalir
        ' 
        btsalir.Location = New Point(442, 303)
        btsalir.Margin = New Padding(2)
        btsalir.Name = "btsalir"
        btsalir.Size = New Size(90, 27)
        btsalir.TabIndex = 13
        btsalir.Text = "Salir"
        btsalir.UseVisualStyleBackColor = True
        ' 
        ' FormProveedores
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(640, 360)
        Controls.Add(btsalir)
        Controls.Add(btborrar)
        Controls.Add(btguardar)
        Controls.Add(btnuevo)
        Controls.Add(ct_correo)
        Controls.Add(ct_telefono)
        Controls.Add(ct_direccion)
        Controls.Add(ct_nombre)
        Controls.Add(ct_idproveedor)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Margin = New Padding(2)
        Name = "FormProveedores"
        Text = "Proveedores"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ct_idproveedor As TextBox
    Friend WithEvents ct_nombre As TextBox
    Friend WithEvents ct_direccion As TextBox
    Friend WithEvents ct_telefono As TextBox
    Friend WithEvents ct_correo As TextBox
    Friend WithEvents btnuevo As Button
    Friend WithEvents btguardar As Button
    Friend WithEvents btborrar As Button
    Friend WithEvents btsalir As Button

End Class
