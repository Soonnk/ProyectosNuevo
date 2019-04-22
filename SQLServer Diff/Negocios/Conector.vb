Imports Datos

Public Class Conector
    Private server As String
    Private user As String
    Private pass As String

    Public Sub New(ByVal server As String, ByVal user As String, ByVal pass As String)
        Me.server = server
        Me.user = user
        Me.pass = pass
    End Sub

    Public Function CargarBasesDeDatos() As String()
        Dim conn As New ConectorSQL(Me.server, Me.user, Me.pass)

        Dim dt As DataTable = conn.Consultar("SELECT name FROM sys.databases")

        Dim databases As String() = {}
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
