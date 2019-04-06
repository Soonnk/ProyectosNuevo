Public Class Reservaciones
    Private id As Integer
    Private numeroHabitaciones As Integer
    Private formaPago As String
    Private fechaLlegada As Date
    Private horaLlegada As DateTime
    Private fechaSalida As Date
    Private horaSalida As DateTime
    Private precioTotal As Decimal
     Private atendio As String
    Private estatus As Char
    Private habitacion As Habitaciones
    Private cliente As Clientes
    Public Sub New(ByVal numeroHabitaciones As Integer,
                   ByVal formaPago As String,
                   ByVal fechaLlegada As Date,
                   ByVal horaLlegada As DateTime,
                   ByVal fechaSalida As Date,
                   ByVal horaSalida As DateTime,
                   ByVal precioTotal As Decimal,
                   ByVal atendio As String,
                   ByVal estatus As Char,
                   ByVal habitacion As Habitaciones,
                   ByVal cliente As Clientes
                  )
        Me.numeroHabitaciones = numeroHabitaciones
        Me.formaPago = formaPago
        Me.fechaLlegada = fechaLlegada
        Me.horaLlegada = horaLlegada
        Me.fechaSalida = fechaSalida
        Me.horaSalida = horaSalida
        Me.precioTotal = precioTotal
        Me.atendio = atendio
        Me.estatus = estatus
        Me.habitacion = habitacion
        Me.cliente = cliente
    End Sub

    Public Property FullNumeroHabitaciones() As Integer
        Get
            Return Me.numeroHabitaciones
        End Get
        Set(value As Integer)
            If value <> "" Then
                numeroHabitaciones = value
            End If
        End Set
    End Property
    Public Property FullFormaPago() As String
        Get
            Return Me.formaPago
        End Get
        Set(value As String)
            If value <> "" Then
                formaPago = value
            End If
        End Set
    End Property
    Public Property FullFechaLlegada() As Date
        Get
            Return Me.fechaLlegada
        End Get
        Set(value As Date)
            If value <> "" Then
                fechaLlegada = value
            End If
        End Set
    End Property
    Public Property FullHoraLlegada() As DateTime
        Get
            Return Me.horaLlegada
        End Get
        Set(value As DateTime)
            If value <> "" Then
                horaLlegada = value
            End If
        End Set
    End Property
    Public Property FullFechaSalida() As Date
        Get
            Return Me.fechaSalida
        End Get
        Set(value As Date)
            If value <> "" Then
                fechaSalida = value
            End If
        End Set
    End Property
    Public Property FullHoraSalida() As DateTime
        Get
            Return Me.horaSalida
        End Get
        Set(value As DateTime)
            If value <> "" Then
                horaSalida = value
            End If
        End Set
    End Property
    Public Property FullPrecioTotal() As Decimal
        Get
            Return Me.precioTotal
        End Get
        Set(value As Decimal)
            If value <> "" Then
                precioTotal = value
            End If
        End Set
    End Property
    Public Property FullAtendio() As String
        Get
            Return Me.atendio
        End Get
        Set(value As String)
            If value <> "" Then
                atendio = value
            End If
        End Set
    End Property
    Public Property FullEstatus() As Char
        Get
            Return Me.estatus
        End Get
        Set(value As Char)
            If value <> "" Then
                estatus = value
            End If
        End Set
    End Property
    Public Property FullHabitacion() As Habitaciones
        Get
            Return Me.habitacion
        End Get
        Set(value As Habitaciones)
            habitacion = value
        End Set
    End Property
    Public Property FullCliente() As Clientes
        Get
            Return Me.cliente
        End Get
        Set(value As Clientes)
            cliente = value
        End Set
    End Property
End Class
