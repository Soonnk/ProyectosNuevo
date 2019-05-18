Public Class Empresa
    Private _OID As Integer
    Private _Nombre As String
    Private _Direccion As String
    Private _Colonia As String
    Private _Poblacion As String
    Private _Pais As String
    Private _CP As String
    Private _RFC As String
    Private _Giro As String
    Private _Telefono As String
    Private _Logotipo As Byte
    Private _Estatus As Boolean
    Public Sub New()
        Me._OID = 1
        Me._Nombre = ""
        Me._Direccion = ""
        Me._Colonia = ""
        Me._Poblacion = ""
        Me._Pais = ""
        Me._CP = ""
        Me._RFC = ""
        Me._Giro = ""
        Me.Telefono = ""
        Me._Logotipo = 0
        Me._Estatus = True
    End Sub

    'Private _Logotipo() As Byte
    Public Property Logotipo() As Byte
        Get
            Return Me._Logotipo
        End Get
        Set(ByVal value As Byte)
            _Logotipo = value
        End Set
    End Property

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

    Public Property Direccion() As String
        Get
            Return Me._Direccion
        End Get
        Set(ByVal value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Colonia() As String
        Get
            Return Me._Colonia
        End Get
        Set(ByVal value As String)
            _Colonia = value
        End Set
    End Property

    Public Property Poblacion() As String
        Get
            Return Me._Poblacion
        End Get
        Set(ByVal value As String)
            _Poblacion = value
        End Set
    End Property

    Public Property Pais() As String
        Get
            Return Me._Pais
        End Get
        Set(ByVal value As String)
            _Pais = value
        End Set
    End Property

    Public Property CP() As String
        Get
            Return Me._CP
        End Get
        Set(ByVal value As String)
            _CP = value
        End Set
    End Property

    Public Property RFC() As String
        Get
            Return Me._RFC
        End Get
        Set(ByVal value As String)
            _RFC = value
        End Set
    End Property

    Public Property Giro() As String
        Get
            Return Me._Giro
        End Get
        Set(ByVal value As String)
            _Giro = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Me._Telefono
        End Get
        Set(ByVal value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Estatus() As Boolean
        Get
            Return Me._Estatus
        End Get
        Set(ByVal value As Boolean)
            _Estatus = value
        End Set
    End Property

End Class
