Imports System.Data.SqlClient

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

    Private Function StringConn() As String
        Dim cadena As String
        If (_db Is Nothing) Then
            cadena = "Data Source= " & _server & ";User id=" & _user & "; Password=" & _pass & " ;pooling=no;Timeout=200;"
        Else
            cadena = "Data Source= " & _server & ";Initial Catalog=" & _db & ";User id=" & _user & "; Password=" & _pass & " ;pooling=no;Timeout=0;"
        End If
        Return cadena
    End Function

    Public Function Consultar(query) As DataTable
        Try
            Dim dt As New DataTable

            Dim conn As New SqlConnection(StringConn())
            adaptador = New SqlDataAdapter(query, conn)

            adaptador.Fill(dt)

            Return dt
        Catch e As Exception
            Throw
        End Try
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
