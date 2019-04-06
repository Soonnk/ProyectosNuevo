Public Class Habitaciones
    Private id As Integer
    Private descripcion As String
    Private capacidad As Integer
    Private precioPorNoche As Decimal

    Public Sub New(ByVal descripcion As String,
                   ByVal capacidad As Integer,
                   ByVal precioPorNoche As Decimal)
        Me.descripcion = descripcion
        Me.capacidad = capacidad
        Me.precioPorNoche = precioPorNoche
    End Sub
    Public Property FullDescripcion() As String
        Get
            Return Me.descripcion
        End Get
        Set(value As String)
            If value <> "" Then
                descripcion = value
            End If
        End Set
    End Property
    Public Property FullCapacidad() As Integer
        Get
            Return Me.capacidad
        End Get
        Set(value As Integer)
            If value <> "" Then
                capacidad = value
            End If
        End Set
    End Property
    Public Property FullprecioPorNoche() As Decimal
        Get
            Return Me.precioPorNoche
        End Get
        Set(value As Decimal)
            If value <> "" Then
                precioPorNoche = value
            End If
        End Set
    End Property
End Class
