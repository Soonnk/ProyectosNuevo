'Consultas a la base de datos en la tabla Configuracion_Simac
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
                simac.NoEmpresa = .Item("NoEmpresa")
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

    'Public Function InsertarSIMAC(ByRef simac As Entidades.SIMAC) As Boolean
    '    Dim Query As String
    '    'Dim id = obj.Incrementar("Configuracion_Conta")

    '    Try
    '        Query = "INSERT INTO Configuracion_Conta(SistemaAdmon, NoEmpresa, 
    '                                                ProductoTerminado, MateriaPrima,
    '                                                MateriaTalla, Fracciones,
    '                                                Procesos,Modelos,
    '                                                Tabla1,Tabla2,
    '                                                Tabla3,Tabla4,
    '                                                Tabla5,Tabla6,
    '                                                FolioPedidoA,FolioPedidoB,
    '                                                FolioOrdenA,FolioOrdenB,
    '                                                CantAvance,AutoAvance,
    '                                                FechaAvance,MultiAlmacen,
    '                                                MaterialAlmacen,ProductoAlmacen,
    '                                                MaxLote,Reporte,
    '                                                Sistema,DBSimac,
    '                                                ProgBase,ValidaUnidad,
    '                                                AutPedido,DestajosAvance,
    '                                                ValidaSuPedido,EntregaParcial,
    '                                                CalculoDesperdicio,ManejaTenerias,
    '                                                PedProdAutorizado,MinutosSemanales,
    '                                                hcCarga,hcDerivados,
    '                                                hcFormulas,hcMateriales,
    '                                                rptFormulas,avancePorProceso,
    '                                                dividirLote,avanceNoValidarProg, 
    '                                                rptPreasignacion,Tabla7,
    '                                                Tabla8,Tabla9,
    '                                                Tabla10,Tabla11,
    '                                                Tabla12,rptExplosionFormulas,
    '                                                editarCantidadDestajo,editarCostoDestajo) 
    '                                                VALUES ('" & simac.SistemaAdmon & "','" & simac.NoEmpresa & "',
    '                                                '" & simac.ProductoTerminado & "','" & simac.MateriaPrima & "',
    '                                                '" & simac.MateriaTalla & "','" & simac.Fracciones & "',
    '                                                '" & simac.Procesos & "','" & simac.Modelos & "',
    '                                                '" & simac.Tabla1 & "','" & simac.Tabla2 & "',
    '                                                '" & simac.Tabla3 & "','" & simac.Tabla4 & "',
    '                                                '" & simac.Tabla5 & "','" & simac.Tabla6 & "',
    '                                                '" & simac.FolioPedidoA & "','" & simac.FolioPedidoB & "',
    '                                                '" & simac.FolioOrdenA & "','" & simac.FolioOrdenB & "',
    '                                                '" & simac.FolioOrdenA & "','" & simac.FolioOrdenB & "',
    '                                                '" & simac.FolioOrdenA & "','" & simac.FolioOrdenB & "',
    '                                                '" & simac.FolioOrdenA & "','" & simac.FolioOrdenB & "',
    '                                                '" & simac.FolioOrdenA & "','" & simac.FolioOrdenB & "',
    '                                                '" & simac.Reubicaciones & "','" & simac.PorSucursal & "',
    '                                                '" & simac.ConceptoNotaCredito & "','" & simac.ContrapartidaCancelacion & "',
    '                                                '" & simac.VistaPrevia & "')"

    '        Return obj.commandSQL(Query)
    '    Catch ex As Exception
    '        'MsgBox(ex)
    '        Return False
    '    End Try
    'End Function


End Class
