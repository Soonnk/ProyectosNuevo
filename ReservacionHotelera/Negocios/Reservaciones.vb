Public Class Reservaciones
    Dim dReservacion As New Datos.Reservaciones

    Public Function Consultar() As DataTable
        Return dReservacion.Cargar("")
    End Function
    Public Function CargarReservacion(ByVal id As Integer) As Entidades.Reservaciones
        Return dReservacion.CargarReservacion(id)
    End Function
    Public Function GuardarReservacion(ByVal res As Entidades.Reservaciones) As Boolean
        If (res.Id = Nothing Or res.Id = 0) Then
            Return dReservacion.InsertarReservacion(res)
        Else
            Return dReservacion.ModificarReservacion(res)
        End If
    End Function
End Class
