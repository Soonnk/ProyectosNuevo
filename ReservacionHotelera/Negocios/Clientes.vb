Public Class Clientes
    Dim oDatos As New Datos.Clientes
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Try
            Return oDatos.Cargar()

        Finally

        End Try
    End Function

    Public Function CargarCliente(ByVal _id) As Entidades.Clientes
        Try
            Return oDatos.CargarCliente(_id)
        Finally

        End Try
    End Function


    Public Function InsertarCliente(ByVal entCliente As Entidades.Clientes) As Boolean
        Try
            Return oDatos.InsertarCliente(entCliente)
        Finally

        End Try
    End Function

    Public Sub Update()
        Try
            oDatos.Update()
        Finally
        End Try

    End Sub

    Public Function BorrarCliente(ByVal _id As Integer) As Boolean
        Try
            Return oDatos.BorrarCliente(_id)
        Finally

        End Try
    End Function

End Class
