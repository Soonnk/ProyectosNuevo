Public Class Habitaciones
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Sub Cargar()
        Dim Query As String
        Try
            Query = "SELECT * FROM Habitaciones"
            ds = obj.CargarDatos(Query)
        Finally

        End Try
    End Sub

    Public Function CargarHabitaciones(ByVal _id) As Entidades.Habitaciones
        Dim query As String = "SELECT * FROM Habitaciones WHERE Id = " & _id
        Try
            ds = obj.CargarDatos(query)

            Dim Entidad As New Entidades.Habitaciones
            With ds.Tables("Datos").Rows(0)
                Entidad.Descripcion = .Item("Descripcion")
                Entidad.Capacidad = .Item("Capacidad")
                Entidad.PrecioPorNoche = .Item("Precio por noche")
            End With
            Return Entidad
        Finally

        End Try
    End Function

    Public Function InsertarHabitacion(ByVal entHabitaciones As Entidades.Habitaciones) As Boolean
        Dim Query As String
        Try
            Query = "INSERT INTO Habitaciones (Descripcion, Capacidad, Precio por noche) VALUES ('" & entHabitaciones.Descripcion & "','" & entHabitaciones.Capacidad & "','" & entHabitaciones.PrecioPorNoche & "')"
            Return obj.commandSQL(Query)
        Catch ex As Exception

        End Try


    End Function

    Public Sub UpdateHabitacion()
        Try
            obj.Update()
        Finally
        End Try
    End Sub


    Public Function BorrarHabitacion(ByVal _Id As Integer) As Boolean
        Dim Query As String
        Try
            Query = "DELETE FROM Habitaciones WHERE Id = " & _Id
            obj.commandSQL(Query)

        Catch ex As Exception

        End Try

    End Function
End Class
