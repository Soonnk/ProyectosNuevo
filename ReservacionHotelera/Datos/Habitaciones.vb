﻿Public Class Habitaciones
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
        Dim query As String = "SELECT * FROM Habitaciones WHERE Id = " & _id
        Try
            ds = obj.CargarDatos(query)

            Dim hEntidad As New Entidades.Habitaciones
            With ds.Tables("Datos").Rows(0)
                hEntidad.Descripcion = .Item("Descripcion")
                hEntidad.Capacidad = .Item("Capacidad")
                hEntidad.PrecioPorNoche = .Item("Precio por noche")
            End With
            Return hEntidad
        Finally

        End Try
    End Function

    Public Function InsertarHabitacion(ByVal entHabitaciones As Entidades.Habitaciones) As Boolean
        Dim Query As String
        Try
            Query = "INSERT INTO Habitaciones (Descripcion, Capacidad, Precio por noche) VALUES ('" & entHabitaciones.Descripcion & "','" & entHabitaciones.Capacidad & "','" & entHabitaciones.PrecioPorNoche & "')"
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


    Public Function BorrarHabitacion(ByVal _Id As Integer) As Boolean
        Dim Query As String
        Try
            Query = "DELETE FROM Habitaciones WHERE Id = " & _Id
            Return obj.commandSQL(Query)

        Catch ex As Exception
            Return False
        End Try

    End Function
End Class
