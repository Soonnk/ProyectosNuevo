Public Class Imagen
    Dim sql As New clsSQL
    Public Function InsertarImagen(ByRef ms1 As System.IO.MemoryStream, ByVal id As Integer) As Boolean
        Try
            Dim Query As String = "UPDATE Empresas set Logotipo = @Colosseum WHERE OID = " & id

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
