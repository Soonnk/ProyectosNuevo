Public Class PrimaryKey
    Inherits Constraint

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Sub New(nombre As String, ByRef tabla As Tabla, ByRef campo As Campo)
        Me.Nombre = nombre
        Me.SetTabla(tabla)
        Me.Campo = campo
    End Sub

    Public Overrides Function Create() As String
        Dim statement = "ALTER TABLE [" & Tabla.ToString & "]" & Environment.NewLine &
                        vbTab & "ADD CONSTRAINT [" & Nombre & "]" & Environment.NewLine &
                        vbTab & "PRIMARY KEY ([" & Campo.ToString & "]);" & Environment.NewLine

        Return statement
    End Function
End Class
