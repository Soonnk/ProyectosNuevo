Public Class Habitaciones
    Dim hDatos As New Datos.Habitaciones
    Public ds As DataSet
    Public Sub Cargar()
        Try
            hDatos.Cargar()
            ds = hDatos.ds
        Finally

        End Try
    End Sub
    Public Function Habitaciones(ByVal _id) As Entidades.Habitaciones
        Try
            Return hDatos.CargarHabitaciones(_id)
        Finally

        End Try
    End Function
    Public Function Insertar(ByVal entHabitaciones As Entidades.Habitaciones) As Boolean
        Try
            Return hDatos.InsertarHabitacion(entHabitaciones)
        Finally

        End Try
    End Function

    Public Sub Update()
        Try
            hDatos.UpdateHabitacion()
        Finally
        End Try

    End Sub

    Public Function Borrar(ByVal _id As Integer) As Boolean
        Try
            Return hDatos.BorrarHabitacion(_id)
        Finally

        End Try
    End Function
End Class
