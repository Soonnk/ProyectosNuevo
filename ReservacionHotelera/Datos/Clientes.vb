Public Class Clientes
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM clientes"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarCliente(ByVal _id) As Entidades.Clientes
        Dim query As String = "SELECT * FROM clientes WHERE idCliente = " & _id
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
        Dim id As Integer = obj.Incrementar("clientes")
        Try
            Query = "INSERT INTO clientes(id,nombre,apellido,direccion,municipio,estado,pais,telefono,correo) VALUES (" & id & ",'" & entCliente.Nombre & "','" & entCliente.Apellido & "','" & entCliente.Direccion & "','" & entCliente.Municipio & "', '" & entCliente.Estado & "','" & entCliente.Pais & "','" & entCliente.Telefono & "', '" & entCliente.Correo & "')"
            Return obj.commandSQL(Query)
        Catch ex As Exception
            MsgBox(ex)
            'Return Nothing
            Return False
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
            Query = "DELETE FROM clientes WHERE idCliente = " & _id
            Return obj.commandSQL(Query)

        Catch ex As Exception
            Return False
        End Try

    End Function



End Class
