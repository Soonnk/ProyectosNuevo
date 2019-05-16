'Consultas a la base de datos en la tabla Configuracion_Simac
Public Class SIMAC
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Configuracion_Simac"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

End Class
