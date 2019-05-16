'Consultas a la base de datos en la tabla Configuracion_Magnus
Public Class MagnusERP

    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Configuracion_Magnus"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

End Class
