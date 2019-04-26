Public Class Empresa
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Empresas"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarEmpresas(ByVal _OID) As Entidades.Empresa
        Dim query As String = "SELECT * FROM Empresas WHERE OID = " & _OID
        Try
            Dim oEmpresa As New Entidades.Empresa
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                oEmpresa.Nombre = .Item("Nombre")
                oEmpresa.Direccion = .Item("Direccion")
                oEmpresa.Colonia = .Item("Colonia")
                oEmpresa.Poblacion = .Item("Poblacion")
                oEmpresa.Pais = .Item("Pais")
                oEmpresa.CP = .Item("CP")
                oEmpresa.RFC = .Item("RFC")
                oEmpresa.Giro = .Item("Giro")
                oEmpresa.Telefono = .Item("Telefono")
                oEmpresa.Logotipo = .Item("Logotipo")
                oEmpresa.Estatus = .Item("estatus")
            End With
            Return oEmpresa
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarEmpresa(ByRef empresa As Entidades.Empresa) As Boolean
        Dim Query As String
        Dim id = obj.Incrementar("Empresas")
        Try
            Query = "INSERT INTO Empresas(OID,Nombre,Direccion,
                                            Colonia,Poblacion,Pais,
                                            CP,RFC,Giro,Telefono,
                                            Logotipo,estatus) VALUES 
                                            (" & id & ",'" & empresa.Nombre & "',
                                            '" & empresa.Direccion & "','" & empresa.Colonia & "',
                                            '" & empresa.Poblacion & "', '" & empresa.Pais & "',
                                            '" & empresa.CP & "', '" & empresa.RFC & "',
                                            '" & empresa.Giro & "', '" & empresa.Telefono & "',
                                            '" & empresa.Logotipo & "', '" & empresa.Estatus & "')"
            Return obj.commandSQL(Query)
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

    Public Sub EditarEmpresa()
        Try
            obj.Update()
        Finally
        End Try
    End Sub

End Class
