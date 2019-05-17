Public Class MagnusERP
    Dim oMagnusERP As New Datos.MagnusERP


    Public Function CargarEntidadMagnusERP(ByRef _OID As Integer) As Entidades.Sistema
        Return oMagnusERP.CargarEntidadMagnusERP(_OID)
    End Function

End Class
