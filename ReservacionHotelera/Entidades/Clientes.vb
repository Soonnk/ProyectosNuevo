Public Class Clientes
    Private id As Integer
    Private nombre As String
    Private apellido As String
    Private direccion As String
    Private municipio As String
    Private estado As String
    Private pais As String
    Private telefono As String
    Private correo As String

    Public Sub New(ByVal nombre As String,
                   ByVal apellido As String,
                   ByVal direccion As String,
                   ByVal municipio As String,
                   ByVal estado As String,
                   ByVal pais As String,
                   ByVal telefono As String,
                   ByVal correo As String
                  )
        Me.nombre = nombre
        Me.apellido = apellido
        Me.direccion = direccion
        Me.municipio = municipio
        Me.estado = estado
        Me.pais = pais
        Me.telefono = telefono
        Me.correo = correo
    End Sub

    Public Property FullNombre() As String
        Get
            Return Me.nombre
        End Get
        Set(value As String)
            If value <> "" Then
                nombre = value
            End If
        End Set
    End Property
    Public Property FullApellido() As String
        Get
            Return Me.apellido
        End Get
        Set(value As String)
            If value <> "" Then
                apellido = value
            End If
        End Set
    End Property
    Public Property FullDireccion() As String
        Get
            Return Me.direccion
        End Get
        Set(value As String)
            If value <> "" Then
                direccion = value
            End If
        End Set
    End Property
    Public Property FullMunicipio() As String
        Get
            Return Me.municipio
        End Get
        Set(value As String)
            If value <> "" Then
                municipio = value
            End If
        End Set
    End Property
    Public Property FullEstado() As String
        Get
            Return Me.estado
        End Get
        Set(value As String)
            If value <> "" Then
                estado = value
            End If
        End Set
    End Property
    Public Property FullPais() As String
        Get
            Return Me.pais
        End Get
        Set(value As String)
            If value <> "" Then
                pais = value
            End If
        End Set
    End Property
    Public Property FullTelefono() As String
        Get
            Return Me.telefono
        End Get
        Set(value As String)
            If value <> "" Then
                telefono = value
            End If
        End Set
    End Property
    Public Property FullCorreo() As String
        Get
            Return Me.correo
        End Get
        Set(value As String)
            If value <> "" Then
                correo = value
            End If
        End Set
    End Property

End Class
