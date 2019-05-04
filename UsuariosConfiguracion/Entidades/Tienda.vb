Public Class Tienda
    Private _OID As Integer
    Private _Descripcion As String
    Private _IdAlmacen As Integer
    Private _IdFolio As Integer
    Private _Factura As Integer
    Private _BasePuntoVenta As String
    Private _BaseMagnus As String
    Private _ServidorLocal As String
    Private _ServidorRemoto As String
    Private _UsuarioLocal As String
    Private _UsuarioRemoto As String
    Private _PasswordLocal As String
    Private _PasswordRemoto As String
    Private _DynDns As String
    Private _PrecioMinimoVenta As String
    Private _FacturarPrecioMinimo As Boolean
    Private _Empresa As Integer
    Private _MuestraExistencia As Boolean

    Public Sub New()
        Me._OID = 0
        Me._Descripcion = ""
        Me._IdAlmacen = 0
        Me._IdFolio = 0
        Me._Factura = 0
        Me.BasePuntoVenta = ""
        Me.BaseMagnus = ""
        Me._ServidorLocal = ""
        Me._ServidorRemoto = ""
        Me._UsuarioLocal = ""
        Me._UsuarioRemoto = ""
        Me._PasswordLocal = ""
        Me._PasswordRemoto = ""
        Me._DynDns = ""
        Me._PrecioMinimoVenta = ""
        Me._FacturarPrecioMinimo = True
        Me._Empresa = 1
        Me._MuestraExistencia = True

    End Sub


    Public Property OID() As Integer
        Get
            Return Me._OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return Me._Descripcion
        End Get
        Set(ByVal value As String)
            _Descripcion = value
        End Set
    End Property

    Public Property IdAlmacen() As Integer
        Get
            Return Me._IdAlmacen
        End Get
        Set(ByVal value As Integer)
            _IdAlmacen = value
        End Set
    End Property

    Public Property IdFolio() As Integer
        Get
            Return Me._IdFolio
        End Get
        Set(ByVal value As Integer)
            _IdFolio = value
        End Set
    End Property

    Public Property Factura() As Integer
        Get
            Return Me._Factura
        End Get
        Set(ByVal value As Integer)
            _Factura = value
        End Set
    End Property

    Public Property BasePuntoVenta() As String
        Get
            Return Me._BasePuntoVenta
        End Get
        Set(ByVal value As String)
            _BasePuntoVenta = value
        End Set
    End Property

    Public Property BaseMagnus() As String
        Get
            Return Me._BaseMagnus
        End Get
        Set(ByVal value As String)
            _BaseMagnus = value
        End Set
    End Property

    Public Property ServidorLocal() As String
        Get
            Return Me._ServidorLocal
        End Get
        Set(ByVal value As String)
            _ServidorLocal = value
        End Set
    End Property

    Public Property ServidorRemoto() As String
        Get
            Return Me._ServidorRemoto
        End Get
        Set(ByVal value As String)
            _ServidorRemoto = value
        End Set
    End Property

    Public Property UsuarioLocal() As String
        Get
            Return Me._UsuarioLocal
        End Get
        Set(ByVal value As String)
            _UsuarioLocal = value
        End Set
    End Property

    Public Property UsuarioRemoto() As String
        Get
            Return Me._UsuarioRemoto
        End Get
        Set(ByVal value As String)
            _UsuarioRemoto = value
        End Set
    End Property

    Public Property PasswordLocal() As String
        Get
            Return Me._PasswordLocal
        End Get
        Set(ByVal value As String)
            _PasswordLocal = value
        End Set
    End Property

    Public Property PasswordRemoto() As String
        Get
            Return Me._PasswordRemoto
        End Get
        Set(ByVal value As String)
            _PasswordRemoto = value
        End Set
    End Property

    Public Property DynDns() As String
        Get
            Return Me._DynDns
        End Get
        Set(ByVal value As String)
            _DynDns = value
        End Set
    End Property

    Public Property PrecioMinimoVenta() As String
        Get
            Return Me._PrecioMinimoVenta
        End Get
        Set(ByVal value As String)
            _PrecioMinimoVenta = value
        End Set
    End Property

    Public Property FacturarPrecioMinimo() As Boolean
        Get
            Return Me._FacturarPrecioMinimo
        End Get
        Set(ByVal value As Boolean)
            _FacturarPrecioMinimo = value
        End Set
    End Property

    Public Property Empresa() As Integer
        Get
            Return Me._Empresa
        End Get
        Set(ByVal value As Integer)
            _Empresa = value
        End Set
    End Property

    Public Property MuestraExistencia() As Boolean
        Get
            Return Me._MuestraExistencia
        End Get
        Set(ByVal value As Boolean)
            _MuestraExistencia = value
        End Set
    End Property

End Class




