Public Class MagnusCONTA
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Configuracion_Conta"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarMagnusCONTA(ByRef _OID As Integer) As Entidades.MagnusCONTA
        Dim query As String = "SELECT * FROM Configuracion_Conta WHERE OID = " & _OID
        Try
            Dim magnusConta As New Entidades.MagnusCONTA
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                magnusConta.DBConta = .Item("DBConta")
                magnusConta.Empresa = .Item("Empresa")
                magnusConta.Sistema = .Item("Sistema")
                magnusConta.Autonumerico = .Item("Autonumerico")
                magnusConta.EjercicioUno = .Item("EjercicioUno")
                magnusConta.ManejarFiscal = .Item("ManejarFiscal")
                magnusConta.Catalogo2 = .Item("Catalogo2")
                magnusConta.Reubicaciones = .Item("Reubicaciones")
                magnusConta.PorSucursal = .Item("PorSucursal")
                magnusConta.ConceptoNotaCredito = .Item("ConceptoNotaCredito")
                magnusConta.ContrapartidaCancelacion = .Item("ContrapartidaCancelacion")
                magnusConta.VistaPrevia = .Item("VistaPrevia")
            End With
            Return magnusConta
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarMagnusCONTA(ByRef eMagnusC As Entidades.MagnusCONTA) As Boolean
        Dim Query As String
        Dim id = obj.Incrementar("Configuracion_Conta")

        Try
            Query = "INSERT INTO Configuracion_Conta(
                                    OID,DBConta,Empresa,Sistema,Autonumerico,EjercicioUno,ManejarFiscal,
                                    Catalogo2,Reubicaciones,PorSucursal,ConceptoNotaCredito,ContrapartidaCancelacion,
                                    VistaPrevia) 
                                    VALUES (" & id & ",'" & eMagnusC.DBConta & "',
                                    '" & eMagnusC.Empresa & "','" & eMagnusC.Sistema & "',
                                    '" & eMagnusC.Autonumerico & "','" & eMagnusC.EjercicioUno & "',
                                    '" & eMagnusC.ManejarFiscal & "','" & eMagnusC.Catalogo2 & "',
                                    '" & eMagnusC.Reubicaciones & "','" & eMagnusC.PorSucursal & "',
                                    '" & eMagnusC.ConceptoNotaCredito & "','" & eMagnusC.ContrapartidaCancelacion & "',
                                    " & eMagnusC.VistaPrevia & ")"

            Return obj.commandSQL(Query)
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

    Public Function EditarMagnusCONTA(ByRef eMagnusC As Entidades.MagnusCONTA) As Boolean
        Dim Query As String
        With eMagnusC
            Query = "UPDATE Configuracion_Conta SET
                                         DBConta = '" & .DBConta & "', Empresa = '" & .Empresa & "',
                                         Sistema = '" & .Sistema & "', Autonumerico = '" & .Autonumerico & "',
                                         EjercicioUno = '" & .EjercicioUno & "', ManejarFiscal = '" & .ManejarFiscal & "',
                                         Catalogo2 = '" & .Catalogo2 & "', Reubicaciones = '" & .Reubicaciones & "',
                                         PorSucursal = '" & .PorSucursal & "', ConceptoNotaCredito = '" & .ConceptoNotaCredito & "',
                                         ContrapartidaCancelacion = '" & .ContrapartidaCancelacion & "', VistaPrevia= '" & .VistaPrevia & "'
                                         WHERE OID = " & .OID
        End With
        Return obj.commandSQL(Query)
    End Function

    Public Function CargarPrueba()
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT Configuracion_Conta.OID, DBConta,Configuracion_Conta.Empresa, Empresas.Nombre, Sistema, Sistemas.Nombre as sis from Configuracion_Conta inner join
Empresas ON (Configuracion_Conta.Empresa = Empresas.OID) inner join Sistemas ON (Configuracion_Conta.Sistema = Sistemas.OID)"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

End Class
