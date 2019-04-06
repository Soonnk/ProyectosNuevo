Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class ConexionSQL
    Public Function commandSQL(ByVal query As String) As Boolean
    'Dim cnn As New SqlConnection(cadenaconexion)

    Dim cnn As New SqlConnection(stringConn)
        Dim cmd As SqlCommand
        Try
            cnn.Open()
            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function RegresaDatos(ByVal query As String) As DataTable
        Try
            Dim conexion As String
            Dim dt As New DataTable

            conexion = stringConn()
            If conexion Is String.Empty Then Return Nothing

            adaptador = New SqlDataAdapter(query, stringConn) ' cadenaconexion
            adaptador.SelectCommand.CommandTimeout = 0
            adaptador.Fill(dt)
            Return dt
        Catch ex As SqlException
            MsgBox(ex.Message)
            Return Nothing
        Finally
            adaptador.Dispose()
            adaptador = Nothing

            ' Finally()

        End Try
    End Function

    Public Function commandSQLEscalar(ByVal query As String) As Integer
        Dim clave As Integer
        'Dim cnn As New SqlConnection(cadenaconexion)
        Dim cnn As New SqlConnection(stringConn)
        Dim cmd As SqlCommand
        Try
            cnn.Open()
            cmd = New SqlCommand(query, cnn)
            cmd.CommandTimeout = 0
            cmd.CommandType = CommandType.Text
            clave = CInt(cmd.ExecuteScalar)
            cmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
            Return clave
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function stringConn() As String

        Dim cadena As String

        cadena = "Data Source= .\CNLEHF ;Initial Catalog= CNLEHFDB ;User Id= ESTRATEGA ;Password= 1234 ;pooling=no;"

        Return cadena

    End Function
End Class
