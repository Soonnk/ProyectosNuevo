'Consultas a la base de datos en la tabla Configuracion_Magnus
Public Class MagnusERP

    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Configuracion_Magnus"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarMagnus(ByRef _OID As Integer) As Entidades.MagnusERP
        Dim query As String = "SELECT * FROM Configuracion_Magnus WHERE OID = " & _OID
        Try
            Dim magnusERP As New Entidades.MagnusERP
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                magnusERP.Empresa = .Item("Empresa")
                magnusERP.Sistema = .Item("Sistema")
                magnusERP.DBMagnus = .Item("DBMagnus")
                magnusERP.usuarioActivo = .Item("usuarioActivo")
                magnusERP.autonumerico = .Item("autonumerico")
                magnusERP.server1 = .Item("server1")
                magnusERP.usuario = .Item("usuario")
                magnusERP.manejaRenta = .Item("manejaRenta")
                magnusERP.manejaObras = .Item("manejaObras")
                magnusERP.manejaTransportes = .Item("manejaTransportes")
                magnusERP.pathCer = .Item("pathCer")
                magnusERP.pathXml = .Item("pathXml")
                magnusERP.rutaReportes = .Item("rutaReportes")
                magnusERP.Lotes = .Item("Lotes")
                magnusERP.manejaDesMax = .Item("manejaDesMax")
                magnusERP.desMax = .Item("desMax")
                magnusERP.desfinMax = .Item("desfinMax")
                magnusERP.mostrarExistencia = .Item("mostrarExistencia")
                magnusERP.edicionMoneda = .Item("edicionMoneda")
                magnusERP.edicionTC = .Item("edicionTC")
                magnusERP.edicionImpuesto = .Item("edicionImpuesto")
                magnusERP.existenciaBruta = .Item("existenciaBruta")
                magnusERP.desXP = .Item("desXP")
                magnusERP.impXP = .Item("impXP")
                magnusERP.numeroDecimalesC = .Item("numeroDecimalesC")
                magnusERP.numeroDecimalesV = .Item("numeroDecimalesV")
                magnusERP.preview = .Item("preview")
                magnusERP.DesgloseDesc = .Item("DesgloseDesc")
                magnusERP.AgrupaTallasFactura = .Item("AgrupaTallasFactura")
                magnusERP.FormaPago = .Item("FormaPago")
                magnusERP.FoliosConta = .Item("FoliosConta")
                magnusERP.ManejarFiscal = .Item("ManejarFiscal")
                magnusERP.RutaEtiqueta = .Item("RutaEtiqueta")
                magnusERP.ReporteTraspaso = .Item("ReporteTraspaso")
                magnusERP.MostrarImagen = .Item("MostrarImagen")
                magnusERP.Simac = .Item("Simac")
                magnusERP.NDecimalesCosto = .Item("NDecimalesCosto")
                magnusERP.rutaImagenes = .Item("rutaImagenes")
                magnusERP.ReporteEmbarque = .Item("ReporteEmbarque")
                magnusERP.ReporteLiquidacion = .Item("ReporteLiquidacion")
                magnusERP.ReporteFaltante = .Item("ReporteFaltante")
                magnusERP.PrecioOferta = .Item("PrecioOferta")
                magnusERP.ProductoCompras = .Item("ProductoCompras")
                magnusERP.IdConceptoSalidaEnsamble = .Item("IdConceptoSalidaEnsamble")
                magnusERP.IdConceptoEntradaKIT = .Item("IdConceptoEntradaKIT")
                magnusERP.ManejaViaje = .Item("ManejaViaje")
                magnusERP.ReporteViaje = .Item("ReporteViaje")
                magnusERP.PorSucursal = .Item("PorSucursal")
                magnusERP.ReporteGastoEmbarque = .Item("ReporteGastoEmbarque")
                magnusERP.ElegirFormato = .Item("ElegirFormato")
                magnusERP.AutoAsignarClave = .Item("AutoAsignarClave")
                magnusERP.GeneraEmbarque = .Item("GeneraEmbarque")
                magnusERP.ServicioFlete = .Item("ServicioFlete")
                magnusERP.ServicioSeguro = .Item("ServicioSeguro")
                magnusERP.IdEsquemaFlete = .Item("IdEsquemaFlete")
                magnusERP.EnvioCorreo = .Item("EnvioCorreo")
                magnusERP.AutorizarPagos = .Item("AutorizarPagos")
                magnusERP.IdProductoEstimacion = .Item("IdProductoEstimacion")
                magnusERP.IdProductoEstimacionSub = .Item("IdProductoEstimacionSub")
                magnusERP.ReporteHojaGeneradora = .Item("ReporteHojaGeneradora")
                magnusERP.ReporteEstimacion = .Item("ReporteEstimacion")
                magnusERP.ReporteCaratulaEstimacion = .Item("ReporteCaratulaEstimacion")
                magnusERP.ValidacionCredito = .Item("ValidacionCredito")
                magnusERP.PeriodoMaxMin = .Item("PeriodoMaxMin")
                magnusERP.NumLiquidacion = .Item("NumLiquidacion")
                magnusERP.ConceptosLiquidaciones = .Item("ConceptosLiquidaciones")
                magnusERP.CuentasComplemento = .Item("CuentasComplemento")
                magnusERP.DecimalesEntrada = .Item("DecimalesEntrada")
                magnusERP.DecimalesSalida = .Item("DecimalesSalida")
                magnusERP.ServicioEmbarque = .Item("ServicioEmbarque")
                magnusERP.RevisionPagos = .Item("RevisionPagos")
                magnusERP.RptEnlaces = .Item("RptEnlaces")
                magnusERP.AutonumeracionLotes = .Item("AutonumeracionLotes")
                magnusERP.CantidadTotalLote = .Item("CantidadTotalLote")
                magnusERP.EditarComision = .Item("ServicioEmbarque")
                magnusERP.PorcentajeEmpresa = .Item("PorcentajeEmpresa")
                magnusERP.PorcentajeOperador = .Item("PorcentajeOperador")
                magnusERP.AgruparClavesIguales = .Item("AgruparClavesIguales")
                magnusERP.manejaMovil = .Item("manejaMovil")
                magnusERP.nivelAlmacen = .Item("nivelAlmacen")
                magnusERP.EnlaceVarios = .Item("EnlaceVarios")
                magnusERP.ReporteOEmbarques = .Item("ReporteOEmbarques")
                magnusERP.ReporteAutorizaciones = .Item("ReporteAutorizaciones")
                magnusERP.ReportePeriodoAutorizaciones = .Item("ReportePeriodoAutorizaciones")
                magnusERP.ReportePeriodoEntregasEmbarque = .Item("ReportePeriodoEntregasEmbarque")
                magnusERP.ReporteInventario = .Item("ReporteInventario")
                magnusERP.EquivalenciaClientes = .Item("EquivalenciaClientes")
                magnusERP.ReporteLotesDocumento = .Item("ReporteLotesDocumento")
                magnusERP.controLotes = .Item("controLotes")
                magnusERP.rptPendientesPorSurtir = .Item("rptPendientesPorSurtir")
                magnusERP.ManejaDescuentoComision = .Item("ManejaDescuentoComision")
                magnusERP.EditarTipoPago = .Item("EditarTipoPago")
                magnusERP.ServicioFleteFactura = .Item("ServicioFleteFactura")
                magnusERP.ProdServicioFlete = .Item("ProdServicioFlete")
                magnusERP.LecturaPickingIncrementoUnidad = .Item("LecturaPickingIncrementoUnidad")
                magnusERP.ContabilizaNivelCuatro = .Item("ContabilizaNivelCuatro")
                magnusERP.incluirDescuentoPrecioXML = .Item("incluirDescuentoPrecioXML")
                magnusERP.CentroCostosCompras = .Item("CentroCostosCompras")
                magnusERP.enlazarParcialPicking = .Item("enlazarParcialPicking")
                magnusERP.equivalenciasDuplicadas = .Item("equivalenciasDuplicadas")
                magnusERP.detallarLotesSIMAC = .Item("detallarLotesSIMAC")
                magnusERP.decimalesPrecio = .Item("decimalesPrecio")
                magnusERP.ventaSoloListaPrecio = .Item("ventaSoloListaPrecio")
                magnusERP.envioPedidosSimac = .Item("envioPedidosSimac")
                magnusERP.ClientePedido = .Item("ClientePedido")
                magnusERP.ReporteLiquidacionMovil = .Item("ReporteLiquidacionMovil")
                magnusERP.ReporteAdeudoRetornable = .Item("ReporteAdeudoRetornable")
                magnusERP.ReporteListaPrecios = .Item("ReporteListaPrecios")
                magnusERP.cantidadPorPrecio = .Item("cantidadPorPrecio")
            End With
            Return magnusERP
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function InsertarMagnusERP(ByRef magnusERP As Entidades.MagnusERP) As Boolean
        Dim Query As String
        Try
            Query = "INSERT INTO Configuracion_Magnus(Empresa,Sistema,DBMagnus,usuarioActivo,
                                                      autonumerico,server1,usuario,manejaRenta,
                                                    manejaObras,manejaTransportes,pathCer,pathXml)VALUES
                                                    (" & magnusERP.Empresa & "," & magnusERP.Sistema & ",'" & magnusERP.DBMagnus & "'," & magnusERP.usuarioActivo & ",
                                                    '" & magnusERP.autonumerico & "','" & magnusERP.server1 & "','" & magnusERP.usuario & "'," & magnusERP.manejaRenta & ",
                " & magnusERP.manejaObras & "," & magnusERP.manejaTransportes & ",'" & magnusERP.pathCer & "','" & magnusERP.pathXml & "')"
            Return obj.commandSQL(Query)
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
    '    


    'Public Function InsertarMagnusERP(ByRef magnusERP As Entidades.MagnusERP) As Boolean
    '    Dim Query As String

    '    Try
    '        Query = "INSERT INTO Configuracion_Magnus(Empresa,Sistema,DBMagnus,usuarioActivo,
    '                                                autonumerico,server1,usuario,manejaRenta,
    '                                                manejaObras,manejaTransportes,pathCer,pathXml,
    '                                                rutaReportes,Lotes,manejaDesMax,desMax,
    '                                                desfinMax,mostrarExistencia,edicionMoneda,edicionTC,
    '                                                edicionImpuesto,existenciaBruta,desXP,impXP,
    '                                                numeroDecimalesC,numeroDecimalesV,
    '                                                preview,DesgloseDesc,AgrupaTallasFactura,
    '                                                FormaPago,FoliosConta,ManejarFiscal,RutaEtiqueta,
    '                                                ReporteTraspaso,MostrarImagen,Simac,NDecimalesCosto,
    '                                                rutaImagenes,ReporteEmbarque,
    '                                                ReporteLiquidacion,ReporteFaltante,
    '                                                PrecioOferta,ProductoCompras,
    '                                                IdConceptoSalidaEnsamble,IdConceptoEntradaKIT,
    '                                                ManejaViaje,ReporteViaje,
    '                                                PorSucursal,ReporteGastoEmbarque,
    '                                                ElegirFormato,AutoAsignarClave,
    '                                                GeneraEmbarque,ServicioFlete,
    '                                                ServicioSeguro,IdEsquemaFlete,
    '                                                EnvioCorreo,AutorizarPagos,
    '                                                IdProductoEstimacion,IdProductoEstimacionSub,
    '                                                ReporteHojaGeneradora,ReporteEstimacion,
    '                                                ReporteCaratulaEstimacion,ValidacionCredito,
    '                                                PeriodoMaxMin,NumLiquidacion,
    '                                                ConceptosLiquidaciones,CuentasComplemento,
    '                                                DecimalesEntrada,DecimalesSalida,
    '                                                ServicioEmbarque,RevisionPagos,
    '                                                RptEnlaces,AutonumeracionLotes,
    '                                                CantidadTotalLote,EditarComision,
    '                                                PorcentajeEmpresa,PorcentajeOperador,
    '                                                AgruparClavesIguales,manejaMovil,
    '                                                nivelAlmacen,EnlaceVarios,
    '                                                ReporteOEmbarques,ReporteAutorizaciones,
    '                                                ReportePeriodoAutorizaciones,ReportePeriodoEntregasEmbarque,
    '                                                envioProduccion,ReporteInventario,
    '                                                EquivalenciaClientes,ReporteLotesDocumento,
    '                                                controLotes,rptPendientesPorSurtir,
    '                                                ManejaDescuentoComision,EditarTipoPago,
    '                                                ServicioFleteFactura,ProdServicioFlete,
    '                                                LecturaPickingIncrementoUnidad,ContabilizaNivelCuatro,
    '                                                incluirDescuentoPrecioXML,CentroCostosCompras,
    '                                                enlazarParcialPicking,equivalenciasDuplicadas,
    '                                                detallarLotesSIMAC,decimalesPrecio,
    '                                                ventaSoloListaPrecio,envioPedidosSimac,
    '                                                ClientePedido,ReporteLiquidacionMovil,
    '                                                ReporteAdeudoRetornable,ReporteListaPrecios,
    '                                                cantidadPorPrecio) 
    '            VALUES (" & magnusERP.Empresa & "," & magnusERP.Sistema & ",'" & magnusERP.DBMagnus & "'," & magnusERP.usuarioActivo & ",
    '            '" & magnusERP.autonumerico & "','" & magnusERP.server1 & "','" & magnusERP.usuario & "'," & magnusERP.manejaRenta & ",
    '            " & magnusERP.manejaObras & "," & magnusERP.manejaTransportes & ",'" & magnusERP.pathCer & "','" & magnusERP.pathXml & "',
    '            '" & magnusERP.rutaReportes & "'," & magnusERP.Lotes & ", '" & magnusERP.manejaDesMax & "','" & magnusERP.desMax & "',
    '            '" & magnusERP.desfinMax & "','" & magnusERP.mostrarExistencia & "','" & magnusERP.edicionMoneda & "','" & magnusERP.edicionTC & "',
    '            '" & magnusERP.edicionImpuesto & "','" & magnusERP.existenciaBruta & "','" & magnusERP.desXP & "','" & magnusERP.impXP & "',
    '            '" & magnusERP.numeroDecimalesC & "','" & magnusERP.numeroDecimalesV & "',
    '            '" & magnusERP.preview & "', '" & magnusERP.DesgloseDesc & "','" & magnusERP.AgrupaTallasFactura & "',
    '            '" & magnusERP.FormaPago & "','" & magnusERP.FoliosConta & "','" & magnusERP.ManejarFiscal & "','" & magnusERP.RutaEtiqueta & "',
    '            '" & magnusERP.ReporteTraspaso & "','" & magnusERP.MostrarImagen & "','" & magnusERP.Simac & "','" & magnusERP.NDecimalesCosto & "',
    '            '" & magnusERP.rutaImagenes & "','" & magnusERP.ReporteEmbarque & "',
    '            '" & magnusERP.ReporteLiquidacion & "','" & magnusERP.ReporteFaltante & "',
    '            '" & magnusERP.PrecioOferta & "','" & magnusERP.ProductoCompras & "',
    '            '" & magnusERP.IdConceptoSalidaEnsamble & "','" & magnusERP.IdConceptoEntradaKIT & "',
    '            '" & magnusERP.ManejaViaje & "','" & magnusERP.ReporteViaje & "',
    '            '" & magnusERP.PorSucursal & "','" & magnusERP.ReporteGastoEmbarque & "',
    '            '" & magnusERP.ElegirFormato & "','" & magnusERP.AutoAsignarClave & "',
    '            '" & magnusERP.GeneraEmbarque & "','" & magnusERP.ServicioFlete & "',
    '            '" & magnusERP.ServicioSeguro & "','" & magnusERP.IdEsquemaFlete & "',
    '            '" & magnusERP.EnvioCorreo & "','" & magnusERP.AutorizarPagos & "',
    '            '" & magnusERP.IdProductoEstimacion & "','" & magnusERP.IdProductoEstimacionSub & "',
    '            '" & magnusERP.ReporteHojaGeneradora & "','" & magnusERP.ReporteEstimacion & "',
    '            '" & magnusERP.ReporteCaratulaEstimacion & "','" & magnusERP.ValidacionCredito & "',
    '            '" & magnusERP.PeriodoMaxMin & "','" & magnusERP.NumLiquidacion & "',
    '            '" & magnusERP.ConceptosLiquidaciones & "','" & magnusERP.CuentasComplemento & "',
    '            '" & magnusERP.DecimalesEntrada & "','" & magnusERP.DecimalesSalida & "',
    '            '" & magnusERP.ServicioEmbarque & "','" & magnusERP.RevisionPagos & "',
    '            '" & magnusERP.RptEnlaces & "','" & magnusERP.AutonumeracionLotes & "',
    '            '" & magnusERP.CantidadTotalLote & "','" & magnusERP.EditarComision & "',
    '            '" & magnusERP.PorcentajeEmpresa & "','" & magnusERP.PorcentajeOperador & "',
    '            '" & magnusERP.AgruparClavesIguales & "','" & magnusERP.manejaMovil & "',
    '            '" & magnusERP.nivelAlmacen & "','" & magnusERP.EnlaceVarios & "',
    '            '" & magnusERP.ReporteOEmbarques & "','" & magnusERP.ReporteAutorizaciones & "',
    '            '" & magnusERP.ReportePeriodoAutorizaciones & "','" & magnusERP.ReportePeriodoEntregasEmbarque & "',
    '            '" & magnusERP.envioProduccion & "','" & magnusERP.ReporteInventario & "',
    '            '" & magnusERP.EquivalenciaClientes & "','" & magnusERP.ReporteLotesDocumento & "',
    '            '" & magnusERP.ServicioFleteFactura & "','" & magnusERP.ProdServicioFlete & "',
    '            '" & magnusERP.LecturaPickingIncrementoUnidad & "','" & magnusERP.ContabilizaNivelCuatro & "',
    '            '" & magnusERP.incluirDescuentoPrecioXML & "','" & magnusERP.CentroCostosCompras & "',
    '            '" & magnusERP.enlazarParcialPicking & "','" & magnusERP.equivalenciasDuplicadas & "',
    '            '" & magnusERP.detallarLotesSIMAC & "','" & magnusERP.decimalesPrecio & "',
    '            '" & magnusERP.ventaSoloListaPrecio & "','" & magnusERP.envioPedidosSimac & "',
    '            '" & magnusERP.ClientePedido & "','" & magnusERP.ReporteLiquidacionMovil & "',
    '            '" & magnusERP.ReporteAdeudoRetornable & "','" & magnusERP.ReporteListaPrecios & "',
    '                                                '" & magnusERP.cantidadPorPrecio & "')"

    '        Return obj.commandSQL(Query)
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '        Return False
    '    End Try
    'End Function

    Public Function EditarMagnusERP(ByRef magnusERP As Entidades.MagnusERP) As Boolean
        Dim Query As String
        With magnusERP
            Query = "UPDATE Configuracion_Magnus SET
                                         DBMagnus = '" & .DBMagnus & "', usuarioActivo = '" & .usuarioActivo & "',
                                         autonumerico = '" & .autonumerico & "', server1 = '" & .server1 & "',
                                         usuario = '" & .usuario & "', manejaRenta  = '" & .manejaRenta & "', 
                                        manejaObras = '" & .manejaObras & "', manejaTransportes  = '" & .manejaTransportes & "',
                                         pathCer = '" & .pathCer & "', pathXml = '" & .pathXml & "',
                                         rutaReportes = '" & .rutaReportes & "', Lotes = '" & .Lotes & "',
                                         manejaDesMax = '" & .manejaDesMax & "', desMax  = '" & .desMax & "',
                                         desfinMax = '" & .desfinMax & "', mostrarExistencia  = '" & .mostrarExistencia & "',
                                         edicionMoneda = '" & .edicionMoneda & "', edicionTC  = '" & .edicionTC & "',
                                         edicionImpuesto = '" & .edicionImpuesto & "', existenciaBruta  = '" & .existenciaBruta & "',
                                         desXP = '" & .desXP & "', impXP  = '" & .impXP & "',
                                         numeroDecimalesC = '" & .numeroDecimalesC & "', numeroDecimalesV = '" & .numeroDecimalesV & "',
                                         preview  = '" & .preview & "',
                                         DesgloseDesc = '" & .DesgloseDesc & "', AgrupaTallasFactura  = '" & .AgrupaTallasFactura & "',
                                         FormaPago = '" & .FormaPago & "', FoliosConta  = '" & .FoliosConta & "',
                                         ManejarFiscal = '" & .ManejarFiscal & "', RutaEtiqueta  = '" & .RutaEtiqueta & "',
                                         ReporteTraspaso= '" & .ReporteTraspaso & "', MostrarImagen  = '" & .MostrarImagen & "',
                                         Simac = '" & .Simac & "', NDecimalesCosto  = '" & .NDecimalesCosto & "',
                                      rutaImagenes = '" & .rutaImagenes & "', ReporteEmbarque  = '" & .ReporteEmbarque & "',
                                         ReporteLiquidacion = '" & .ReporteLiquidacion & "', ReporteFaltante = '" & .ReporteFaltante & "',
                                         PrecioOferta = '" & .PrecioOferta & "', ProductoCompras  = '" & .ProductoCompras & "',
                                         IdConceptoSalidaEnsamble = '" & .IdConceptoSalidaEnsamble & "', IdConceptoEntradaKIT  = '" & .IdConceptoEntradaKIT & "',
                                         ManejaViaje = '" & .ManejaViaje & "', ReporteViaje  = '" & .ReporteViaje & "',
                                         PorSucursal = '" & .PorSucursal & "', ReporteGastoEmbarque = '" & .ReporteGastoEmbarque & "',
                                         ElegirFormato = '" & .ElegirFormato & "', AutoAsignarClave = '" & .AutoAsignarClave & "',
                                         GeneraEmbarque = '" & .GeneraEmbarque & "', ServicioFlete = '" & .ServicioFlete & "',
                                         ServicioSeguro = '" & .ServicioSeguro & "', IdEsquemaFlete = '" & .IdEsquemaFlete & "',
                                         EnvioCorreo = '" & .EnvioCorreo & "', AutorizarPagos = '" & .AutorizarPagos & "',
                                         IdProductoEstimacion = '" & .IdProductoEstimacion & "', IdProductoEstimacionSub = '" & .IdProductoEstimacionSub & "',
                                         ReporteHojaGeneradora = '" & .ReporteHojaGeneradora & "', ReporteEstimacion = '" & .ReporteEstimacion & "',
                                         ReporteCaratulaEstimacion = '" & .ReporteCaratulaEstimacion & "', ValidacionCredito = '" & .ValidacionCredito & "',
                                         PeriodoMaxMin = '" & .PeriodoMaxMin & "', NumLiquidacion = '" & .NumLiquidacion & "',
                                         ConceptosLiquidaciones = '" & .ConceptosLiquidaciones & "', CuentasComplemento = '" & .CuentasComplemento & "',
                                         DecimalesEntrada = '" & .DecimalesEntrada & "', DecimalesSalida = '" & .DecimalesSalida & "',
                                         ServicioEmbarque = '" & .ServicioEmbarque & "', RevisionPagos = '" & .RevisionPagos & "',
                                         RptEnlaces = '" & .RptEnlaces & "', AutonumeracionLotes = '" & .AutonumeracionLotes & "',
                                         CantidadTotalLote = '" & .CantidadTotalLote & "', EditarComision = '" & .EditarComision & "',
                                         PorcentajeEmpresa = '" & .PorcentajeEmpresa & "', PorcentajeOperador = '" & .PorcentajeOperador & "',
                                         AgruparClavesIguales = '" & .AgruparClavesIguales & "', manejaMovil = '" & .manejaMovil & "',
                                         nivelAlmacen = '" & .nivelAlmacen & "', EnlaceVarios = '" & .EnlaceVarios & "',
                                         ReporteOEmbarques = '" & .ReporteOEmbarques & "', ReporteAutorizaciones = '" & .ReporteAutorizaciones & "',
                                         ReportePeriodoAutorizaciones = '" & .ReportePeriodoAutorizaciones & "', ReportePeriodoEntregasEmbarque = '" & .ReportePeriodoEntregasEmbarque & "',
                                         envioProduccion = '" & .envioProduccion & "', ReporteInventario = '" & .ReporteInventario & "',
                                         EquivalenciaClientes = '" & .EquivalenciaClientes & "', ReporteLotesDocumento = '" & .ReporteLotesDocumento & "',
                                         controLotes = '" & .controLotes & "', rptPendientesPorSurtir = '" & .rptPendientesPorSurtir & "',
                                         ManejaDescuentoComision = '" & .ManejaDescuentoComision & "', EditarTipoPago = '" & .EditarTipoPago & "',
                                         ServicioFleteFactura= '" & .ServicioFleteFactura & "', ProdServicioFlete = '" & .ProdServicioFlete & "',
                                         LecturaPickingIncrementoUnidad = '" & .LecturaPickingIncrementoUnidad & "', ContabilizaNivelCuatro = '" & .ContabilizaNivelCuatro & "',
                                         incluirDescuentoPrecioXML = '" & .incluirDescuentoPrecioXML & "', CentroCostosCompras = '" & .CentroCostosCompras & "',
                                         enlazarParcialPicking = '" & .enlazarParcialPicking & "', equivalenciasDuplicadas = '" & .equivalenciasDuplicadas & "',
                                         detallarLotesSIMAC = '" & .detallarLotesSIMAC & "', decimalesPrecio = '" & .decimalesPrecio & "',
                                         ventaSoloListaPrecio = '" & .ventaSoloListaPrecio & "', envioPedidosSimac = '" & .envioPedidosSimac & "',
                                         ClientePedido = '" & .ClientePedido & "', ReporteLiquidacionMovil = '" & .ReporteLiquidacionMovil & "',
                                         ReporteAdeudoRetornable = '" & .ReporteAdeudoRetornable & "', 
                                         ReporteListaPrecios = '" & .ReporteListaPrecios & "', cantidadPorPrecio = '" & .cantidadPorPrecio & "'
                                         WHERE OID = " & .OID
        End With
        Return obj.commandSQL(Query)
    End Function


    Public Function CargarEntidadMagnusERP(ByRef _OID As Integer) As Entidades.Sistema
        Dim query As String = "SELECT * FROM Sistemas WHERE Empresa = " & _OID
        Try
            Dim magnusERP As New Entidades.Sistema
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                magnusERP.OID = .Item("OID")
                magnusERP.Nombre = .Item("Nombre")
                magnusERP.Empresa = .Item("Empresa")
                magnusERP.Codigo = .Item("Codigo")
                magnusERP.Serie = .Item("Serie")
                magnusERP.Activacion = .Item("Activacion")
            End With
            Return magnusERP
        Catch ex As Exception
            Return Nothing
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


    Public Function CargarEmpresa() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "Select * from Empresas
				where OID in (Select Empresa from Sistemas 
										where Empresa not in (Select Empresa from Configuracion_Magnus) and Nombre = 'Magnus ERP')"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarInnerJoin()
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT Configuracion_Magnus.OID,Configuracion_Magnus.Empresa,Configuracion_Magnus.Sistema
                    ,DBMagnus,usuarioActivo,autonumerico,server1,usuario,manejaRenta,manejaObras
                    ,manejaTransportes,pathCer,pathXml,rutaReportes,Lotes,manejaDesMax,desMax
                    ,desfinMax,mostrarExistencia,edicionMoneda,edicionTC,edicionImpuesto
                    ,existenciaBruta,desXP,impXP,numeroDecimalesC,numeroDecimalesV,preview
                    ,DesgloseDesc,AgrupaTallasFactura,FormaPago,FoliosConta,ManejarFiscal
                    ,RutaEtiqueta,ReporteTraspaso,MostrarImagen,Simac,NDecimalesCosto,rutaImagenes
                    ,ReporteEmbarque,ReporteLiquidacion,ReporteFaltante,PrecioOferta
                    ,ProductoCompras,IdConceptoSalidaEnsamble,IdConceptoEntradaKIT
                    ,ManejaViaje,ReporteViaje,PorSucursal,ReporteGastoEmbarque,ElegirFormato
                    ,AutoAsignarClave,GeneraEmbarque,ServicioFlete,ServicioSeguro
                    ,IdEsquemaFlete,EnvioCorreo,AutorizarPagos,IdProductoEstimacion
	                ,IdProductoEstimacionSub,ReporteHojaGeneradora,ReporteEstimacion
                    ,ReporteCaratulaEstimacion,ValidacionCredito,PeriodoMaxMin
                    ,NumLiquidacion,ConceptosLiquidaciones,CuentasComplemento
                    ,DecimalesEntrada,DecimalesSalida,ServicioEmbarque,RevisionPagos
                    ,RptEnlaces,AutonumeracionLotes,CantidadTotalLote,EditarComision
                    ,PorcentajeEmpresa,PorcentajeOperador,AgruparClavesIguales
                    ,manejaMovil,nivelAlmacen,EnlaceVarios,ReporteOEmbarques
                    ,ReporteAutorizaciones,ReportePeriodoAutorizaciones
                    ,ReportePeriodoEntregasEmbarque,envioProduccion,ReporteInventario
                    ,EquivalenciaClientes,ReporteLotesDocumento,controLotes
                    ,rptPendientesPorSurtir,ManejaDescuentoComision,EditarTipoPago
                    ,ServicioFleteFactura,ProdServicioFlete,LecturaPickingIncrementoUnidad
                    ,ContabilizaNivelCuatro,incluirDescuentoPrecioXML
                    ,CentroCostosCompras,enlazarParcialPicking,equivalenciasDuplicadas
                    ,detallarLotesSIMAC,decimalesPrecio,ventaSoloListaPrecio
                    ,envioPedidosSimac,ClientePedido,ReporteLiquidacionMovil
                    ,ReporteAdeudoRetornable,ReporteListaPrecios,cantidadPorPrecio,
	                Empresas.Nombre AS nom,Sistemas.Nombre AS sis
                    FROM Configuracion_Magnus INNER JOIN Empresas ON (Configuracion_Magnus.Empresa= Empresas.OID)
                    INNER JOIN Sistemas ON (Configuracion_Magnus.Sistema = Sistemas.OID) WHERE Sistemas.Nombre = 'Magnus ERP'"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function


End Class
