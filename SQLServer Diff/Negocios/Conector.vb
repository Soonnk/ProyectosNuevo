Imports Datos

Public Class Conector
    Private server As String
    Private user As String
    Private pass As String
    Private db As String


    Public Sub New(ByVal server As String, ByVal user As String, ByVal pass As String)
        Me.server = server
        Me.user = user
        Me.pass = pass
    End Sub

    Public Sub New(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal db As String)
        Me.server = server
        Me.user = user
        Me.pass = pass
        Me.db = db
    End Sub

    Public Function ConsultarTablas() As DataTable
        Dim conn As New ConectorSQL(Me.server, Me.user, Me.pass)
        conn.Database = Me.db

        Dim dt As DataTable = conn.Consultar("Select 'Tabla' as 'objeto', name FROM sysobjects WHERE Type = 'U' ORDER BY name")

        Return dt
    End Function
    Public Function ConsultarCampos(ByVal nombreTabla As String) As DataTable
        Dim conn As New ConectorSQL(server, user, pass)
        conn.Database = db

        Dim dt As DataTable = conn.Consultar(
            "SELECT 
	            'campo' as 'objeto',
	            CONCAT('" & nombreTabla & ".',c.name) as name,
	            t.name as 'type',
	            CASE
		            WHEN t.name = 'nvarchar' AND NOT c.max_length=-1 THEN c.max_length/2
		            WHEN t.name = 'varchar' THEN c.max_length
		            ELSE c.max_length
	            END as longitud,
	            c.precision,
	            c.scale
            FROM sys.all_columns c
            INNER JOIN sys.types t on c.system_type_id = t.user_type_id
            WHERE object_id = (Select id From sysobjects where name = '" & nombreTabla & "')
            ORDER BY name")

        Return dt
    End Function

    Public Function CargarBasesDeDatos() As String()
        Dim conn As New ConectorSQL(Me.server, Me.user, Me.pass)

        Dim dt As DataTable = conn.Consultar("SELECT name FROM sys.databases")

        Dim databases(dt.Rows.Count - 1) As String
        For i As Integer = 0 To dt.Rows.Count - 1
            databases(i) = dt.Rows(i).Item("name")
        Next
        Return databases
    End Function
    '---------------------------------Procedimientos Estáticos--------------------------------------
    Public Shared Function CargarInstanciasLocales() As String()
        Return ConectorSQL.GetSQLServerInstances()
    End Function
End Class
