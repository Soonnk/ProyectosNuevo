Public Class MagnusERP
    Dim oMagnusERP As New Datos.MagnusERP


    Public Function Cargar() As DataTable
        Try
            Return oMagnusERP.CargarInnerJoin

        Finally
        End Try
    End Function

    Public Function CargarMagnusERP(ByVal _OID As Integer) As Entidades.MagnusERP
        Return oMagnusERP.CargarMagnus(_OID)
    End Function

    Public Function InsertarMagnusERP(ByVal eMagnusERP As Entidades.MagnusERP) As Boolean
        Return oMagnusERP.InsertarMagnusERP(eMagnusERP)
    End Function

    Public Function EditarMagnusERP(ByVal entMagnus As Entidades.MagnusERP) As Boolean
        Return oMagnusERP.EditarMagnusERP(entMagnus)
    End Function

    Public Function GetDB() As DataTable
        Try
            Return oMagnusERP.GetDB
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CargarEntidadMagnusERP(ByRef _OID As Integer) As Entidades.Sistema
        Return oMagnusERP.CargarEntidadMagnusERP(_OID)
    End Function

    Public Function CargarEmpresas() As DataTable
        Try
            Return oMagnusERP.CargarEmpresas
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
