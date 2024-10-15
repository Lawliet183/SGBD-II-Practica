Imports MySql.Data.MySqlClient

Public Class FormMenuPrincipal
    Dim conexion As MySqlConnection

    Private Sub Bt_Proveedores_Click(sender As Object, e As EventArgs) Handles btReporteExistencias.Click

    End Sub

    Private Sub FormMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormMenuPrincipal_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.Hide()
        Dim login As FormLogin = New FormLogin()
        login.ShowDialog()
        conexion = FormLogin.ConseguirConexion()
        Me.Activate()
    End Sub
End Class