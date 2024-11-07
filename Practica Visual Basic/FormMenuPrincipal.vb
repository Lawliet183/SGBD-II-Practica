Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class FormMenuPrincipal
    Dim conexion As MySqlConnection

    ' Accesores (Set-Get)
    Friend Sub AsignarConexion(ByRef nuevaConexion As MySqlConnection)
        conexion = nuevaConexion
    End Sub

    Friend Function ConseguirConexion()
        Return conexion
    End Function


    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim loginBD As New FormLoginBD()
        loginBD.MdiParent = Me
        loginBD.Show()
    End Sub

    Private Sub FormMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Si se establecio una conexion, cerrarla
        If conexion IsNot Nothing Then
            conexion.Close()
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim clientes As New FormClientes
        clientes.MdiParent = Me
        clientes.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim proveedores As New FormProveedores
        proveedores.MdiParent = Me
        proveedores.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim usuarios As New FormUsuarios
        usuarios.MdiParent = Me
        usuarios.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim productos As New FormProductos
        productos.MdiParent = Me
        productos.Show()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Dim compras As New FormCompras
        compras.MdiParent = Me
        compras.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim ventas As New FormVentas
        ventas.MdiParent = Me
        ventas.Show()
    End Sub

    Private Sub CatalogoProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoProductosToolStripMenuItem.Click
        Dim catalogoProductos As New FormCatalogoProductos
        catalogoProductos.MdiParent = Me
        catalogoProductos.Show()
    End Sub

    Private Sub CatalogoClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoClientesToolStripMenuItem.Click
        Dim catalogoClientes As New FormCatalogoClientes
        catalogoClientes.MdiParent = Me
        catalogoClientes.Show()
    End Sub

    Private Sub CatalogoProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoProveedoresToolStripMenuItem.Click
        Dim catalogoVendedores As New FormCatalogoProveedores
        catalogoVendedores.MdiParent = Me
        catalogoVendedores.Show()
    End Sub

    Private Sub ReporteExistenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteExistenciasToolStripMenuItem.Click
        Dim reporteExistencias As New FormReporteExistencias
        reporteExistencias.MdiParent = Me
        reporteExistencias.Show()
    End Sub

    Private Sub ReporteExistenciasAlMinimoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteExistenciasAlMinimoToolStripMenuItem.Click
        Dim reporteExistenciasAlMinimo As New FormReporteExistenciasAlMinimo
        reporteExistenciasAlMinimo.MdiParent = Me
        reporteExistenciasAlMinimo.Show()
    End Sub

    Private Sub ReporteComprasPorRangoDeFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteComprasPorRangoDeFechaToolStripMenuItem.Click
        Dim reporteComprasPorFecha As New FormReporteComprasPorFecha
        reporteComprasPorFecha.MdiParent = Me
        reporteComprasPorFecha.Show()
    End Sub

    Private Sub ReporteVentasPorRangoDeFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasPorRangoDeFechaToolStripMenuItem.Click
        Dim reporteVentasPorFecha As New FormReporteVentasPorFecha
        reporteVentasPorFecha.MdiParent = Me
        reporteVentasPorFecha.Show()
    End Sub

    Private Sub ReporteGananciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteGananciasToolStripMenuItem.Click
        Dim reporteGanancias As New FormReporteGanancias
        reporteGanancias.MdiParent = Me
        reporteGanancias.Show()
    End Sub
End Class