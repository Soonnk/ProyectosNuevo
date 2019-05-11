Imports System.Data
Imports System.Data.SqlClient
Public Class clsSQL
    Public cadenaconexion As String
    Public ds As New DataSet
    Dim adaptador As SqlDataAdapter

    Public Shared Function StringConn() As String
        Dim cadena As String
        Try
            cadena = "Data Source= 192.168.0.112;Initial Catalog=usuariosConfiguracion;User id=magnus3; Password=1234;pooling=no;Timeout=0;"

            Return cadena
        Finally

        End Try
    End Function

    Public Function StringConn2() As String
        Dim cadena As String
        Try
            cadena = "Data Source= 192.168.0.112;Initial Catalog=AMOR_MAGNUS;User id=magnus3; Password=1234;pooling=no;Timeout=0;"

            Return cadena
        Finally

        End Try
    End Function
    Public Function commandSQL(ByVal query As String) As Boolean
        Dim cnn As New SqlConnection(StringConn())
        Dim cmd As SqlCommand
        Try
            cnn.Open()
            cmd = New SqlCommand(query, cnn)
            cmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex)
            Return Nothing
        End Try
    End Function

    Public Function commandSQLImagen(ByVal query As String, ByRef ms1 As System.IO.MemoryStream) As Boolean
        Dim cnn As New SqlConnection(StringConn())
        Dim cmd As SqlCommand
        Try
            cnn.Open()
            cmd = New SqlCommand(query, cnn)
            cmd.Parameters.Add(New SqlParameter("@Colosseum", ms1.GetBuffer()))
            cmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex)
            Return Nothing
        End Try
    End Function

    Public Function commandSQL(ByVal query() As String) As Boolean
        Dim cnn As New SqlConnection(StringConn)
        Dim cmd As New SqlCommand
        Dim tr As SqlTransaction
        Try
            cnn.Open()
            tr = cnn.BeginTransaction(IsolationLevel.ReadCommitted)

            For intIndex As Integer = 0 To query.Length - 1
                cmd = New SqlCommand(query(intIndex), cnn, tr)
                cmd.ExecuteNonQuery()
            Next
            tr.Commit()
            Return True
        Catch ex As Exception
            tr.Rollback()
            Return Nothing
        Finally
            cnn.Close()
            cnn.Dispose()
        End Try
    End Function

    Public Function CargarDatos(ByVal query As String) As DataSet
        Try
            adaptador = New SqlDataAdapter(query, StringConn)
            adaptador.Fill(ds, "Datos")
            Return ds
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function RegresarDatos(ByVal query As String) As DataTable
        Try
            Dim dt As New DataTable
            adaptador = New SqlDataAdapter(query, StringConn)
            adaptador.Fill(dt)
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function RegresarDatosMagnus(ByVal query As String) As DataTable
        Try
            Dim dt As New DataTable
            adaptador = New SqlDataAdapter(query, StringConn2)
            adaptador.Fill(dt)
            Return dt
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub Update()
        Try
            Dim oCmdBuilder As New SqlCommandBuilder(adaptador)
            adaptador = oCmdBuilder.DataAdapter
            adaptador.Update(ds.Tables("Datos"))
        Finally

        End Try
    End Sub
    Public Function Incrementar(ByVal tabla As String) As Integer
        Dim id As Integer
        Try
            Dim dt As New DataTable
            adaptador = New SqlDataAdapter("SELECT MAX(OID) FROM " & tabla, StringConn)
            adaptador.Fill(dt)
            id = CInt(dt.Rows(0).Item(0)) + 1
            Return id

        Catch ex As Exception
            Return id + 1
        End Try
    End Function

    Public Function InsertarImagen(ByVal query As String, ByRef ms1 As System.IO.MemoryStream) As Boolean

        Dim cnn As New SqlConnection(StringConn)
        Dim cmd As SqlCommand
        Try
            cnn.Open()
            cmd = New SqlCommand(query, cnn)
            cmd.Parameters.Add(New SqlParameter("@Colosseum", ms1.GetBuffer()))
            cmd.ExecuteNonQuery()
            cnn.Close()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
