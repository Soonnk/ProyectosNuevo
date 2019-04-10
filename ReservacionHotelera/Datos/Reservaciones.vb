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
            Return obj.RegresarDatos(query)
        Catch ex As Exception
            Return Nothing
        Finally

        End Try
    End Function

    Public Function CargarReservacion(ByVal _idReservacion As Integer) As Entidades.Reservaciones
        Dim query As String = "SELECT * FROM v_reservaciones WHERE id = " & _idReservacion

        Try
            Dim r As New Entidades.Reservaciones
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                r.FechaLlegada = .Item("fecha_Llegada")
                r.HoraLlegada = .Item("hora_Llegada")
                r.FechaSalida = .Item("fecha_Salida")
                r.HoraSalida = .Item("hora_Salida")
                r.Atendio = .Item("Atendio")
                r.FormaPago = .Item("Forma_de_Pago")
                r.PrecioTotal = .Item("Cantidad_pagar")

                r.Cliente = New Entidades.Clientes
                r.Cliente.Nombre = .Item("nombre_cliente")
                r.Cliente.Telefono = .Item("telefono_cliente")
                r.Cliente.Correo = .Item("correo_cliente")
            End With
            If (dt.Rows.Count > 0) Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    With dt.Rows(i)
                        Dim habitacion As New Entidades.Habitaciones
                        habitacion.Descripcion = .Item("tipo_habitacion")
                        habitacion.PrecioPorNoche = .Item("costo_habitacion")

                        r.AgregarHabitacion(habitacion)
                    End With
                Next
            End If
            Return r
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarReservacion(ByRef reservacion As Entidades.Reservaciones) As Boolean
        Dim id = obj.Incrementar("reservaciones")

        Dim batch(reservacion.Habitacion.Count) As String
        With reservacion
            Dim insert As String = "INSERT INTO reservaciones(
                                    id,
	                                formaPago,
	                                fechaLlegada,
	                                horaLlegada,
	                                fechaSalida,
	                                horaSalida,
	                                atendio,
	                                estado,
	                                idCliente
                                ) VALUES (" & id & ",'" &
                                    .FormaPago & "','" &
                                    .FechaLlegada & "','" &
                                    .HoraLlegada & "','" &
                                    .FechaSalida & "','" &
                                    .HoraSalida & "'," &
                                    .Atendio & "','" &
                                    .Estatus & "','" &
                                    .Cliente.Id & ")"
            batch(0) = insert

            For i As Integer = 1 To .Habitacion.Count
                batch(i) = "INSERT INTO reservaciones_habitacion VALUES (" & .Id & "," & .Habitacion.ElementAt(i - 1).Id & "," & .Habitacion.ElementAt(i - 1).PrecioPorNoche & ")"
            Next

        End With
        reservacion.Id = id
        Return obj.commandSQL(batch)
    End Function

    Public Function ModificarReservacion(ByRef reservacion As Entidades.Reservaciones) As Boolean
        Dim insert As String
        With reservacion
            insert = "UPDATE reservaciones SET
	                                    formaPago = '" & .FormaPago & "',
	                                    atendio = '" & .Atendio & "',
	                                    estado = '" & .Estatus & "'
                                    WHERE id = " & .Id
        End With

        Return obj.commandSQL(insert)
    End Function
End Class
