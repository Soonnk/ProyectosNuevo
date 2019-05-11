Public Class Campo
    Inherits SQLObject

    Private _tabla As Tabla
    Private _tipo As String
    Private _longitud As Integer
    Private _precision As Integer
    Private _escala As Integer
    Private _nullable As Boolean
    Private _identity As Boolean

    Public Sub New(nombre As String, tipo As String, longitud As Integer, precision As Integer, escala As Integer, nullable As Boolean, identity As Boolean)
        Me.Nombre = nombre
        _tipo = tipo
        _longitud = longitud
        _precision = precision
        _escala = escala
        _nullable = nullable
        _identity = identity
    End Sub

    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Sub New()

    End Sub

    Public ReadOnly Property Tabla() As Tabla
        Get
            Return _tabla
        End Get
    End Property
    Public Sub SetTabla(ByRef tabla As Tabla)
        _tabla = tabla
    End Sub

    Public Property Tipo() As String
        Set(value As String)
            _tipo = value
        End Set
        Get
            Return _tipo
        End Get
    End Property

    Public Property Longitud() As Integer
        Set(value As Integer)
            _longitud = value
        End Set
        Get
            Return _longitud
        End Get
    End Property

    Public Property Precision() As Integer
        Set(value As Integer)
            _precision = value
        End Set
        Get
            Return _precision
        End Get
    End Property

    Public Property Escala() As Integer
        Set(value As Integer)
            _escala = value
        End Set
        Get
            Return _escala
        End Get
    End Property

    Public Property Nullable() As Boolean
        Set(value As Boolean)
            _nullable = value
        End Set
        Get
            Return _nullable
        End Get
    End Property

    Public Property Identity() As Boolean
        Set(value As Boolean)
            _identity = value
        End Set
        Get
            Return _identity
        End Get
    End Property

    Public ReadOnly Property TipoSQL(a As Boolean) As String
        Get
            Dim statement As String
            Dim lengthString As String
            lengthString = IIf(Longitud >= 0, Longitud, "max")

            statement = Tipo
            If Tipo.Equals("varchar") Or Tipo.Equals("nvarchar") Or Tipo.Equals("varbinary") Then
                statement += "(" & lengthString & ")"
            ElseIf Tipo.Equals("decimal") Or Tipo.Equals("numeric") Then
                statement += "(" & Precision & "," & Escala & ")"
            End If

            statement += IIf(Nullable, " NULL", " NOT NULL")

            If a AndAlso Identity Then
                statement += " IDENTITY(1,1)"
            End If

            Return statement
        End Get
    End Property

    Public Function BuscarDefault() As String
        For Each d As Constraint In Tabla.Constraints
            If TypeOf d Is DefaultValue Then
                If d.Campo.ToString.Equals(Nombre) Then
                    Return DirectCast(d, DefaultValue).Value
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Function DropCreatedDefault() As String
        Dim statement As String
        statement = "--Desechando Default Constraint recien creada" & Environment.NewLine
        statement = "Declare @a varchar(max)" & Environment.NewLine
        statement += "Set @a = (SELECT name FROM sys.objects WHERE object_id IN (" & Environment.NewLine
        statement += "SELECT default_object_id FROM sys.columns WHERE object_id = OBJECT_ID('" & Tabla.ToString & "')" & Environment.NewLine
        statement += "))" & Environment.NewLine
        statement += "EXEC('ALTER TABLE [" & Tabla.ToString & "] DROP CONSTRAINT [' + @a + ']')"

        Return statement
    End Function

    Public Overrides Function Create() As String
        Dim statement As String

        statement = "ALTER TABLE [" & Tabla.ToString & "]" & Environment.NewLine
        statement += vbTab & "ADD [" & Nombre & "] "

        If Tipo.Equals("varchar") Or Tipo.Equals("nvarchar") Or Tipo.Equals("varbinary") Then
            statement += Tipo & "(" & IIf(Longitud > 0, Longitud, "max") & ") "
        ElseIf Tipo.Equals("decimal") Or Tipo.Equals("numeric") Then
            statement += Tipo & "(" & Precision & "," & Escala & ") "
        Else
            statement += Tipo & " "
        End If

        If Identity Then
            statement += "IDENTITY(1,1) "
        End If

        If Nullable And Not Identity Then
            statement += "NULL "
        Else
            If Not Nullable And Not Identity Then
                Dim def = BuscarDefault()
                If def IsNot Nothing Then
                    statement += "NOT NULL DEFAULT (" & def & ")" & Environment.NewLine
                    statement += DropCreatedDefault()
                Else
                    Throw New Exception("No se puede crear campo NOT NULL sin un default")
                End If
            End If
        End If
        Return statement
    End Function

    Public Overrides Function Drop() As String
        Return "ALTER TABLE [" & Tabla.ToString & "] DROP COLUMN [" & Nombre & "]"
    End Function

    Public Function Alter() As String
        Dim statement As String = ""
        If Not Nullable Then
            statement += "Print 'ATENCION: SE CAMBIARAN VALORES NULL DE LA COLUMNA " & Tabla.ToString & "].[" & Nombre & "] PARA PODER ESTABLECER NOT NULL'" & Environment.NewLine
            statement += "UPDATE [" & Tabla.ToString & "] SET [" & Nombre & "] = 0 WHERE [" & Nombre & "] = NULL" & Environment.NewLine
        End If
        statement += "ALTER TABLE [" & Tabla.ToString & "]" & Environment.NewLine
        statement += vbTab & "ALTER COLUMN [" & Nombre & "] " & TipoSQL(False)

        Return statement
    End Function

    Public Function DropIdentity() As String
        Dim statement As String
        Dim tempName As String

        tempName = "TempColumn" & DateTime.Now.ToString("hhmmssfff")

        System.Threading.Thread.Sleep(1)

        statement = "ALTER TABLE [" & Tabla.ToString & "] ADD [" & tempName & "] " & TipoSQL(True) & IIf(Not Nullable, " DEFAULT (0)", "") & Environment.NewLine &
                    "GO" & Environment.NewLine

        statement += "UPDATE [" & Tabla.ToString & "] SET [" & tempName & "] = [" & Nombre & "]" & Environment.NewLine

        statement += Drop() & Environment.NewLine

        statement += IIf(Not Nullable, DropCreatedDefault() & Environment.NewLine, "")

        statement += "EXEC sp_rename '[" & Tabla.Nombre & "].[" & tempName & "]', '" & Nombre & "', 'COLUMN'"

        Return statement
    End Function
End Class
