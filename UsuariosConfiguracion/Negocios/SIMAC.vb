Public Class SIMAC
    Dim oSimac As New Datos.SIMAC

    Public Function Cargar() As DataTable
        Try
            Return oSimac.CargarInnerJoin()
        Finally
        End Try
    End Function

    Public Function CargarSIMAC(ByVal _OID As Integer) As Entidades.SIMAC
        Return oSimac.CargarSIMAC(_OID)
    End Function

    Public Function InsertarSIMAC(ByVal entSimac As Entidades.SIMAC) As Boolean
        Return oSimac.InsertarSIMAC(entSimac)
    End Function

    Public Function EditarSimac(ByVal entSimac As Entidades.SIMAC) As Boolean
        Return oSimac.EditarSIMAC(entSimac)
    End Function

    Public Function GetDB() As DataTable
        Try
            Return oSimac.GetDB
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function


    Public Function GuardarReporteSIMAC(ByVal entReporte As Entidades.ReporteSIMAC) As Boolean
        Return oSimac.GuardarReporteSIMAC(entReporte)
    End Function

    Public Function EditarReporteSIMAC(ByVal entReporte As Entidades.ReporteSIMAC) As Boolean
        Return oSimac.EditarReporte(entReporte)
    End Function

    Public Function CargarReporteSIMAC(ByVal simac As Integer) As DataTable
        Return oSimac.CargarReporteSIMAC(simac)
    End Function

    Public Function CargarEntidadSIMAC(ByRef _OID As Integer) As Entidades.Sistema
        Return oSimac.CargarEntidadSIMAC(_OID)
    End Function


    Public Function CargarEmpresas() As DataTable
        Try
            Return oSimac.CargarEmpresa
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
