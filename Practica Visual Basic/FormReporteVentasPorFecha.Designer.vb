<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteVentasPorFecha
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
        btFiltrar = New Button()
        btExportar = New Button()
        btSalir = New Button()
        dtp_fechaFin = New DateTimePicker()
        dtp_fechaInicio = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
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
        DataGridView1.Size = New Size(662, 194)
        DataGridView1.TabIndex = 0
        ' 
        ' btFiltrar
        ' 
        btFiltrar.Location = New Point(411, 218)
        btFiltrar.Name = "btFiltrar"
        btFiltrar.Size = New Size(94, 29)
        btFiltrar.TabIndex = 1
        btFiltrar.Text = "Filtrar"
        btFiltrar.UseVisualStyleBackColor = True
        ' 
        ' btExportar
        ' 
        btExportar.Location = New Point(511, 218)
        btExportar.Name = "btExportar"
        btExportar.Size = New Size(125, 29)
        btExportar.TabIndex = 4
        btExportar.Text = "Exportar a Excel"
        btExportar.UseVisualStyleBackColor = True
        ' 
        ' btSalir
        ' 
        btSalir.Location = New Point(460, 284)
        btSalir.Name = "btSalir"
        btSalir.Size = New Size(94, 29)
        btSalir.TabIndex = 6
        btSalir.Text = "Salir"
        btSalir.UseVisualStyleBackColor = True
        ' 
        ' dtp_fechaFin
        ' 
        dtp_fechaFin.CustomFormat = "yyyy-MM-dd"
        dtp_fechaFin.Format = DateTimePickerFormat.Custom
        dtp_fechaFin.Location = New Point(129, 284)
        dtp_fechaFin.Name = "dtp_fechaFin"
        dtp_fechaFin.Size = New Size(250, 27)
        dtp_fechaFin.TabIndex = 7
        ' 
        ' dtp_fechaInicio
        ' 
        dtp_fechaInicio.CustomFormat = "yyyy-MM-dd"
        dtp_fechaInicio.Format = DateTimePickerFormat.Custom
        dtp_fechaInicio.Location = New Point(129, 220)
        dtp_fechaInicio.Name = "dtp_fechaInicio"
        dtp_fechaInicio.Size = New Size(250, 27)
        dtp_fechaInicio.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 225)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 20)
        Label1.TabIndex = 9
        Label1.Text = "Fecha de inicio:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 291)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 20)
        Label2.TabIndex = 10
        Label2.Text = "Fecha de fin:"
        ' 
        ' FormReporteVentasPorFecha
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(662, 355)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dtp_fechaInicio)
        Controls.Add(dtp_fechaFin)
        Controls.Add(btSalir)
        Controls.Add(btExportar)
        Controls.Add(btFiltrar)
        Controls.Add(DataGridView1)
        Name = "FormReporteVentasPorFecha"
        Text = "Reporte de Ventas por rango de fecha"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btFiltrar As Button
    Friend WithEvents btExportar As Button
    Friend WithEvents btSalir As Button
    Friend WithEvents dtp_fechaFin As DateTimePicker
    Friend WithEvents dtp_fechaInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
