Public Class MagnusERP
    Dim oMagnusERP As New Datos.MagnusERP


    Public Function CargarEntidadMagnusERP(ByRef _OID As Integer) As Entidades.Sistema
        Return oMagnusERP.CargarEntidadMagnusERP(_OID)
    End Function

    Public Function CargarEmpresas() As DataTable
        Try
            Return oMagnusERP.CargarEmpresa
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
