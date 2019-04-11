Public Class Habitaciones
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Habitaciones"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarHabitaciones(ByVal _id) As Entidades.Habitaciones
        Dim query As String = "SELECT * FROM Habitaciones WHERE id = " & _id
        Try
            ds = obj.CargarDatos(query)

            Dim hEntidad As New Entidades.Habitaciones
            With ds.Tables("Datos").Rows(0)
                hEntidad.Id = .Item("id")
                hEntidad.Descripcion = .Item("descripcion")
                hEntidad.Capacidad = .Item("capacidad")
                hEntidad.PrecioPorNoche = .Item("precioPorNoche")
            End With
            Return hEntidad
        Finally

        End Try
    End Function

    Public Function InsertarHabitacion(ByVal entHabitaciones As Entidades.Habitaciones) As Boolean
        Dim Query As String
        Dim id As Integer = obj.Incrementar("Habitaciones")
        Try
            Query = "INSERT INTO Habitaciones (id, descripcion, capacidad, precioPorNoche) VALUES ('" & entHabitaciones.Id & entHabitaciones.Descripcion & "','" & entHabitaciones.Capacidad & "','" & entHabitaciones.PrecioPorNoche & "')"
            Return obj.commandSQL(Query)
        Catch ex As Exception
            Return False
        End Try


    End Function

    Public Sub UpdateHabitacion()
        Try
            obj.Update()
        Finally
        End Try
    End Sub


    Public Function BorrarHabitacion(ByVal _id As Integer) As Boolean
        Dim Query As String
        Try
            Query = "DELETE FROM Habitaciones WHERE id = " & _id
            Return obj.commandSQL(Query)

        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
