Imports Datos
Imports Entidad
Public Class Loader
    Private dbModelo As List(Of SQLObject)
    Private dbDestino As List(Of SQLObject)
    Private conexionModelo As Conexion
    Private conexionDestino As Conexion

    Public Sub New(conModelo As Conexion, conDestino As Conexion)
        Me.conexionModelo = conModelo
        Me.conexionDestino = conDestino

        Try
            With conexionModelo
                Dim conector1 = New ConectorSQL(.Server, .User, .Password, .Database)
                dbModelo = conector1.CargarTablas()
            End With


            With conexionDestino
                Dim conector2 = New ConectorSQL(.Server, .User, .Password, .Database)
                dbDestino = conector2.CargarTablas()
            End With
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public ReadOnly Property Modelo() As List(Of SQLObject)
        Get
            Return dbModelo
        End Get
    End Property
    Public ReadOnly Property Destino() As List(Of SQLObject)
        Get
            Return dbDestino
        End Get
    End Property


    Public Class Conexion
        Private _server As String
        Private _user As String
        Private _pass As String
        Private _db As String

        Public Sub New(server As String,
                       user As String,
                       pass As String)
            Me._server = server
            Me._pass = pass
            Me._user = user
        End Sub
        Public Sub New(server As String,
                       user As String,
                       pass As String,
                       db As String)
            Me._server = server
            Me._pass = pass
            Me._user = user
            Me._db = db
        End Sub

        Public Property Server() As String
            Set(value As String)
                Me._server = value
            End Set
            Get
                Return _server
            End Get
        End Property
        Public Property User() As String
            Set(value As String)
                Me._user = value
            End Set
            Get
                Return _user
            End Get
        End Property
        Public Property Password() As String
            Set(value As String)
                Me._pass = value
            End Set
            Get
                Return _pass
            End Get
        End Property
        Public Property Database() As String
            Set(value As String)
                Me._db = value
            End Set
            Get
                Return _db
            End Get
        End Property
    End Class

    Public Shared Function CargarDatabases(ByRef con As Conexion) As String()
        Dim conector = New ConectorSQL(con.Server, con.User, con.Password)
        Return conector.CargarBasesDeDatos()
    End Function
    Public Shared Function CargarInstanciasLocales() As String()
        Return ConectorSQL.GetSQLServerInstances()
    End Function
End Class
