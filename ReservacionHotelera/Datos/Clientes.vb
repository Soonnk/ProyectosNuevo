Public Class Clientes
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Sub Cargar()
        Dim Query As String
        Try
            Query = "SELECT * FROM Clientes"
            ds = obj.CargarDatos(Query)
        Finally

        End Try
    End Sub

    Public Function InsertarCliente(ByVal entCliente As Entidades.Clientes) As Boolean
        Dim Query As String
        Try
            Query = "INSERT INTO Cliente(nombre,apellido,direccion,municipio,estado,pais,telefono,correo) VALUES ('" & entCliente.Nombre & "','" & entCliente.Apellido & "','" & entCliente.Direccion & "','" & entCliente.Municipio & "', '" & entCliente.Estado & "','" & entCliente.Pais & "','" & entCliente.Telefono & "', '" & entCliente.Correo & "')"
        Catch ex As Exception

        End Try

        Return 0
    End Function

End Class
