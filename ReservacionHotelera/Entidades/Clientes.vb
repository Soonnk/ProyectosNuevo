Public Class Clientes
    Private _id As Integer
    Private _nombre As String
    Private _apellido As String
    Private _direccion As String
    Private _municipio As String
    Private _estado As String
    Private _pais As String
    Private _telefono As String
    Private _correo As String

    Public Sub New()
        Me._id = 0 
        Me._nombre = ""
        Me._apellido = ""
        Me._direccion = ""
        Me._municipio = ""
        Me._estado = ""
        Me._pais = ""
        Me._telefono = ""
        Me._correo = ""
    End Sub

    Public Property Id() As String
        Get
            Return Me._id
        End Get
        Set(value As String)
            If value <> "" Then
                _id = value
            End If
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            If value <> "" Then
                _nombre = value
            End If
        End Set
    End Property
    Public Property Apellido() As String
        Get
            Return Me._apellido
        End Get
        Set(value As String)
            If value <> "" Then
                _apellido = value
            End If
        End Set
    End Property
    Public Property Direccion() As String
        Get
            Return Me._direccion
        End Get
        Set(value As String)
            If value <> "" Then
                _direccion = value
            End If
        End Set
    End Property
    Public Property Municipio() As String
        Get
            Return Me._municipio
        End Get
        Set(value As String)
            If value <> "" Then
                _municipio = value
            End If
        End Set
    End Property
    Public Property Estado() As String
        Get
            Return Me._estado
        End Get
        Set(value As String)
            If value <> "" Then
                estado = value
            End If
        End Set
    End Property
    Public Property Pais() As String
        Get
            Return Me._pais
        End Get
        Set(value As String)
            If value <> "" Then
                _pais = value
            End If
        End Set
    End Property
    Public Property Telefono() As String
        Get
            Return Me._telefono
        End Get
        Set(value As String)
            If value <> "" Then
                _telefono = value
            End If
        End Set
    End Property
    Public Property Correo() As String
        Get
            Return Me._correo
        End Get
        Set(value As String)
            If value <> "" Then
                _correo = value
            End If
        End Set
    End Property

End Class
