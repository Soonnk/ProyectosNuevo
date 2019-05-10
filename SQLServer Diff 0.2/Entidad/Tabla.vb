Imports Entidad.SQLObject
Public Class Tabla
    Inherits SQLObject

    Private _campos As List(Of Campo)
    Private _indices As List(Of Index)
    Private _constraints As List(Of Constraint)

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Property Campos() As List(Of Campo)
        Set(value As List(Of Campo))
            _campos = value
        End Set
        Get
            Return _campos
        End Get
    End Property

    Public ReadOnly Property CamposSQLObject() As List(Of SQLObject)
        Get
            Dim lista = New List(Of SQLObject)

            lista.AddRange(_campos)

            Return lista
        End Get
    End Property

    Public Property Indices() As List(Of Index)
        Set(value As List(Of Index))
            _indices = value
        End Set
        Get
            Return _indices
        End Get
    End Property

    Public Property Constraints() As List(Of Constraint)
        Set(value As List(Of Constraint))
            _constraints = value
        End Set
        Get
            Return _constraints
        End Get
    End Property

    Public Overrides Function Create() As String
        Dim statement As String
        statement = "CREATE TABLE [" & Nombre & "]("
        For Each c As Campo In Campos
            statement += Environment.NewLine & vbTab & "[" & c.Nombre & "] " & c.TipoSQL(True) & ","
        Next
        statement = statement.Substring(0, statement.Length - 1)
        statement += ")" & Environment.NewLine & "GO"

        Return statement
    End Function

    Public Overrides Function Drop() As String
        Return "DROP TABLE [" & Nombre & "]"
    End Function

    Public Function Rebuild() As String
        Dim statement As String
        statement = "--RECONSTRUCCION COMPLETA DE LA TABLA [" & Nombre & "]" & Environment.NewLine & Environment.NewLine

        Dim tempName As String
        tempName = "TempTable" & DateTime.Now.ToString("hhmmssfff")

        System.Threading.Thread.Sleep(1)

        statement += "EXEC sp_rename '[" & Nombre & "]', '" & tempName & "', 'OBJECT'" & Environment.NewLine & Environment.NewLine

        statement += Create() & Environment.NewLine

        statement += "SET IDENTITY_INSERT [" & Nombre & "] ON" & Environment.NewLine

        statement += "INSERT INTO [" & Nombre & "] ("

        For Each c As Campo In Campos
            statement += Environment.NewLine & vbTab & "[" & c.Nombre & "],"
        Next
        statement = statement.Substring(0, statement.Length - 1)

        statement += ") SELECT "
        For Each c As Campo In Campos
            statement += Environment.NewLine & vbTab & "[" & c.Nombre & "],"
        Next
        statement = statement.Substring(0, statement.Length - 1)
        statement += " FROM [" & tempName & "]" & Environment.NewLine & Environment.NewLine

        statement += "DROP TABLE [" & tempName & "]"

        Return statement
    End Function
End Class
