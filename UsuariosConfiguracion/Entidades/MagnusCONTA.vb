Public Class MagnusCONTA
    Private _OID As Integer
    Private _DBConta As String
    Private _Empresa As Integer
    Private _Sistema As Integer
    Private _Autonumerico As Boolean
    Private _EjercicioUno As String
    Private _ManejarFiscal As Boolean
    Private _Catalogo2 As String
    Private _Reubicaciones As Boolean
    Private _PorSucursal As Boolean
    Private _ConceptoNotaCredito As String
    Private _ContrapartidaCancelacion As Boolean
    Private _VistaPrevia As Boolean

    Public Sub New()
        _OID = 0
        _DBConta = ""
        _Empresa = 0
        _Sistema = 0
        _Autonumerico = False
        _EjercicioUno = ""
        _ManejarFiscal = False
        _Catalogo2 = ""
        _Reubicaciones = False
        _PorSucursal = False
        _ConceptoNotaCredito = ""
        _ContrapartidaCancelacion = False
        _VistaPrevia = False
    End Sub

    Public Property OID() As Integer
        Get
            Return Me._OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
        End Set
    End Property

    Public Property DBConta() As String
        Get
            Return Me._DBConta
        End Get
        Set(ByVal value As String)
            _DBConta = value
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

    Public Property Sistema() As Integer
        Get
            Return Me._Sistema
        End Get
        Set(ByVal value As Integer)
            _Sistema = value
        End Set
    End Property

    Public Property Autonumerico() As Boolean
        Get
            Return Me._Autonumerico
        End Get
        Set(ByVal value As Boolean)
            _Autonumerico = value
        End Set
    End Property

    Public Property EjercicioUno() As String
        Get
            Return Me._EjercicioUno
        End Get
        Set(ByVal value As String)
            _EjercicioUno = value
        End Set
    End Property

    Public Property ManejarFiscal() As Boolean
        Get
            Return Me._ManejarFiscal
        End Get
        Set(ByVal value As Boolean)
            _ManejarFiscal = value
        End Set
    End Property

    Public Property Catalogo2() As String
        Get
            Return Me._Catalogo2
        End Get
        Set(ByVal value As String)
            _Catalogo2 = value
        End Set
    End Property

    Public Property Reubicaciones() As Boolean
        Get
            Return Me._Reubicaciones
        End Get
        Set(ByVal value As Boolean)
            _Reubicaciones = value
        End Set
    End Property
    Public Property PorSucursal() As Boolean
        Get
            Return Me._PorSucursal
        End Get
        Set(ByVal value As Boolean)
            _PorSucursal = value
        End Set
    End Property

    Public Property ConceptoNotaCredito() As String
        Get
            Return Me._ConceptoNotaCredito
        End Get
        Set(ByVal value As String)
            _ConceptoNotaCredito = value
        End Set
    End Property

    Public Property ContrapartidaCancelacion() As Boolean
        Get
            Return Me._ContrapartidaCancelacion
        End Get
        Set(ByVal value As Boolean)
            _ContrapartidaCancelacion = value
        End Set
    End Property
    Public Property VistaPrevia() As Boolean
        Get
            Return Me._VistaPrevia
        End Get
        Set(ByVal value As Boolean)
            _VistaPrevia = value
        End Set
    End Property
End Class
