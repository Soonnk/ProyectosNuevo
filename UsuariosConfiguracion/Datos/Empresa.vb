﻿'Consultas a la base de datos en la tabla empresas
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
                oEmpresa.Estatus = .Item("activo")
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
                                            Logotipo,activo) VALUES 
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


    Public Function EditarEmpresa(ByRef empresa As Entidades.Empresa) As Boolean
        Dim Query As String
        With empresa
            Query = "UPDATE Empresas SET
                                         Nombre = '" & .Nombre & "', Direccion = '" & .Direccion & "',
                                         Colonia = '" & .Colonia & "', Poblacion = '" & .Poblacion & "',
                                         Pais = '" & .Pais & "', CP= '" & .CP & "', RFC = '" & .RFC & "',
                                         Giro= '" & .Giro & "', Telefono= '" & .Telefono & "',
                                         Logotipo = '" & .Logotipo & "',activo= '" & .Estatus & "'
                                         WHERE OID = " & .OID
        End With
        Return obj.commandSQL(Query)
    End Function

    Public Function InsertarEmpresaImagen(ByRef empresa As Entidades.Empresa, ByRef ms1 As System.IO.MemoryStream) As Boolean
        Dim Query As String
        Dim id = obj.Incrementar("Empresas")

        Try
            Query = "INSERT INTO Empresas(OID,Nombre,Direccion,
                                            Colonia,Poblacion,Pais,
                                            CP,RFC,Giro,Telefono,
                                            Logotipo,activo) VALUES 
                                            (" & id & ",'" & empresa.Nombre & "',
                                            '" & empresa.Direccion & "','" & empresa.Colonia & "',
                                            '" & empresa.Poblacion & "', '" & empresa.Pais & "',
                                            '" & empresa.CP & "', '" & empresa.RFC & "',
                                            '" & empresa.Giro & "', '" & empresa.Telefono & "',
                                            @Colosseum, '" & empresa.Estatus & "')"
            Return obj.commandSQLImagen(Query, ms1)
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function
End Class


