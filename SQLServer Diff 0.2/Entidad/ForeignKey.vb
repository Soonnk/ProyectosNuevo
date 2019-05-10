Public Class ForeignKey
    Inherits Constraint

    Private _campoReferencia As Campo
    Private _tablaReferencia As Tabla

    Public Sub New(nombre As String,
                   ByRef tablaPadre As Tabla,
                   ByRef campoPadre As Campo,
                   ByRef tablaReferencia As Tabla,
                   ByRef campoReferencia As Campo)
        Me.Nombre = nombre
        Me.SetTabla(tablaPadre)
        Me.Campo = campoPadre
        Me.TablaReferencia = tablaReferencia
        Me.CampoReferencia = campoReferencia
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Property TablaReferencia() As Tabla
        Get
            Return _tablaReferencia
        End Get
        Set(ByVal value As Tabla)
            _tablaReferencia = value
        End Set
    End Property

    Public Property CampoReferencia() As Campo
        Get
            Return _campoReferencia
        End Get
        Set(ByVal value As Campo)
            _campoReferencia = value
        End Set
    End Property

    Public Overrides Function Create() As String
        Dim statement As String

        statement = "ALTER TABLE [" & Tabla.ToString & "]" & Environment.NewLine
        statement += vbTab & "WITH NOCHECK"
        statement += vbTab & "ADD CONSTRAINT [" & Nombre & "]" & Environment.NewLine
        statement += vbTab & "FOREIGN KEY ([" & Campo.ToString & "]) REFERENCES [" & TablaReferencia.ToString & "]([" & CampoReferencia.ToString & "])" & Environment.NewLine
        statement += "ALTER TABLE [" & Tabla.ToString & "]" & Environment.NewLine
        statement += vbTab & "CHECK CONSTRAINT [" & Nombre & "]"

        Return statement
    End Function

End Class
