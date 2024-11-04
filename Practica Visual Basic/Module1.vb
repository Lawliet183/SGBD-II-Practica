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

    'Function ConvertirGridAExcel(ByVal Datagridview1 As DataGridView) As Boolean
    '    Dim exApp As New Excel.Application
    '    Dim exLibro As Excel.Workbook
    '    Dim exHoja As Excel.Worksheet

    '    Try
    '        exLibro = exApp.Workbooks.Add
    '        exHoja = exLibro.Worksheets.Add()

    '        ''Numero de Filas y columnas
    '        Dim columnas As Integer = Datagridview1.ColumnCount
    '        Dim filas As Integer = Datagridview1.RowCount
    '        For columna As Integer = 1 To columnas
    '            exHoja.Cells.Item(1, columna) = Datagridview1.Columns(columna - 1).Name.ToString
    '            exHoja.Cells.Item(1, columna).horizontalalignment = 3
    '        Next

    '        For fila As Integer = 0 To filas - 1
    '            For col As Integer = 0 To columnas - 1
    '                exHoja.Cells.Item(fila + 2, col + 1) = Datagridview1.Rows(fila).Cells(col).Value
    '            Next
    '        Next

    '        ''Titulo en negrita alineado al centro y que el tamaño de la columna se ajuste al texto
    '        exHoja.Rows.Item(1).font.bold = 1
    '        exHoja.Rows.Item(1).horizontalalignment = 3
    '        exHoja.Columns.AutoFit()

    '        ''Aplicacion visible
    '        exApp.Application.Visible = True
    '        exHoja = Nothing
    '        exLibro = Nothing
    '        exApp = Nothing
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Exportar a Excel")
    '        Return False
    '    End Try

    '    Return True
    'End Function

End Module
