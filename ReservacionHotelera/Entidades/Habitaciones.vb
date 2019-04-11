Public Class Habitaciones
    Private _id As Integer
    Private _descripcion As String
    Private _capacidad As Integer
    Private _precioPorNoche As Decimal

    Public Sub New()
        Me._id = 0
        Me._descripcion = ""
        Me._capacidad = 0
        Me._precioPorNoche = 0
    End Sub
    Public Property Id() As String
        Get
            Return Me._id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return Me._descripcion
        End Get
        Set(ByVal value As String)
            If value <> "" Then
                _descripcion = value
            End If
        End Set
    End Property
    Public Property Capacidad() As Integer
        Get
            Return Me._capacidad
        End Get
        Set(ByVal value As Integer)
            _capacidad = value
        End Set
    End Property
    Public Property PrecioPorNoche() As Decimal
        Get
            Return Me._precioPorNoche
        End Get
        Set(ByVal value As Decimal)
            _precioPorNoche = value
        End Set
    End Property
End Class
