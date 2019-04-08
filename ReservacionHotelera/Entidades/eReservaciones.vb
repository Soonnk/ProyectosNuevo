Public Class eReservaciones
    Private _id As Integer
    Private _numeroHabitaciones As Integer
    Private _formaPago As String
    Private _fechaLlegada As Date
    Private _horaLlegada As DateTime
    Private _fechaSalida As Date
    Private _horaSalida As DateTime
    Private _precioTotal As Decimal
    Private _atendio As String
    Private _estatus As Char
    Private _habitacion As eHabitaciones
    Private _cliente As eClientes
    Public Sub New()
        Me._id = 0
        Me._numeroHabitaciones = 0
        Me._formaPago = ""
        Me._fechaLlegada = Today()
        Me._horaLlegada = Now()
        Me._fechaSalida = Today()
        Me._horaSalida = Now()
        Me._precioTotal = 0
        Me._atendio = ""
        Me._estatus = "A"
        Me._habitacion = Nothing
        Me._cliente = Nothing
    End Sub

    Public Property Id() As Integer
        Get
            Return Me._id
        End Get
        Set(ByVal value As Integer)
            If value <> "" Then
                _id = value
            End If
        End Set
    End Property
    Public Property NumeroHabitaciones() As Integer
        Get
            Return Me._numeroHabitaciones
        End Get
        Set(ByVal value As Integer)
            If value <> "" Then
                _numeroHabitaciones = value
            End If
        End Set
    End Property
    Public Property FormaPago() As String
        Get
            Return Me._formaPago
        End Get
        Set(ByVal value As String)
            If value <> "" Then
                _formaPago = value
            End If
        End Set
    End Property
    Public Property FechaLlegada() As Date
        Get
            Return Me._fechaLlegada
        End Get
        Set(ByVal value As Date)
            If value <> "" Then
                _fechaLlegada = value
            End If
        End Set
    End Property
    Public Property HoraLlegada() As DateTime
        Get
            Return Me._horaLlegada
        End Get
        Set(ByVal value As DateTime)
            If value <> "" Then
                _horaLlegada = value
            End If
        End Set
    End Property
    Public Property FechaSalida() As Date
        Get
            Return Me._fechaSalida
        End Get
        Set(ByVal value As Date)
            If value <> "" Then
                _fechaSalida = value
            End If
        End Set
    End Property
    Public Property HoraSalida() As DateTime
        Get
            Return Me._horaSalida
        End Get
        Set(ByVal value As DateTime)
            If value <> "" Then
                _horaSalida = value
            End If
        End Set
    End Property
    Public Property PrecioTotal() As Decimal
        Get
            Return Me._precioTotal
        End Get
        Set(ByVal value As Decimal)
            If value <> "" Then
                _precioTotal = value
            End If
        End Set
    End Property
    Public Property Atendio() As String
        Get
            Return Me._atendio
        End Get
        Set(ByVal value As String)
            If value <> "" Then
                _atendio = value
            End If
        End Set
    End Property
    Public Property Estatus() As Char
        Get
            Return Me._estatus
        End Get
        Set(ByVal value As Char)
            If value <> "" Then
                _estatus = value
            End If
        End Set
    End Property
    Public Property Habitacion() As Habitaciones
        Get
            Return Me._habitacion
        End Get
        Set(ByVal value As Habitaciones)
            _habitacion = value
        End Set
    End Property
    Public Property Cliente() As Clientes
        Get
            Return Me._cliente
        End Get
        Set(ByVal value As Clientes)
            _cliente = value
        End Set
    End Property
End Class
