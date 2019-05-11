Public MustInherit Class Constraint
    Inherits SQLObject

    Private _campo As Campo
    Private _tabla As Tabla

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Sub New(nombre As String, columna As Campo, tabla As Tabla)
        Me.Nombre = nombre
        _campo = columna
        _tabla = tabla
    End Sub

    Public Sub New()
    End Sub

    Public Property Campo() As Campo
        Get
            Return _campo
        End Get
        Set(ByVal value As Campo)
            _campo = value
        End Set
    End Property

    Public ReadOnly Property Tabla() As Tabla
        Get
            Return _tabla
        End Get
    End Property
    Public Sub SetTabla(ByRef tabla As Tabla)
        _tabla = tabla
    End Sub

    Public Overrides Function Drop() As String
        Dim statement As String

        statement = "ALTER TABLE [" & Tabla.ToString & "] DROP CONSTRAINT [" & Nombre & "];"

        Return statement
    End Function
End Class
