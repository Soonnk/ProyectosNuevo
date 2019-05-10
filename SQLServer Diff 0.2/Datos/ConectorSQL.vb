Imports System.Data.SqlClient
Imports Entidad

Public Class ConectorSQL
    Private _server As String
    Private _user As String
    Private _pass As String
    Private _db As String

    Public ds As New DataSet
    Dim adaptador As SqlDataAdapter

    ''' <summary>
    ''' Prepara un nuevo objeto ConectorSQL con los parametros especificados, esto no crea la conexion SQL, solo permite preparar la capa de datos
    ''' para poder conectarse con el servidor. Por defecto se conctara a la base de datos master a menos que se cambie la propiedad Database
    ''' </summary>
    ''' <param name="server">Servidor con el que se establecera conexión</param>
    ''' <param name="user">Usuario a loguear en el servidor</param>
    ''' <param name="pass">Contraseña a utilizar para logueo</param>
    Public Sub New(
                  ByVal server As String,
                  ByVal user As String,
                  ByVal pass As String)
        _server = server
        _user = user
        _pass = pass
    End Sub

    Public Sub New(
                  ByVal server As String,
                  ByVal user As String,
                  ByVal pass As String,
                  ByVal db As String)
        _server = server
        _user = user
        _pass = pass
        _db = db
    End Sub

    Private Function StringConn() As String
        Dim cadena As String
        If (_db Is Nothing) Then
            cadena = "Data Source= " & _server & ";User id=" & _user & "; Password=" & _pass & " ;pooling=no;Timeout=200;"
        Else
            cadena = "Data Source= " & _server & ";Initial Catalog=" & _db & ";User id=" & _user & "; Password=" & _pass & " ;pooling=no;Timeout=0;"
        End If
        Return cadena
    End Function

    Public Function CargarTablas() As List(Of SQLObject)
        Try
            Dim tablas = New List(Of SQLObject)
            Dim dt As New DataTable

            Dim conn As New SqlConnection(StringConn())
            adaptador = New SqlDataAdapter("SELECT name FROM sys.tables", conn)

            adaptador.Fill(dt)

            For Each r As DataRow In dt.Rows
                tablas.Add(New Tabla(r.Item("name")))
            Next

            For Each t As Tabla In tablas
                t.Campos = New List(Of Campo)
                t.Constraints = New List(Of Constraint)
                t.Indices = New List(Of Index)

                CargarCampos(t)
                CargarConstraints(t)
                CargarIndices(t)
            Next
            adaptador.Dispose()
            conn.Close()

            Return tablas
        Catch e As Exception
            Throw
        End Try
    End Function

    Private Sub CargarCampos(ByRef tabla As Tabla)
        Try
            Dim dt As New DataTable

            Dim conn As New SqlConnection(StringConn())

            Dim query = "SELECT
	            c.name,
	            t.name as 'type',
	            CASE
		            WHEN t.name = 'nvarchar' AND NOT c.max_length=-1 THEN c.max_length/2
		            WHEN t.name = 'varchar' THEN c.max_length
		            ELSE c.max_length
	            END as longitud,
	            c.precision,
	            c.scale,
				c.is_nullable,
                c.is_identity
            FROM sys.all_columns c
            INNER JOIN sys.types t on c.system_type_id = t.user_type_id
            WHERE object_id = OBJECT_ID('" & tabla.Nombre & "')
            ORDER BY name"

            adaptador = New SqlDataAdapter(query, conn)

            adaptador.Fill(dt)

            For Each r As DataRow In dt.Rows
                Dim c = New Campo(r.Item("name"), r.Item("type"), r.Item("longitud"), r.Item("precision"), r.Item("scale"), r.Item("is_nullable"), r.Item("is_identity"))
                c.SetTabla(tabla)
                tabla.Campos.Add(c)
            Next
            adaptador.Dispose()
            conn.Close()
        Catch e As Exception
            Throw
        End Try
    End Sub

    Private Sub CargarConstraints(ByRef tabla As Tabla)
        CargarForeignKeys(tabla)
        CargarDefaults(tabla)
        CargarClavesPrimarias(tabla)
    End Sub

    Private Sub CargarForeignKeys(ByRef tabla As Tabla)
        Try
            Dim dt As New DataTable

            Dim conn As New SqlConnection(StringConn())

            Dim query = "SELECT
	                                o.name as name,
	                                po.name as parent_name,
	                                pc.name as parent_column,
	                                ro.name as reference_name,
	                                rc.name as reference_column
                                FROM sys.foreign_key_columns f
                                INNER JOIN sys.objects o
	                                ON o.object_id = f.constraint_object_id
                                INNER JOIN sys.objects po
	                                ON po.object_id = f.parent_object_id
                                INNER JOIN sys.objects ro
	                                ON ro.object_id = f.referenced_object_id
                                INNER JOIN sys.all_columns pc
	                                ON pc.column_id = f.parent_column_id
	                                AND pc.object_id = f.parent_object_id
                                INNER JOIN sys.all_columns rc
	                                ON rc.column_id = f.referenced_column_id
	                                AND rc.object_id = f.referenced_object_id
                                WHERE f.parent_object_id = OBJECT_ID('" & tabla.ToString & "')"

            adaptador = New SqlDataAdapter(query, conn)

            adaptador.Fill(dt)

            For Each r As DataRow In dt.Rows
                Dim f = New ForeignKey(
                    r.Item("name"),
                    tabla,
                    New Campo(r.Item("parent_column")),
                    New Tabla(r.Item("reference_name")),
                    New Campo(r.Item("reference_column")))
                tabla.Constraints.Add(f)
            Next
            adaptador.Dispose()
            conn.Close()
        Catch e As Exception
            Throw
        End Try
    End Sub

    Private Sub CargarDefaults(ByRef tabla As Tabla)
        Try
            Dim dt As New DataTable

            Dim conn As New SqlConnection(StringConn())

            Dim query = "Select 
	                                d.name as name,
	                                o.name as parent_name,
	                                c.name as column_name,
	                                d.definition as value
                                From sys.default_constraints d
                                INNER JOIN sys.all_columns c
                                	ON  c.column_id = d.parent_column_id
                                	AND c.object_id = d.parent_object_id
                                INNER JOIN sys.objects o
	                                ON d.parent_object_id = o.object_id
                                WHERE d.parent_object_id = OBJECT_ID('" & tabla.ToString & "')"

            adaptador = New SqlDataAdapter(query, conn)

            adaptador.Fill(dt)

            For Each r As DataRow In dt.Rows
                Dim f = New DefaultValue(
                    r.Item("name"),
                    tabla,
                    New Campo(r.Item("column_name")),
                    r.Item("value"))
                tabla.Constraints.Add(f)
            Next
            adaptador.Dispose()
            conn.Close()
        Catch e As Exception
            Throw
        End Try
    End Sub

    Private Sub CargarClavesPrimarias(ByRef tabla As Tabla)
        Try
            Dim dt As New DataTable

            Dim conn As New SqlConnection(StringConn())

            Dim query = "EXEC sp_pkeys '" & tabla.Nombre & "'"

            adaptador = New SqlDataAdapter(query, conn)

            adaptador.Fill(dt)
            For Each r As DataRow In dt.Rows()
                Dim p = New PrimaryKey(r.Item("PK_NAME"), tabla, New Campo(r.Item("COLUMN_NAME")))
                tabla.Constraints.Add(p)
            Next
            adaptador.Dispose()
            conn.Close()
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub CargarIndices(ByRef tabla As Tabla)
        Try
            Dim dt As New DataTable

            Dim conn As New SqlConnection(StringConn())

            Dim query = "SELECT * from sys.indexes WHERE object_id = OBJECT_ID('" & tabla.Nombre & "')  AND is_primary_key = 0 AND type_desc <> 'HEAP'"

            adaptador = New SqlDataAdapter(query, conn)

            adaptador.Fill(dt)
            For Each r As DataRow In dt.Rows()
                Dim i = New Index(r.Item("name"), r.Item("is_unique"), r.Item("type_desc").Equals("CLUSTERED"), tabla)
                tabla.Indices.Add(i)
            Next
            conn.Close()
            adaptador.Dispose()

            For Each i As Index In tabla.Indices
                dt = New DataTable

                conn = New SqlConnection(StringConn())

                query = "SELECT 
                        ic.*,
                        c.name
                    FROM sys.index_columns ic
                    INNER JOIN sys.columns c on c.column_id = ic.column_id
                    	AND c.object_id = ic.object_id
                    WHERE ic.object_id=OBJECT_ID('" & tabla.Nombre & "')
                    	AND index_id = (SELECT index_id from sys.indexes WHERE name = '" & i.Nombre & "')"

                adaptador = New SqlDataAdapter(query, conn)

                adaptador.Fill(dt)
                For Each r As DataRow In dt.Rows()
                    Dim c = New Campo(r.Item("name"))
                    If (r.Item("is_included_column")) Then
                        i.Includes.Add(c)
                    Else
                        i.Campos.Add(c)
                    End If
                Next
                conn.Close()
                adaptador.Dispose()
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Public Function CargarBasesDeDatos() As String()
        Dim conn As New SqlConnection(StringConn)
        Dim query = "SELECT name FROM sys.databases"

        adaptador = New SqlDataAdapter(query, conn)

        Dim dt As New DataTable

        adaptador.Fill(dt)

        Dim databases(dt.Rows.Count - 1) As String
        For i As Integer = 0 To dt.Rows.Count - 1
            databases(i) = dt.Rows(i).Item("name")
        Next
        Return databases
    End Function

    '--------------------------------------Procedimientos de encapsulado-------------------------------------------------
    Public Property User() As String
        Get
            Return Me._user
        End Get
        Set(value As String)
            Me._user = value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return Me._pass
        End Get
        Set(value As String)
            Me._pass = value
        End Set
    End Property

    Public Property Server() As String
        Get
            Return Me._server
        End Get
        Set(value As String)
            Me._server = value
        End Set
    End Property

    Public Property Database() As String
        Get
            Return Me._db
        End Get
        Set(value As String)
            Me._db = value
        End Set
    End Property

    '--------------------------------------Procedimientos Estáticos------------------------------------------------------

    ''' <summary>
    ''' Consulta en el Registro todas las instancias de SQL Server que se encuentran instaladas
    ''' </summary>
    ''' <returns>String() con los nombres de las instancias</returns>
    Public Shared Function GetSQLServerInstances() As String()
        ' Inicializar las matrices a la vez que se declaran.
        Dim instances64Bit As String() = New String() {}
        Dim instances32Bit As String() = New String() {}

        ' Instancias instaladas de SQL Server.
        Dim keyName As String = "HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Microsoft SQL Server"
        Dim value As Object = Microsoft.Win32.Registry.GetValue(keyName, "InstalledInstances", New String() {})
        If (Not value Is Nothing) Then
            ' NO ELIMINAR la verificación Nothing, porque si no existe la clave éste será
            ' el valor que tenga la variable 'value'.
            instances64Bit = DirectCast(value, String())
        End If

        ' Si el sistema operativo es de 64 bits, obtenemos las posibles instancias
        ' instaladas de SQL Server de 32 bits existentes en el subsistema WOW64.
        keyName = "HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Microsoft SQL Server"
        value = Microsoft.Win32.Registry.GetValue(keyName, "InstalledInstances", New String() {})
        If (Not value Is Nothing) Then
            ' NO ELIMINAR la verificación Nothing, porque si no existe la clave éste será
            ' el valor que tenga la variable 'value'.
            instances32Bit = DirectCast(value, String())
        End If

        ' Nombre del equipo
        Dim cn As String = Environment.GetEnvironmentVariable("COMPUTERNAME")

        Dim localInstanceNames As New List(Of String)(instances64Bit)
        localInstanceNames = localInstanceNames.Union(instances32Bit).ToList()

        For n As Int32 = 0 To localInstanceNames.Count - 1
            Dim name As String = localInstanceNames(n)
            If (name.Equals("MSSQLSERVER", StringComparison.OrdinalIgnoreCase)) Then
                localInstanceNames(n) = cn
            Else
                localInstanceNames(n) = IO.Path.Combine(cn, name)
            End If
        Next

        Return localInstanceNames.ToArray()

    End Function
End Class

