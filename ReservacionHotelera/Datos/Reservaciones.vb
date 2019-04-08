Imports Entidades.Reservaciones

'Clase Datos.Reservaciones proveera una interfaz entre la capa de Negocios y la Base de datos,
'aqui se encontrarán los metodos para hacer insercion, actualizacion y eliminacion de la base de datos
'en la tabla Reservaciones.
Public Class Reservaciones
    Dim obj As New clsSQL

    Public Function Cargar(ByVal filtro As String) As DataTable
        Dim query As String
        If (filtro Is Nothing Or filtro.Equals("")) Then
            query = "SELECT * FROM v_reservaciones"
        Else
            query = "SELECT * FROM v_reservaciones WHERE "
        End If
        Try
            Return obj.CargarDatos(query).Tables("v_reservaciones")
        Catch ex As Exception
            Return Nothing
        Finally

        End Try
    End Function

    Public Function CargarReservacion(ByVal _idReservacion As Integer) As Reservaciones

    End Function
End Class
