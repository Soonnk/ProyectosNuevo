Public Class Sistema
    Dim oSistema As New Datos.Sistema

    Public Function Cargar() As DataTable
        Try
            Return oSistema.CargarPrueba()
        Finally
        End Try
    End Function

    Public Function CargarSistema(ByVal _OID As Integer) As Entidades.Sistema
        Return oSistema.CargarSistema(_OID)
    End Function

    Public Function InsertarSistema(ByVal entSistema As Entidades.Sistema) As Boolean
        Return oSistema.InsertarSistema(entSistema)
    End Function

    Public Function EditarSistema(ByVal entSistema As Entidades.Sistema) As Boolean
        Return oSistema.EditarSistema(entSistema)
    End Function
End Class
