<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenuPrincipal
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
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        btReporteExistencias = New Button()
        btReporteExistenciasMinimo = New Button()
        btReporteGanancias = New Button()
        GroupBox3 = New GroupBox()
        btReporteVentasFecha = New Button()
        btReporteComprasFecha = New Button()
        btReporteProveedores = New Button()
        btReporteClientes = New Button()
        btReporteProductos = New Button()
        Label3 = New Label()
        Label5 = New Label()
        GroupBox4 = New GroupBox()
        btFormularioDetalleCompras = New Button()
        btFormularioVentas = New Button()
        btFormularioProveedores = New Button()
        btFormularioCompras = New Button()
        btFormularioClientes = New Button()
        btFormularioUsuarios = New Button()
        btFormularioProductos = New Button()
        btFormularioDetalleVentas = New Button()
        btSalir = New Button()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Times New Roman", 26F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(238))
        Label1.Location = New Point(0, 11)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(719, 62)
        Label1.TabIndex = 0
        Label1.Text = "Gestión y control de inventario digital" & vbCrLf
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.MediumSpringGreen
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(10, 4)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(719, 86)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' btReporteExistencias
        ' 
        btReporteExistencias.BackColor = Color.Cyan
        btReporteExistencias.FlatStyle = FlatStyle.Popup
        btReporteExistencias.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btReporteExistencias.Location = New Point(30, 283)
        btReporteExistencias.Margin = New Padding(2)
        btReporteExistencias.Name = "btReporteExistencias"
        btReporteExistencias.Size = New Size(234, 33)
        btReporteExistencias.TabIndex = 2
        btReporteExistencias.Text = "Reporte de Existencias"
        btReporteExistencias.UseVisualStyleBackColor = False
        ' 
        ' btReporteExistenciasMinimo
        ' 
        btReporteExistenciasMinimo.BackColor = Color.Cyan
        btReporteExistenciasMinimo.FlatStyle = FlatStyle.Popup
        btReporteExistenciasMinimo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btReporteExistenciasMinimo.Location = New Point(30, 246)
        btReporteExistenciasMinimo.Margin = New Padding(2)
        btReporteExistenciasMinimo.Name = "btReporteExistenciasMinimo"
        btReporteExistenciasMinimo.Size = New Size(234, 33)
        btReporteExistenciasMinimo.TabIndex = 1
        btReporteExistenciasMinimo.Text = "Reporte de Existencias al minimo"
        btReporteExistenciasMinimo.UseVisualStyleBackColor = False
        ' 
        ' btReporteGanancias
        ' 
        btReporteGanancias.BackColor = Color.Cyan
        btReporteGanancias.FlatStyle = FlatStyle.Popup
        btReporteGanancias.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btReporteGanancias.Location = New Point(30, 209)
        btReporteGanancias.Margin = New Padding(2)
        btReporteGanancias.Name = "btReporteGanancias"
        btReporteGanancias.Size = New Size(234, 33)
        btReporteGanancias.TabIndex = 0
        btReporteGanancias.Text = "Reporte de Ganancias"
        btReporteGanancias.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.DeepPink
        GroupBox3.Controls.Add(btReporteExistencias)
        GroupBox3.Controls.Add(btReporteVentasFecha)
        GroupBox3.Controls.Add(btReporteExistenciasMinimo)
        GroupBox3.Controls.Add(btReporteComprasFecha)
        GroupBox3.Controls.Add(btReporteGanancias)
        GroupBox3.Controls.Add(btReporteProveedores)
        GroupBox3.Controls.Add(btReporteClientes)
        GroupBox3.Controls.Add(btReporteProductos)
        GroupBox3.Location = New Point(374, 107)
        GroupBox3.Margin = New Padding(2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(2)
        GroupBox3.Size = New Size(291, 336)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        ' 
        ' btReporteVentasFecha
        ' 
        btReporteVentasFecha.BackColor = Color.Cyan
        btReporteVentasFecha.FlatStyle = FlatStyle.Popup
        btReporteVentasFecha.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btReporteVentasFecha.Location = New Point(30, 172)
        btReporteVentasFecha.Margin = New Padding(2)
        btReporteVentasFecha.Name = "btReporteVentasFecha"
        btReporteVentasFecha.Size = New Size(234, 33)
        btReporteVentasFecha.TabIndex = 4
        btReporteVentasFecha.Text = "Reporte de Ventas por rango de fecha"
        btReporteVentasFecha.UseVisualStyleBackColor = False
        ' 
        ' btReporteComprasFecha
        ' 
        btReporteComprasFecha.BackColor = Color.Chartreuse
        btReporteComprasFecha.FlatStyle = FlatStyle.Popup
        btReporteComprasFecha.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btReporteComprasFecha.Location = New Point(30, 135)
        btReporteComprasFecha.Margin = New Padding(2)
        btReporteComprasFecha.Name = "btReporteComprasFecha"
        btReporteComprasFecha.Size = New Size(234, 33)
        btReporteComprasFecha.TabIndex = 3
        btReporteComprasFecha.Text = "Reporte de Compras por rango de fecha"
        btReporteComprasFecha.UseVisualStyleBackColor = False
        ' 
        ' btReporteProveedores
        ' 
        btReporteProveedores.BackColor = Color.Chartreuse
        btReporteProveedores.FlatStyle = FlatStyle.Popup
        btReporteProveedores.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btReporteProveedores.Location = New Point(30, 98)
        btReporteProveedores.Margin = New Padding(2)
        btReporteProveedores.Name = "btReporteProveedores"
        btReporteProveedores.Size = New Size(234, 33)
        btReporteProveedores.TabIndex = 2
        btReporteProveedores.Text = "Catálogo de Proveedores"
        btReporteProveedores.UseVisualStyleBackColor = False
        ' 
        ' btReporteClientes
        ' 
        btReporteClientes.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btReporteClientes.BackColor = Color.Chartreuse
        btReporteClientes.FlatStyle = FlatStyle.Popup
        btReporteClientes.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btReporteClientes.Location = New Point(30, 61)
        btReporteClientes.Margin = New Padding(2)
        btReporteClientes.Name = "btReporteClientes"
        btReporteClientes.Size = New Size(234, 33)
        btReporteClientes.TabIndex = 1
        btReporteClientes.Text = "Catálogo de Clientes"
        btReporteClientes.UseVisualStyleBackColor = False
        ' 
        ' btReporteProductos
        ' 
        btReporteProductos.BackColor = Color.Chartreuse
        btReporteProductos.FlatStyle = FlatStyle.Popup
        btReporteProductos.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btReporteProductos.Location = New Point(30, 24)
        btReporteProductos.Margin = New Padding(2)
        btReporteProductos.Name = "btReporteProductos"
        btReporteProductos.Size = New Size(234, 33)
        btReporteProductos.TabIndex = 0
        btReporteProductos.Text = "Catálogo de Productos"
        btReporteProductos.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.MediumPurple
        Label3.Font = New Font("Times New Roman", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(374, 92)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(291, 26)
        Label3.TabIndex = 5
        Label3.Text = "Ver reportes"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.MediumPurple
        Label5.Font = New Font("Times New Roman", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(67, 92)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(291, 25)
        Label5.TabIndex = 7
        Label5.Text = "Ver formularios"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.DarkGreen
        GroupBox4.Controls.Add(btFormularioDetalleCompras)
        GroupBox4.Controls.Add(btFormularioVentas)
        GroupBox4.Controls.Add(btFormularioProveedores)
        GroupBox4.Controls.Add(btFormularioCompras)
        GroupBox4.Controls.Add(btFormularioClientes)
        GroupBox4.Controls.Add(btFormularioUsuarios)
        GroupBox4.Controls.Add(btFormularioProductos)
        GroupBox4.Controls.Add(btFormularioDetalleVentas)
        GroupBox4.FlatStyle = FlatStyle.Popup
        GroupBox4.Location = New Point(67, 107)
        GroupBox4.Margin = New Padding(2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(2)
        GroupBox4.Size = New Size(291, 336)
        GroupBox4.TabIndex = 8
        GroupBox4.TabStop = False
        ' 
        ' btFormularioDetalleCompras
        ' 
        btFormularioDetalleCompras.BackColor = Color.Peru
        btFormularioDetalleCompras.FlatStyle = FlatStyle.Popup
        btFormularioDetalleCompras.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btFormularioDetalleCompras.Location = New Point(15, 283)
        btFormularioDetalleCompras.Margin = New Padding(2)
        btFormularioDetalleCompras.Name = "btFormularioDetalleCompras"
        btFormularioDetalleCompras.Size = New Size(255, 33)
        btFormularioDetalleCompras.TabIndex = 3
        btFormularioDetalleCompras.Text = "Detalle de Compras"
        btFormularioDetalleCompras.UseVisualStyleBackColor = False
        ' 
        ' btFormularioVentas
        ' 
        btFormularioVentas.BackColor = Color.Khaki
        btFormularioVentas.FlatStyle = FlatStyle.Popup
        btFormularioVentas.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btFormularioVentas.Location = New Point(15, 135)
        btFormularioVentas.Margin = New Padding(2)
        btFormularioVentas.Name = "btFormularioVentas"
        btFormularioVentas.Size = New Size(255, 33)
        btFormularioVentas.TabIndex = 4
        btFormularioVentas.Text = "Ventas"
        btFormularioVentas.UseVisualStyleBackColor = False
        ' 
        ' btFormularioProveedores
        ' 
        btFormularioProveedores.BackColor = Color.Khaki
        btFormularioProveedores.FlatStyle = FlatStyle.Popup
        btFormularioProveedores.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btFormularioProveedores.Location = New Point(15, 24)
        btFormularioProveedores.Margin = New Padding(2)
        btFormularioProveedores.Name = "btFormularioProveedores"
        btFormularioProveedores.Size = New Size(255, 33)
        btFormularioProveedores.TabIndex = 0
        btFormularioProveedores.Text = "Proveedores"
        btFormularioProveedores.UseVisualStyleBackColor = False
        ' 
        ' btFormularioCompras
        ' 
        btFormularioCompras.BackColor = Color.Peru
        btFormularioCompras.FlatStyle = FlatStyle.Popup
        btFormularioCompras.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btFormularioCompras.Location = New Point(15, 246)
        btFormularioCompras.Margin = New Padding(2)
        btFormularioCompras.Name = "btFormularioCompras"
        btFormularioCompras.Size = New Size(255, 33)
        btFormularioCompras.TabIndex = 2
        btFormularioCompras.Text = "Compras"
        btFormularioCompras.UseVisualStyleBackColor = False
        ' 
        ' btFormularioClientes
        ' 
        btFormularioClientes.BackColor = Color.Khaki
        btFormularioClientes.FlatStyle = FlatStyle.Popup
        btFormularioClientes.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btFormularioClientes.Location = New Point(15, 98)
        btFormularioClientes.Margin = New Padding(2)
        btFormularioClientes.Name = "btFormularioClientes"
        btFormularioClientes.Size = New Size(255, 33)
        btFormularioClientes.TabIndex = 3
        btFormularioClientes.Text = "Clientes"
        btFormularioClientes.UseVisualStyleBackColor = False
        ' 
        ' btFormularioUsuarios
        ' 
        btFormularioUsuarios.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btFormularioUsuarios.BackColor = Color.Peru
        btFormularioUsuarios.FlatStyle = FlatStyle.Popup
        btFormularioUsuarios.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btFormularioUsuarios.Location = New Point(15, 209)
        btFormularioUsuarios.Margin = New Padding(2)
        btFormularioUsuarios.Name = "btFormularioUsuarios"
        btFormularioUsuarios.Size = New Size(255, 33)
        btFormularioUsuarios.TabIndex = 1
        btFormularioUsuarios.Text = "Usuarios"
        btFormularioUsuarios.UseVisualStyleBackColor = False
        ' 
        ' btFormularioProductos
        ' 
        btFormularioProductos.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btFormularioProductos.BackColor = Color.Khaki
        btFormularioProductos.FlatStyle = FlatStyle.Popup
        btFormularioProductos.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btFormularioProductos.Location = New Point(15, 61)
        btFormularioProductos.Margin = New Padding(2)
        btFormularioProductos.Name = "btFormularioProductos"
        btFormularioProductos.Size = New Size(255, 33)
        btFormularioProductos.TabIndex = 1
        btFormularioProductos.Text = "Productos"
        btFormularioProductos.UseVisualStyleBackColor = False
        ' 
        ' btFormularioDetalleVentas
        ' 
        btFormularioDetalleVentas.BackColor = Color.Peru
        btFormularioDetalleVentas.FlatStyle = FlatStyle.Popup
        btFormularioDetalleVentas.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btFormularioDetalleVentas.Location = New Point(15, 172)
        btFormularioDetalleVentas.Margin = New Padding(2)
        btFormularioDetalleVentas.Name = "btFormularioDetalleVentas"
        btFormularioDetalleVentas.Size = New Size(255, 33)
        btFormularioDetalleVentas.TabIndex = 0
        btFormularioDetalleVentas.Text = "Detalle de Ventas"
        btFormularioDetalleVentas.UseVisualStyleBackColor = False
        ' 
        ' btSalir
        ' 
        btSalir.BackColor = Color.LightCyan
        btSalir.FlatStyle = FlatStyle.Popup
        btSalir.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic)
        btSalir.Location = New Point(243, 462)
        btSalir.Name = "btSalir"
        btSalir.Size = New Size(253, 35)
        btSalir.TabIndex = 9
        btSalir.Text = "Salir"
        btSalir.UseVisualStyleBackColor = False
        ' 
        ' FormMenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Purple
        ClientSize = New Size(739, 527)
        Controls.Add(btSalir)
        Controls.Add(Label5)
        Controls.Add(GroupBox4)
        Controls.Add(Label3)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Margin = New Padding(2)
        Name = "FormMenuPrincipal"
        Text = "MenuPrincipal"
        GroupBox1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btReporteExistencias As Button
    Friend WithEvents btReporteExistenciasMinimo As Button
    Friend WithEvents btReporteGanancias As Button
    Friend WithEvents btReporteVentasFecha As Button
    Friend WithEvents btReporteComprasFecha As Button
    Friend WithEvents btReporteProveedores As Button
    Friend WithEvents btReporteClientes As Button
    Friend WithEvents btReporteProductos As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btFormularioDetalleCompras As Button
    Friend WithEvents btFormularioCompras As Button
    Friend WithEvents btFormularioProductos As Button
    Friend WithEvents btFormularioVentas As Button
    Friend WithEvents btFormularioDetalleVentas As Button
    Friend WithEvents btFormularioUsuarios As Button
    Friend WithEvents btFormularioClientes As Button
    Friend WithEvents btFormularioProveedores As Button
    Friend WithEvents btSalir As Button

End Class
