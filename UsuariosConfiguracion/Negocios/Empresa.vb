Public Class Empresa
    Dim oEmpresa As New Datos.Empresa

    Public Function Cargar() As DataTable
        Try
            Return oEmpresa.Cargar()
        Finally
        End Try
    End Function

    Public Function CargarEmpresa(ByVal _OID As Integer) As Entidades.Empresa
        Try
            Return oEmpresa.CargarEmpresas(_OID)
        Finally
        End Try
    End Function

    Public Function InsertarEmpresa(ByVal entEmpresa As Entidades.Empresa) As Boolean
        Try
            Return oEmpresa.InsertarEmpresa(entEmpresa)
        Finally
        End Try
    End Function


    Public Sub Update()
        Try
            oEmpresa.ModificarEmpresa()
        Finally
        End Try
    End Sub

End Class

