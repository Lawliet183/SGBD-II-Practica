Imports MySql.Data.MySqlClient

Public Class FormLogin
    Dim conexion As MySqlConnection

    Private Sub btLogin_Click(sender As Object, e As EventArgs) Handles btLogin.Click
        Dim userID As String = ct_userID.Text
        Dim password As String = ct_password.Text

        conexion = Conectar(userID, password)
        If conexion Is Nothing Then
            Application.Exit()
        End If

        Me.Close()
    End Sub

    Friend Function ConseguirConexion()
        Return conexion
    End Function
End Class