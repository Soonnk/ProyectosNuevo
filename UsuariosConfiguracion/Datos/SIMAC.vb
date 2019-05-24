'Consultas a la base de datos en la tabla Configuracion_Simac
Imports System.Data.SqlClient
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

    Public Function CargarSIMAC(ByRef _OID As Integer) As Entidades.SIMAC
        Dim query As String = "SELECT * FROM Configuracion_Simac WHERE OID = " & _OID
        Try
            Dim simac As New Entidades.SIMAC
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                simac.SistemaAdmon = .Item("SistemaAdmon")
                simac.Empresa = .Item("Empresa")
                simac.ProductoTerminado = .Item("ProductoTerminado")
                simac.MateriaPrima = .Item("MateriaPrima")
                simac.MateriaTalla = .Item("MateriaTalla")
                simac.Fracciones = .Item("Fracciones")
                simac.Procesos = .Item("Procesos")
                simac.Modelos = .Item("Modelos")
                simac.Tabla1 = .Item("Tabla1")
                simac.Tabla2 = .Item("Tabla2")
                simac.Tabla3 = .Item("Tabla3")
                simac.Tabla4 = .Item("Tabla4")
                simac.Tabla5 = .Item("Tabla5")
                simac.Tabla6 = .Item("Tabla6")
                simac.FolioPedidoA = .Item("FolioPedidoA")
                simac.FolioPedidoB = .Item("FolioPedidoB")
                simac.FolioOrdenA = .Item("FolioOrdenA")
                simac.FolioOrdenB = .Item("FolioOrdenB")
                simac.CantAvance = .Item("CantAvcance")
                simac.AutoAvance = .Item("AutoAvance")
                simac.FechaAvance = .Item("FechaAvance")
                simac.MultiAlmacen = .Item("MultiAlmacen")
                simac.MaterialAlmacen = .Item("MaterialAlmacen")
                simac.ProductoAlmacen = .Item("ProductoAlmacen")
                simac.MaxLote = .Item("MaxLote")
                simac.Reporte = .Item("Reporte")
                simac.Sistema = .Item("Sistema")
                simac.DBSimac = .Item("DBSimac")
                simac.ProgBase = .Item("ProgBase")
                simac.ValidaUnidad = .Item("ValidaUnidad")
                simac.AutPedido = .Item("AutPedido")
                simac.DestajosAvance = .Item("DestajosAvance")
                simac.ValidadSuPedido = .Item("ValidadSuPedido")
                simac.EntregaParcial = .Item("EntregaParcial")
                simac.CalculoDesperdicio = .Item("CalculoDesperdicio")
                simac.ManejaTenerias = .Item("ManejaTenerias")
                simac.PedProdAutorizado = .Item("PedProdAutorizado")
                simac.MinutosSemanales = .Item("MinutosSemanales")
                simac.hcCarga = .Item("hcCarga")
                simac.hcDerivados = .Item("hcDerivados")
                simac.hcFormulas = .Item("hcFormulas")
                simac.hcMateriales = .Item("hcMaterialess")
                simac.rptFormulas = .Item("rptFormulas")
                simac.avancePorProceso = .Item("avancePorProceso")
                simac.dividirLote = .Item("dividirLote")
                simac.avanceNoValidarProg = .Item("avanceNoValidarProg")
                simac.rptPreasignacion = .Item("rptPreasignacion")
                simac.Tabla7 = .Item("Tabla7")
                simac.Tabla8 = .Item("Tabla8")
                simac.Tabla9 = .Item("Tabla9")
                simac.Tabla10 = .Item("Tabla10")
                simac.Tabla11 = .Item("Tabla11")
                simac.Tabla12 = .Item("Tabla12")
                simac.rptExplosionFormulas = .Item("rptExplosionFormulas")
                simac.editarCantidadDestajo = .Item("editarCantidadDestajo")
                simac.editarCostoDestaje = .Item("editarCostoDestaje")
            End With
            Return simac
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarSIMAC(ByRef simac As Entidades.SIMAC) As Boolean
        Dim Query As String
        'Dim id = obj.Incrementar("Configuracion_Conta")

        Try
            Query = "INSERT INTO Configuracion_Simac(SistemaAdmon, Empresa, 
                                                    ProductoTerminado, MateriaPrima,
                                                    MateriaTalla, Fracciones,
                                                    Procesos,Modelos,
                                                    Tabla1,Tabla2,
                                                    Tabla3,Tabla4,
                                                    Tabla5,Tabla6,
                                                    FolioPedidoA,FolioPedidoB,
                                                    FolioOrdenA,FolioOrdenB,
                                                    CantAvance,AutoAvance,
                                                    FechaAvance,MultiAlmacen,
                                                    MaterialAlmacen,ProductoAlmacen,
                                                    MaxLote,
                                                    Sistema,DBSimac,
                                                    ProgBase,ValidaUnidad,
                                                    AutPedido,DestajosAvance,
                                                    ValidadSuPedido,EntregaParcial,
                                                    CalculoDesperdicio,ManejaTenerias,
                                                    PedProdAutorizado,MinutosSemanales,
                                                    hcCarga,hcDerivados,
                                                    hcFormulas,hcMateriales,
                                                    rptFormulas,avancePorProceso,
                                                    dividirLote,avanceNoValidarProg, 
                                                    rptPreasignacion,Tabla7,
                                                    Tabla8,Tabla9,
                                                    Tabla10,Tabla11,
                                                    Tabla12,rptExplosionFormulas,
                                                    editarCantidadDestajo,editarCostoDestaje) 
                                                    VALUES ('" & simac.SistemaAdmon & "','" & simac.Empresa & "',
                                                    '" & simac.ProductoTerminado & "','" & simac.MateriaPrima & "',
                                                    '" & simac.MateriaTalla & "','" & simac.Fracciones & "',
                                                    '" & simac.Procesos & "','" & simac.Modelos & "',
                                                    '" & simac.Tabla1 & "','" & simac.Tabla2 & "',
                                                    '" & simac.Tabla3 & "','" & simac.Tabla4 & "',
                                                    '" & simac.Tabla5 & "','" & simac.Tabla6 & "',
                                                    '" & simac.FolioPedidoA & "','" & simac.FolioPedidoB & "',
                                                    '" & simac.FolioOrdenA & "','" & simac.FolioOrdenB & "',
                                                    '" & simac.CantAvance & "','" & simac.AutoAvance & "',
                                                    '" & simac.FechaAvance & "','" & simac.MultiAlmacen & "',
                                                    '" & simac.MaterialAlmacen & "','" & simac.ProductoAlmacen & "',
                                                   '" & simac.MaxLote & "',
                                                    '" & simac.Sistema & "','" & simac.DBSimac & "',
                                                    '" & simac.ProgBase & "','" & simac.ValidaUnidad & "',
                                                    '" & simac.AutPedido & "','" & simac.DestajosAvance & "',
                                                    '" & simac.ValidadSuPedido & "','" & simac.EntregaParcial & "',
                                                    '" & simac.CalculoDesperdicio & "','" & simac.ManejaTenerias & "',
                                                    '" & simac.PedProdAutorizado & "','" & simac.MinutosSemanales & "',
                                                    '" & simac.hcCarga & "','" & simac.hcDerivados & "',
                                                    '" & simac.hcFormulas & "','" & simac.hcMateriales & "',
                                                    '" & simac.rptFormulas & "','" & simac.avancePorProceso & "',
                                                    '" & simac.dividirLote & "','" & simac.avanceNoValidarProg & "',
                                                    '" & simac.rptPreasignacion & "','" & simac.Tabla7 & "',
                                                    '" & simac.Tabla8 & "','" & simac.Tabla9 & "',
                                                    '" & simac.Tabla10 & "','" & simac.Tabla11 & "',
                                                    '" & simac.Tabla12 & "','" & simac.rptExplosionFormulas & "',
                                                    '" & simac.editarCantidadDestajo & "','" & simac.editarCostoDestaje & "')"

            Return obj.commandSQL(Query)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Public Function EditarSIMAC(ByRef simac As Entidades.SIMAC) As Boolean
        Dim Query As String
        With simac
            Query = "UPDATE Configuracion_Simac SET
                                         SistemaAdmon = '" & .SistemaAdmon & "', ProductoTerminado = '" & .ProductoTerminado & "',
                                         MateriaPrima = '" & .MateriaPrima & "', MateriaTalla = '" & .MateriaTalla & "',
                                         Fracciones = '" & .Fracciones & "', Procesos  = '" & .Procesos & "', 
                                         Modelos = '" & .Modelos & "', Tabla1  = '" & .Tabla1 & "',
                                         Tabla2 = '" & .Tabla2 & "', Tabla3 = '" & .Tabla3 & "',
                                         Tabla4 = '" & .Tabla4 & "', Tabla5 = '" & .Tabla5 & "',
                                         Tabla6 = '" & .Tabla6 & "', FolioPedidoA  = '" & .FolioPedidoA & "',
                                         FolioPedidoB = '" & .FolioPedidoB & "', FolioOrdenA  = '" & .FolioOrdenA & "',
                                         FolioOrdenB = '" & .FolioOrdenB & "', CantAvance  = '" & .CantAvance & "',
                                         AutoAvance = '" & .AutoAvance & "', FechaAvance  = '" & .FechaAvance & "',
                                         MultiAlmacen = '" & .MultiAlmacen & "', MaterialAlmacen  = '" & .MaterialAlmacen & "',
                                         ProductoAlmacen = '" & .ProductoAlmacen & "', MaxLote  = '" & .MaxLote & "',
                                         DBSimac  = '" & .DBSimac & "',
                                         ProgBase = '" & .ProgBase & "', ValidaUnidad  = '" & .ValidaUnidad & "',
                                         AutPedido = '" & .AutPedido & "', DestajosAvance  = '" & .DestajosAvance & "',
                                         ValidadSuPedido = '" & .ValidadSuPedido & "', EntregaParcial  = '" & .EntregaParcial & "',
                                         CalculoDesperdicio= '" & .CalculoDesperdicio & "', ManejaTenerias  = '" & .ManejaTenerias & "',
                                         PedProdAutorizado = '" & .PedProdAutorizado & "', MinutosSemanales  = '" & .MinutosSemanales & "',
                                         hcCarga = '" & .hcCarga & "', hcDerivados  = '" & .hcDerivados & "',
                                         hcFormulas = '" & .hcFormulas & "', hcMateriales  = '" & .hcMateriales & "',
                                         rptFormulas = '" & .rptFormulas & "', avancePorProceso  = '" & .avancePorProceso & "',
                                         dividirLote = '" & .dividirLote & "', avanceNoValidarProg  = '" & .avanceNoValidarProg & "',
                                         rptPreasignacion = '" & .rptPreasignacion & "', Tabla7  = '" & .Tabla7 & "',
                                         Tabla8 = '" & .Tabla8 & "', Tabla9 = '" & .Tabla9 & "',
                                         Tabla10 = '" & .Tabla10 & "', Tabla11 = '" & .Tabla11 & "',
                                         Tabla12 = '" & .Tabla12 & "', rptExplosionFormulas = '" & .rptExplosionFormulas & "',
                                         editarCantidadDestajo = '" & .editarCantidadDestajo & "', editarCostoDestaje = '" & .editarCostoDestaje & "'
                                         WHERE OID = " & .OID
        End With
        Return obj.commandSQL(Query)
    End Function

    Public Function GuardarReporteSIMAC(ByVal entReporte As Entidades.ReporteSIMAC) As Boolean
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "insert ReportesSIMAC(Nombre, FechaModificacion, Tipo, SIMAC, Archivo)values
                    ('" & entReporte.Nombre & "', '" & Format(entReporte.FechaModificacion, "yyyyMMdd") & "', '" & entReporte.Tipo & "'," & entReporte.SIMAC & ", @Imagen)"
            Dim conn = New SqlConnection(clsSQL.StringConn)
            conn.Open()
            Dim command = New SqlCommand(Query, conn)
            'If Not entReporte.Archivo Is Nothing Then
            command.Parameters.Add("@Imagen", SqlDbType.VarBinary)
                command.Parameters("@Imagen").Value = entReporte.Archivo
            'End If

            command.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

    Public Function EditarReporte(ByRef entReporte As Entidades.ReporteSIMAC) As Boolean
        Dim dt As New DataTable
        Dim Query As String
        Try
            With entReporte
                Query = "UPDATE ReportesSIMAC SET FechaModificacion = '" & Format(entReporte.FechaModificacion, "yyyyMMdd") & "',
                                        Archivo = @Imagen WHERE Clave = " & .OID
                Dim conn = New SqlConnection(clsSQL.StringConn)
                conn.Open()
                Dim command = New SqlCommand(Query, conn)
                command.Parameters.Add("@Imagen", SqlDbType.VarBinary)
                command.Parameters("@Imagen").Value = entReporte.Archivo
                command.ExecuteNonQuery()
                conn.Close()
            End With
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

    Public Function CargarReporteSIMAC(ByVal simac As Integer) As DataTable
        Dim Query As String
        Dim dt As DataTable
        Try
            Query = " SELECT * FROM ReportesSIMAC WHERE SIMAC = " & simac
            dt = obj.RegresarDatos(Query)
            Return dt
        Catch ex As Exception
        End Try
    End Function

    Public Function GetDB() As DataTable
        Try
            Dim query As String = ""
            Dim obj As New clsSQL
            query = "Select name From sys.databases Order By create_date Desc"
            Return obj.RegresarDatos(query)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CargarEntidadSIMAC(ByRef _OID As Integer) As Entidades.Sistema
        Dim query As String = "SELECT * FROM Sistemas WHERE Empresa = " & _OID
        Try
            Dim simac As New Entidades.Sistema
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                simac.OID = .Item("OID")
                simac.Nombre = .Item("Nombre")
                simac.Empresa = .Item("Empresa")
                simac.Codigo = .Item("Codigo")
                simac.Serie = .Item("Serie")
                simac.Activacion = .Item("Activacion")
            End With
            Return simac
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function CargarEmpresa() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "Select * from Empresas
				where OID in (Select Empresa from Sistemas 
										where Empresa not in (Select Empresa from Configuracion_Simac) and Nombre = 'SIMAC') "
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarInnerJoin()
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "Select Configuracion_Simac.OID,Configuracion_Simac.Empresa, SistemaAdmon, ProductoTerminado, MateriaPrima,MateriaTalla,Fracciones,Procesos,
Modelos, Tabla1,Tabla2,Tabla3,Tabla4,Tabla5,Tabla6,FolioOrdenA,FolioOrdenB,FolioPedidoA,FolioPedidoB,
CantAvance, AutoAvance, FechaAvance,MultiAlmacen,MaterialAlmacen,ProductoAlmacen,MaxLote,Configuracion_Simac.Sistema,DBSimac,
ProgBase,ValidaUnidad,AutPedido,DestajosAvance,ValidadSuPedido,EntregaParcial,CalculoDesperdicio,ManejaTenerias,PedProdAutorizado,
MinutosSemanales,hcCarga,hcDerivados,hcFormulas,hcMateriales,rptFormulas,avancePorProceso,dividirLote,
avanceNoValidarProg,rptPreasignacion,Tabla7,Tabla8,Tabla9,Tabla10,Tabla11,Tabla12,rptExplosionFormulas,editarCantidadDestajo,editarCostoDestaje,
Empresas.Nombre as nom, Sistemas.Nombre as sis from Configuracion_Simac inner join
Empresas ON (Configuracion_Simac.Empresa = Empresas.OID) inner join Sistemas ON (Configuracion_Simac.Sistema = Sistemas.OID) WHERE Sistemas.Nombre ='SIMAC'"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

End Class
