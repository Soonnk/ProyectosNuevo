Public Class Empresa
    Dim oEmpresa As New Datos.Empresa

    Public Function Cargar() As DataTable
        Try
            Return oEmpresa.Cargar()
        Finally
        End Try
    End Function

    Public Function CargarEmpresa(ByVal _OID As Integer) As Entidades.Empresa
        Return oEmpresa.CargarEmpresas(_OID)
    End Function

    Public Function InsertarEmpresa(ByVal entEmpresa As Entidades.Empresa) As Boolean
        Return oEmpresa.InsertarEmpresa(entEmpresa)
    End Function

    Public Function EditarEmpresa(ByVal entEmpresa As Entidades.Empresa) As Boolean
        Return oEmpresa.EditarEmpresa(entEmpresa)
    End Function

    Dim dImagenes As New Datos.Imagen
    Public Function InsertarImagen(ByRef ms1 As System.IO.MemoryStream) As Boolean
        Try

            Return dImagenes.InsertarImagen(ms1)
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



