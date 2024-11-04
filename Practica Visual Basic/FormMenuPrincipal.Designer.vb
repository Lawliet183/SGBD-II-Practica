Imports System.Windows.Forms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuPrincipal))
        ToolStrip1 = New ToolStrip()
        ToolStripDropDownButton3 = New ToolStripDropDownButton()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ComprasToolStripMenuItem = New ToolStripMenuItem()
        ProductosToolStripMenuItem = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        ToolStripDropDownButton2 = New ToolStripDropDownButton()
        ComprasPorRangoDeFechaToolStripMenuItem = New ToolStripMenuItem()
        VentasPorRangoDeFechaToolStripMenuItem = New ToolStripMenuItem()
        GananciasToolStripMenuItem = New ToolStripMenuItem()
        ExistenciasAlMinimoToolStripMenuItem = New ToolStripMenuItem()
        ExistenciasToolStripMenuItem = New ToolStripMenuItem()
        ToolStripDropDownButton1 = New ToolStripDropDownButton()
        CatalogoProductosToolStripMenuItem = New ToolStripMenuItem()
        CatalogoClientesToolStripMenuItem = New ToolStripMenuItem()
        CatalogoProveedoresToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(20, 20)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripDropDownButton3, ToolStripDropDownButton2, ToolStripDropDownButton1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1083, 27)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripDropDownButton3
        ' 
        ToolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton3.DropDownItems.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ComprasToolStripMenuItem, ProductosToolStripMenuItem, ProveedoresToolStripMenuItem, UsuariosToolStripMenuItem, VentasToolStripMenuItem})
        ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), Image)
        ToolStripDropDownButton3.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        ToolStripDropDownButton3.Size = New Size(101, 24)
        ToolStripDropDownButton3.Text = "Formularios"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(174, 26)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' ComprasToolStripMenuItem
        ' 
        ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        ComprasToolStripMenuItem.Size = New Size(174, 26)
        ComprasToolStripMenuItem.Text = "Compras"
        ' 
        ' ProductosToolStripMenuItem
        ' 
        ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        ProductosToolStripMenuItem.Size = New Size(174, 26)
        ProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(174, 26)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(174, 26)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(174, 26)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' ToolStripDropDownButton2
        ' 
        ToolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton2.DropDownItems.AddRange(New ToolStripItem() {ComprasPorRangoDeFechaToolStripMenuItem, VentasPorRangoDeFechaToolStripMenuItem, GananciasToolStripMenuItem, ExistenciasAlMinimoToolStripMenuItem, ExistenciasToolStripMenuItem})
        ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), Image)
        ToolStripDropDownButton2.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        ToolStripDropDownButton2.Size = New Size(82, 24)
        ToolStripDropDownButton2.Text = "Reportes"
        ' 
        ' ComprasPorRangoDeFechaToolStripMenuItem
        ' 
        ComprasPorRangoDeFechaToolStripMenuItem.Name = "ComprasPorRangoDeFechaToolStripMenuItem"
        ComprasPorRangoDeFechaToolStripMenuItem.Size = New Size(282, 26)
        ComprasPorRangoDeFechaToolStripMenuItem.Text = "Compras por rango de fecha"
        ' 
        ' VentasPorRangoDeFechaToolStripMenuItem
        ' 
        VentasPorRangoDeFechaToolStripMenuItem.Name = "VentasPorRangoDeFechaToolStripMenuItem"
        VentasPorRangoDeFechaToolStripMenuItem.Size = New Size(282, 26)
        VentasPorRangoDeFechaToolStripMenuItem.Text = "Ventas por rango de fecha"
        ' 
        ' GananciasToolStripMenuItem
        ' 
        GananciasToolStripMenuItem.Name = "GananciasToolStripMenuItem"
        GananciasToolStripMenuItem.Size = New Size(282, 26)
        GananciasToolStripMenuItem.Text = "Ganancias"
        ' 
        ' ExistenciasAlMinimoToolStripMenuItem
        ' 
        ExistenciasAlMinimoToolStripMenuItem.Name = "ExistenciasAlMinimoToolStripMenuItem"
        ExistenciasAlMinimoToolStripMenuItem.Size = New Size(282, 26)
        ExistenciasAlMinimoToolStripMenuItem.Text = "Existencias al minimo"
        ' 
        ' ExistenciasToolStripMenuItem
        ' 
        ExistenciasToolStripMenuItem.Name = "ExistenciasToolStripMenuItem"
        ExistenciasToolStripMenuItem.Size = New Size(282, 26)
        ExistenciasToolStripMenuItem.Text = "Existencias"
        ' 
        ' ToolStripDropDownButton1
        ' 
        ToolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripDropDownButton1.DropDownItems.AddRange(New ToolStripItem() {CatalogoProductosToolStripMenuItem, CatalogoClientesToolStripMenuItem, CatalogoProveedoresToolStripMenuItem})
        ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), Image)
        ToolStripDropDownButton1.ImageTransparentColor = Color.Magenta
        ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        ToolStripDropDownButton1.Size = New Size(90, 24)
        ToolStripDropDownButton1.Text = "Catalogos"
        ' 
        ' CatalogoProductosToolStripMenuItem
        ' 
        CatalogoProductosToolStripMenuItem.Name = "CatalogoProductosToolStripMenuItem"
        CatalogoProductosToolStripMenuItem.Size = New Size(224, 26)
        CatalogoProductosToolStripMenuItem.Text = "Productos"
        ' 
        ' CatalogoClientesToolStripMenuItem
        ' 
        CatalogoClientesToolStripMenuItem.Name = "CatalogoClientesToolStripMenuItem"
        CatalogoClientesToolStripMenuItem.Size = New Size(224, 26)
        CatalogoClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' CatalogoProveedoresToolStripMenuItem
        ' 
        CatalogoProveedoresToolStripMenuItem.Name = "CatalogoProveedoresToolStripMenuItem"
        CatalogoProveedoresToolStripMenuItem.Size = New Size(224, 26)
        CatalogoProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' FormMenuPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1083, 658)
        Controls.Add(ToolStrip1)
        IsMdiContainer = True
        Margin = New Padding(2)
        Name = "FormMenuPrincipal"
        Text = "Menu Principal"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasPorRangoDeFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasPorRangoDeFechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GananciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistenciasAlMinimoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExistenciasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoProveedoresToolStripMenuItem As ToolStripMenuItem

End Class
