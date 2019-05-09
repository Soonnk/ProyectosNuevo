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

    Public Function GeneraObjReporte(ByVal FileBytes() As Byte) As Entidades.ReportesPuntoVenta
        Try
            Dim ReportePV As New Entidades.ReportesPuntoVenta()
            If Me.txtTipoReporte.EditValue Is Nothing Then
                MsgBox("No has capturado un tipo", MsgBoxStyle.Exclamation, "Tiendas")
            Else
                ReportePV.Tipo = Me.txtTipoReporte.EditValue
                'ReportePV.Archivo = FileBytes
                ReportePV.Nombre = Me.txtNombreReporte.EditValue
                ReportePV.FechaModificacion = Date.Now
            End If
            Return ReportePV
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
