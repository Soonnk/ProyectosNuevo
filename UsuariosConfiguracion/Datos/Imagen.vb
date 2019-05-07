Public Class Imagen
    Dim sql As New clsSQL
    Public Function InsertarImagen(ByRef ms1 As System.IO.MemoryStream, ByVal id As Integer) As Boolean
        Try
            Dim Query As String = "UPDATE Empresas set Logotipo = @Colosseum WHERE OID = " & id

            Return sql.InsertarImagen(Query, ms1)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function CargarImagen() As DataTable
        Try
            Dim Query As String = "SELECT * FROM imagenes WHERE Id = 1"
            Return sql.RegresarDatos(Query)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarEmpresaImagen(ByRef empresa As Entidades.Empresa, ByRef ms1 As System.IO.MemoryStream) As Boolean
        Dim Query As String
        Dim id = sql.Incrementar("Empresas")

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
            Return sql.commandSQLImagen(Query, ms1)
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

End Class
