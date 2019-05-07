Public Class Imagen
    Dim dImagenes As New Datos.Imagen
    Public Function InsertarImagen(ByRef ms1 As System.IO.MemoryStream, ByVal id As Integer) As Boolean
        Try

            Return dImagenes.InsertarImagen(ms1, id)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function CargarImagen() As DataTable
        Try

            Return dImagenes.CargarImagen
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

End Class
