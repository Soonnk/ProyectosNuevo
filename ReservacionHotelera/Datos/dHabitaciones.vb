Public Class dHabitaciones
    Dim obj As New clsSQL
    Public dt As DataTable
    Public Sub Cargar()
        Dim Query As String
        Try
            Query = "SELECT * FROM Habitaciones"
            dt = obj.CargarDatos(Query)
        Finally

        End Try
    End Sub

    Public Function CargarHabitaciones(ByVal _IdCliente) As Entidades.eHabitaciones
        Dim query As String = "SELECT * FROM Habitaciones WHERE Id = " & _Id
        Try
            dt = obj.CargarDatos(query)

            Dim hEntidad As New Entidades.eHabitaciones
            With ds.Tables("Datos").Rows(0)
                hEntidad.Descripcion = .Item("Descripcion")
                hEntidad.Capacidad = .Item("Capacidad")
                hEntidad.precioPorNoche = .Item("Precio por noche")
            End With
            Return hEntidad
        Finally

        End Try
    End Function
End Class
