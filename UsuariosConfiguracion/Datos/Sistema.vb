Public Class Sistema
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar()
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM vista_sistemas"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarSistema(ByRef _OID As Integer) As Entidades.Sistema
        Dim query As String = "SELECT * FROM vista_sistemas WHERE id = " & _OID
        Try
            Dim sistema As New Entidades.Sistema
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                sistema.Nombre = .Item("Nombre")
                sistema.Codigo = .Item("Codigo")
                sistema.Serie = .Item("Serie")
                sistema.Activacion = .Item("Activacion")
                sistema.DB = .Item("DB")
                sistema.Empresa = New Entidades.Empresa
                sistema.Empresa.OID = .Item("cveEmpresa")
                sistema.Empresa.Nombre = .Item("Empresa")

            End With
            If (dt.Rows.Count > 0) Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    With dt.Rows(i)
                        Dim empresa As New Entidades.Empresa
                        empresa.OID = .Item("cveEmpresa")
                        empresa.Nombre = .Item("Empresa")
                        sistema.AgregarEmpresa(empresa)
                    End With
                Next
            End If
            Return sistema
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarSistema(ByRef eSistema As Entidades.Sistema) As Boolean
        Dim Query As String
        Dim OID = obj.Incrementar("Sistemas")

        Try
            Query = "INSERT INTO Sistemas(
                                    OID,Nombre,Codigo,Serie,Activacion,DB,Empresa
                                ) VALUES (" & OID & ",'" & eSistema.Nombre & "','" &
                                    eSistema.Codigo & "','" & eSistema.Serie & "','" &
                                    eSistema.Activacion & "','" & eSistema.DB & "'," &
                                    eSistema.Empresa.OID & ")"
            eSistema.OID = OID
            Return obj.commandSQL(Query)
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function




    Public Function EditarSistema(ByRef eSistema As Entidades.Sistema) As Boolean
        Dim Query As String
        With eSistema
            Query = "UPDATE Empresas SET
                                         Nombre = '" & .Nombre & "', Codigo = '" & .Codigo & "',
                                         Serie = '" & .Serie & "', Activacion = '" & .Activacion & "',
                                         DB = '" & .DB & "', Empresa= '" & .Empresa.OID & "'
                                         WHERE OID = " & .OID
        End With
        Return obj.commandSQL(Query)
    End Function


End Class
