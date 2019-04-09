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

    Public Function CargarCliente(ByVal _id) As Entidades.Clientes
        Dim query As String = "SELECT * FROM Clientes WHERE Id = " & _id
        Try
            ds = obj.CargarDatos(query)

            Dim oEntidad As New Entidades.Clientes
            With ds.Tables("Datos").Rows(0)
                oEntidad.Nombre = .Item("nombre")
                oEntidad.Apellido = .Item("apellido")
                oEntidad.Direccion = .Item("direccion")
                oEntidad.Municipio = .Item("municipio")
                oEntidad.Estado = .Item("estado")
                oEntidad.Pais = .Item("pais")
                oEntidad.Telefono = .Item("Telefono")
                oEntidad.Correo = .Item("correo")
            End With
            Return oEntidad
        Finally


        End Try
    End Function

    Public Function InsertarCliente(ByVal entCliente As Entidades.Clientes) As Boolean
        Dim Query As String
        Try
            Query = "INSERT INTO Cliente(nombre,apellido,direccion,municipio,estado,pais,telefono,correo) VALUES ('" & entCliente.Nombre & "','" & entCliente.Apellido & "','" & entCliente.Direccion & "','" & entCliente.Municipio & "', '" & entCliente.Estado & "','" & entCliente.Pais & "','" & entCliente.Telefono & "', '" & entCliente.Correo & "')"
            Return obj.commandSQL(Query)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub Update()
        Try
            obj.Update()
        Finally
        End Try
    End Sub


    Public Function BorrarCliente(ByVal _id As Integer) As Boolean
        Dim Query As String
        Try
            Query = "DELETE FROM Clientes WHERE Id = " & _id
            obj.commandSQL(Query)

        Catch ex As Exception
            Return Nothing
        End Try
    End Function



End Class
