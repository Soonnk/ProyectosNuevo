Imports Entidad

Public Class Index
    Inherits SQLObject

    Private _unique As Boolean
    Private _clustered As Boolean
    Private _tabla As Tabla
    Private _campos As List(Of Campo)
    Private _includes As List(Of Campo)

    Public Sub New(nombre As String,
                   ByRef unique As Boolean,
                   ByRef clustered As Boolean,
                   ByRef tabla As Tabla,
                   ByRef campos As List(Of Campo),
                   ByRef includes As List(Of Campo))
        Me.Nombre = nombre
        Me.Unique = unique
        Me.Clustered = clustered
        Me.SetTabla(tabla)
        Me.Campos = campos
        Me.Includes = includes
    End Sub

    Public Sub New(nombre As String,
                   ByRef unique As Boolean,
                   ByRef clustered As Boolean,
                   ByRef tabla As Tabla)
        Me.Nombre = nombre
        Me.Unique = unique
        Me.Clustered = clustered
        Me.SetTabla(tabla)
        Me.Campos = New List(Of Campo)
        Me.Includes = New List(Of Campo)
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
        Me.Campos = New List(Of Campo)
        Me.Includes = New List(Of Campo)
    End Sub

    Public Property Unique() As Boolean
        Set(value As Boolean)
            _unique = value
        End Set
        Get
            Return _unique
        End Get
    End Property
    Public Property Clustered() As Boolean
        Set(value As Boolean)
            _clustered = value
        End Set
        Get
            Return _clustered
        End Get
    End Property
    Public ReadOnly Property Tabla() As Tabla
        Get
            Return _tabla
        End Get
    End Property
    Public Sub SetTabla(ByRef tabla As Tabla)
        Me._tabla = tabla
    End Sub

    Public Property Includes() As List(Of Campo)
        Set(value As List(Of Campo))
            _includes = value
        End Set
        Get
            Return _includes
        End Get
    End Property
    Public Property Campos() As List(Of Campo)
        Set(value As List(Of Campo))
            _campos = value
        End Set
        Get
            Return _campos
        End Get
    End Property
    Public Overrides Function Create() As String
        Dim statement As String
        statement = "CREATE " & IIf(_unique, "UNIQUE ", "") & IIf(_clustered, "CLUSTERED ", "NONCLUSTERED ") & "INDEX [" & Nombre & "]" & Environment.NewLine
        statement += vbTab & "ON [" & Tabla.ToString & "] ("
        For Each c As Campo In _campos
            statement += Environment.NewLine & vbTab & vbTab & "[" & c.Nombre & "],"
        Next
        statement = statement.Substring(0, statement.Length - 1)
        statement += Environment.NewLine & vbTab & ")"
        If (Includes IsNot Nothing AndAlso Includes.Count > 0) Then
            statement += Environment.NewLine & vbTab & "INCLUDE("
            For Each c As Campo In _includes
                statement += Environment.NewLine & vbTab & vbTab & "[" & c.Nombre & "],"
            Next
            statement = statement.Substring(0, statement.Length - 1)
            statement += Environment.NewLine & vbTab & ")"
        End If
        Return statement
    End Function

    Public Overrides Function Drop() As String
        Return "DROP INDEX [" & Nombre & "] ON [" & Tabla.ToString & "]"
    End Function
End Class
