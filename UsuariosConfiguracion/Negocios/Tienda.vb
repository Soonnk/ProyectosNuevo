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

End Class
