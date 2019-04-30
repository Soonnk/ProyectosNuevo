Public Class Imagen
    Dim sql As New clsSQL
    Public Function InsertarImagen(ByRef ms1 As System.IO.MemoryStream) As Boolean
        Try
            Dim Query As String = "Insert into imagenes (Id, Imagen) values (1, @Colosseum)"

            Return sql.InsertarImagen(Query, ms1)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function CargarImagen() As DataTable
        Try
            Dim Query As String = "SELECT * FROM imagenes WHERE Id = 1"
            Return sql.RegresarDatos(Query)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
