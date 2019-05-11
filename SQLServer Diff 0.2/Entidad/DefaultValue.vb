Public Class DefaultValue
    Inherits Constraint

    Private _value As String

    Public Sub New(nombre As String,
                   ByRef tabla As Tabla,
                   ByRef campo As Campo,
                   ByRef value As String)
        Me.Nombre = nombre
        Me.SetTabla(tabla)
        Me.Campo = campo
        Me.Value = value
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Property Value() As String
        Get
            Return _value
        End Get
        Set(value As String)
            _value = value
        End Set
    End Property

    Public Overrides Function Create() As String
        Dim statement As String

        statement = "ALTER TABLE [" & Tabla.ToString & "]" & Environment.NewLine
        statement += vbTab & "ADD CONSTRAINT [" & Nombre & "]" & Environment.NewLine


        statement += vbTab & "DEFAULT " & Value & " FOR [" & Campo.ToString & "]"

        Return statement
    End Function
End Class
