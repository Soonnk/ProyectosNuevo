Public Class Tienda
    Dim oTienda As New Datos.Tienda

    Public Function Cargar() As DataTable
        Try
            Return oTienda.CargarPrueba()
        Finally
        End Try
    End Function

    Public Function CargarTienda(ByVal _OID As Integer) As Entidades.Tienda
        Return oTienda.CargarTiendas(_OID)
    End Function

    Public Function InsertarTienda(ByVal entTienda As Entidades.Tienda) As Boolean
        Return oTienda.InsertarTienda(entTienda)
    End Function

    Public Function EditarTienda(ByVal entTienda As Entidades.Tienda) As Boolean
        Return oTienda.EditarTienda(entTienda)
    End Function

    Public Function GetDB() As DataTable
        Try
            Return oTienda.GetDB
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CargarAlmacen() As DataTable
        Try
            Return oTienda.CargarAlmacen()
        Finally
        End Try
    End Function

    Public Function CargarFolioAlmacen(ByVal IdAlmacen As Integer) As DataTable
        Try
            Return oTienda.CargarFolioAlmacen(IdAlmacen)
        Finally
        End Try
    End Function

    Public Function GuardarReportePuntoVenta(ByVal entReporte As Entidades.ReportesPuntoVenta) As Boolean
        Return oTienda.GuardarReportePuntoVenta(entReporte)
    End Function

    Public Function EditarReportePuntoVenta(ByVal entReporte As Entidades.ReportesPuntoVenta) As Boolean
        Return oTienda.EditarReporte(entReporte)
    End Function

    Public Function CargarReportePuntoVenta(ByVal tienda As Integer) As DataTable
        Return oTienda.CargarReportePuntoVenta(tienda)
    End Function

    Public Function CargarEntidadTienda(ByRef _OID As Integer) As Entidades.Sistema
        Return oTienda.CargarEntidadTienda(_OID)
    End Function

    Public Function CargarEmpresas() As DataTable
        Try
            Return oTienda.CargarEmpresa
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
