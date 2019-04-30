Public Class Sistema
    Private _OID As Integer
    Private _Nombre As String
    Private _Codigo As String
    Private _Serie As String
    Private _Activacion As String
    Private _DB As String
    Private _Empresa As Integer
    Public Sub New()
        Me._OID = 0
        Me._Nombre = ""
        Me._Codigo = ""
        Me._Serie = ""
        Me._Activacion = ""
        Me._DB = ""
        Me._Empresa = 0
    End Sub

    Public Property OID() As Integer
        Get
            Return Me._OID
        End Get
        Set(ByVal value As Integer)
            _OID = value
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


    Public Property Codigo() As String
        Get
            Return Me._Codigo
        End Get
        Set(ByVal value As String)
            _Codigo = value
        End Set
    End Property

    Public Property Serie() As String
        Get
            Return Me._Serie
        End Get
        Set(ByVal value As String)
            _Serie = value
        End Set
    End Property

    Public Property Activacion() As String
        Get
            Return Me._Activacion
        End Get
        Set(ByVal value As String)
            _Activacion = value
        End Set
    End Property

    Public Property DB() As String
        Get
            Return Me._DB
        End Get
        Set(ByVal value As String)
            _DB = value
        End Set
    End Property


    Public Property Empresa() As Integer
        Get
            Return _Empresa
        End Get
        Set(ByVal value As Integer)
            _Empresa = value
        End Set
    End Property

End Class
