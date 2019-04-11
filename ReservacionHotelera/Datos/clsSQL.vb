Imports System.Data
Imports System.Data.SqlClient
Public Class clsSQL
    Public cadenaconexion As String
    Public ds As New DataSet
    Dim adaptador As SqlDataAdapter

    Public Function StringConn() As String
        Dim cadena As String
        Try
            cadena = "Data Source=192.168.0.108;Initial Catalog=Hoteles;User id=usuario1; Password=1234"
            Return cadena
        Finally

        End Try
    End Function
    Public Function commandSQL(ByVal query As String) As Boolean
        Dim cnn As New SqlConnection(StringConn)
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
            Dim dt As DataTable
            adaptador = New SqlDataAdapter(query, StringConn)
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
        Try
            Dim dt As DataTable
            adaptador = New SqlDataAdapter("SELECT MAX(id) FROM " & tabla, StringConn)
            adaptador.Fill(dt)

            Return CInt(dt.Rows(0).Item(0)) + 1
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class
