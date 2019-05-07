Public Class ReportesPuntoVenta
    Private _Tipo As String
    Private _Archivo As String
    Private _Nombre As String
    Private _FechaModificacion As String


    Public Property Tipo() As String
        Get
            Return Me._Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property


    Public Property Archivo() As String
        Get
            Return Me._Archivo
        End Get
        Set(ByVal value As String)
            _Archivo = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me._Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property FechaModificacion() As String
        Get
            Return Me._FechaModificacion
        End Get
        Set(ByVal value As String)
            _FechaModificacion = value
        End Set
    End Property
End Class
