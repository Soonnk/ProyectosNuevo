Imports Datos

Public Class Conector
    Private server As String
    Private user As String
    Private pass As String
    Private db As String

    ''' <summary>
    ''' Construye un nuevo Conector que solo permitira consultar en el DefaultSchema del usuario dado hasta que se
    ''' asigne una nueva DB
    ''' </summary>
    ''' <param name="server">DataSource de la conexion</param>
    ''' <param name="user">Usuario para Login</param>
    ''' <param name="pass">Password para Login</param>
    Public Sub New(ByVal server As String, ByVal user As String, ByVal pass As String)
        Me.server = server
        Me.user = user
        Me.pass = pass
    End Sub

    ''' <summary>
    ''' Construye un nuevo Conector con un Schema de inicio dado. Este permitira consultar por las tabla de 
    ''' el Schema y sus campos 
    ''' </summary>
    ''' <param name="server">DataSource de la conexion</param>
    ''' <param name="user">Usuario para Login</param>
    ''' <param name="pass">Password para Login</param>
    ''' <param name="db">Base de datos a conectar</param>
    Public Sub New(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal db As String)
        Me.server = server
        Me.user = user
        Me.pass = pass
        Me.db = db
    End Sub

    ''' <summary>
    ''' Consulta las tablas existentes en la Base de datos correspondiente a esta conexion
    ''' </summary>
    ''' <returns>DataTable con las bases de datos</returns>
    Public Function ConsultarTablas() As DataTable
        Dim conn As New ConectorSQL(Me.server, Me.user, Me.pass)
        conn.Database = Me.db

        Dim dt As DataTable = conn.Consultar("Select 'Tabla' as 'objeto', name FROM sysobjects WHERE Type = 'U' ORDER BY name")

        Return dt
    End Function

    ''' <summary>
    ''' Consulta los campos de una tabla con sus correspondientes Tipos
    ''' </summary>
    ''' <param name="nombreTabla">Nombre de la Tabla que será consultada</param>
    ''' <returns>DataTable con los campos de la Tabla en formato "name","type","longitud","precision","scale"</returns>
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
	            c.scale,
				c.is_nullable,
                is_identity
            FROM sys.all_columns c
            INNER JOIN sys.types t on c.system_type_id = t.user_type_id
            WHERE object_id = (Select id From sysobjects where name = '" & nombreTabla & "')
            ORDER BY name")

        Return dt
    End Function

    Public Function CargarIndexes() As DataTable
        Dim conn As New ConectorSQL(server, user, pass)
        conn.Database = db
        Dim dt = New DataTable
        dt.Columns.Add(New DataColumn("name"))
        dt.Columns.Add(New DataColumn("column"))
        For Each r As DataRow In ConsultarTablas().Rows
            For Each sr As DataRow In conn.Consultar("EXEC sp_helpindex '" & r.Item("name") & "'").Rows()
                dt.Rows.Add(r.Item("name") & "." & sr.Item("index_name"), sr.Item("index_keys"))
            Next
        Next

        Return dt
    End Function

    Public Function CargarForeignKeys() As DataTable
        Dim conn As New ConectorSQL(server, user, pass)
        conn.Database = db
        Dim dt = New DataTable
        dt.Columns.Add(New DataColumn("name"))
        dt.Columns.Add(New DataColumn("primarykey"))
        dt.Columns.Add(New DataColumn("foreignkey"))
        For Each r As DataRow In ConsultarTablas().Rows
            For Each sr As DataRow In conn.Consultar("EXEC sp_fkeys '" & r.Item("name") & "'").Rows()
                dt.Rows.Add(sr.Item("FKTABLE_NAME") & "." & sr.Item("FK_NAME"), sr.Item("PKTABLE_NAME") & "." & sr.Item("PKCOLUMN_NAME"), sr.Item("FKTABLE_NAME") & "." & sr.Item("FKCOLUMN_NAME"))
            Next
        Next

        Return dt
    End Function

    Public Function CargarPrimaryKeys() As DataTable
        Dim conn As New ConectorSQL(server, user, pass)
        conn.Database = db
        Dim dt = New DataTable
        dt.Columns.Add(New DataColumn("name"))
        dt.Columns.Add(New DataColumn("primarykey"))
        For Each r As DataRow In ConsultarTablas().Rows
            For Each sr As DataRow In conn.Consultar("EXEC sp_pkeys '" & r.Item("name") & "'").Rows()
                dt.Rows.Add(sr.Item("TABLE_NAME") & "." & sr.Item("PK_NAME"), sr.Item("TABLE_NAME") & "." & sr.Item("COLUMN_NAME"))
            Next
        Next

        Return dt
    End Function

    Public Function CargarPrimaryKeys(ByVal nombreTabla As String) As DataTable
        Dim conn As New ConectorSQL(server, user, pass)
        conn.Database = db

        Dim dt As DataTable = conn.Consultar("EXEC sp_pkeys '" & nombreTabla & "'")

        Return dt
    End Function

    ''' <summary>
    ''' Consulta las Bases de datos existentes en la instancia de SQLServer Seleccionada
    ''' </summary>
    ''' <returns>Arreglo con los nombres de las Bases de Datos</returns>
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

    ''' <summary>
    ''' Devuelve las Instancias locales Instaladas de SQLServer
    ''' </summary>
    ''' <returns>Arreglo con los nombres de todas las instancias instaladas</returns>
    Public Shared Function CargarInstanciasLocales() As String()
        Return ConectorSQL.GetSQLServerInstances()
    End Function
End Class
