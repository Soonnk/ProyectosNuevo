Public MustInherit Class SQLObject
    Private _nombre As String

    Public Property Nombre() As String
        Set(value As String)
            _nombre = value
        End Set
        Get
            Return _nombre
        End Get
    End Property

    Public MustOverride Function Create() As String

    Public MustOverride Function Drop() As String

    Public Overrides Function ToString() As String
        Return Me._nombre
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        Dim objeto = TryCast(obj, SQLObject)

        If objeto Is Nothing Then
            Return False
        Else
            Return objeto.Nombre.Equals(Me.Nombre)
        End If
    End Function
End Class
