Public Class MagnusCONTA
    Dim oMagnusConta As New Datos.MagnusCONTA

    Public Function Cargar() As DataTable
        Try
            Return oMagnusConta.CargarPrueba()
        Finally
        End Try
    End Function

    Public Function CargarMagnusCONTA(ByVal _OID As Integer) As Entidades.MagnusCONTA
        Return oMagnusConta.CargarMagnusCONTA(_OID)
    End Function

    Public Function InsertarMagnusCONTA(ByVal entMagnusC As Entidades.MagnusCONTA) As Boolean
        Return oMagnusConta.InsertarMagnusCONTA(entMagnusC)
    End Function

    Public Function EditarMagnusCONTA(ByVal entMagnusC As Entidades.MagnusCONTA) As Boolean
        Return oMagnusConta.EditarMagnusCONTA(entMagnusC)
    End Function

    Public Function GetDB() As DataTable
        Try
            Return oMagnusConta.GetDB
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CargarEmpresas() As DataTable
        Try
            Return oMagnusConta.CargarEmpresa
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CargarEntidadMagnusConta(ByRef _OID As Integer) As Entidades.Sistema
        Return oMagnusConta.CargarEntidadMagnusConta(_OID)
    End Function

End Class
