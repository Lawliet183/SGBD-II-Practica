Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class FormLoginBD
    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim userID As String = ct_userID.Text
        Dim password As String = ct_password.Text
        Dim database As String = ct_BD.Text

        Dim conexion As MySqlConnection = Conectar(userID, password, database)
        If conexion Is Nothing Then
            Application.Exit()
        End If

        FormMenuPrincipal.AsignarConexion(conexion)

        Dim loginUsuario As New FormLoginUsuario()
        loginUsuario.MdiParent = Me.MdiParent
        loginUsuario.Show()

        Me.Close()
    End Sub
End Class