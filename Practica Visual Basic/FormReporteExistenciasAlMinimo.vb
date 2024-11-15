﻿Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class FormReporteExistenciasAlMinimo
    Dim conexion As MySqlConnection

    Private Sub FormReporteExistenciasAlMinimo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = FormMenuPrincipal.ConseguirConexion()
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de producto', " &
            "stock_minimo as 'Stock minimo' " &
            "FROM Productos"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)

        InicializarProductos()
    End Sub

    Private Sub btResetear_Click(sender As Object, e As EventArgs) Handles btResetear.Click
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de producto', " &
            "stock_minimo as 'Stock minimo' " &
            "FROM Productos"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
        comboBoxProducto.Text = ""
    End Sub

    Private Sub btExportar_Click(sender As Object, e As EventArgs) Handles btExportar.Click
        ConvertirGridAExcel(DataGridView1)
    End Sub

    Private Sub btOrdenAscendente_Click(sender As Object, e As EventArgs) Handles btOrdenAscendente.Click
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de producto', " &
            "stock_minimo as 'Stock minimo' " &
            "FROM Productos " &
            "ORDER BY stock_minimo asc"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btOrdenDescendente_Click(sender As Object, e As EventArgs) Handles btOrdenDescendente.Click
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de producto', " &
            "stock_minimo as 'Stock minimo' " &
            "FROM Productos " &
            "ORDER BY stock_minimo desc"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Close()
    End Sub

    Private Sub Buscar()
        Dim SQL As String = "SELECT " &
            "nombre as 'Nombre de producto', " &
            "stock_minimo as 'Stock minimo' " &
            "FROM Productos " &
            "WHERE nombre like '" & comboBoxProducto.Text & "%'"

        DataGridView1.DataSource = Cargar_grid(SQL, conexion)
    End Sub

    Private Sub comboBoxProducto_TextChanged(sender As Object, e As EventArgs) Handles comboBoxProducto.TextChanged
        Buscar()
    End Sub

    Private Sub InicializarProductos()
        Dim orden As String = "select nombre from productos"
        Dim campo As String = "nombre"

        Dim dataReader As MySqlDataReader = Nothing
        Try
            Dim comando As New MySqlCommand(orden, conexion)
            dataReader = comando.ExecuteReader()
        Catch ex As Exception
            If dataReader IsNot Nothing And Not dataReader.IsClosed Then
                dataReader.Close()
            End If

            Exit Sub
        End Try

        While dataReader.Read()
            comboBoxProducto.Items.Add(dataReader.GetString(campo))
        End While

        dataReader.Close()
    End Sub
End Class