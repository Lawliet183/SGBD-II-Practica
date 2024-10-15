Imports MySql.Data.MySqlClient

Module Module1
    Public Function Conectar(ByVal userID As String, ByVal password As String)
        Dim conexion = New MySqlConnection
        Try
            conexion.ConnectionString = "server=localhost;" &
                "user id=" & userID & ";" &
                "password=" & password & ";" &
                "database=inventario;"

            conexion.Open()
        Catch ex As MySqlException
            MessageBox.Show("No se ha podido realizar la conexion a la base de datos.")
            End
        End Try

        Return conexion
    End Function

    Function Cargar_grid(ByVal sql As String, ByVal conexion As MySqlConnection)
        Dim dataAdapter As New MySqlDataAdapter(sql, conexion)
        Dim dataset As New DataSet
        'llenar el dataset
        dataAdapter.Fill(dataset)

        Return dataset.Tables(0)
    End Function

End Module
