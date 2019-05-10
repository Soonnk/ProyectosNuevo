Public Class ReportesPuntoVenta
    Private _OID As Integer
    Private _Tipo As String
    Private _Archivo As Byte()
    Private _Nombre As String
    Private _FechaModificacion As Date
    Private _Tienda As Integer

    Public Sub New()
        Me._OID = 0
        Me._Nombre = ""
        Me._Tipo = ""
        Me._Archivo = Nothing
        Me._FechaModificacion = ""
        Me._Tienda = 0
    End Sub

    Public Property OID() As Integer
        Get
            Return Me._OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return Me._Tipo
        End Get
        Set(ByVal value As String)
            _Tipo = value
        End Set
    End Property


    Public Property Archivo() As Byte()
        Get
            Return Me._Archivo
        End Get
        Set(ByVal value As Byte())
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

    Public Property FechaModificacion() As Date
        Get
            Return Me._FechaModificacion
        End Get
        Set(ByVal value As Date)
            _FechaModificacion = value
        End Set
    End Property

    Public Property Tienda() As Integer
        Get
            Return Me._Tienda
        End Get
        Set(ByVal value As Integer)
            _Tienda = value
        End Set
    End Property

End Class
