Public Class Reservaciones
    Private _id As Integer
    Private _formaPago As String
    Private _fechaLlegada As Date
    Private _horaLlegada As DateTime
    Private _fechaSalida As Date
    Private _horaSalida As DateTime
    Private _precioTotal As Decimal
    Private _atendio As String
    Private _estatus As Char
    Private _habitaciones As List(Of Habitaciones)
    Private _cliente As Clientes
    Public Sub New()
        Me._id = 0
        Me._formaPago = ""
        Me._fechaLlegada = Today()
        Me._horaLlegada = Now()
        Me._fechaSalida = Today()
        Me._horaSalida = Now()
        Me._precioTotal = 0
        Me._atendio = ""
        Me._estatus = "A"
        Me._habitaciones = New List(Of Habitaciones)
        Me._cliente = Nothing
    End Sub

    Public Property Id() As Integer
        Get
            Return Me._id
        End Get
        Set(ByVal value As Integer)
            _id = value
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
            _fechaLlegada = value
        End Set
    End Property
    Public Property HoraLlegada() As DateTime
        Get
            Return Me._horaLlegada
        End Get
        Set(ByVal value As DateTime)
            _horaLlegada = value
        End Set
    End Property
    Public Property FechaSalida() As Date
        Get
            Return Me._fechaSalida
        End Get
        Set(ByVal value As Date)
            _fechaSalida = value
        End Set
    End Property
    Public Property HoraSalida() As DateTime
        Get
            Return Me._horaSalida
        End Get
        Set(ByVal value As DateTime)
            _horaSalida = value
        End Set
    End Property
    Public Property PrecioTotal() As Decimal
        Get
            Return Me._precioTotal
        End Get
        Set(ByVal value As Decimal)
            _precioTotal = value
        End Set
    End Property
    Public Property Atendio() As String
        Get
            Return Me._atendio
        End Get
        Set(ByVal value As String)
            _atendio = value
        End Set
    End Property
    Public Property Estatus() As Char
        Get
            Return Me._estatus
        End Get
        Set(ByVal value As Char)
            _estatus = value
        End Set
    End Property
    Public Property Habitacion() As List(Of Habitaciones)
        Get
            Return Me._habitaciones
        End Get
        Set(ByVal value As List(Of Habitaciones))
            _habitaciones = value
        End Set
    End Property
    Public Sub AgregarHabitacion(ByRef habitacion As Habitaciones)
        Me._habitaciones.Add(habitacion)
    End Sub
    Public Sub RemoverHabitacion(ByRef habitacion As Habitaciones)
        Me._habitaciones.Remove(habitacion)
    End Sub
    Public Property Cliente() As Clientes
        Get
            Return Me._cliente
        End Get
        Set(ByVal value As Clientes)
            _cliente = value
        End Set
    End Property
End Class
